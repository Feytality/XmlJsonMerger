namespace XmlJsonMerger
{
    partial class ChooseFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFiles));
            this.xmlLbl = new System.Windows.Forms.Label();
            this.jsonLbl = new System.Windows.Forms.Label();
            this.openXmlFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openJsonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseXmlTxt = new System.Windows.Forms.TextBox();
            this.chooseJsonTxt = new System.Windows.Forms.TextBox();
            this.chooseXmlBtn = new System.Windows.Forms.Button();
            this.chooseJsonBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xmlLbl
            // 
            this.xmlLbl.AutoSize = true;
            this.xmlLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xmlLbl.Location = new System.Drawing.Point(28, 21);
            this.xmlLbl.Name = "xmlLbl";
            this.xmlLbl.Size = new System.Drawing.Size(93, 15);
            this.xmlLbl.TabIndex = 0;
            this.xmlLbl.Text = "Choose XML file";
            // 
            // jsonLbl
            // 
            this.jsonLbl.AutoSize = true;
            this.jsonLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonLbl.Location = new System.Drawing.Point(28, 71);
            this.jsonLbl.Name = "jsonLbl";
            this.jsonLbl.Size = new System.Drawing.Size(97, 15);
            this.jsonLbl.TabIndex = 1;
            this.jsonLbl.Text = "Choose JSON file";
            // 
            // openXmlFileDialog
            // 
            this.openXmlFileDialog.FileName = "mapxml";
            this.openXmlFileDialog.Filter = "*.xml|*.jpg";
            // 
            // openJsonFileDialog
            // 
            this.openJsonFileDialog.FileName = "buildingJson";
            this.openJsonFileDialog.Filter = "*.json|*.JSON";
            // 
            // chooseXmlTxt
            // 
            this.chooseXmlTxt.Enabled = false;
            this.chooseXmlTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseXmlTxt.Location = new System.Drawing.Point(31, 38);
            this.chooseXmlTxt.Name = "chooseXmlTxt";
            this.chooseXmlTxt.Size = new System.Drawing.Size(245, 21);
            this.chooseXmlTxt.TabIndex = 2;
            // 
            // chooseJsonTxt
            // 
            this.chooseJsonTxt.Enabled = false;
            this.chooseJsonTxt.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseJsonTxt.Location = new System.Drawing.Point(31, 87);
            this.chooseJsonTxt.Name = "chooseJsonTxt";
            this.chooseJsonTxt.Size = new System.Drawing.Size(245, 21);
            this.chooseJsonTxt.TabIndex = 3;
            // 
            // chooseXmlBtn
            // 
            this.chooseXmlBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseXmlBtn.Location = new System.Drawing.Point(282, 38);
            this.chooseXmlBtn.Name = "chooseXmlBtn";
            this.chooseXmlBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseXmlBtn.TabIndex = 4;
            this.chooseXmlBtn.Text = "Browse...";
            this.chooseXmlBtn.UseVisualStyleBackColor = true;
            this.chooseXmlBtn.Click += new System.EventHandler(this.chooseXmlBtn_Click);
            // 
            // chooseJsonBtn
            // 
            this.chooseJsonBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseJsonBtn.Location = new System.Drawing.Point(282, 87);
            this.chooseJsonBtn.Name = "chooseJsonBtn";
            this.chooseJsonBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseJsonBtn.TabIndex = 5;
            this.chooseJsonBtn.Text = "Browse...";
            this.chooseJsonBtn.UseVisualStyleBackColor = true;
            this.chooseJsonBtn.Click += new System.EventHandler(this.chooseJsonBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeBtn.Location = new System.Drawing.Point(122, 134);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(130, 33);
            this.mergeBtn.TabIndex = 6;
            this.mergeBtn.Text = "MERGE!";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // ChooseFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 179);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.chooseJsonBtn);
            this.Controls.Add(this.chooseXmlBtn);
            this.Controls.Add(this.chooseJsonTxt);
            this.Controls.Add(this.chooseXmlTxt);
            this.Controls.Add(this.jsonLbl);
            this.Controls.Add(this.xmlLbl);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseFiles";
            this.Text = "Please choose files to merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xmlLbl;
        private System.Windows.Forms.Label jsonLbl;
        private System.Windows.Forms.OpenFileDialog openXmlFileDialog;
        private System.Windows.Forms.OpenFileDialog openJsonFileDialog;
        private System.Windows.Forms.TextBox chooseXmlTxt;
        private System.Windows.Forms.TextBox chooseJsonTxt;
        private System.Windows.Forms.Button chooseXmlBtn;
        private System.Windows.Forms.Button chooseJsonBtn;
        private System.Windows.Forms.Button mergeBtn;
    }
}

