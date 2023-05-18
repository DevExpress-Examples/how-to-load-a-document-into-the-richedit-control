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
            Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.btnLoadFile = New DevExpress.XtraBars.BarButtonItem()
            Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.btnLoadStream = New DevExpress.XtraBars.BarButtonItem()
            Me.btnLoadString = New DevExpress.XtraBars.BarButtonItem()
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'richEditControl1
            '
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 183)
            Me.richEditControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.richEditControl1.MenuManager = Me.RibbonControl1
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
            Me.richEditControl1.Size = New System.Drawing.Size(1434, 681)
            Me.richEditControl1.TabIndex = 0
            '
            'RibbonControl1
            '
            Me.RibbonControl1.ExpandCollapseItem.Id = 0
            Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonControl1.SearchEditItem, Me.btnLoadFile, Me.btnLoadStream, Me.btnLoadString})
            Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl1.MaxItemId = 4
            Me.RibbonControl1.Name = "RibbonControl1"
            Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
            Me.RibbonControl1.Size = New System.Drawing.Size(1434, 183)
            '
            'btnLoadFile
            '
            Me.btnLoadFile.Caption = "Load Document from File"
            Me.btnLoadFile.Id = 1
            Me.btnLoadFile.Name = "btnLoadFile"
            '
            'RibbonPage1
            '
            Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
            Me.RibbonPage1.Name = "RibbonPage1"
            Me.RibbonPage1.Text = "File"
            '
            'RibbonPageGroup1
            '
            Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadFile)
            Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadStream)
            Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLoadString)
            Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
            Me.RibbonPageGroup1.Text = "Load"
            '
            'defaultLookAndFeel1
            '
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            '
            'btnLoadStream
            '
            Me.btnLoadStream.Caption = "Load Document from Stream"
            Me.btnLoadStream.Id = 2
            Me.btnLoadStream.Name = "btnLoadStream"
            '
            'btnLoadString
            '
            Me.btnLoadString.Caption = "Load Document from RTF String"
            Me.btnLoadString.Id = 3
            Me.btnLoadString.Name = "btnLoadString"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1434, 864)
            Me.Controls.Add(Me.richEditControl1)
            Me.Controls.Add(Me.RibbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Ribbon = Me.RibbonControl1
            Me.Text = "Load Document Example"
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents btnLoadFile As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents btnLoadStream As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btnLoadString As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

