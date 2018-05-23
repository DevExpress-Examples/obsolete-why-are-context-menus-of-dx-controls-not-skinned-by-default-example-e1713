Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraForm1
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraForm1))
			Me.btnFix = New DevExpress.XtraEditors.SimpleButton()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.testGridControl = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.rgStyles = New DevExpress.XtraEditors.RadioGroup()
			Me.testPictureEdit = New DevExpress.XtraEditors.PictureEdit()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.testGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rgStyles.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.testPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' btnFix
			' 
			Me.btnFix.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.btnFix.Appearance.Options.UseFont = True
			Me.btnFix.Location = New System.Drawing.Point(134, 686)
			Me.btnFix.Name = "btnFix"
			Me.btnFix.Size = New System.Drawing.Size(707, 22)
			Me.btnFix.TabIndex = 2
			Me.btnFix.Text = "Set MenuManager"
'			Me.btnFix.Click += New System.EventHandler(Me.btnFix_Click);
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
			Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
			Me.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
			Me.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
			Me.layoutControl1.Controls.Add(Me.labelControl1)
			Me.layoutControl1.Controls.Add(Me.testGridControl)
			Me.layoutControl1.Controls.Add(Me.rgStyles)
			Me.layoutControl1.Controls.Add(Me.testPictureEdit)
			Me.layoutControl1.Controls.Add(Me.btnFix)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(847, 714)
			Me.layoutControl1.TabIndex = 3
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' labelControl1
			' 
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl1.Location = New System.Drawing.Point(7, 7)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(834, 26)
			Me.labelControl1.StyleController = Me.layoutControl1
			Me.labelControl1.TabIndex = 8
			Me.labelControl1.Text = resources.GetString("labelControl1.Text")
			' 
			' testGridControl
			' 
			Me.testGridControl.Location = New System.Drawing.Point(196, 65)
			Me.testGridControl.MainView = Me.gridView1
			Me.testGridControl.Name = "testGridControl"
			Me.testGridControl.Size = New System.Drawing.Size(642, 379)
			Me.testGridControl.TabIndex = 7
			Me.testGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.testGridControl
			Me.gridView1.Name = "gridView1"
			' 
			' rgStyles
			' 
			Me.rgStyles.Location = New System.Drawing.Point(10, 65)
			Me.rgStyles.Name = "rgStyles"
			Me.rgStyles.Size = New System.Drawing.Size(110, 640)
			Me.rgStyles.TabIndex = 5
			' 
			' testPictureEdit
			' 
			Me.testPictureEdit.Location = New System.Drawing.Point(196, 455)
			Me.testPictureEdit.Name = "testPictureEdit"
			Me.testPictureEdit.Size = New System.Drawing.Size(642, 217)
			Me.testPictureEdit.TabIndex = 6
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "Root"
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlItem5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(847, 714)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "Root"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.btnFix
			Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
			Me.layoutControlItem2.Location = New System.Drawing.Point(127, 679)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(718, 33)
			Me.layoutControlItem2.Text = "layoutControlItem2"
			Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextToControlDistance = 0
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlGroup2
			' 
			Me.layoutControlGroup2.CustomizationFormText = "Look And Feel"
			Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3})
			Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 37)
			Me.layoutControlGroup2.Name = "layoutControlGroup2"
			Me.layoutControlGroup2.Size = New System.Drawing.Size(127, 675)
			Me.layoutControlGroup2.Text = "Look And Feel"
			Me.layoutControlGroup2.TextLocation = DevExpress.Utils.Locations.Default
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.rgStyles
			Me.layoutControlItem3.CustomizationFormText = "Look And Feel"
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(121, 651)
			Me.layoutControlItem3.Text = "Look And Feel"
			Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextToControlDistance = 0
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlGroup3
			' 
			Me.layoutControlGroup3.CustomizationFormText = "Test DX controls"
			Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem4, Me.layoutControlItem1})
			Me.layoutControlGroup3.Location = New System.Drawing.Point(127, 37)
			Me.layoutControlGroup3.Name = "layoutControlGroup3"
			Me.layoutControlGroup3.Size = New System.Drawing.Size(718, 642)
			Me.layoutControlGroup3.Text = "Test DX controls"
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.testGridControl
			Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(712, 390)
			Me.layoutControlItem4.Text = "GridControl"
			Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(54, 13)
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.testPictureEdit
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 390)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(712, 228)
			Me.layoutControlItem1.Text = "PictureEdit"
			Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(54, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.labelControl1
			Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(845, 37)
			Me.layoutControlItem5.Text = "layoutControlItem5"
			Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextToControlDistance = 0
			Me.layoutControlItem5.TextVisible = False
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.MaxItemId = 0
			' 
			' XtraForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(847, 714)
			Me.Controls.Add(Me.layoutControl1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "XtraForm1"
			Me.Text = "E1713 - Why are context menus of DX controls not skinned by default?"
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.testGridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rgStyles.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.testPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnFix As DevExpress.XtraEditors.SimpleButton
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private rgStyles As DevExpress.XtraEditors.RadioGroup
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private testGridControl As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private testPictureEdit As DevExpress.XtraEditors.PictureEdit
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace