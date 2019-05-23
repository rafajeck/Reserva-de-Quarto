using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.Class
{
    public class CS_Cliente
    {
        #region "Atributos"
            Database db;
            private int ID;
            private string NOME;
            private string CPF;
            private string TELEFONE;
            private string ENDERECO;
            private string EMAIL;
          

        #endregion


        #region "Método Construtor"

        public CS_Cliente(int id, string nome, string cpf, string telefone, string endereco, string email)
        {
            ID = id;
            NOME = nome;
            CPF = cpf;
            TELEFONE = telefone;
            ENDERECO = endereco;
            EMAIL = email;
        }
        public CS_Cliente(int id, string nome, string cpf)
        {
            this.ID = id;
            this.NOME = nome;
            this.CPF = cpf;
                       
        }

        public CS_Cliente() { }

        public void Incluir()
        {
            try
            {
                db = new Database();
                db.Conectar();
                db.ExecutarComandoSQL("INSERT INTO cliente VALUES (null, '" + NOME + "', '" + CPF + "', '" + TELEFONE + "', '" + ENDERECO + "', '" + EMAIL + "')", true);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro FATAL - " + ex.Message);
            }
            finally
            {
                db = null;
            }

        }
        #endregion


    }
}
