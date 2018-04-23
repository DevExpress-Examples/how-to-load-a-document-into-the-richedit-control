Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native

Namespace LoadDocument
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Shared Function GetResourceStream(ByVal resourceName As String) As Stream
			Return System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
		End Function

		Private Sub btnLoadStream_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadStream.Click
			Using stream As Stream = GetResourceStream("LoadDocument.Documents.TextWithImages.rtf")
				stream.Seek(0, SeekOrigin.Begin)
				richEditControl1.LoadDocument(stream, DocumentFormat.Rtf)
				stream.Close()
			End Using

		End Sub

		Private Sub btnLoadFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadFile.Click
			richEditControl1.LoadDocument("Documents\TextWithImages.rtf",DocumentFormat.Rtf)
		End Sub

		Private Sub richEditControl1_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.DocumentLoaded
			Dim documentName As String = richEditControl1.Options.DocumentSaveOptions.CurrentFileName
			MessageBox.Show("Document file name: " & documentName, "Info")

		End Sub


		Private Sub btnLoadString_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadString.Click
			richEditControl1.RtfText = "{\rtf1\ansi\deff0{\fonttbl{\f0\fnil Times New Roman;}}" & ControlChars.CrLf & "{\colortbl ;\red255\green0\blue0;\red0\green0\blue0;\red255\green192\blue0;\red255\green255\blue0;\red0\green176\blue80;\red0\green176\blue240;" & ControlChars.CrLf & "\red0\green112\blue192;\red112\green48\blue160;\red153\green204\blue255;\red255\green102\blue0;\red0\green204\blue255;\red192\green192\blue192;" & ControlChars.CrLf & "\red255\green153\blue204;\red0\green255\blue0;\red204\green153\blue255;\red51\green51\blue51;\red51\green102\blue255;\red255\green153\blue0;" & ControlChars.CrLf & "\red153\green153\blue153;\red128\green128\blue128;\red255\green204\blue0;\red0\green255\blue255;\red51\green51\blue153;\red204\green255\blue255;}" & ControlChars.CrLf & "\viewkind4\uc1\pard\sl264\slmult1\cf1\lang1033\b\f0\fs44 R\b0 ichard\cf2  \cf3\b O\b0 f\cf2  \cf4\b Y\b0 ork\cf2  \cf5\b G\b0 ave\cf2  \cf6\b B\b0" & ControlChars.CrLf & "attle\cf2  \cf7\b I\b0 n\cf2  \cf8\b V\b0 ain\cf2 .\cf0\fs24\par" & ControlChars.CrLf & "\pard\cf9\fs48 T\cf10 h\cf11 i\cf12 s\cf2  \cf13 i\cf14 s\cf2  \cf15\ul c\cf16 o\cf10 l\cf17 o\cf18 r\cf19 i\cf12 z\cf10 e\cf20 d\cf2\ulnone  \cf20" & ControlChars.CrLf & "t\cf21 e\cf1 x\cf22 t\cf23 .\par\cf2\fs52 This\fs24  \fs32 te\b xt\fs24  \fs96 c\super o\nosupersub n\sub t\nosupersub a\super i\nosupersub n\sub" & ControlChars.CrLf & "s\cf23\nosupersub\fs24  \cf24\ul diffe\cf2 rent \i\fs96 chara\i0 cter f\cf15 or\ulnone mat\cf2 ting in one \b0 paragraph.\cf0\fs24\par" & ControlChars.CrLf & "}"
		End Sub








	End Class
End Namespace