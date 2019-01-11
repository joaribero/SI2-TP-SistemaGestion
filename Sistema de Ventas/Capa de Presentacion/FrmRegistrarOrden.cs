using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{
    public partial class FrmRegistrarOrden : Form
    {
        public FrmRegistrarOrden()
        {
            InitializeComponent();
        }
        clsOrden O = new clsOrden();
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboBox()
        {
            cbEstado.DataSource = O.Listar();
            cbEstado.DisplayMember = "Descripcion";
            cbEstado.ValueMember = "IdEstado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListadoClientes fc = new FrmListadoClientes();
            Program.LlamadaExt = true;
            fc.ShowDialog();
            txtDocC.Text = Program.IdCliente +"";
            txtNomCli.Text = Program.ApellidosCliente + " " + Program.NombreCliente;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistroCliente C = new FrmRegistroCliente();
            Program.Evento = 0;
            C.ShowDialog(); 
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados E = new FrmListadoEmpleados();
            Program.LlamadaExt = true;
            E.ShowDialog();
            txtIdResp.Text = Program.IdEmpleado + "";
            txtNomResp.Text = Program.ApelEmpleado + " " + Program.NomEmpleado;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPremio.Text != "")
            {
                O.Titulo = txtTitulo.Text;
                O.IdResponsable = Convert.ToInt32(txtIdResp.Text);
                O.IdCliente = Program.IdCliente;
                O.Fecha = Convert.ToDateTime(dtFecha.Text);
                O.FechaFin = Convert.ToDateTime(dtFechaFin.Text);
                O.Detalle = txtDetalle.Text;
                O.Premio = Convert.ToInt32(txtPremio.Text);
                O.Estado = Convert.ToInt32(cbEstado.SelectedValue);
                if (Program.Evento == 1)
                {
                    O.IdORden = Convert.ToInt32(txtOrden.Text);
                    DevComponents.DotNetBar.MessageBoxEx.Show(O.ActualizarOrden(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show(O.NuevaOrden(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un valor de presupuesto para la orden.","DELMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void FrmRegistrarOrden_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }
    }
}
