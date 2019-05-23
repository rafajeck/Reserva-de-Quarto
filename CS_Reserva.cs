using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.Class
{
    class CS_Reserva : CS_Cliente
    {
        Database db;

        private int ID;
        private DateTime DATA_ENT;
        private DateTime DATA_SAI;
        private double VALOR_TOTAL;
        private string NOME;
        public CS_Reserva (int id, DateTime data_ent, DateTime data_sai, double valor_total)
        {
            ID = id;
            DATA_ENT = data_ent;
            DATA_SAI = data_sai;
            VALOR_TOTAL = valor_total;
        }

        public CS_Reserva()
        { }

        public void Incluir()
        {
            try
            {
                db = new Database();
                db.Conectar();
                db.ExecutarComandoSQL("INSERT INTO reserva values (null, '" + this.DATA_ENT.ToString("yyyy-MM-dd") + "','" + this.DATA_SAI.ToString("yyyy-MM-dd") + "','" + VALOR_TOTAL.ToString(CultureInfo.InvariantCulture) + "')", true);


            }
            catch (Exception e)
            {
                throw new Exception("Erro ao incluir!" + e.Message);
            }
            finally
            {
                db = null;
            }

        }

        public DataTable Listar(string NOME,DateTime DATA_ENT, DateTime DATA_SAI, double VALOR_TOTAL)
        {
            /*SELECT cliente.NOME,reserva.DATA_ENT, reserva.DATE_SAI, reserva.VALOR_TOTAL
FROM reserva
INNER JOIN cliente
ON reserva.ID = cliente.ID;*/
            try
            {
                db = new Database();
                db.Conectar();
                return db.RetDataTable("SELECT cliente.NOME, reserva.DATA_ENT, reserva.DATE_SAI, reserva.VALOR_TOTAL FROM reserva INNER JOIN ON reserva.ID = cliente.ID WHERE " + NOME + " = " + DATA_ENT + " = " + DATA_SAI + " = " + VALOR_TOTAL);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Listar - " + ex.Message);
            }
            finally
            {
                db = null;
            }
        }

    }
}
