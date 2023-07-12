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
    }
}