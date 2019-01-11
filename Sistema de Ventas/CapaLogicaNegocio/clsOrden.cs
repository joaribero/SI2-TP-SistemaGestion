using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class clsOrden
    {
        clsManejador M = new clsManejador();

        public int IdORden { get; set; }
        public int IdResponsable { get; set; }
        public int IdCliente { get; set; }
        public String Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaFin { get; set; }
        public int Premio { get; set; }
        public int Estado { get; set; }
        public String Titulo { get; set; }

        public DataTable Listar()
        {
            return M.Listado("ListarEstado", null);
        }

        public String NuevaOrden()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Resp", IdResponsable));
                lst.Add(new clsParametro("@Cliente", IdCliente));
                lst.Add(new clsParametro("@Detalle", Detalle));
                lst.Add(new clsParametro("@Fecha", Fecha));
                lst.Add(new clsParametro("@FechaFin", FechaFin));
                lst.Add(new clsParametro("@Valor", Premio));
                lst.Add(new clsParametro("@Estado", Estado));
                lst.Add(new clsParametro("@Titulo", Titulo));   
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("RegistrarOrden", ref lst);
                return Mensaje = lst[8].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ActualizarOrden()
        {
            List<clsParametro> lst = new List<clsParametro>();
            String Mensaje = "";
            try
            {
                lst.Add(new clsParametro("@Id", IdORden));
                lst.Add(new clsParametro("@Resp", IdResponsable));
                lst.Add(new clsParametro("@Cliente", IdCliente));
                lst.Add(new clsParametro("@Detalle", Detalle));
                lst.Add(new clsParametro("@Fecha", Fecha));
                lst.Add(new clsParametro("@FechaFin", FechaFin));
                lst.Add(new clsParametro("@Valor", Premio));
                lst.Add(new clsParametro("@Estado", Estado));
                lst.Add(new clsParametro("@Titulo", Titulo));
                lst.Add(new clsParametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
                M.EjecutarSP("ActualizarOrden", ref lst);
                return Mensaje = lst[8].Valor.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ListadoOrdenes()
        {
            return M.Listado("ListadoOrdenes", null);
        }
    }
}
