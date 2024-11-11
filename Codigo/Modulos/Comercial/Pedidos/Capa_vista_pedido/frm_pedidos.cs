using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_controlador_pedido;
using Capa_modelo_pedido;

namespace Capa_vista_pedido
{
    public partial class frm_pedidos : Form
    {
        logica logic;

        string valorSeleccionadovendedor;
        string valorSeleccionadoclientes;
        string valorSeleccionadoProducto;
        string valorSeleccionadoBucadorE;

        public frm_pedidos()
        {
            InitializeComponent();
            logic = new logica();
            InicializarTotal();
            Btn_cancelar.Enabled = true;
            Btn_nuevoCE.Enabled = true;
            Btn_buscarE.Enabled = true;
            Txt_ClienteB.Enabled = false;

            ToolTip tagregrarE = new ToolTip();
            tagregrarE.SetToolTip(Btn_agregar, "agregar producto");
            ToolTip tguardar = new ToolTip();
            tguardar.SetToolTip(Btn_nuevoCE, "Guardar cotización");
            ToolTip tcancelar = new ToolTip();
            tcancelar.SetToolTip(Btn_cancelar, "Cancelar Cambios");
            ToolTip teliminar = new ToolTip();
            tcancelar.SetToolTip(Btn_borrar, "elimna producto");
            ToolTip tmodificar = new ToolTip();
            ToolTip tbuscardorE = new ToolTip();
            tcancelar.SetToolTip(Btn_buscarE, "buscar encambezado");
            ToolTip tayuda = new ToolTip();
            tayuda.SetToolTip(Btn_ayuda, "ayuda con cotizacion");
            ToolTip treporte = new ToolTip();
            treporte.SetToolTip(Btn_reporte, "reporte de cotizacion");
            ToolTip tguardarD = new ToolTip();

            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";

            string stablaCE = "Tbl_cotizacion_encabezado";
            string scampo1CE = "Pk_id_cotizacionEnc";


            string stablal = "Tbl_Productos";
            string scampo1l = "Pk_id_Producto";
            string scampo2l = "nombreProducto";


            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);
            prollenarselista(stablal, scampo1l, scampo2l);
            prollenarsBucador(stablaCE, scampo1CE);



