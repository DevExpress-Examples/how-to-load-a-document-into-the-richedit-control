Namespace LoadDocumentExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.btnFromString = New DevExpress.XtraEditors.SimpleButton()
            Me.btnFromStream = New DevExpress.XtraEditors.SimpleButton()
            Me.btnFromFile = New DevExpress.XtraEditors.SimpleButton()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 47)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(1229, 655)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.btnFromString)
            Me.panelControl1.Controls.Add(Me.btnFromStream)
            Me.panelControl1.Controls.Add(Me.btnFromFile)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1229, 47)
            Me.panelControl1.TabIndex = 1
            ' 
            ' btnFromString
            ' 
            Me.btnFromString.Location = New System.Drawing.Point(470, 13)
            Me.btnFromString.Name = "btnFromString"
            Me.btnFromString.Size = New System.Drawing.Size(178, 23)
            Me.btnFromString.TabIndex = 2
            Me.btnFromString.Text = "Load Document from String"
            ' 
            ' btnFromStream
            ' 
            Me.btnFromStream.Location = New System.Drawing.Point(253, 13)
            Me.btnFromStream.Name = "btnFromStream"
            Me.btnFromStream.Size = New System.Drawing.Size(178, 23)
            Me.btnFromStream.TabIndex = 1
            Me.btnFromStream.Text = "Load Document from Stream"
            ' 
            ' btnFromFile
            ' 
            Me.btnFromFile.Location = New System.Drawing.Point(36, 13)
            Me.btnFromFile.Name = "btnFromFile"
            Me.btnFromFile.Size = New System.Drawing.Size(178, 23)
            Me.btnFromFile.TabIndex = 0
            Me.btnFromFile.Text = "Load Document from File"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1229, 702)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Load Document Example"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnFromString As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnFromStream As DevExpress.XtraEditors.SimpleButton
        Private WithEvents btnFromFile As DevExpress.XtraEditors.SimpleButton
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

