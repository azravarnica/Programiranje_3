namespace FIT.WinForms.Studenti
{
    partial class frmStudentiNovi
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
            btnSpasi = new Button();
            groupBox2 = new GroupBox();
            btnNovaLozinka = new Button();
            label7 = new Label();
            cmbSemestri = new ComboBox();
            dtpDatumRodjenja = new DateTimePicker();
            cbAktivan = new CheckBox();
            txtLozinka = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtIndeks = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtIme = new TextBox();
            label3 = new Label();
            txtPrezime = new TextBox();
            label5 = new Label();
            pbSlika = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnOdabirSlike = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(381, 220);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(75, 23);
            btnSpasi.TabIndex = 2;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNovaLozinka);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbSemestri);
            groupBox2.Controls.Add(dtpDatumRodjenja);
            groupBox2.Controls.Add(cbAktivan);
            groupBox2.Controls.Add(txtLozinka);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtIndeks);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtIme);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtPrezime);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(144, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(312, 188);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnNovaLozinka
            // 
            btnNovaLozinka.BackgroundImage = Properties.Resources._5619264;
            btnNovaLozinka.BackgroundImageLayout = ImageLayout.Stretch;
            btnNovaLozinka.Location = new Point(258, 97);
            btnNovaLozinka.Name = "btnNovaLozinka";
            btnNovaLozinka.Size = new Size(43, 33);
            btnNovaLozinka.TabIndex = 17;
            btnNovaLozinka.UseVisualStyleBackColor = true;
            btnNovaLozinka.Click += btnNovaLozinka_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(160, 45);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 16;
            label7.Text = "Semestar:";
            // 
            // cmbSemestri
            // 
            cmbSemestri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemestri.FormattingEnabled = true;
            cmbSemestri.Location = new Point(158, 63);
            cmbSemestri.Name = "cmbSemestri";
            cmbSemestri.Size = new Size(143, 23);
            cmbSemestri.TabIndex = 3;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(12, 153);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(200, 23);
            dtpDatumRodjenja.TabIndex = 6;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Checked = true;
            cbAktivan.CheckState = CheckState.Checked;
            cbAktivan.Location = new Point(227, 158);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 7;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 9F);
            txtLozinka.Location = new Point(119, 107);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(133, 23);
            txtLozinka.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 10;
            label1.Text = "Broj indeksa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 89);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Lozinka:";
            // 
            // txtIndeks
            // 
            txtIndeks.Enabled = false;
            txtIndeks.Font = new Font("Segoe UI", 9F);
            txtIndeks.Location = new Point(12, 107);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(101, 23);
            txtIndeks.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 45);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(12, 63);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(135, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 1);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Font = new Font("Segoe UI", 9F);
            txtIme.Location = new Point(12, 19);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(135, 23);
            txtIme.TabIndex = 0;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Datum rodjenja:";
            // 
            // txtPrezime
            // 
            txtPrezime.Font = new Font("Segoe UI", 9F);
            txtPrezime.Location = new Point(158, 19);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(143, 23);
            txtPrezime.TabIndex = 1;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 1);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Ime:";
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 45);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(117, 129);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 13;
            pbSlika.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOdabirSlike
            // 
            btnOdabirSlike.Location = new Point(12, 191);
            btnOdabirSlike.Name = "btnOdabirSlike";
            btnOdabirSlike.Size = new Size(117, 23);
            btnOdabirSlike.TabIndex = 0;
            btnOdabirSlike.Text = "Odaberi sliku:";
            btnOdabirSlike.UseVisualStyleBackColor = true;
            btnOdabirSlike.Click += btnOdabirSlike_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmStudentiNovi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 248);
            Controls.Add(btnOdabirSlike);
            Controls.Add(pbSlika);
            Controls.Add(btnSpasi);
            Controls.Add(groupBox2);
            Name = "frmStudentiNovi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            Load += frmStudentiNovi_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSpasi;
        private GroupBox groupBox2;
        private TextBox txtIndeks;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtIme;
        private Label label5;
        private CheckBox cbAktivan;
        private TextBox txtLozinka;
        private Label label2;
        private TextBox txtPrezime;
        private Label label3;
        private PictureBox pbSlika;
        private Label label1;
        private DateTimePicker dtpDatumRodjenja;
        private Label label7;
        private ComboBox cmbSemestri;
        private OpenFileDialog openFileDialog1;
        private Button btnOdabirSlike;
        private Button btnNovaLozinka;
        private ErrorProvider errorProvider1;
    }
}