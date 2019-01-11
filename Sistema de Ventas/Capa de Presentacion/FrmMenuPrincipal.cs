using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using System.Runtime.InteropServices;

namespace Capa_de_Presentacion
{
    public partial class FrmMenuPrincipal : DevComponents.DotNetBar.Metro.MetroForm
    {
        int EnviarFecha = 0;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            lblUser.Text = Program.NombreEmpleadoLogueado;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
            MostrarFormLogo();
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelBack.Controls.Count > 0)
                this.panelBack.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelBack.Controls.Add(fh);
            this.panelBack.Tag = fh;
            fh.Show();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        private void MostrarFormLogo()
        {
            AbrirFormInPanel(new FormLogo());
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListadoProductos fm = new FrmListadoProductos();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fm);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes fm = new FrmListadoClientes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fm);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas fm = new FrmRegistroVentas();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fm);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmOrdenes fm = new frmOrdenes();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(EnviarFecha){
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void CapturarFechaSistema() {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmListadoEmpleados fm = new FrmListadoEmpleados();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormInPanel(fm);

        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void menuVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
