namespace LoadDocumentExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnFromString = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromStream = new DevExpress.XtraEditors.SimpleButton();
            this.btnFromFile = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 47);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(1229, 655);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnFromString);
            this.panelControl1.Controls.Add(this.btnFromStream);
            this.panelControl1.Controls.Add(this.btnFromFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1229, 47);
            this.panelControl1.TabIndex = 1;
            // 
            // btnFromString
            // 
            this.btnFromString.Location = new System.Drawing.Point(470, 13);
            this.btnFromString.Name = "btnFromString";
            this.btnFromString.Size = new System.Drawing.Size(178, 23);
            this.btnFromString.TabIndex = 2;
            this.btnFromString.Text = "Load Document from String";
            this.btnFromString.Click += new System.EventHandler(this.btnFromString_Click);
            // 
            // btnFromStream
            // 
            this.btnFromStream.Location = new System.Drawing.Point(253, 13);
            this.btnFromStream.Name = "btnFromStream";
            this.btnFromStream.Size = new System.Drawing.Size(178, 23);
            this.btnFromStream.TabIndex = 1;
            this.btnFromStream.Text = "Load Document from Stream";
            this.btnFromStream.Click += new System.EventHandler(this.btnFromStream_Click);
            // 
            // btnFromFile
            // 
            this.btnFromFile.Location = new System.Drawing.Point(36, 13);
            this.btnFromFile.Name = "btnFromFile";
            this.btnFromFile.Size = new System.Drawing.Size(178, 23);
            this.btnFromFile.TabIndex = 0;
            this.btnFromFile.Text = "Load Document from File";
            this.btnFromFile.Click += new System.EventHandler(this.btnFromFile_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 702);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Load Document Example";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnFromString;
        private DevExpress.XtraEditors.SimpleButton btnFromStream;
        private DevExpress.XtraEditors.SimpleButton btnFromFile;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

