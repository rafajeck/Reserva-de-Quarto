using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Class;

namespace WindowsFormsApplication3
{
    public partial class Recibo : Form
    {

        public Recibo (string TipoQuartoSelecionado, DateTime DATA_ENT, DateTime DATA_SAI, double VALOR_TOTAL)
        {

            InitializeComponent();
            
            this.txt_tipoQuarto.Text = TipoQuartoSelecionado.ToString();    
            this.txt_CheckIn.Text = DATA_ENT.ToString();
            this.txt_CheckOut.Text = DATA_SAI.ToString();
            this.txt_Valor.Text = VALOR_TOTAL.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
            Application.Exit();

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Recibo_Load(object sender, EventArgs e)
        {

        }

        private void txt_CheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
    }
}
