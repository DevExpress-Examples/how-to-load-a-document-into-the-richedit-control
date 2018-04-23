namespace LoadDocument {
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
            if(disposing && (components != null)) {
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadString = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadStream = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoadFile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl1.Location = new System.Drawing.Point(0, 38);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(644, 372);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            this.richEditControl1.DocumentLoaded += new System.EventHandler(this.richEditControl1_DocumentLoaded);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadString);
            this.panelControl1.Controls.Add(this.btnLoadStream);
            this.panelControl1.Controls.Add(this.btnLoadFile);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(644, 38);
            this.panelControl1.TabIndex = 1;
            // 
            // btnLoadString
            // 
            this.btnLoadString.Location = new System.Drawing.Point(312, 7);
            this.btnLoadString.Name = "btnLoadString";
            this.btnLoadString.Size = new System.Drawing.Size(149, 23);
            this.btnLoadString.TabIndex = 4;
            this.btnLoadString.Text = "Load Document from String";
            this.btnLoadString.Click += new System.EventHandler(this.btnLoadString_Click);
            // 
            // btnLoadStream
            // 
            this.btnLoadStream.Location = new System.Drawing.Point(157, 7);
            this.btnLoadStream.Name = "btnLoadStream";
            this.btnLoadStream.Size = new System.Drawing.Size(149, 23);
            this.btnLoadStream.TabIndex = 3;
            this.btnLoadStream.Text = "Load Document from Stream";
            this.btnLoadStream.Click += new System.EventHandler(this.btnLoadStream_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 7);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(139, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load Document from File";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 410);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadFile;
        private DevExpress.XtraEditors.SimpleButton btnLoadStream;
        private DevExpress.XtraEditors.SimpleButton btnLoadString;
    }
}

