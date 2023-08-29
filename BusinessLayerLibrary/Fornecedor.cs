using System.Data;
using System.Data.SqlClient;

namespace BusinessLayerLibrary
{
    public class Fornecedor : Pessoa, IUsuario
    {
       
        public bool Logar()
        {
            Connection cn = new Connection();
            SqlConnection conn = cn.getConnection();
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Fornecedores where login='" + Login + "' and Senha='" + Senha + "'";
            cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();

            bool retorno = false;

            if (dr.Read())
            {
                retorno = true;
            }

            dr.Close();
            dr.Dispose();

            conn.Close();
            conn.Dispose();

            return retorno;
          
        }
        public bool ResetPassword()
        {
            return true;
        }


        public DataSet Listar()
        {
            Connection cn = new Connection();
            SqlConnection conn = cn.getConnection();
            conn.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("Select idfornecedor as id, login as usuario, senha as pwd from Fornecedores", conn);

            adpt.Fill(ds);
           
            conn.Close();
            conn.Dispose();

            return ds;

        }
        
    }
}