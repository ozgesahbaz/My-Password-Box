using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_TwitterSampleWithEFCore
{
    public partial class frmVaultAddEdit : Form
    {
        public frmVaultAddEdit()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtName, string.Empty);

            string name = txtName.Text?.Trim();

            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(txtName, "Bu alan boş geçilemez.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        bool showPassword = false;

        private void btnPasswordShowHide_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                txtPassword.PasswordChar = '\0';
                btnPasswordShowHide.Text = "Gizle";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnPasswordShowHide.Text = "Göster";
            }
        }
    }
}
