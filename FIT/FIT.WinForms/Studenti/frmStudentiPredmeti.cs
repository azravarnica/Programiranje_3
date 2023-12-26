using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FIT.WinForms.Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student? student;

        public frmStudentiPredmeti(Student odabraniStudent)
        {
            InitializeComponent();
            this.student = odabraniStudent;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredmete();
            UcitajLicnePodatke();
        }

        private void UcitajLicnePodatke()
        {
            lblImePrezimeIndeks.Text = $"{student.Indeks},  {student.Ime}  {student.Prezime}";
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.LoadData(InMemoryDb.Predmeti);
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;

                var postojiPredmet = student.PolozeniPredmeti.Where(polozeni =>
                                             polozeni.PredmetId == predmet.Id).Count() > 0;
                if (postojiPredmet)
                {
                    MessageBox.Show($"Navedeni kurs vec postoji");
                    return;
                }

                /* foreach(var p in student.PolozeniPredmeti)
                 {
                     if(p.Id == predmet.Id)
                     {
                         MessageBox.Show($"Navedeni kurs vec postoji");
                         return;
                     }
                 } */
                var polozeni = new PolozeniPredmet()
                {
                    Id = student.PolozeniPredmeti.Count + 1,
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = predmet,
                    PredmetId = predmet.Id,

                };
                student.PolozeniPredmeti.Add(polozeni);
                UcitajPolozenePredmete();
            }
        }
        private bool ValidanUnos()
        {
            return
            Validator.ProvjeriUnos(cmbPredmeti, errorProvider1, Kljucevi.ReqiredValue) &&
            Validator.ProvjeriUnos(cmbOcjene, errorProvider1, Kljucevi.ReqiredValue);

        }
    }
}
