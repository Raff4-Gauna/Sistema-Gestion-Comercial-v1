﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentación.Usos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.MdConfiguracion
{
    public partial class frmSucursales : Form
    {
        //mantener activa solo una ventana y evitar duplicidad
        private static frmSucursales instancia = null;

        public static frmSucursales ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frmSucursales();
            }
            return instancia;
        }
        public frmSucursales()
        {
            InitializeComponent();
        }
        private void frmSucursales_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Alta" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Baja" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {

                }
            }


            //Mostrar todos las Sucursales

            List<Sucursales> Lista = new CN_Sucursales().Listar();

            foreach (Sucursales item in Lista)
            {

                dgvdata.Rows.Add(new object[] {"", item.IdSucursales, item.Nombre, item.Direccion, item.Telefono,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Alta" : "Baja"
                });

            }
            // metodo de sumar las sucursales
            SumarSucursales();
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Almacenar la posición actual del cursor
            int posicionCursor = txtNombre.SelectionStart;

            // Convertir el texto a mayúsculas y asignarlo de nuevo al control
            txtNombre.Text = txtNombre.Text.ToUpper();

            // Restaurar la posición del cursor
            txtNombre.SelectionStart = posicionCursor;
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar la entrada del carácter si no es un número
                e.Handled = true;
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Sucursales obj = new Sucursales()
            {
                IdSucursales = Convert.ToInt32(txtid.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false

            };

            if (obj.IdSucursales == 0)
            {

                int idgenerado = new CN_Sucursales().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"", idgenerado, txtNombre.Text, txtDireccion.Text, txtTelefono.Text,


                    ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).Texto.ToString()
                    });

                    Limpiar();

                    // Para actualizar el total
                    SumarSucursales();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resultado = new CN_Sucursales().Editar(obj, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtNombre.Text;
                    row.Cells["Direccion"].Value = txtDireccion.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }
        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            cboestado.SelectedIndex = 0;
            txtNombre.Select();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtNombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDireccion.Text = dgvdata.Rows[indice].Cells["Direccion"].Value.ToString();
                    txtTelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();

                    foreach (OpcionCombo oc in cboestado.Items)
                    {

                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }

                    }



                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar la sucursal", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Sucursales obj = new Sucursales()
                    {
                        IdSucursales = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Sucursales().Eliminar(obj, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));

                        Limpiar();

                        // Para actualizar el total
                        SumarSucursales();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        // Sumar todas las sucursales
        public void SumarSucursales()
        {
            int Total = 0;

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                Total++;
            }

            lblTotalSucursales.Text = Total.ToString();
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        
    }
}
