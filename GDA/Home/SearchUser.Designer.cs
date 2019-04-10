namespace GDA.User
{
    partial class SearchUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUser));
            this.ddlSearch = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.ddcnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dduserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dduserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ddcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlSearch
            // 
            this.ddlSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSearch.FormattingEnabled = true;
            this.ddlSearch.Items.AddRange(new object[] {
            "Search All Users",
            "Search By User Id",
            "Search By Contact",
            "Search By Cnic"});
            this.ddlSearch.Location = new System.Drawing.Point(39, 123);
            this.ddlSearch.Name = "ddlSearch";
            this.ddlSearch.Size = new System.Drawing.Size(157, 29);
            this.ddlSearch.TabIndex = 64;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnRegister.Location = new System.Drawing.Point(419, 123);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(91, 32);
            this.btnRegister.TabIndex = 59;
            this.btnRegister.Text = "Search";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(234, 123);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(153, 30);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.Text = "Enter value...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(100, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Users";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(234, 124);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(153, 30);
            this.txtContact.TabIndex = 61;
            this.txtContact.Text = "Enter value...";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(933, 100);
            this.panel4.TabIndex = 58;
            // 
            // txtCnic
            // 
            this.txtCnic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnic.Location = new System.Drawing.Point(234, 124);
            this.txtCnic.Multiline = true;
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(153, 30);
            this.txtCnic.TabIndex = 62;
            this.txtCnic.Text = "Enter value...";
            // 
            // ddcnic
            // 
            this.ddcnic.HeaderText = "CNIC";
            this.ddcnic.Name = "ddcnic";
            this.ddcnic.Width = 150;
            // 
            // dduserName
            // 
            this.dduserName.HeaderText = "User Name";
            this.dduserName.Name = "dduserName";
            // 
            // ddaddress
            // 
            this.ddaddress.HeaderText = "Address";
            this.ddaddress.MinimumWidth = 7;
            this.ddaddress.Name = "ddaddress";
            this.ddaddress.Width = 150;
            // 
            // ddemail
            // 
            this.ddemail.HeaderText = "Email";
            this.ddemail.MinimumWidth = 7;
            this.ddemail.Name = "ddemail";
            this.ddemail.Width = 150;
            // 
            // ddrole
            // 
            this.ddrole.HeaderText = "Role";
            this.ddrole.MinimumWidth = 3;
            this.ddrole.Name = "ddrole";
            this.ddrole.Width = 60;
            // 
            // ddpassword
            // 
            this.ddpassword.HeaderText = "Password";
            this.ddpassword.Name = "ddpassword";
            // 
            // ddname
            // 
            this.ddname.HeaderText = "Name";
            this.ddname.Name = "ddname";
            // 
            // dduserID
            // 
            this.dduserID.HeaderText = "Id";
            this.dduserID.MinimumWidth = 3;
            this.dduserID.Name = "dduserID";
            this.dduserID.Width = 60;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dduserID,
            this.ddname,
            this.ddpassword,
            this.ddrole,
            this.ddemail,
            this.ddaddress,
            this.dduserName,
            this.ddcontact,
            this.ddcnic});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(39, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 168);
            this.dataGridView1.TabIndex = 63;
            // 
            // ddcontact
            // 
            this.ddcontact.HeaderText = "Contact number";
            this.ddcontact.Name = "ddcontact";
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "UserRoles";
            // 
            // userRolesBindingSource1
            // 
            this.userRolesBindingSource1.DataMember = "UserRoles";
            // 
            // userRolesBindingSource2
            // 
            this.userRolesBindingSource2.DataMember = "UserRoles";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(25, 39);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(59, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.ControlBox = false;
            this.Controls.Add(this.ddlSearch);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Search_load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private System.Windows.Forms.ComboBox ddlSearch;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.BindingSource userRolesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddcnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dduserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dduserID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddcontact;
        private System.Windows.Forms.BindingSource userRolesBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}