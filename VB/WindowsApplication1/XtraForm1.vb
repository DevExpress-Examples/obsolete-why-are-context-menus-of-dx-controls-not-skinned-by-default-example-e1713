Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace WindowsApplication1
	Partial Public Class XtraForm1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			InitStylesRadioGroup()
		End Sub
		Private Sub SetMenuManager()
			If testGridControl.MenuManager Is Nothing Then
				testGridControl.MenuManager = barManager1
			Else
				testGridControl.MenuManager = Nothing
			End If
			If testPictureEdit.MenuManager Is Nothing Then
				testPictureEdit.MenuManager = barManager1
			Else
				testPictureEdit.MenuManager = Nothing
			End If
			If btnFix.Text = "Set MenuManager" Then
				btnFix.Text = "Unset MenuManager"
			Else
				btnFix.Text = "Set MenuManager"
			End If
		End Sub
		Private Sub InitStylesRadioGroup()
			For Each skinContainer As SkinContainer In SkinManager.Default.Skins
				rgStyles.Properties.Items.Add(New RadioGroupItem(skinContainer.SkinName, skinContainer.SkinName))
			Next skinContainer
			AddHandler rgStyles.SelectedIndexChanged, AddressOf rgStyles_SelectedIndexChanged
			rgStyles.SelectedIndex = 5
		End Sub
		Private Sub rgStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim rg As RadioGroup = CType(sender, RadioGroup)
			UserLookAndFeel.Default.SetSkinStyle(rg.Properties.Items(rg.SelectedIndex).Value.ToString())
		End Sub
		Private Sub btnFix_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFix.Click
			SetMenuManager()
		End Sub
	End Class
End Namespace