            // Asocia el evento SelectedIndexChanged después de poblar el ComboBox
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged);
            Cbo_producto.SelectedIndexChanged += new EventHandler(Cbo_producto_SelectedIndexChanged);
            //proactualizardatagriew();*/
        }

        private void InicializarTotal()
        {
            Txt_total.Text = "00.00"; // Asignar el valor "00.00" al TextBox
        }

        public void prollenarseVendedores(string tabla, string campo1, string campo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(tabla, campo1, campo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_vendedor.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_vendedor.Items.Add(new ComboBoxItemv
                {
                    Value = row[campo1].ToString(),
                    Display = row[campo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));
            }

            Cbo_vendedor.AutoCompleteCustomSource = coleccion;
            Cbo_vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_vendedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // /////////////////////////////////////////////////////////////////////////////////
        public void prollenarseClientes(string stabla, string scampo1, string scampo2)
        {
            // Obtén los datos para el ComboBox
            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_cliente.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_cliente.Items.Add(new ComboBoxItemc
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_cliente.AutoCompleteCustomSource = coleccion;
            Cbo_cliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public class ComboBoxItem
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }

        public class ComboBoxItemv
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }
        public class ComboBoxItemc
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }

        public void prollenarselista(string stabla, string scampo1, string scampo2)
        {

            var dt = logic.funenviar(stabla, scampo1, scampo2);

            // Limpia el ComboBox antes de llenarlo
            Cbo_producto.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // Agrega el elemento mostrando el formato "ID-Nombre"
                Cbo_producto.Items.Add(new ComboBoxItem
                {
                    Value = row[scampo1].ToString(),
                    Display = row[scampo2].ToString()
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo1]) + "-" + Convert.ToString(row[scampo2]));
                coleccion.Add(Convert.ToString(row[scampo2]) + "-" + Convert.ToString(row[scampo1]));
            }

            Cbo_producto.AutoCompleteCustomSource = coleccion;
            Cbo_producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_producto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public class ComboBoxItemP
        {
            public string Value { get; set; }
            public string Display { get; set; }


            public override string ToString()
            {
                return $"{Value}-{Display}";
            }
        }

        /*public void prollenarsBucador(string stabla, string scampo)
        {
            // Obtén los datos para el ComboBox
            var dt1 = logic.funenviar1(stabla, scampo);

            // Limpia el ComboBox antes de llenarlo
            Cbo_buscadorE.Items.Clear();

            foreach (DataRow row in dt1.Rows)
            {
                // Agrega el elemento mostrando solo el campo
                Cbo_buscadorE.Items.Add(new ComboBoxItem1
                {
                    Value = row[scampo].ToString(), // ID o valor para la selección
                    Display = row[scampo].ToString() // Solo el nombre a mostrar
                });
            }

            // Configura AutoComplete para el ComboBox con el formato deseado
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt1.Rows)
            {
                // Solo se agrega el campo para autocompletar
                coleccion.Add(Convert.ToString(row[scampo]));
            }

            Cbo_buscadorE.AutoCompleteCustomSource = coleccion;
            Cbo_buscadorE.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_buscadorE.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }*/

        public class ComboBoxItem1
        {
            public string Value { get; set; } // Este será el ID o valor que representa el item
            public string Display { get; set; } // Este será el texto que se muestra en el ComboBox

            // Sobrescribir el método ToString para mostrar solo el nombre en el ComboBox
            public override string ToString()
            {
                return Display; // Solo muestra el campo Display
            }
        }

        /*private void ActualizarComboBox()
        {
            // Limpiar los ítems actuales de los ComboBox
            Cbo_vendedor.Items.Clear();
            Cbo_cliente.Items.Clear();

            Cbo_producto.Items.Clear();
            Cbo_buscadorE.Items.Clear();

            // Definir las tablas y campos para los vendedores y clientes
            string stablav = "Tbl_vendedores";
            string scampo1v = "Pk_id_vendedor";
            string scampo2v = "vendedores_nombre";


            string stablaC = "Tbl_clientes";
            string scampo1C = "Pk_id_cliente";
            string scampo2C = "Clientes_nombre";

            string stablaCE = "Tbl_cotizacion_encabezado";
            string scampo1CE = "Pk_id_cotizacionEnc";

            string stablal = "Tbl_Productos";
            string scampo1l = "Pk_id_Producto";
            string scampo2l = "nombreProducto";


            // Llenar los ComboBox con las funciones correspondientes
            prollenarseVendedores(stablav, scampo1v, scampo2v);
            prollenarseClientes(stablaC, scampo1C, scampo2C);
            prollenarselista(stablal, scampo1l, scampo2l);
            prollenarsBucador(stablaCE, scampo1CE);

            // Asociar los eventos SelectedIndexChanged si aún no se han registrado
            Cbo_vendedor.SelectedIndexChanged += new EventHandler(Cbo_vendedor_SelectedIndexChanged);
            Cbo_cliente.SelectedIndexChanged += new EventHandler(Cbo_cliente_SelectedIndexChanged_1);
            Cbo_producto.SelectedIndexChanged += new EventHandler(Cbo_producto_SelectedIndexChanged);
            //  Cbo_buscadorE.SelectedIndexChanged += new EventHandler(Cbo_buscadorE_SelectedIndexChanged);

        }*/

        private void LimpiarDataGridView(DataGridView dataGridView)
        {
            // Verifica si el DataGridView tiene filas
            if (dataGridView.Rows.Count > 0)
            {
                // Elimina todas las filas
                dataGridView.Rows.Clear();
            }
        }

        private void limpiarT()
        {
            Txt_idEncezado.Clear();
            Cbo_vendedor.SelectedIndex = -1;
            Cbo_cliente.SelectedIndex = -1;
            Cbo_buscadorE.SelectedIndex = -1;
            Dtp_fechaC.Value = DateTime.Today;
            Txt_ClienteB.Clear();
            Txt_total.Clear();
            Cbo_producto.SelectedIndex = -1;
            Txt_precio.Clear();
            LimpiarDataGridView(Dgv_pedido);
            Txt_cotizacion.Clear();


        }

        private void limpiar()
        {
            Cbo_producto.SelectedIndex = -1;
            Txt_precio.Clear();
            Txt_cantidad.Value = 0;


        }

        private void Cbo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_cliente.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItemc)Cbo_cliente.SelectedItem;
                valorSeleccionadoclientes = selectedItem.Value;


                string idcliente = valorSeleccionadoclientes;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");

                DataTable tableProducto = logic.funllenarCliente(idcliente);

                if (tableProducto != null && tableProducto.Rows.Count > 0)
                {
                    // Suponiendo que el precio está en la columna "ListDetalle_preVenta"
                    Txt_ClienteB.Text = tableProducto.Rows[0]["Cliente_Tipo"].ToString();
                }
                else
                {
                    Txt_ClienteB.Text = "Precio no encontrado"; // Mensaje o acción en caso de que no se encuentre el precio
                }

            }
        }

        private void Cbo_producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que el cliente esté seleccionado
            if (Cbo_cliente.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente antes de elegir un producto.", "Validación", MessageBoxButtons.OK);
                limpiar();
                return; // Sale de la función si no hay un cliente seleccionado

            }

            if (Cbo_producto.SelectedItem != null)
            {

                var selectedItem = (ComboBoxItem)Cbo_producto.SelectedItem;
                valorSeleccionadoProducto = selectedItem.Value;

                string idcliente = valorSeleccionadoclientes;  // Asegúrate de que `valorSeleccionadoclientes` contenga el idCliente
                string idProducto = valorSeleccionadoProducto; // Asegúrate de que `valorSeleccionadoProducto` contenga el idProducto

                //opcion uno
                // Llamar a la función que obtiene los datos del producto con el cliente específico
                DataTable tableProducto = logic.funllenarProducto1(idcliente, idProducto);

                if (tableProducto != null && tableProducto.Rows.Count > 0)
                {
                    // Suponiendo que el precio calculado está en la columna "precio"
                    Txt_precio.Text = tableProducto.Rows[0]["precio"].ToString();

                }
                else
                {
                    DataTable tableProducto2 = logic.funllenarProducto2(idProducto);

                    if (tableProducto2 != null && tableProducto2.Rows.Count > 0)
                    {
                        // Suponiendo que el precio está en la columna "ListDetalle_preVenta"
                        Txt_precio.Text = tableProducto2.Rows[0]["precioUnitario"].ToString();

                    }
                    else
                    {
                        Txt_precio.Text = "Precio no encontrado"; // Mensaje o acción en caso de que no se encuentre el precio
                    }
                }

            }
        }

        private void Cbo_vendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_vendedor.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItemv)Cbo_vendedor.SelectedItem;
                valorSeleccionadovendedor = selectedItem.Value;
                // MessageBox.Show($"Valor seleccionado: {valorSeleccionadousuario}", "Valor Seleccionado");
            }
        }

        private void InsertarEncabezado()
        {
           // Cbo_vendedor.Enabled = false;
           // Cbo_cliente.Enabled = false;

            if (Txt_idEncezado.Text == "")
            {

                MessageBox.Show("Falta ID de Pedido");
               // Cbo_vendedor.Enabled = false;
               // Cbo_cliente.Enabled = false;
            }
            else if (Cbo_vendedor.Text == "")
            {
                MessageBox.Show("Falta Vendedor");
                //Cbo_vendedor.Enabled = false;
                //Cbo_cliente.Enabled = false;
            }

            else
            {
                string Idcotizacion = Txt_idEncezado.Text;
                DateTime fechaVence = Dtp_fechaV.Value; // Suponiendo que tienes un DateTimePicker para la fecha de vencimiento
                string total = Txt_total.Text;
                string sVendedorSeleccionado = valorSeleccionadovendedor;
                string sClienteSeleccionado = valorSeleccionadoclientes;

                logic.insertarEncabezado(Txt_idEncezado.Text.ToString(), sVendedorSeleccionado, sClienteSeleccionado, fechaVence, Txt_total.Text.ToString());

            }
        }

        private void InsertarDetalle()
        {
            if (!int.TryParse(Txt_idEncezado.Text, out int Idpedido))
            {
                MessageBox.Show("El valor del encabezado no es válido.");
                return;
            }

            if (!int.TryParse(Txt_cotizacion.Text, out int Idcotizacion))
            {
                MessageBox.Show("El valor del idcotizacion no es válido.");
                return;
            }

            // Iterar sobre cada fila de Dgv_pedido
            foreach (DataGridViewRow row in Dgv_pedido.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila de nueva entrada

                // Verificar que todas las celdas tengan valores válidos antes de insertar
                if (row.Cells["Producto"].Value != null &&
                    row.Cells["Cantidad"].Value != null &&
                    row.Cells["Precio"].Value != null &&
                    row.Cells["Subtotal"].Value != null)
                {
                    // Extraer datos de cada celda
                    int Idproducto = Convert.ToInt32(row.Cells["Producto"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);

                    // Agregar mensajes de depuración
                    Console.WriteLine($"Intentando insertar: Idpedido={Idpedido}, Idproducto={Idproducto}, Idcotizacion={Idcotizacion}, cantidad={cantidad}, precio={precio}, subtotal={subtotal}");

                    // Llamar a la función log.insertarDetalle con Idcotizacion como parámetro
                    if (!logic.insertarDetalle(Idpedido, Idproducto, Idcotizacion, cantidad, precio, subtotal))
                    {
                        MessageBox.Show("Error al insertar el detalle.");
                    }
                }
            }
            MessageBox.Show("Cotización Guardada correctamente.");
        }




        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (Cbo_producto.SelectedItem == null || string.IsNullOrEmpty(Txt_precio.Text) || Txt_cantidad.Value <= 0)
            {
                MessageBox.Show("Faltan Datos Por Seleccionar", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Variables para los valores a agregar
            string producto = valorSeleccionadoProducto;
            int cantidad = (int)Txt_cantidad.Value;
            decimal precio = Convert.ToDecimal(Txt_precio.Text);
            decimal subtotal = precio * cantidad;

            bool productoExistente = false;


            // Verificar si el producto ya está en la lista
            foreach (DataGridViewRow fila in Dgv_pedido.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == producto)
                {
                    productoExistente = true;
                    MessageBox.Show("El producto ya está en la cotización.", "Producto Existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }



            }

            if (!productoExistente)
            {
                // Agregar la fila a la  en el orden solicitado
                Dgv_pedido.Rows.Add(producto, cantidad, precio, subtotal);
                // iContadorFila++;

                // Sumar el subtotal al total actual en Txt_total
                decimal totalActual = string.IsNullOrEmpty(Txt_total.Text) ? 0 : Convert.ToDecimal(Txt_total.Text);
                decimal nuevoTotal = totalActual + subtotal;
                Txt_total.Text = nuevoTotal.ToString();
                MessageBox.Show($"Nuevo total: {nuevoTotal.ToString("0.00")}");

            }

            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada en el DataGridView
                if (Dgv_pedido.SelectedRows.Count > 0)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult confirmacion = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta asignación?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmacion == DialogResult.Yes)
                    {
                        // Obtener el subtotal de la fila seleccionada (suponiendo que está en la columna 3)
                        decimal subtotalEliminado = Convert.ToDecimal(Dgv_pedido.SelectedRows[0].Cells[3].Value);

                        // Eliminar la fila del DataGridView
                        Dgv_pedido.Rows.RemoveAt(Dgv_pedido.SelectedRows[0].Index);

                        // Actualizar el total en Txt_total restando el subtotal eliminado
                        decimal totalActual = string.IsNullOrEmpty(Txt_total.Text) ? 0 : Convert.ToDecimal(Txt_total.Text);
                        decimal nuevoTotal = totalActual - subtotalEliminado;
                        Txt_total.Text = nuevoTotal.ToString(); // Actualizar el total en el formato correcto

                        MessageBox.Show($"Se eliminó el producto. Nuevo total: {nuevoTotal.ToString("0.00")}");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            InicializarTotal();
        }

        private void Btn_nuevoCE_Click(object sender, EventArgs e)
        {
            InsertarEncabezado();
            InsertarDetalle();
            limpiarT();
        }

        private void BuscarCotizacion()
        {
            try
            {
                if (Cbo_buscadorE.SelectedItem is ComboBoxItem1 selectedItem)
                {
                    string idCotizacion = selectedItem.Value;

                    // Llamar a la lógica para obtener el detalle de la cotización
                    DataTable detalle = logic.ObtenerDetalle(idCotizacion);

                    // Verificar si se obtuvieron datos
                    if (detalle.Rows.Count > 0)
                    {
                        // Asignar el DataTable al DataGridView
                        Dgv_pedido.DataSource = detalle;
                        MessageBox.Show("Datos cargados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para la cotización seleccionada.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una cotización válida del combo de búsqueda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cotización: " + ex.Message);
            }
        }

        public void prollenarsBucador(string stabla, string scampo)
        {
            var dt1 = logic.funenviar1(stabla, scampo);
            Cbo_buscadorE.Items.Clear();

            foreach (DataRow row in dt1.Rows)
            {
                Cbo_buscadorE.Items.Add(new ComboBoxItem1
                {
                    Value = row[scampo].ToString(),
                    Display = row[scampo].ToString()
                });
            }

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt1.Rows)
            {
                coleccion.Add(Convert.ToString(row[scampo]));
            }

            Cbo_buscadorE.AutoCompleteCustomSource = coleccion;
            Cbo_buscadorE.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Cbo_buscadorE.AutoCompleteSource = AutoCompleteSource.CustomSource;

            MessageBox.Show("ComboBox cargado con " + dt1.Rows.Count + " elementos.");
        }



        private void Btn_buscarE_Click(object sender, EventArgs e)
        {
            BuscarCotizacion();
        }

        private void PruebaInsertarDetalle()
        {
            // Datos de prueba
            Txt_idEncezado.Text = "3";      // Simula el ID del encabezado del pedido
            Txt_cotizacion.Text = "5";      // Simula el ID de cotización

            // Limpia el DataGridView y añade una fila de prueba
            Dgv_pedido.Rows.Clear();
            Dgv_pedido.Rows.Add("3", "10", "25.50", "1005.00");  // Ejemplo: ProductoID, Cantidad, Precio, Subtotal

            // Llamar al método InsertarDetalle, que ejecutará la inserción en las capas
            InsertarDetalle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PruebaInsertarDetalle();
        }
    }
}
