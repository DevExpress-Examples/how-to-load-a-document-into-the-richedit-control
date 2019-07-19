using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace LoadDocumentExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.DocumentLoaded += RichEditControl1_DocumentLoaded;
        }

        private void btnFromFile_Click(object sender, EventArgs e)
        {
            #region #fromfile
            richEditControl1.LoadDocument("Grimm.docx");
            #endregion #fromfile
        }

        private void btnFromStream_Click(object sender, EventArgs e)
        {
            #region #from-stream
            using (Stream stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LoadDocumentExample.TextWithImagesODT"))
            {
                richEditControl1.LoadDocument(stream);
            }
            #endregion #from-stream
        }

        private void RichEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            string documentName = richEditControl1.Options.DocumentSaveOptions.CurrentFileName;
            string msg;
            if (documentName == String.Empty)
                msg = "Current file name is empty.";
            else
                msg = "Current file name is " + documentName;
            MessageBox.Show(msg, "Info");
        }

        private void btnFromString_Click(object sender, EventArgs e)
        {
            #region #fromstring
            richEditControl1.RtfText = @"{\rtf1\ansi\ansicpg1252\deff0\deflang1049
{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}
{\f1\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green0\blue255;}
\viewkind4\uc1\pard\cf1\lang1033\b\f0\fs32 Test.\cf0\b0\f1\fs20\par}";
            #endregion #fromstring
        }
    }
}
