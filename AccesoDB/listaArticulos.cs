using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elementos;

namespace AccesoDB
{
    public class listaArticulos
    {
       public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                accesoDB.setquery("select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, M.Id as IdMarca, C.Id as IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca= M.Id and A.IdCategoria=C.ID");
                accesoDB.runread();
                while (accesoDB.Reader.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)accesoDB.Reader["Id"];
                    aux.Codigo = (string)accesoDB.Reader["Codigo"];
                    aux.Nombre = (string)accesoDB.Reader["Nombre"];
                    aux.Descripcion = (string)accesoDB.Reader["Descripcion"];
                    if (!(accesoDB.Reader["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)accesoDB.Reader["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)accesoDB.Reader["Marca"];
                    aux.Marca.Id = (int)accesoDB.Reader["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)accesoDB.Reader["Categoria"];
                    aux.Categoria.Id = (int)accesoDB.Reader["IdCategoria"];
                    aux.Precio = (decimal)accesoDB.Reader["Precio"];

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
        public void agregar(Articulos articulos)
        {
            AccesoDB acce = new AccesoDB();

            try
            {
                acce.setquery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)");
                acce.setparametro("@Codigo", articulos.Codigo);
                acce.setparametro("@Nombre", articulos.Nombre);
                acce.setparametro("@Descripcion", articulos.Descripcion);
                acce.setparametro("@IdMarca", articulos.Marca.Id);
                acce.setparametro("@IdCategoria", articulos.Categoria.Id);
                acce.setparametro("@ImagenUrl", articulos.ImagenUrl);
                acce.setparametro("@Precio", articulos.Precio);
                acce.exeaction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acce.closeconnection();
            }
        }
        public void modificar(Articulos articulos)
        {
            AccesoDB acce = new AccesoDB();

            try
            {
                acce.setquery("update ARTICULOS set Codigo=@Codigo,Nombre=@Nombre,Descripcion=@Descripcion,IdMarca=@IdMarca,IdCategoria=@IdCategoria,ImagenUrl=@ImagenUrl,Precio=@Precio where Id=@Id");
                acce.setparametro("@Codigo", articulos.Codigo);
                acce.setparametro("@Nombre", articulos.Nombre);
                acce.setparametro("@Descripcion", articulos.Descripcion);
                acce.setparametro("@IdMarca", articulos.Marca.Id);
                acce.setparametro("@IdCategoria", articulos.Categoria.Id);
                acce.setparametro("@ImagenUrl", articulos.ImagenUrl);
                acce.setparametro("@Precio", articulos.Precio);
                acce.setparametro("@Id", articulos.Id);
                acce.exeaction();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                acce.closeconnection();
            }
        }
        public void eliminar(int Id)
        {
            
            try
            {
                AccesoDB accesoDB = new AccesoDB();
                accesoDB.setquery("DELETE from ARTICULOS where Id=@Id");
                accesoDB.setparametro("@Id", Id);
                accesoDB.exeaction();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Articulos> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDB accesoDB = new AccesoDB();
            try
            {
                string consulta = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, M.Id as IdMarca, C.Id as IdCategoria, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca= M.Id and A.IdCategoria=C.ID and ";
                switch (campo)
                {
                    case "Codigo":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Codigo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Codigo like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Descripcion":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += "A.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "A.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += "A.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;
                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;
                                break;
                            case "Termina con":
                                consulta += "Precio < " + filtro;
                                break;
                            default:
                                consulta += "Precio = " + filtro;
                                break;
                        }
                        break;

                    default:
                        break;
                }
                accesoDB.setquery(consulta);
                accesoDB.runread();
                while (accesoDB.Reader.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)accesoDB.Reader["Id"];
                    aux.Codigo = (string)accesoDB.Reader["Codigo"];
                    aux.Nombre = (string)accesoDB.Reader["Nombre"];
                    aux.Descripcion = (string)accesoDB.Reader["Descripcion"];
                    if (!(accesoDB.Reader["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)accesoDB.Reader["ImagenUrl"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)accesoDB.Reader["Marca"];
                    aux.Marca.Id = (int)accesoDB.Reader["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)accesoDB.Reader["Categoria"];
                    aux.Categoria.Id = (int)accesoDB.Reader["IdCategoria"];
                    aux.Precio = (decimal)accesoDB.Reader["Precio"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
