
namespace WinFormsApp_TwitterSampleWithEFCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lstLabels = new System.Windows.Forms.ListBox();
            this.dgvVaults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnCategoryAdd = new System.Windows.Forms.ToolStripButton();
            this.btnCategorySave = new System.Windows.Forms.ToolStripButton();
            this.btnCategoryDel = new System.Windows.Forms.ToolStripButton();
            this.btnCategoryRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnLabelAdd = new System.Windows.Forms.ToolStripButton();
            this.btnLabelEdit = new System.Windows.Forms.ToolStripButton();
            this.btnLabelDel = new System.Windows.Forms.ToolStripButton();
            this.btnLabelRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnVaultAdd = new System.Windows.Forms.ToolStripButton();
            this.btnVaultEdit = new System.Windows.Forms.ToolStripButton();
            this.btnVaultDel = new System.Windows.Forms.ToolStripButton();
            this.btnVaultRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowPassword = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnDecryptPass = new System.Windows.Forms.ToolStripButton();
            this.txtDecryptedPass = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaults)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(12, 28);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(215, 25);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // lstLabels
            // 
            this.lstLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstLabels.FormattingEnabled = true;
            this.lstLabels.ItemHeight = 17;
            this.lstLabels.Location = new System.Drawing.Point(12, 59);
            this.lstLabels.Name = "lstLabels";
            this.lstLabels.Size = new System.Drawing.Size(215, 395);
            this.lstLabels.TabIndex = 2;
            this.lstLabels.SelectedIndexChanged += new System.EventHandler(this.lstLabels_SelectedIndexChanged);
            // 
            // dgvVaults
            // 
            this.dgvVaults.AllowUserToAddRows = false;
            this.dgvVaults.AllowUserToDeleteRows = false;
            this.dgvVaults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaults.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvVaults.Location = new System.Drawing.Point(233, 28);
            this.dgvVaults.MultiSelect = false;
            this.dgvVaults.Name = "dgvVaults";
            this.dgvVaults.ReadOnly = true;
            this.dgvVaults.RowTemplate.Height = 27;
            this.dgvVaults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVaults.Size = new System.Drawing.Size(730, 426);
            this.dgvVaults.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnCategoryAdd,
            this.btnCategorySave,
            this.btnCategoryDel,
            this.btnCategoryRefresh,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.btnLabelAdd,
            this.btnLabelEdit,
            this.btnLabelDel,
            this.btnLabelRefresh,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.btnVaultAdd,
            this.btnVaultEdit,
            this.btnVaultDel,
            this.btnVaultRefresh,
            this.toolStripSeparator4,
            this.btnShowPassword,
            this.btnDecryptPass,
            this.toolStripSeparator3,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.helpToolStripButton,
            this.txtDecryptedPass});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel1.Text = "Kategori :";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCategoryAdd.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.plus_16;
            this.btnCategoryAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(23, 22);
            this.btnCategoryAdd.Text = "Yeni Kategori";
            this.btnCategoryAdd.Click += new System.EventHandler(this.btnCategoryAdd_Click);
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCategorySave.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.edit_48;
            this.btnCategorySave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(23, 22);
            this.btnCategorySave.Text = "Kategori Düzenle";
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnCategoryDel
            // 
            this.btnCategoryDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCategoryDel.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.cancel_16;
            this.btnCategoryDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoryDel.Name = "btnCategoryDel";
            this.btnCategoryDel.Size = new System.Drawing.Size(23, 22);
            this.btnCategoryDel.Text = "Kategori Sil";
            this.btnCategoryDel.Click += new System.EventHandler(this.btnCategoryDel_Click);
            // 
            // btnCategoryRefresh
            // 
            this.btnCategoryRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCategoryRefresh.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.refresh_16;
            this.btnCategoryRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCategoryRefresh.Name = "btnCategoryRefresh";
            this.btnCategoryRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnCategoryRefresh.Text = "Kategori Yenile";
            this.btnCategoryRefresh.Click += new System.EventHandler(this.btnCategoryRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Etiket :";
            // 
            // btnLabelAdd
            // 
            this.btnLabelAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLabelAdd.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.plus_16;
            this.btnLabelAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLabelAdd.Name = "btnLabelAdd";
            this.btnLabelAdd.Size = new System.Drawing.Size(23, 22);
            this.btnLabelAdd.Text = "Add Label";
            this.btnLabelAdd.Click += new System.EventHandler(this.btnLabelAdd_Click);
            // 
            // btnLabelEdit
            // 
            this.btnLabelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLabelEdit.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.edit_48;
            this.btnLabelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLabelEdit.Name = "btnLabelEdit";
            this.btnLabelEdit.Size = new System.Drawing.Size(23, 22);
            this.btnLabelEdit.Text = "Edit Label";
            this.btnLabelEdit.Click += new System.EventHandler(this.btnLabelEdit_Click);
            // 
            // btnLabelDel
            // 
            this.btnLabelDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLabelDel.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.cancel_16;
            this.btnLabelDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLabelDel.Name = "btnLabelDel";
            this.btnLabelDel.Size = new System.Drawing.Size(23, 22);
            this.btnLabelDel.Text = "Delete Label";
            this.btnLabelDel.Click += new System.EventHandler(this.btnLabelDel_Click);
            // 
            // btnLabelRefresh
            // 
            this.btnLabelRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLabelRefresh.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.refresh_16;
            this.btnLabelRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLabelRefresh.Name = "btnLabelRefresh";
            this.btnLabelRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnLabelRefresh.Text = "Refresh Label";
            this.btnLabelRefresh.Click += new System.EventHandler(this.btnLabelRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel3.Text = "Şifre :";
            // 
            // btnVaultAdd
            // 
            this.btnVaultAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVaultAdd.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.plus_16;
            this.btnVaultAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVaultAdd.Name = "btnVaultAdd";
            this.btnVaultAdd.Size = new System.Drawing.Size(23, 22);
            this.btnVaultAdd.Text = "toolStripButton9";
            this.btnVaultAdd.Click += new System.EventHandler(this.btnVaultAdd_Click);
            // 
            // btnVaultEdit
            // 
            this.btnVaultEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVaultEdit.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.edit_48;
            this.btnVaultEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVaultEdit.Name = "btnVaultEdit";
            this.btnVaultEdit.Size = new System.Drawing.Size(23, 22);
            this.btnVaultEdit.Text = "toolStripButton10";
            this.btnVaultEdit.Click += new System.EventHandler(this.btnVaultEdit_Click);
            // 
            // btnVaultDel
            // 
            this.btnVaultDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVaultDel.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.cancel_16;
            this.btnVaultDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVaultDel.Name = "btnVaultDel";
            this.btnVaultDel.Size = new System.Drawing.Size(23, 22);
            this.btnVaultDel.Text = "toolStripButton11";
            this.btnVaultDel.Click += new System.EventHandler(this.btnVaultDel_Click);
            // 
            // btnVaultRefresh
            // 
            this.btnVaultRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVaultRefresh.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.refresh_16;
            this.btnVaultRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVaultRefresh.Name = "btnVaultRefresh";
            this.btnVaultRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnVaultRefresh.Text = "toolStripButton12";
            this.btnVaultRefresh.Click += new System.EventHandler(this.btnVaultRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowPassword.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.eye_16;
            this.btnShowPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(23, 22);
            this.btnShowPassword.Text = "Şifreleri Göster";
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // btnDecryptPass
            // 
            this.btnDecryptPass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDecryptPass.Image = global::WinFormsApp_TwitterSampleWithEFCore.Properties.Resources.key_16;
            this.btnDecryptPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDecryptPass.Name = "btnDecryptPass";
            this.btnDecryptPass.Size = new System.Drawing.Size(23, 22);
            this.btnDecryptPass.Text = "Şifre Çöz";
            this.btnDecryptPass.Click += new System.EventHandler(this.btnDecryptPass_Click);
            // 
            // txtDecryptedPass
            // 
            this.txtDecryptedPass.Name = "txtDecryptedPass";
            this.txtDecryptedPass.ReadOnly = true;
            this.txtDecryptedPass.Size = new System.Drawing.Size(100, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvVaults);
            this.Controls.Add(this.lstLabels);
            this.Controls.Add(this.cmbCategories);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(991, 504);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Password Box";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaults)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ListBox lstLabels;
        private System.Windows.Forms.DataGridView dgvVaults;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCategoryAdd;
        private System.Windows.Forms.ToolStripButton btnCategorySave;
        private System.Windows.Forms.ToolStripButton btnCategoryDel;
        private System.Windows.Forms.ToolStripButton btnCategoryRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLabelAdd;
        private System.Windows.Forms.ToolStripButton btnLabelEdit;
        private System.Windows.Forms.ToolStripButton btnLabelDel;
        private System.Windows.Forms.ToolStripButton btnLabelRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnVaultAdd;
        private System.Windows.Forms.ToolStripButton btnVaultEdit;
        private System.Windows.Forms.ToolStripButton btnVaultDel;
        private System.Windows.Forms.ToolStripButton btnVaultRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnShowPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripButton btnDecryptPass;
        private System.Windows.Forms.ToolStripTextBox txtDecryptedPass;
    }
}

