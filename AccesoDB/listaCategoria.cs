using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;

namespace AccesoDB
{
    public class listaCategoria
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDB AccesoDB = new AccesoDB();
            try
            {
                AccesoDB.setquery("select Id, Descripcion from CATEGORIAS");
                AccesoDB.runread();
                while (AccesoDB.Reader.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)AccesoDB.Reader["Id"];
                    aux.Descripcion = (string)AccesoDB.Reader["Descripcion"];
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
                AccesoDB.closeconnection();
                    
            }
        }
    }
}
