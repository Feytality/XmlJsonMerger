using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XmlJsonMerger
{
    public partial class ChooseFiles : Form
    {
        private JObject mapJson;
        private JObject buildingJson;

        public ChooseFiles()
        {
            InitializeComponent();
        }

        private void chooseXmlBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openXmlFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                // Read the Xml file.
                FileStream fs = new FileStream(openXmlFileDialog.FileName, FileMode.Open, FileAccess.Read);

                //Convert contents into XML Document object.
                XmlDocument doc = new XmlDocument();
                doc.Load(fs);

                //Convert into JSON.
                string jsonText = JsonConvert.SerializeXmlNode(doc);
                
                // Store for later.
                dynamic dJson = JsonConvert.DeserializeObject(jsonText);
                mapJson = new JObject(dJson);

                chooseXmlTxt.Text = openXmlFileDialog.FileName;
            }
        }

        private void chooseJsonBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = openJsonFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                // Read the JSON file.
                string json = "";
                using (StreamReader r = new StreamReader(openJsonFileDialog.FileName))
                {
                    json = r.ReadToEnd();
                }

                // Store for later
                dynamic dJson = JsonConvert.DeserializeObject(json);
                buildingJson = new JObject(dJson);

                chooseJsonTxt.Text = openJsonFileDialog.FileName;
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            if (!chooseJsonTxt.Text.Equals("") && !chooseXmlTxt.Text.Equals(""))
            {
                // Get list of all keys in JSON file (each key stands for a building name)
                IList<string> keys = buildingJson.Properties().Select(p => p.Name).ToList();

                // Iterate over polygon information
                JArray array = JArray.Parse(mapJson["kml"]["Document"]["Placemark"].ToString());

                foreach (JObject content in array.Children<JObject>())
                {
                    foreach (JProperty prop in content.Properties())
                    {
                        if (prop.Name.Equals("name") && keys.Contains(prop.Value.ToString()))
                        {
                            // This means the building exists in the buildingJson object, add properties from
                            // mapJson into buildingJson.
                            string matchingKey = prop.Value.ToString();
                            buildingJson[matchingKey]["Polygon"] = content["Polygon"];
                            buildingJson[matchingKey]["ExtendedData"] = content["ExtendedData"];
                            buildingJson[matchingKey]["styleUrl"] = content["styleUrl"];
                        }
                    }
                }

                // Place the new buildingJson file onto user's desktop
                DownloadNewBuildingJson();
            }
            else
            {
                MessageBox.Show("Please choose both an XML file and a JSON file.",
                    "Attention",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }


        private void DownloadNewBuildingJson()
        {
            string desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string fullFileName = Path.Combine(desktopFolder, "buildingsJson.json");
            FileStream fs = new FileStream(fullFileName, FileMode.Create);
            fs.Close();
            System.IO.File.WriteAllText(fullFileName, buildingJson.ToString());
        }

    }


}
