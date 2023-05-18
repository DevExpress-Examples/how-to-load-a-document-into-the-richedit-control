Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services
Imports System
Imports System.IO
Imports System.Windows.Forms

Namespace LoadDocumentExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            AddHandler richEditControl1.DocumentLoaded, AddressOf RichEditControl1_DocumentLoaded
        End Sub
        Private Sub RichEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim documentName As String = richEditControl1.Options.DocumentSaveOptions.CurrentFileName
            Dim msg As String
            If documentName = String.Empty Then
                msg = "Current file name is empty."
            Else
                msg = "Current file name is " & documentName
            End If
            MessageBox.Show(msg, "Info")
        End Sub
        Private Sub btnFromFile_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadFile.ItemClick
            '            #Region "#fromfile"
            richEditControl1.LoadDocument("Grimm.docx")
            '            #End Region ' #fromfile
        End Sub

        Private Sub btnFromStream_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadStream.ItemClick
            '            #Region "#from-stream"
            Using stream As Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("TextWithImagesODT")
                richEditControl1.LoadDocument(stream)
            End Using
            '            #End Region ' #from-stream
        End Sub
        Private Sub btnFromString_Click(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLoadString.ItemClick
            '            #Region "#fromstring"
            richEditControl1.RtfText = "{\rtf1\ansi\ansicpg1252\deff0\deflang1049" &
                                        "{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}" &
                                        "{\f1\fswiss\fcharset0 Arial;}}" &
                                        "{\colortbl ;\red0\green0\blue255;}" &
                                        "\viewkind4\uc1\pard\cf1\lang1033\b\f0\fs32 Test.\cf0\b0\f1\fs20\par}"
            '            #End Region ' #fromstring
        End Sub
    End Class
End Namespace
