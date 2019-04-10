namespace GDA.Allottees
{
    partial class allotteesPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allotteesPayment));
            this.PaidOnDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.otherPayment = new System.Windows.Forms.Button();
            this.dueDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlDueDate = new System.Windows.Forms.DateTimePicker();
            this.ddlDueAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.ddlPaidDate = new System.Windows.Forms.DateTimePicker();
            this.ddlSurcharge = new System.Windows.Forms.TextBox();
            this.ddlAmountPaid = new System.Windows.Forms.TextBox();
            this.ddlInstallment = new System.Windows.Forms.ComboBox();
            this.installmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.surcharge = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaidOnDate
            // 
            this.PaidOnDate.Location = new System.Drawing.Point(687, 202);
            this.PaidOnDate.Name = "PaidOnDate";
            this.PaidOnDate.Size = new System.Drawing.Size(286, 23);
            this.PaidOnDate.TabIndex = 19;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(687, 152);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(286, 34);
            this.txtAmount.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.SeaGreen;
            this.label12.Location = new System.Drawing.Point(601, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Paid on";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(71, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Due Amount";
            // 
            // otherPayment
            // 
            this.otherPayment.BackColor = System.Drawing.Color.SeaGreen;
            this.otherPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.otherPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherPayment.ForeColor = System.Drawing.Color.Snow;
            this.otherPayment.Location = new System.Drawing.Point(416, 334);
            this.otherPayment.Name = "otherPayment";
            this.otherPayment.Size = new System.Drawing.Size(224, 45);
            this.otherPayment.TabIndex = 15;
            this.otherPayment.Text = "Submit";
            this.otherPayment.UseVisualStyleBackColor = false;
            this.otherPayment.Click += new System.EventHandler(this.otherPayment_Click);
            // 
            // dueDate
            // 
            this.dueDate.Location = new System.Drawing.Point(194, 202);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(286, 23);
            this.dueDate.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(575, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Paid on";
            // 
            // ddlDueDate
            // 
            this.ddlDueDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlDueDate.Location = new System.Drawing.Point(196, 180);
            this.ddlDueDate.Name = "ddlDueDate";
            this.ddlDueDate.Size = new System.Drawing.Size(286, 23);
            this.ddlDueDate.TabIndex = 13;
            // 
            // ddlDueAmount
            // 
            this.ddlDueAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlDueAmount.Location = new System.Drawing.Point(196, 102);
            this.ddlDueAmount.Multiline = true;
            this.ddlDueAmount.Name = "ddlDueAmount";
            this.ddlDueAmount.Size = new System.Drawing.Size(286, 41);
            this.ddlDueAmount.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(575, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Amount Paid";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Snow;
            this.btn_Submit.Location = new System.Drawing.Point(414, 322);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(218, 48);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // ddlPaidDate
            // 
            this.ddlPaidDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlPaidDate.Location = new System.Drawing.Point(694, 180);
            this.ddlPaidDate.Name = "ddlPaidDate";
            this.ddlPaidDate.Size = new System.Drawing.Size(286, 23);
            this.ddlPaidDate.TabIndex = 7;
            // 
            // ddlSurcharge
            // 
            this.ddlSurcharge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSurcharge.Location = new System.Drawing.Point(196, 227);
            this.ddlSurcharge.Multiline = true;
            this.ddlSurcharge.Name = "ddlSurcharge";
            this.ddlSurcharge.Size = new System.Drawing.Size(286, 41);
            this.ddlSurcharge.TabIndex = 6;
            // 
            // ddlAmountPaid
            // 
            this.ddlAmountPaid.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlAmountPaid.Location = new System.Drawing.Point(694, 102);
            this.ddlAmountPaid.Multiline = true;
            this.ddlAmountPaid.Name = "ddlAmountPaid";
            this.ddlAmountPaid.Size = new System.Drawing.Size(286, 41);
            this.ddlAmountPaid.TabIndex = 5;
            // 
            // ddlInstallment
            // 
            this.ddlInstallment.DataSource = this.installmentBindingSource;
            this.ddlInstallment.DisplayMember = "title";
            this.ddlInstallment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlInstallment.FormattingEnabled = true;
            this.ddlInstallment.Location = new System.Drawing.Point(196, 49);
            this.ddlInstallment.Name = "ddlInstallment";
            this.ddlInstallment.Size = new System.Drawing.Size(286, 24);
            this.ddlInstallment.TabIndex = 4;
            this.ddlInstallment.ValueMember = "id";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(194, 49);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(286, 34);
            this.txtTitle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(69, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due date";
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Location = new System.Drawing.Point(194, 154);
            this.txtDueAmount.Multiline = true;
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(286, 34);
            this.txtDueAmount.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(194, 107);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(286, 37);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(71, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Due Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(601, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(71, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(69, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surcharge";
            // 
            // surcharge
            // 
            this.surcharge.AutoSize = true;
            this.surcharge.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surcharge.ForeColor = System.Drawing.Color.SeaGreen;
            this.surcharge.Location = new System.Drawing.Point(71, 268);
            this.surcharge.Name = "surcharge";
            this.surcharge.Size = new System.Drawing.Size(75, 16);
            this.surcharge.TabIndex = 21;
            this.surcharge.Text = "Surcharge";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.surcharge);
            this.tabPage2.Controls.Add(this.txtSurcharge);
            this.tabPage2.Controls.Add(this.PaidOnDate);
            this.tabPage2.Controls.Add(this.txtAmount);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.otherPayment);
            this.tabPage2.Controls.Add(this.dueDate);
            this.tabPage2.Controls.Add(this.txtDueAmount);
            this.tabPage2.Controls.Add(this.txtTitle);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.SeaGreen;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Payment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(194, 255);
            this.txtSurcharge.Multiline = true;
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(286, 34);
            this.txtSurcharge.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(71, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(69, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Due Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(69, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Installment";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ddlDueDate);
            this.tabPage1.Controls.Add(this.ddlDueAmount);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btn_Submit);
            this.tabPage1.Controls.Add(this.ddlPaidDate);
            this.tabPage1.Controls.Add(this.ddlSurcharge);
            this.tabPage1.Controls.Add(this.ddlAmountPaid);
            this.tabPage1.Controls.Add(this.ddlInstallment);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.SeaGreen;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Installment";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox7);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 106);
            this.panel4.TabIndex = 40;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(23, 35);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(71, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Allottees Payment";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 104);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 738);
            this.tabControl1.TabIndex = 41;
            // 
            // allotteesPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "allotteesPayment";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Paymemt_load);
            ((System.ComponentModel.ISupportInitialize)(this.installmentBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PaidOnDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button otherPayment;
        private System.Windows.Forms.DateTimePicker dueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker ddlDueDate;
        private System.Windows.Forms.TextBox ddlDueAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DateTimePicker ddlPaidDate;
        private System.Windows.Forms.TextBox ddlSurcharge;
        private System.Windows.Forms.TextBox ddlAmountPaid;
        private System.Windows.Forms.ComboBox ddlInstallment;
        private System.Windows.Forms.BindingSource installmentBindingSource;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label surcharge;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}