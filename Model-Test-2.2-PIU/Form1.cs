using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Test_2._2_PIU
{
    public partial class Form1 : Form
    {
        List<Medicament> Medicamente = new List<Medicament>();
        List<string> Afectiuni = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            Medicament medicament = new Medicament(textBoxDenumire.Text, Convert.ToInt32(textBoxNrUnitati.Text), ListaAfectiuni(), DataExpirarii(), FormaPrezentare());

            Medicamente.Add(medicament);
        }

        private List<string> ListaAfectiuni()
        {
            var afectiuni = new List<string>();
            if(checkBoxDurereInGat.Checked)
            {
                afectiuni.Add(checkBoxDurereInGat.Text);
            }
            if(checkBoxFebra.Checked)
            {
                afectiuni.Add(checkBoxFebra.Text);
            } 
            return afectiuni;
        }

        private DateTime DataExpirarii()
        {
            return dateTimePickerExpirare.Value;
        }

        private string FormaPrezentare()
        {
            string formaPrezentare = "NECUNOSCUT";

            if(radioButtonFiole.Checked)
            {
                formaPrezentare = radioButtonFiole.Text;
            }
            if (radioButtonSirop.Checked)
            {
                formaPrezentare = radioButtonSirop.Text;
            }
            if (radioButtonTablete.Checked)
            {
                formaPrezentare = radioButtonTablete.Text;
            }
            return formaPrezentare;
        }

        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            var listaMedicamente = this.Medicamente;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaMedicamente;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
