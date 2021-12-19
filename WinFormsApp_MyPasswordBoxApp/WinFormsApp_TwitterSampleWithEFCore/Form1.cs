using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_TwitterSampleWithEFCore.Models;

namespace WinFormsApp_TwitterSampleWithEFCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseContext _db = new DatabaseContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnCategoryRefresh_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            List<Category> categories = _db.Categories.Include(x => x.Labels).ToList();

            cmbCategories.DataSource = null;
            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "Id";

            //foreach (Category c in categories)
            //{

            //}

            contextMenuStrip1.Items.Clear();

            //categories.ForEach(c => contextMenuStrip1.Items.Add(c.Name));

            categories.ForEach(category =>
            {
                ToolStripMenuItem categoryItem = contextMenuStrip1.Items.Add(category.Name) as ToolStripMenuItem;

                category.Labels.ToList().ForEach(label =>
                {
                    ToolStripItem labelItem = categoryItem.DropDownItems.Add(label.Name, null, ContextMenuItem_Click);
                    labelItem.Tag = label;
                });
            });


        }

        private void ContextMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvVaults.SelectedRows != null && dgvVaults.SelectedRows.Count > 0)
            {
                ToolStripItem labelItem = sender as ToolStripItem;
                Models.Label label = labelItem.Tag as Models.Label;
                Vault vault = dgvVaults.SelectedRows[0].DataBoundItem as Vault;

                DialogResult result = MessageBox.Show($"\"{vault.Name}\" isimli şifreyi \"{label.Name}\" etiketi altına taşımak istediğinize emin misiniz?", "Şifre Taşıma", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    vault.LabelId = label.Id;

                    if (_db.SaveChanges() > 0)
                    {
                        LoadVaultsByLabel();
                    }
                }
            }
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            frmNameForm frm = new frmNameForm();
            frm.Text = "Kategori Ekle";
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _db.Categories.Add(new Category
                {
                    Name = frm.txtName.Text,
                    CreatedAt = DateTime.Now
                });

                if (_db.SaveChanges() > 0)
                {
                    LoadCategories();
                }
                else
                {
                    MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex > -1)
            {
                Category category = cmbCategories.SelectedItem as Category;

                frmNameForm frm = new frmNameForm();
                frm.Text = "Kategori Düzenle";
                frm.txtName.Text = category.Name;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    //Category c = _db.Categories.Find(category.Id);
                    category.Name = frm.txtName.Text;
                    category.UpdatedAt = DateTime.Now;

                    if (_db.SaveChanges() > 0)
                    {
                        int selectedIndex = cmbCategories.SelectedIndex;
                        LoadCategories();
                        cmbCategories.SelectedIndex = selectedIndex;
                    }
                    else
                    {
                        MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCategoryDel_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex > -1)
            {
                Category category = cmbCategories.SelectedItem as Category;

                if (category.Labels.Any())
                {
                    DialogResult dialogResultApprovement = MessageBox.Show($"{category.Name} isimli kategoriye ait etiketler bulunmaktadır. İşleme devam ederseniz bu etiketler ve onlara ait şifreler silinecektir. Devam etmek istiyor musunuz?\n\n NOT : Dilerseniz şifreleri başka kategoriye ait etiketlere taşıdıktan sonra işlemi gerçekleştirebilirsiniz.", "Kategori Sil İşlemi Devam Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dialogResultApprovement == DialogResult.No)
                    {
                        return;
                    }
                }

                DialogResult result = MessageBox.Show($"{category.Name} isimli kategoriyi silmek istediğinize emin misiniz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (result == DialogResult.Yes)
                {
                    _db.Categories.Remove(category);

                    if (_db.SaveChanges() > 0)
                    {
                        LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLabelAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex > -1)
            {
                Category category = cmbCategories.SelectedItem as Category;

                frmNameForm frm = new frmNameForm();
                frm.Text = "Etiket Ekle";
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _db.Labels.Add(new Models.Label
                    {
                        Name = frm.txtName.Text,
                        CreatedAt = DateTime.Now,
                        //Category = category,
                        CategoryId = category.Id
                    });

                    if (_db.SaveChanges() > 0)
                    {
                        LoadLabelsByCategory();
                    }
                    else
                    {
                        MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.", "Kategori Seçili Değil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLabelsByCategory()
        {
            if (cmbCategories.SelectedIndex > -1)
            {
                Category category = cmbCategories.SelectedItem as Category;

                lstLabels.DataSource = null;
                lstLabels.DataSource = _db.Labels.Where(x => x.CategoryId == category.Id).ToList();
                lstLabels.DisplayMember = "Name";
                lstLabels.ValueMember = "Id";
            }
        }

        private void btnLabelEdit_Click(object sender, EventArgs e)
        {
            if (lstLabels.SelectedIndex > -1)
            {
                //Category category = cmbCategories.SelectedItem as Category;
                Models.Label label = lstLabels.SelectedItem as Models.Label;

                frmNameForm frm = new frmNameForm();
                frm.Text = "Etiket Düzenle";
                frm.txtName.Text = label.Name;
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    label.Name = frm.txtName.Text;
                    label.UpdatedAt = DateTime.Now;

                    if (_db.SaveChanges() > 0)
                    {
                        int selectedLabelIndex = lstLabels.SelectedIndex;
                        LoadLabelsByCategory();
                        lstLabels.SelectedIndex = selectedLabelIndex;
                    }
                    else
                    {
                        MessageBox.Show("Hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir etiket seçiniz.", "Etiket Seçili Değil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLabelsByCategory();
        }

        private void btnLabelDel_Click(object sender, EventArgs e)
        {
            if (lstLabels.SelectedIndex > -1)
            {
                Models.Label label = lstLabels.SelectedItem as Models.Label;

                if (label.Vaults.Any())
                {
                    DialogResult dialogResultApprovement = MessageBox.Show($"{label.Name} isimli etikete ait şifreler bulunmaktadır. İşleme devam ederseniz bu şifrelerde silinecektir. Devam etmek istiyor musunuz?\n\n NOT : Dilerseniz şifreleri başka etikete taşıdıktan sonra işlemi gerçekleştirebilirsiniz.", "Etiket Sil İşlemi Devam Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dialogResultApprovement == DialogResult.No)
                    {
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show($"{label.Name} isimli etiket silinsin mi?", "Etiket Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    _db.Labels.Remove(label);

                    if (_db.SaveChanges() > 0)
                    {
                        LoadLabelsByCategory();
                    }
                    else
                    {
                        MessageBox.Show("Etiket bulunamadı.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnLabelRefresh_Click(object sender, EventArgs e)
        {
            LoadLabelsByCategory();
        }

        private void btnVaultAdd_Click(object sender, EventArgs e)
        {
            if (lstLabels.SelectedIndex > -1)
            {
                Models.Label label = lstLabels.SelectedItem as Models.Label;

                frmVaultAddEdit frm = new frmVaultAddEdit();
                frm.Text = "Şifre Ekleme";
                frm.StartPosition = FormStartPosition.CenterParent;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(frm.txtPassword.Text);

                    Vault vault = new Vault
                    {
                        Name = frm.txtName.Text,
                        Username = frm.txtUsername.Text,
                        Password = Convert.ToBase64String(passwordBytes),
                        Description = frm.txtDescription.Text,
                        CreatedAt = DateTime.Now,
                        LabelId = label.Id
                    };

                    _db.Vaults.Add(vault);

                    if (_db.SaveChanges() > 0)
                    {
                        LoadVaultsByLabel();
                    }
                }
            }
        }

        private void LoadVaultsByLabel()
        {
            if (lstLabels.SelectedIndex > -1)
            {
                Models.Label label = lstLabels.SelectedItem as Models.Label;
                List<Vault> vaults = _db.Vaults.Where(x => x.LabelId == label.Id).ToList();

                //vaults.ForEach(vault =>
                //{
                //    byte[] bytes = Convert.FromBase64String(vault.Password);
                //    vault.Password = System.Text.Encoding.UTF8.GetString(bytes);
                //});

                dgvVaults.DataSource = null;
                dgvVaults.DataSource = vaults;

                dgvVaults.Columns["Id"].Visible = false;
                dgvVaults.Columns["LabelId"].Visible = false;
                dgvVaults.Columns["Label"].Visible = false;
                dgvVaults.Columns["Password"].Visible = showPassword;

                dgvVaults.Columns["Name"].HeaderText = "Adı";
                dgvVaults.Columns["Username"].HeaderText = "Kullanıcı Adı";
                dgvVaults.Columns["Password"].HeaderText = "Şifre";
                dgvVaults.Columns["Description"].HeaderText = "Açıklama";
                dgvVaults.Columns["CreatedAt"].HeaderText = "Oluşturma Tar.";
                dgvVaults.Columns["UpdatedAt"].HeaderText = "Güncelleme Tar.";

                dgvVaults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
        }

        private void btnVaultRefresh_Click(object sender, EventArgs e)
        {
            LoadVaultsByLabel();
        }

        private void lstLabels_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVaultsByLabel();
        }

        private void btnVaultEdit_Click(object sender, EventArgs e)
        {
            if (dgvVaults.SelectedRows != null && dgvVaults.SelectedRows.Count > 0)
            {
                Models.Label label = lstLabels.SelectedItem as Models.Label;
                Vault vault = dgvVaults.SelectedRows[0].DataBoundItem as Vault;

                frmVaultAddEdit frm = new frmVaultAddEdit();
                frm.Text = "Şifre Düzenle";
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.txtName.Text = vault.Name;
                frm.txtUsername.Text = vault.Username;
                frm.txtDescription.Text = vault.Description;

                byte[] bytes = Convert.FromBase64String(vault.Password);
                string pass = System.Text.Encoding.UTF8.GetString(bytes);

                frm.txtPassword.Text = pass;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(frm.txtPassword.Text);

                    vault.Name = frm.txtName.Text;
                    vault.Username = frm.txtUsername.Text;
                    vault.Password = Convert.ToBase64String(passwordBytes);
                    vault.Description = frm.txtDescription.Text;
                    vault.UpdatedAt = DateTime.Now;

                    if (_db.SaveChanges() > 0)
                    {
                        int selectedIndex = dgvVaults.SelectedRows[0].Index;
                        LoadVaultsByLabel();
                        dgvVaults.Rows[selectedIndex].Selected = true;
                    }
                }
            }
        }

        bool showPassword = false;

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                btnShowPassword.Image = Properties.Resources.eye_off_16;
                btnShowPassword.Text = "Şifreleri Gizle";
                btnShowPassword.ToolTipText = "Şifreleri Gizle";

                dgvVaults.Columns["Password"].Visible = true;
            }
            else
            {
                btnShowPassword.Image = Properties.Resources.eye_16;
                btnShowPassword.Text = "Şifreleri Göster";
                btnShowPassword.ToolTipText = "Şifreleri Göster";

                dgvVaults.Columns["Password"].Visible = false;
            }
        }

        private void btnVaultDel_Click(object sender, EventArgs e)
        {
            if (dgvVaults.SelectedRows != null && dgvVaults.SelectedRows.Count > 0)
            {
                Vault vault = dgvVaults.SelectedRows[0].DataBoundItem as Vault;

                DialogResult dialogResult = MessageBox.Show($"{vault.Name} isimli şifre silinsin mi?", "Şifre Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialogResult == DialogResult.Yes)
                {
                    _db.Vaults.Remove(vault);

                    if (_db.SaveChanges() > 0)
                    {
                        LoadVaultsByLabel();
                    }
                }
            }
        }

        private void btnDecryptPass_Click(object sender, EventArgs e)
        {
            if (dgvVaults.SelectedRows != null && dgvVaults.SelectedRows.Count > 0)
            {
                Vault vault = dgvVaults.SelectedRows[0].DataBoundItem as Vault;

                byte[] bytes = Convert.FromBase64String(vault.Password);
                string pass = System.Text.Encoding.UTF8.GetString(bytes);

                txtDecryptedPass.Text = pass;
            }
        }
    }
}
