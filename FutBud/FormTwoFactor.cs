using System;
using MetroFramework.Forms;

namespace FutBud
{
    public partial class TwoFactor : MetroForm
    {
        public TwoFactor()
        {
            InitializeComponent();
            StyleManager = metroStyleManager;
            try
            {
                metroStyleManager.Style = Properties.Settings.Default.MetroColor;
                metroStyleManager.Theme = Properties.Settings.Default.MetroTheme;
            }
            catch
            {
                // ignored
            }
        }

        public string Code { get; set; }

        private void FormTwoFactor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Code = tbCode.Text;
            Close();
        }
    }
}
