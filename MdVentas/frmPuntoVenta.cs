﻿using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using CapaPresentación.Utilidades;
using CapaPresentación.MdVentas.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdVentas
{
    public partial class frmPuntoVenta : Form
    {
        // Mantener activa solo una ventana y evitar duplicidad
        private static frmPuntoVenta instancia = null;

        public static frmPuntoVenta ventana_unica(Usuario oUsuario = null)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmPuntoVenta(oUsuario);
            }
            return instancia;
        }

        //--------------------------------------
        private Usuario _Usuario;
        public frmPuntoVenta(Usuario oUsuario)
        {
            _Usuario = oUsuario;
            InitializeComponent();

            // Autocompletar Textbox con consulta por SQL
            CD_Productos cdProductos = new CD_Productos();
            try
            {
                cdProductos.AutoCompledDescripcion(txtDescripcionProd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            // cargar nombre de usuario en el formulario
            if (_Usuario != null)
            {
                lblusuario.Text = "" + _Usuario.NombreCompleto;
            }
            else
            {
                // Manejar el caso en que el usuario sea nulo, si es necesario
                lblusuario.Text = "Usuario: Desconocido";
            }

            // Autoseleccionar el primer cliente
            List<Clientes> ListaClientes = new CN_Clientes().Listar();
            if (ListaClientes.Count > 0)
            {
                var primerCliente = ListaClientes.First();
                txtdocumentocliente.Text = primerCliente.Documento;
                txtnombrecliente.Text = primerCliente.NombreCompleto;
            }

            // Autoseleccionar el primer método de pago
            List<MetodosPagos> ListaMetodosPagos = new CN_Metodos_Pagos().Listar();
            if (ListaMetodosPagos.Count > 0)
            {
                var primerMetodoPago = ListaMetodosPagos.First();
                txtmetodopago.Text = primerMetodoPago.NombreMetodo;
            }

            // Cargar los tipos de documentos
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Remito X", Texto = "Remito X" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";
            txtpagocon.Text = "";
            txtcambio.Text = "";
            txttotalpagar.Text = "0";

            rbCodigo.Select();
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarClientes())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdocumentocliente.Text = modal._Cliente.Documento;
                    txtnombrecliente.Text = modal._Cliente.NombreCompleto;
                    txtcodbarraproducto.Select();
                }
                else
                {
                    txtdocumentocliente.Select();
                }

            }
        }

        //Radio button de seleccion
        private void rbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigoBarra.Checked)
            {
                txtcodbarraproducto.Select();
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo.Checked)
            {
                txtCodproducto.Select();
            }
        }

        private void btnbuscarmetodospagos_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarMetodosPagos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtmetodopago.Text = modal._MetodosPagos.NombreMetodo;
                    txtcodbarraproducto.Select();
                }
                else
                {
                    txtmetodopago.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new frmListarProductos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodbarraproducto.Text = modal._Producto.CodigoBarras;
                    txtproducto.Text = modal._Producto.DescripcionGeneral;
                    txtprecio.Text = modal._Producto.PrecioFinal.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(modal._Producto.StockExistente).ToString("");
                    txtcantidad.Select();
                }
                else
                {
                    txtcodbarraproducto.Select();
                }

            }
        }
        //Buscar producto por codigo de barras
        private void txtcodbarraproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Productos oProducto = new CN_Productos().Listar().Where(p => p.CodigoBarras == txtcodbarraproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtprecio.Text = oProducto.PrecioFinal.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                  //  txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtcodbarraproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        // Buscar producto por codigo interno
        private void txtCodproducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Productos().Listar().FirstOrDefault(p => p.Codigo == txtCodproducto.Text && p.Estado == true);

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtprecio.Text = oProducto.PrecioFinal.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                   // txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtCodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        // Buscar producto por descripcion
        private void txtDescripcionProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Productos oProducto = new CN_Productos().Listar().FirstOrDefault(p => p.DescripcionGeneral == txtDescripcionProd.Text && p.Estado == true);

                if (oProducto != null)
                {
                    txtcodbarraproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.DescripcionGeneral;
                    txtprecio.Text = oProducto.PrecioFinal.ToString("N2");
                    txtstock.Text = Convert.ToDecimal(oProducto.StockExistente).ToString();
                    txtCodproducto.Text = Convert.ToDecimal(oProducto.Codigo).ToString();
                  //  txtcantidad.Select();

                    // Agregar automáticamente al DataGridView
                    AgregarProductoAlDataGridView();
                }
                else
                {
                    txtDescripcionProd.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtstock.Text = "";
                    txtCodproducto.Text = "";
                    txtDescripcionProd.Text = "";
                    txtcantidad.Value = 1;
                    MessageBox.Show("Producto no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //No aceptar caracteres especiales y solo numeros
        private void txtcodbarraproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }
        }

        private void txtCodproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }
        }

        //Agregar rapidamente al datagrid
        private void AgregarProductoAlDataGridView()
        {
            decimal precio = 0;
            decimal cantidad = txtcantidad.Value;
            bool producto_existe = false;
            int index = -1;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }

            if (cantidad > Convert.ToDecimal(txtstock.Text))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    index = fila.Index;
                    break;
                }
            }

            if (producto_existe)
            {
                // Si el producto ya existe, actualizamos la cantidad
                decimal nueva_cantidad = Convert.ToDecimal(dgvdata.Rows[index].Cells["Cantidad"].Value) + cantidad;
                dgvdata.Rows[index].Cells["Cantidad"].Value = nueva_cantidad;
                dgvdata.Rows[index].Cells["SubTotal"].Value = (nueva_cantidad * precio).ToString("N2");
            }
            else
            {
                // Si el producto no existe, agregamos una nueva fila
                dgvdata.Rows.Add(new object[] {
                    txtidproducto.Text,
                    txtproducto.Text,
                    precio.ToString("N2"),
                    cantidad,
                    (cantidad * precio).ToString("N2")
                });
            }

            // Restar el stock independientemente de si el producto existe o no en el carrito
            bool respuesta = new CN_Venta().RestarStock(Convert.ToInt32(txtidproducto.Text), cantidad);

            if (respuesta)
            {
                calcularTotal();
                limpiarProducto();
            }
        }


        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            AgregarProductoAlDataGridView();
        }

        //agregar item por medio de una tecla
        private void frmPuntoVenta_KeyUp(object sender, KeyEventArgs e)
        {
            // F1 BOTON PARA AGREGAR PROD AL DATAGRID
            if (e.KeyCode == Keys.F1)
            {
                btnagregarproducto.PerformClick();
            }
            // F2 BOTON PARA LIMPIAR CAMPOS DE TEXTOS
            if (e.KeyCode == Keys.F2)
            {
                btnlimpiarcampos.PerformClick();
            }
            // F10 BOTON PARA ABRIR EL FORMS DE LISTA DE PRODUCTOS
            if (e.KeyCode == Keys.F10)
            {
                btnbuscarproducto.PerformClick();
            }
            // F5 BOTON PARA GRABAR VENTA
            if (e.KeyCode == Keys.F5)
            {
                btncrearventa.PerformClick();
            }
            // F9 BOTON PARA ABRIR FORMS DE VERIFICAR DE PRECIO PROD
            if (e.KeyCode == Keys.F9)
            {
                btnverificarprecio.PerformClick();
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalpagar.Text = total.ToString("N2");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtDescripcionProd.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txtcantidad.Value = 1;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.remove20.Width;
                var h = Properties.Resources.remove20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.remove20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToDecimal(dgvdata.Rows[index].Cells["Cantidad"].Value));

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    }
                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularcambio()
        {

            if (txttotalpagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalpagar.Text);

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = "0";
            }

            if (decimal.TryParse(txtpagocon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        //Grabar y crear la venta
        private void btncrearventa_Click(object sender, EventArgs e)
        {

            if (txtdocumentocliente.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtnombrecliente.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(decimal));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    Convert.ToDouble(row.Cells["Cantidad"].Value),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0000:00000000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {
                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                DocumentoCliente = txtdocumentocliente.Text,
                DescripcionMetodoPago = txtmetodopago.Text,
                NombreCliente = txtnombrecliente.Text,
                MontoPago = Convert.ToDecimal(txtpagocon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            // Después de realizar la venta
            if (respuesta)
            {
                var result = MessageBox.Show("Número de venta generada:\n" + numeroDocumento + "\n", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                }

                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagocon.Text = "";
                txtcambio.Text = "";
            }


        }

        private void btnlimpiarcampos_Click(object sender, EventArgs e)
        {
            txtcodbarraproducto.Text = "";
            txtCodproducto.Text = "";
            txtproducto.Text = "";
            txtDescripcionProd.Text = "";
            txtprecio.Text = "";
            txtstock.Text = "";
            txttotalpagar.Text = "";
            txtpagocon.Text = "";
            txtcambio.Text = "";
            txtcantidad.Text = "1";

            // Limpia el DataGridView usando la misma lógica que en el evento dgvdata_CellContentClick
            for (int index = dgvdata.Rows.Count - 1; index >= 0; index--)
            {
                bool respuesta = new CN_Venta().SumarStock(
                    Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                    Convert.ToDecimal(dgvdata.Rows[index].Cells["Cantidad"].Value));

                if (respuesta)
                {
                    dgvdata.Rows.RemoveAt(index);
                    calcularTotal();
                }
            }
        }

        //Abrir verificador de precios productos
        private void btnverificarprecio_Click(object sender, EventArgs e)
        {
            frmVerificadorPrecio frmVerificadorPrecio = new frmVerificadorPrecio();
            frmVerificadorPrecio.Show();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter es un número o una coma
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número o una coma, ignora el evento
                e.Handled = true;
            }
        }

        private void txtDescripcionProd_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtDescripcionProd.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtDescripcionProd.Text = txtDescripcionProd.Text.ToUpper();

            // Restaurar la posición del cursor
            txtDescripcionProd.SelectionStart = posicionCursor;
        }
    }
}
