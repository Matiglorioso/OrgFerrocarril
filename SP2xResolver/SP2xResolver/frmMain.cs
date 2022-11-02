using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP2xResolver
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int Dia;
            btnCalcular.Enabled = false;    
            txtDistancia.Text = "";
            txtDistanciaTotal.Text = "";
            txtImporte.Text = "";
            cmbDias.Items.Clear();
            for(Dia = 1; Dia <= 30; Dia++) // se carga con los días 1 a 30
            {
                cmbDias.Items.Add(Dia);
            }
            cmbDias.SelectedIndex = 0;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float Importe = 0;
            int Distancia = 0;
            int Dias;

            Dias = int.Parse(cmbDias.Text);
            Distancia = int.Parse ( txtDistancia.Text );
            Distancia = Distancia * 2;
            txtDistanciaTotal.Text = Distancia.ToString();
            Importe = Distancia * 5;
            if(Dias >= 7 && Distancia >= 100)
            {
                Importe = Importe * 0.5f; // se agrega la letra "f" para indicar que el valor se tome de tipo float
            }
            txtImporte.Text = Importe.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            if(txtDistancia.Text != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }
        }
    }
}
