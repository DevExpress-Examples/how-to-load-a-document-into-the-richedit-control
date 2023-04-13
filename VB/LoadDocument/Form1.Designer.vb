Namespace LoadDocument

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnLoadString = New DevExpress.XtraEditors.SimpleButton()
            Me.btnLoadStream = New DevExpress.XtraEditors.SimpleButton()
            Me.btnLoadFile = New DevExpress.XtraEditors.SimpleButton()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 38)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(644, 372)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            AddHandler Me.richEditControl1.DocumentLoaded, New System.EventHandler(AddressOf Me.richEditControl1_DocumentLoaded)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.btnLoadString)
            Me.panelControl1.Controls.Add(Me.btnLoadStream)
            Me.panelControl1.Controls.Add(Me.btnLoadFile)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(644, 38)
            Me.panelControl1.TabIndex = 1
            ' 
            ' btnLoadString
            ' 
            Me.btnLoadString.Location = New System.Drawing.Point(312, 7)
            Me.btnLoadString.Name = "btnLoadString"
            Me.btnLoadString.Size = New System.Drawing.Size(149, 23)
            Me.btnLoadString.TabIndex = 4
            Me.btnLoadString.Text = "Load Document from String"
            AddHandler Me.btnLoadString.Click, New System.EventHandler(AddressOf Me.btnLoadString_Click)
            ' 
            ' btnLoadStream
            ' 
            Me.btnLoadStream.Location = New System.Drawing.Point(157, 7)
            Me.btnLoadStream.Name = "btnLoadStream"
            Me.btnLoadStream.Size = New System.Drawing.Size(149, 23)
            Me.btnLoadStream.TabIndex = 3
            Me.btnLoadStream.Text = "Load Document from Stream"
            AddHandler Me.btnLoadStream.Click, New System.EventHandler(AddressOf Me.btnLoadStream_Click)
            ' 
            ' btnLoadFile
            ' 
            Me.btnLoadFile.Location = New System.Drawing.Point(12, 7)
            Me.btnLoadFile.Name = "btnLoadFile"
            Me.btnLoadFile.Size = New System.Drawing.Size(139, 23)
            Me.btnLoadFile.TabIndex = 0
            Me.btnLoadFile.Text = "Load Document from File"
            AddHandler Me.btnLoadFile.Click, New System.EventHandler(AddressOf Me.btnLoadFile_Click)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(644, 410)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private btnLoadFile As DevExpress.XtraEditors.SimpleButton

        Private btnLoadStream As DevExpress.XtraEditors.SimpleButton

        Private btnLoadString As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace
