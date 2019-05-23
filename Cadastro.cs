using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.Class;

namespace WindowsFormsApplication3
{
    public partial class Cadastro : Form
    {
        public object Response { get; private set; }

        public Cadastro()
        {
            InitializeComponent();
        }

        #region "Placeholder para Formulario"
        private void NomeText_Enter(object sender, EventArgs e)
        {
            if (NomeText.Text == "Nome")
            {
                NomeText.Text = "";

                NomeText.ForeColor = Color.Black;
            }
            
        }

        private void NomeText_Leave(object sender, EventArgs e)
        {
            if (NomeText.Text == "")
            {
                NomeText.Text = "Nome";

                NomeText.ForeColor = Color.Silver;
            }
        }

        private void CpfText_Enter(object sender, EventArgs e)
        {
            if (CpfText.Text == "CPF")
            {
                CpfText.Text = "";

                CpfText.ForeColor = Color.Black;
            }
        }

        private void CpfText_Leave(object sender, EventArgs e)
        {
            if (CpfText.Text == "")
            {
                CpfText.Text = "CPF";

                CpfText.ForeColor = Color.Silver;
            }
        }

        private void TelText_Enter(object sender, EventArgs e)
        {
            if (TelText.Text == "Telefone")
            {
                TelText.Text = "";

                TelText.ForeColor = Color.Black;
            }
        }

        private void TelText_Leave(object sender, EventArgs e)
        {
            if (TelText.Text == "")
            {
                TelText.Text = "Telefone";

                TelText.ForeColor = Color.Silver;
            }
        }

        private void EndText_Enter(object sender, EventArgs e)
        {
            if (EndText.Text == "Endereço")
            {
                EndText.Text = "";

                EndText.ForeColor = Color.Black;
            }
        }

        private void EndText_Leave(object sender, EventArgs e)
        {
            if (EndText.Text == "")
            {
                EndText.Text = "Endereço";

                EndText.ForeColor = Color.Silver;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (EmailText.Text == "E-mail")
            {
                EmailText.Text = "";

                EmailText.ForeColor = Color.Black;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (EmailText.Text == "")
            {
                EmailText.Text = "E-mail";

                EmailText.ForeColor = Color.Silver;
            }
        }
         
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (NomeText.Text == "Nome" || CpfText.Text == "CPF" || TelText.Text == "Telefone" || EndText.Text == "Endereço" || EmailText.Text == "E-mail")
                MessageBox.Show("Insira Seus Dados", "EASYROOM");
            else
                {
             
                try
                    {
                        CS_Cliente Cadastro = new CS_Cliente(-1, NomeText.Text, CpfText.Text, TelText.Text, EndText.Text, EmailText.Text);
                        Cadastro.Incluir();
                      
                        MessageBox.Show("Seu Cadastro Foi Efetuado Com  Sucesso!! \nClick em OK para Reserva de Quarto", "EASYROOM");
                    this.Hide();
                    Reserva Quarto = new Reserva();
                    Quarto.ShowDialog();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
          
        }

        private void NomeText_TextChanged(object sender, EventArgs e)
        {
          
        }   

        private void CpfText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }
    }
   

    
}
