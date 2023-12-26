using FIT.Data;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente()
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = InMemoryDb.Studenti;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            frmStudentiNovi frmStudentiNovi = new frmStudentiNovi();
            if (frmStudentiNovi.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Text = $"red -> {e.RowIndex} kolona -> {e.ColumnIndex}";
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form forma = null;
           
          /*  if (dgvStudenti.CurrentCell is DataGridViewButtonCell)
            {
                frmStudentiPredmeti frmStudentiPredmeti = new frmStudentiPredmeti(odabraniStudent);
                frmStudentiPredmeti.ShowDialog();
            }
            else
            {
                frmStudentiNovi frmEditovanjeStudenta = new frmStudentiNovi(odabraniStudent);
                frmEditovanjeStudenta.ShowDialog();
                UcitajStudente();
            }*/

          if(dgvStudenti.CurrentCell is DataGridViewButtonCell)
                forma = new frmStudentiPredmeti(odabraniStudent);
          else 
                forma = new frmStudentiNovi(odabraniStudent);

          forma.ShowDialog();

        }
    }
}
