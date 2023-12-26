using FIT.Infrastructure;
using FIT.Data;
using FIT.WinForms.Helpers;

namespace FIT.WinForms
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {


            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidanUnos())
            {
                foreach (var korisnik in InMemoryDb.Korisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    {
                        if (korisnik.Aktivan)
                            //MessageBox.Show($"{Resursi.Get(Kljucevi.Welcome)} {korisnik}");
                            MessageBox.Show($"" +
                             $"{Resursi.Get(Kljucevi.Welcome)} {korisnik}",
                             Resursi.Get(Kljucevi.Info),
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Information);
                        else
                            // MessageBox.Show($"{korisnik}, vas korisnicki nalog nije aktivan!");
                            MessageBox.Show($"{korisnik}, {Resursi.Get(Kljucevi.AccountNotActive)}  ");
                        return;
                    }
                }
                //MessageBox.Show($"Korisnicko ime ili lozinka nisu validni!");
                MessageBox.Show($"" + $"{Resursi.Get(Kljucevi.UsernameOrPasswordNotValid)}",
                                Resursi.Get(Kljucevi.Warning), MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, Kljucevi.ReqiredValue) &&
              Validator.ProvjeriUnos(txtLozinka, err, Kljucevi.ReqiredValue);
        }

        private void lblRegistracija_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registracija = new frmRegistracija();
            registracija.ShowDialog();
        }
    }
}
