using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;

namespace LoadDocument{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        static Stream GetResourceStream(string resourceName) {
            return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
        }

        private void btnLoadStream_Click(object sender, EventArgs e) {
            using(Stream stream = GetResourceStream("LoadDocument.Documents.TextWithImages.rtf")) {
                stream.Seek(0, SeekOrigin.Begin);
                richEditControl1.LoadDocument(stream, DocumentFormat.Rtf);
                stream.Close();
            }

        }

        private void btnLoadFile_Click(object sender, EventArgs e) {
            richEditControl1.LoadDocument("Documents\\TextWithImages.rtf",DocumentFormat.Rtf);
        }

        private void richEditControl1_DocumentLoaded(object sender, EventArgs e) {
            string documentName = richEditControl1.Options.DocumentSaveOptions.CurrentFileName;
            MessageBox.Show("Document file name: " + documentName, "Info");

        }


        private void btnLoadString_Click(object sender, EventArgs e) {
            richEditControl1.RtfText = @"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil Times New Roman;}}
{\colortbl ;\red255\green0\blue0;\red0\green0\blue0;\red255\green192\blue0;\red255\green255\blue0;\red0\green176\blue80;\red0\green176\blue240;
\red0\green112\blue192;\red112\green48\blue160;\red153\green204\blue255;\red255\green102\blue0;\red0\green204\blue255;\red192\green192\blue192;
\red255\green153\blue204;\red0\green255\blue0;\red204\green153\blue255;\red51\green51\blue51;\red51\green102\blue255;\red255\green153\blue0;
\red153\green153\blue153;\red128\green128\blue128;\red255\green204\blue0;\red0\green255\blue255;\red51\green51\blue153;\red204\green255\blue255;}
\viewkind4\uc1\pard\sl264\slmult1\cf1\lang1033\b\f0\fs44 R\b0 ichard\cf2  \cf3\b O\b0 f\cf2  \cf4\b Y\b0 ork\cf2  \cf5\b G\b0 ave\cf2  \cf6\b B\b0
attle\cf2  \cf7\b I\b0 n\cf2  \cf8\b V\b0 ain\cf2 .\cf0\fs24\par
\pard\cf9\fs48 T\cf10 h\cf11 i\cf12 s\cf2  \cf13 i\cf14 s\cf2  \cf15\ul c\cf16 o\cf10 l\cf17 o\cf18 r\cf19 i\cf12 z\cf10 e\cf20 d\cf2\ulnone  \cf20
t\cf21 e\cf1 x\cf22 t\cf23 .\par\cf2\fs52 This\fs24  \fs32 te\b xt\fs24  \fs96 c\super o\nosupersub n\sub t\nosupersub a\super i\nosupersub n\sub
s\cf23\nosupersub\fs24  \cf24\ul diffe\cf2 rent \i\fs96 chara\i0 cter f\cf15 or\ulnone mat\cf2 ting in one \b0 paragraph.\cf0\fs24\par
}";
        }








    }
}