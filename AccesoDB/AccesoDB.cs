using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDB
{
    public class AccesoDB
    {
        private SqlConnection connection;
        private SqlCommand conexionCommand;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public AccesoDB()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS;database=CATALOGO_DB;integrated security=true");
            conexionCommand = new SqlCommand();
        }
        public void setquery(string query)
        {
            conexionCommand.CommandType = System.Data.CommandType.Text;
            conexionCommand.CommandText = query;
        }
        public void runread()
        {
            conexionCommand.Connection = connection;
            try
            {
                connection.Open();
                reader = conexionCommand.ExecuteReader();
            }
            catch (Exception ex)
            {   

                throw ex;
            }
        }
        public void exeaction()
        {
            conexionCommand.Connection = connection;
            try
            {
                connection.Open();
                conexionCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setparametro(string nombre, object valor)
        {
            conexionCommand.Parameters.AddWithValue(nombre, valor);
        }
        public void closeconnection()
        {
            if(reader != null)
                reader.Close();
            connection.Close();           
        }
    }
}
