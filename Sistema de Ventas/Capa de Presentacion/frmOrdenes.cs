using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Capa_de_Presentacion
{
    public partial class frmOrdenes :DevComponents.DotNetBar.Metro.MetroForm
    {
        clsOrden E = new clsOrden();
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            MostrarListadoOrdenes();
            lblCliente.Text = dataGridView1.Rows[0].Cells[11].Value.ToString() + " " + dataGridView1.Rows[0].Cells[12].Value.ToString();
            lblOrden.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            lblResp.Text = dataGridView1.Rows[0].Cells[9].Value.ToString() + " " + dataGridView1.Rows[0].Cells[10].Value.ToString();
            lblTitulo.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            switch (dataGridView1.Rows[0].Cells[13].Value)
            {
                case "Pendiente":
                    lblEstado.BackColor = Color.Gold;
                    lblEstado.ForeColor = Color.Black;
                    break;
                case "En ejecución":
                    lblEstado.BackColor = Color.LightGray;
                    lblEstado.ForeColor = Color.SteelBlue;
                    break;
                case "Desestimada":
                    lblEstado.BackColor = Color.ForestGreen;
                    lblEstado.ForeColor = Color.White;
                    break;
                case "Finalizada":
                    lblEstado.BackColor = Color.ForestGreen;
                    lblEstado.ForeColor = Color.White;
                    break;

            }
            lblEstado.Text = dataGridView1.Rows[0].Cells[13].Value.ToString();
            lblFecha.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            lblFechaFin.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            lblPremio.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            txtDetalle.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
        }
        private void MostrarListadoOrdenes()
        {
            DataTable dt = new DataTable();
            dt = E.ListadoOrdenes();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count != 1)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                }                
                dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][8].ToString();
                dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][1].ToString();
                dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][2].ToString();
                dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][3].ToString();
                dataGridView1.Rows[i].Cells[5].Value = Convert.ToDateTime(dt.Rows[i][4]).Date.ToString();
                if (dt.Rows[i][5] is null)
                {
                    dataGridView1.Rows[i].Cells[6].Value = DateTime.Now.ToString();
                }
                else
                {
                    dataGridView1.Rows[i].Cells[6].Value = (dt.Rows[i][5]).ToString();
                }              
                dataGridView1.Rows[i].Cells[7].Value = dt.Rows[i][6].ToString();
                dataGridView1.Rows[i].Cells[8].Value = dt.Rows[i][7].ToString();
                dataGridView1.Rows[i].Cells[9].Value = dt.Rows[i][9].ToString();
                dataGridView1.Rows[i].Cells[10].Value = dt.Rows[i][10].ToString();
                dataGridView1.Rows[i].Cells[11].Value = dt.Rows[i][11].ToString();
                dataGridView1.Rows[i].Cells[12].Value = dt.Rows[i][12].ToString();
                dataGridView1.Rows[i].Cells[13].Value = dt.Rows[i][13].ToString();
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
            lblCliente.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[12].Value.ToString();
            lblOrden.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblResp.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[10].Value.ToString();
            lblTitulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            switch (dataGridView1.CurrentRow.Cells[13].Value)
            {
                case "Pendiente":
                    lblEstado.BackColor = Color.LightGoldenrodYellow;
                    lblEstado.ForeColor = Color.Black;
                    break;
                case "En ejecución":
                    lblEstado.BackColor = Color.LightGray;
                    lblEstado.ForeColor = Color.SteelBlue;
                    break;
                case "Desestimada":
                    lblEstado.BackColor = Color.ForestGreen;
                    lblEstado.ForeColor = Color.White;
                    break;
                case "Finalizada":
                    lblEstado.BackColor = Color.ForestGreen;
                    lblEstado.ForeColor = Color.White;
                    break;

            }                
            lblEstado.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            lblFecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblFechaFin.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            lblPremio.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString(); 
            txtDetalle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarOrden f = new FrmRegistrarOrden();
            Program.Evento = 0;
            f.ShowDialog();
            dataGridView1.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmRegistrarOrden P = new FrmRegistrarOrden();
                P.txtOrden.Text = dataGridView1.CurrentRow.Cells[0].Value + "";
                P.txtTitulo.Text = dataGridView1.CurrentRow.Cells[1].Value + "";
                P.txtIdResp.Text = dataGridView1.CurrentRow.Cells[2].Value + "";
                P.txtNomResp.Text = dataGridView1.CurrentRow.Cells[9].Value + " " + dataGridView1.CurrentRow.Cells[10].Value;
                P.txtNomCli.Text = dataGridView1.CurrentRow.Cells[11].Value + " " + dataGridView1.CurrentRow.Cells[12].Value;
                P.txtDetalle.Text = dataGridView1.CurrentRow.Cells[4].Value + "";
                P.cbEstado.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value;
                P.txtDocC.Text = dataGridView1.CurrentRow.Cells[3].Value + "";
                if (dataGridView1.SelectedRows.Count > 0)
                    Program.Evento = 1;
                else
                    Program.Evento = 0;
                P.ShowDialog();
                dataGridView1.ClearSelection();
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Debe Seleccionar la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
