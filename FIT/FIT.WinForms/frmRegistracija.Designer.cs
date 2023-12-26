namespace FIT.WinForms
{
    partial class frmRegistracija
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbAktivan = new CheckBox();
            txtLozinka = new TextBox();
            label2 = new Label();
            txtKorisnickoIme = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtPrezime = new TextBox();
            label4 = new Label();
            txtIme = new TextBox();
            label5 = new Label();
            btnSpasi = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_fit;
            pictureBox1.Location = new Point(12, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(179, 23);
            label1.Name = "label1";
            label1.Size = new Size(357, 84);
            label1.TabIndex = 6;
            label1.Text = "Univerzitet \"Dzemal Bijedic\" Mostar\r\nFakultet informacijskih tehnologija\r\nwww.fit.ba";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAktivan);
            groupBox1.Controls.Add(txtLozinka);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtKorisnickoIme);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(303, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(270, 190);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Korisnicki podaci:";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(36, 154);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 8;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 12F);
            txtLozinka.Location = new Point(36, 102);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(219, 29);
            txtLozinka.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 84);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 12F);
            txtKorisnickoIme.Location = new Point(36, 52);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(219, 29);
            txtKorisnickoIme.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 31);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Korisnicko ime:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(270, 190);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Licni podaci:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(36, 154);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 29);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 136);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Segoe UI", 12F);
            txtPrezime.Location = new Point(36, 104);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(219, 29);
            txtPrezime.TabIndex = 7;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 84);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Segoe UI", 12F);
            txtIme.Location = new Point(36, 52);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(219, 29);
            txtIme.TabIndex = 5;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 31);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Ime:";
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(498, 343);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 9;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistracija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 376);
            Controls.Add(btnSpasi);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmRegistracija";
            Text = "frmRegistracija";
            Load += frmRegistracija_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtLozinka;
        private Label label2;
        private TextBox txtKorisnickoIme;
        private Label label3;
        private CheckBox cbAktivan;
        private GroupBox groupBox2;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtPrezime;
        private Label label4;
        private TextBox txtIme;
        private Label label5;
        private Button btnSpasi;
        private ErrorProvider errorProvider1;
    }
}