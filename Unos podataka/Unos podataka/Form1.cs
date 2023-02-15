using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unos_podataka
{
    
    
    public partial class Form1 : Form
    {
        class Vozilo
        {
            string marka, model, vrsta, voziPo;

            public Vozilo(string marka, string model, string vrsta)
            {
                this.marka = marka;
                this.model = model;
                this.vrsta = vrsta;
            }

            public string Marka { get => marka; set => marka = value; }
            public string Model { get => model; set => model = value; }
            public string Vrsta { get => vrsta; set => vrsta = value; }
            public string VoziPo { get => voziPo; set => voziPo = value; }

            public override string ToString()
            {
                return "Marka: " + this.marka + "\r\nModel: " + this.model + "\r\nVrsta: " + this.vrsta + "\r\nVozi po: " + this.voziPo +  "\r\n \r\n";
            }
        }
        List<Vozilo> voziloLista = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo vozila = new Vozilo(txtBoxMarka.Text, txtBoxModel.Text, cmbBoxVrsta.Text);
                voziloLista.Add(vozila);
                txtBoxMarka.Clear();
                txtBoxModel.Clear();
            }
            catch
            {
                MessageBox.Show("Pogrešan unos, Molim pokušajte ponovno.", "Pogrešan unps", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxMarka.Clear() ;
                txtBoxModel.Clear() ;
            }
        }

        private void cmbBoxVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtBoxIspis.Clear();
            foreach(Vozilo v in voziloLista)
            { 
                txtBoxIspis.AppendText(v.ToString());
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach(Vozilo v in voziloLista){
                if(v.Vrsta == "Avion")
                {
                    v.VoziPo = "Zrak";
                }else if(v.Vrsta == "Automobil")
                {
                    v.VoziPo = "Cesti";
                }
                else
                {
                    v.VoziPo = "Voda";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
