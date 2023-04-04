using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sesija;
using Domen;

namespace Forme
{
    public partial class RadSaUcenikom : Form
    {
        public RadSaUcenikom()
        {
            InitializeComponent();
        }

        private void btnunos_Click(object sender, EventArgs e)
        {
            int jmbg =int.Parse( txtjmbg.Text);
            string ime = txtime.Text;
            string prezime=txtprezime.Text;

           Ucenik u=new Ucenik 
            {
                Jmbg = jmbg,
                Ime=ime,
                Prezime = prezime,
                Mesto = cmbmesto.SelectedItem as Mesto,
                Odeljenje =cmbodeljenje.SelectedItem as Odeljenje
            };
            try
            {
                int rezultat = Broker.DajSesiju().UbaciUcenika_uBazu(u);
                if (rezultat > 0)
                {
                    MessageBox.Show("Uspesno ste dodali ucenika!!!");
                }
                else
                {
                    MessageBox.Show("Niste uspesno dodali ucenika!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vec postoji taj ucenik u bazi!!!" + ex.Message);
            }
            dgvucenik.DataSource = Broker.DajSesiju().VratiSveUcenike();

        }

        private void RadSaUcenikom_Load(object sender, EventArgs e)
        {
            dgvucenik.DataSource = Broker.DajSesiju().VratiSveUcenike();
            cmbmesto.DataSource = Broker.DajSesiju().VratiSvaMesta();

        }

        
    }
}
