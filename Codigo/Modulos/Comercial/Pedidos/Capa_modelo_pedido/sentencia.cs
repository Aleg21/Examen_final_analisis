using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_modelo_pedido
{
    public class sentencia
    {
        conexion cn = new conexion();

        public sentencia()
        {
            
        }

        public DataTable funobtener(string stabla, string scampo1, string scampo2)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo1 + "," + scampo2 + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);


            return dt;
        }

        public DataTable funobtener1(string stabla, string scampo)
        {
            conexion cn = new conexion();
            string ssql = "SELECT DISTINCT " + scampo + " FROM " + stabla;

            OdbcCommand command = new OdbcCommand(ssql, cn.conectar());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt1 = new DataTable();
            adaptador.Fill(dt1);

            return dt1;
        }

        public OdbcDataAdapter prollenadoCliente(string idcliente)
        {
            cn.conectar();
            string ssqlPrecioProducto = "SELECT Cliente_Tipo FROM Tbl_clientes WHERE Pk_id_cliente = " + idcliente;
            //funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }

        public OdbcDataAdapter prollenadoProducto1(string idcliente, string idProducto)
        {
            string ssqlPrecioProducto = "SELECT p.Pk_id_Producto, p.nombreProducto, COALESCE(ld.ListDetalle_preVenta, p.precioUnitario) AS precio " +
                            "FROM Tbl_Productos p " +
                            "LEFT JOIN Tbl_lista_detalle ld ON p.Pk_id_Producto = ld.Fk_id_Producto " +
                            "LEFT JOIN Tbl_clientes c ON c.FK_id_lista_Encabezado = ld.Fk_id_lista_Encabezado " +
                            "WHERE c.Pk_id_cliente = " + idcliente + " " +
                            "AND p.Pk_id_Producto = " + idProducto;

            // funInsertarBitacora(idUsuario, "Realizó una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }

        public OdbcDataAdapter prollenadoProducto2(string idProducto)
        {

            string ssqlPrecioProducto = "SELECT precioUnitario FROM Tbl_Productos WHERE Pk_id_Producto = " + idProducto;
            //funInsertarBitacora(idUsuario, "Realizo una consulta a aplicaciones", "tbl_aplicaciones", "1000");
            OdbcDataAdapter dataTable = new OdbcDataAdapter(ssqlPrecioProducto, cn.conectar());
            return dataTable;
        }
        //****************************************************************************************************************************************
        public void funInsertarCotizacionE(string Idcotizacion, string IdVendedor, string IdClientes, DateTime FechaVen, string TotalC)
        {
            try
            {
                string query = "INSERT INTO Tbl_pedido_encabezado (Pk_id_pedidoEnc, Fk_id_vendedor, Fk_id_cliente, PedidoEncfecha, PedidoEnc_total) VALUES (?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Pk_id_pedidoEnc", Idcotizacion);
                    command.Parameters.AddWithValue("@Fk_id_vendedor", IdVendedor);
                    command.Parameters.AddWithValue("@Fk_id_cliente", IdClientes);
                    command.Parameters.AddWithValue("@PedidoEncfecha", FechaVen);
                    command.Parameters.AddWithValue("@PedidoEnc_total", TotalC);
                    command.ExecuteNonQuery();
                }
                // Crear instancia de la clase Sentencia en Capa_modelo_seguridad
                /* var bitacora = new Capa_Modelo_Seguridad.sentencia();

                 // Llama a la función de bitácora
                 bitacora.funInsertarBitacora(sIdUsuario, "Realizó una insercion a la tabla de Comisiones encabezado", "Tbl_comisiones_encabezado", "3000");
             */
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla encabezado: " + ex.Message);
            }
        }

        /*public void funInsertarCotizacionD(int Idpedido, int IdProducto, int Idcotizacion, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                string query = "INSERT INTO Tbl_pedido_detalle (Fk_id_pedidoEnc, Fk_id_producto, Fk_id_cotizacionEnc, PedidoDet_cantidad, PedidoDet_precio, PedidoDet_subtotal) VALUES (?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_pedidoEnc", Idpedido);
                    command.Parameters.AddWithValue("@Fk_id_producto", IdProducto);
                    command.Parameters.AddWithValue("@Fk_id_cotizacionEnc", Idcotizacion);
                    command.Parameters.AddWithValue("@PedidoDet_cantidad", Cantidad);
                    command.Parameters.AddWithValue("@PedidoDet_precio", Precio);
                    command.Parameters.AddWithValue("@PedidoDet_subtotal", Subtotal);
                    command.ExecuteNonQuery();
                }

                Console.WriteLine($"Inserción exitosa: Idpedido={Idpedido}, IdProducto={IdProducto}, Idcotizacion={Idcotizacion}, Cantidad={Cantidad}, Precio={Precio}, Subtotal={Subtotal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en la tabla detalle comisiones: " + ex.Message);
            }
        }*/



        public DataTable ObtenerDetalle(string idCotizacion)
        {
            DataTable detalle = new DataTable();
            try
            {
                string query = "SELECT Fk_id_producto, PedidoDet_cantidad, PedidoEnc_precio, PedidoEnc_total FROM Tbl_pedido_detalle WHERE Fk_id_pedidoEnc = ?";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_pedidoEnc", idCotizacion);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                    {
                        adapter.Fill(detalle);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ObtenerDetalle: " + ex.Message);
            }
            return detalle;
        }

        public void funInsertarDetalle(int Idpedido, int IdProducto, int Idcotizacion, int Cantidad, decimal Precio, decimal Subtotal)
        {
            try
            {
                string query = "INSERT INTO Tbl_pedido_detalle (Fk_id_pedidoEnc, Fk_id_producto, Fk_id_cotizacionEnc, PedidoDet_cantidad, PedidoEnc_precio, PedidoEnc_total) " +
                               "VALUES (?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, cn.conectar()))
                {
                    command.Parameters.AddWithValue("@Fk_id_pedidoEnc", Idpedido);  // ID del encabezado
                    command.Parameters.AddWithValue("@Fk_id_producto", IdProducto);  // ID del producto
                    command.Parameters.AddWithValue("@Fk_id_cotizacionEnc", Idcotizacion);  // ID de cotización
                    command.Parameters.AddWithValue("@PedidoDet_cantidad", Cantidad);  // Cantidad
                    command.Parameters.AddWithValue("@PedidoEnc_precio", Precio);  // Precio
                    command.Parameters.AddWithValue("@PedidoEnc_total", Subtotal);  // Subtotal

                    command.ExecuteNonQuery();
                }

                Console.WriteLine($"Inserción exitosa: Idpedido={Idpedido}, IdProducto={IdProducto}, Idcotizacion={Idcotizacion}, Cantidad={Cantidad}, Precio={Precio}, Subtotal={Subtotal}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el detalle: " + ex.Message);
            }
        }







    }
}
