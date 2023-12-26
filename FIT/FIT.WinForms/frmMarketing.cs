using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmMarketing : Form
    {
        delegate void marketing(string poruka);
        event marketing SMSMarketing;

        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BH Telecom -> {poruka}");
        }
        void HTEronet(string poruka)
        {
            MessageBox.Show($"HT Eronet -> {poruka}");
        }
        void mTel(string poruka)
        {
            MessageBox.Show($"mTel -> {poruka}");
        }
        public frmMarketing()
        {
            InitializeComponent();
        }

        private void frmMarketing_Load(object sender, EventArgs e)
        {

        }
        void PretplatiMetodu(object sender, marketing metoda)
        {
            if ((sender as CheckBox).Checked)
                SMSMarketing += metoda;
            else
                SMSMarketing -= metoda;
        }

        private void cbBHTelecom_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, BHTelecom);
        }

        private void cbHTEronet_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, HTEronet);
        }

        private void cbMTel_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, mTel);
        }
        int Test(int a) { return 0; }
        private void button1_Click(object sender, EventArgs e)
        {
            //fun je pokaziac na funkciju koja prima int i vraca int kao rezultat
            Func<int, int> fun = Test;
            Func<int, bool> filter = x => x >= 8;

            int[] niz = new int[] { 6, 8, 9, 6, 8 };
            niz.Where(filter); //8, 9, 8
            //provjeri da lijeva strana nije null
            //SMSMarketing?.Invoke(txtPoruka.Text);
        }
    }
}
