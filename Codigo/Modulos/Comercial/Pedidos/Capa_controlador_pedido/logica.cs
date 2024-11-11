using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_modelo_pedido;

namespace Capa_controlador_pedido
{
    public class logica
    {
        sentencia sn;

        public logica()
        {
            sn = new sentencia();
        }


        public DataTable funenviar(string stabla, string scampo1, string scampo2)
        {

            var dt = sn.funobtener(stabla, scampo1, scampo2);

            return dt;
        }

        public DataTable funenviar1(string stabla, string scampo1)
        {

            var dt1 = sn.funobtener1(stabla, scampo1);

            return dt1;
        }

        public DataTable funllenarCliente(string idcliente)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoCliente(idcliente)) //Cambio de referencia para fuuncionamiento de APlicaciones Usuarios
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }

        public DataTable funllenarProducto1(string idcliente, string idProducto)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoProducto1(idcliente, idProducto))
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;

            }
        }

        public DataTable funllenarProducto2(string idProducto)
        {
            try
            {
                using (OdbcDataAdapter cmpsAplicaciones = sn.prollenadoProducto2(idProducto))
                {
                    DataTable tableProducto = new DataTable();
                    cmpsAplicaciones.Fill(tableProducto);
                    return tableProducto;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public bool insertarEncabezado(string Idcotizacion, string IdVendedor, string IdClientes, DateTime FechaVen, string TotalC)
        {
            try
            {
                sn.funInsertarCotizacionE(Idcotizacion, IdVendedor, IdClientes, FechaVen, TotalC);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Encabezado: " + ex.Message);
                return false;
            }
        }
        /*public bool insertarDetalle(int Idpedido, int IdProducto, int Idcotizacion, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                Console.WriteLine($"Llamando a funInsertarCotizacionD: Idpedido={Idpedido}, IdProducto={IdProducto}, Idcotizacion={Idcotizacion}, Cantidad={Cantidad}, Precio={Precio}, Subtotal={Subtotal}");
                sn.funInsertarCotizacionD(Idpedido, IdProducto, Idcotizacion, Cantidad, Precio, Subtotal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Detalle: " + ex.Message);
                return false;
            }
        }*/


        public class DetallePeddido
        {
            public string Idpedido { get; set; }
            public int IdProducto { get; set; }
            public string Idcotizacion { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
            public decimal Subtotal { get; set; }
        }

        public DataTable ObtenerDetalle(string idCotizacion)
        {
            try
            {
                return sn.ObtenerDetalle(idCotizacion);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDetalle: " + ex.Message);
                return new DataTable();
            }
        }


        public bool insertarDetalle(int Idpedido, int IdProducto, int Idcotizacion, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                Console.WriteLine($"Llamando a funInsertarDetalle: Idpedido={Idpedido}, IdProducto={IdProducto}, Idcotizacion={Idcotizacion}, Cantidad={Cantidad}, Precio={Precio}, Subtotal={Subtotal}");
                sn.funInsertarDetalle(Idpedido, IdProducto, Idcotizacion, Cantidad, Precio, Subtotal);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Detalle: " + ex.Message);
                return false;
            }
        }



    }
}
