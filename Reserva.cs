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
    public partial class Reserva : Form
    {
        
        public Reserva()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double valorTotal = double.Parse(numericUpDown1.Value.ToString()) * 150.0;
            label3.Text = valorTotal.ToString("C2");
        }

       

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double valorTotal = double.Parse(numericUpDown2.Value.ToString()) * 80.0;
            label6.Text = valorTotal.ToString("C2");
            //dateTimePicker2.Value = dateTimePicker1.Value + 
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double valorTotal = double.Parse(numericUpDown3.Value.ToString()) * 300.0;
            label7.Text = valorTotal.ToString("C2");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            #region "Método Soma Total Dos Quartos"
            double VALOR_TOTAL = 0;
            double QUARTO_SOLTEIRO = 80;
            double QUARTO_CASAL = 150;
            double QUARTO_COMPARTILHADO = 300;
            
            if (checkBox1.Checked == true)
            {
                VALOR_TOTAL = VALOR_TOTAL + QUARTO_SOLTEIRO * Convert.ToInt32(numericUpDown2.Text);                    
            }
            if (checkBox2.Checked == true)
            {
                VALOR_TOTAL = VALOR_TOTAL + QUARTO_CASAL * Convert.ToInt32(numericUpDown1.Text);
            }
            if (checkBox3.Checked == true)
            {
                VALOR_TOTAL = VALOR_TOTAL + QUARTO_COMPARTILHADO * Convert.ToInt32(numericUpDown3.Text);
            }

            #endregion
            string TipoQuartoSelecionado = "";
            if (checkBox1.Checked)
            {
                TipoQuartoSelecionado = "Solteiro";
            }
            else if (checkBox2.Checked)
            {
                TipoQuartoSelecionado = "Casal";
            }
            else if (checkBox3.Checked)
            {
                TipoQuartoSelecionado = "Compartilhado";
            }
            if (checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
                MessageBox.Show("Por Favor Selecione um Quarto","EASYROOM");
            else
            {
                try
                {   
                    
                    CS_Reserva Quarto = new CS_Reserva(-1, dateTimePicker1.Value, dateTimePicker2.Value,VALOR_TOTAL);
                    
                    Quarto.Incluir();
                    
                    MessageBox.Show("Sua Reserva Foi Efetuada Com Sucesso Obrigado!! \nClick Em OK para Verificar os Dados de sua Reserva", "EASYROOM");
                    this.Hide();

                    Recibo Cliente = new Recibo(TipoQuartoSelecionado,dateTimePicker1.Value, dateTimePicker2.Value, VALOR_TOTAL);
                    Cliente.ShowDialog();    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

       
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            //dateTimePicker2.Value = dateTimePicker1.Value + Convert.ToInt32(numericUpDown2.Text) + 
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }
    }
}
