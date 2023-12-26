namespace FIT.WinForms
{
    partial class frmMarketing
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
            txtPoruka = new TextBox();
            cbBHTelecom = new CheckBox();
            button1 = new Button();
            cbHTEronet = new CheckBox();
            cbMTel = new CheckBox();
            SuspendLayout();
            // 
            // txtPoruka
            // 
            txtPoruka.Location = new Point(12, 12);
            txtPoruka.Multiline = true;
            txtPoruka.Name = "txtPoruka";
            txtPoruka.Size = new Size(418, 178);
            txtPoruka.TabIndex = 0;
            // 
            // cbBHTelecom
            // 
            cbBHTelecom.AutoSize = true;
            cbBHTelecom.Location = new Point(12, 196);
            cbBHTelecom.Name = "cbBHTelecom";
            cbBHTelecom.Size = new Size(89, 19);
            cbBHTelecom.TabIndex = 1;
            cbBHTelecom.Text = "BH Telecom";
            cbBHTelecom.UseVisualStyleBackColor = true;
            cbBHTelecom.CheckedChanged += cbBHTelecom_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(355, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Posalji";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbHTEronet
            // 
            cbHTEronet.AutoSize = true;
            cbHTEronet.Location = new Point(114, 196);
            cbHTEronet.Name = "cbHTEronet";
            cbHTEronet.Size = new Size(78, 19);
            cbHTEronet.TabIndex = 3;
            cbHTEronet.Text = "HT Eronet";
            cbHTEronet.UseVisualStyleBackColor = true;
            cbHTEronet.CheckedChanged += cbHTEronet_CheckedChanged;
            // 
            // cbMTel
            // 
            cbMTel.AutoSize = true;
            cbMTel.Location = new Point(219, 196);
            cbMTel.Name = "cbMTel";
            cbMTel.Size = new Size(51, 19);
            cbMTel.TabIndex = 4;
            cbMTel.Text = "mTel";
            cbMTel.UseVisualStyleBackColor = true;
            cbMTel.CheckedChanged += cbMTel_CheckedChanged;
            // 
            // frmMarketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 229);
            Controls.Add(cbMTel);
            Controls.Add(cbHTEronet);
            Controls.Add(button1);
            Controls.Add(cbBHTelecom);
            Controls.Add(txtPoruka);
            Name = "frmMarketing";
            Text = "frmMarketing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPoruka;
        private CheckBox cbBHTelecom;
        private Button button1;
        private CheckBox cbHTEronet;
        private CheckBox cbMTel;
    }
}