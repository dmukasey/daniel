using System.Data.SqlClient;
using System.Configuration;


namespace BusinessLayerLibrary
{
    public class Connection
    {
        public SqlConnection getConnection()
        {
            string cnstring = ConfigurationManager.ConnectionStrings["cnstring"].ConnectionString;
            return new SqlConnection(cnstring);
        }        

    }
}