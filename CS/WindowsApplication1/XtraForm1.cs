using System;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication1 {
    public partial class XtraForm1 : XtraForm {
        public XtraForm1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitStylesRadioGroup();
        }
        private void SetMenuManager() {
            testGridControl.MenuManager = testGridControl.MenuManager == null ? barManager1 : null;
            testPictureEdit.MenuManager = testPictureEdit.MenuManager == null ? barManager1 : null;
            btnFix.Text = btnFix.Text == "Set MenuManager" ? "Unset MenuManager" : "Set MenuManager";
        }
        private void InitStylesRadioGroup() {
            foreach (SkinContainer skinContainer in SkinManager.Default.Skins) {
                rgStyles.Properties.Items.Add(new RadioGroupItem(skinContainer.SkinName, skinContainer.SkinName));
            }
            rgStyles.SelectedIndexChanged += rgStyles_SelectedIndexChanged;
            rgStyles.SelectedIndex = 5;
        }
        private void rgStyles_SelectedIndexChanged(object sender, EventArgs e) {
            RadioGroup rg = (RadioGroup)sender;
            UserLookAndFeel.Default.SetSkinStyle(rg.Properties.Items[rg.SelectedIndex].Value.ToString());
        }
        private void btnFix_Click(object sender, EventArgs e) {
            SetMenuManager();
        }
    }
}