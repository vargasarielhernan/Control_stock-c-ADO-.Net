using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;

namespace AccesoDB
{
    public class listaMarca
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select Id, Descripcion from MARCAS");
                accesoDB.runread();
                while (accesoDB.Reader.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)accesoDB.Reader["Id"];
                    aux.Descripcion = (string)accesoDB.Reader["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDB.closeconnection();
            }
        }
    }
}
