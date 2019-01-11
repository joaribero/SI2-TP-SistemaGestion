namespace Capa_de_Presentacion
{
    partial class frmOrdenes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RApel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDetalle = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPremio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconcerrar
            // 
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(890, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(20, 20);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 12;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titulo,
            this.IdResponsable,
            this.IdCliente,
            this.Detalle,
            this.Fecha,
            this.FechaFin,
            this.Premio,
            this.IdEstado,
            this.RApel,
            this.RNom,
            this.CApel,
            this.CNom,
            this.Estado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(232, 542);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 50;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdResponsable
            // 
            this.IdResponsable.HeaderText = "IdResponsable";
            this.IdResponsable.Name = "IdResponsable";
            this.IdResponsable.ReadOnly = true;
            this.IdResponsable.Visible = false;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "FechaFin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Visible = false;
            // 
            // Premio
            // 
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            this.Premio.Visible = false;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "IdEstado";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Visible = false;
            // 
            // RApel
            // 
            this.RApel.HeaderText = "RApel";
            this.RApel.Name = "RApel";
            this.RApel.ReadOnly = true;
            this.RApel.Visible = false;
            // 
            // RNom
            // 
            this.RNom.HeaderText = "RNom";
            this.RNom.Name = "RNom";
            this.RNom.ReadOnly = true;
            this.RNom.Visible = false;
            // 
            // CApel
            // 
            this.CApel.HeaderText = "CApel";
            this.CApel.Name = "CApel";
            this.CApel.ReadOnly = true;
            this.CApel.Visible = false;
            // 
            // CNom
            // 
            this.CNom.HeaderText = "CNom";
            this.CNom.Name = "CNom";
            this.CNom.ReadOnly = true;
            this.CNom.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(810, 478);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(680, 476);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Orden Nro; ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblResp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(555, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 91);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(74, 51);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(57, 17);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // lblResp
            // 
            this.lblResp.AutoSize = true;
            this.lblResp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResp.Location = new System.Drawing.Point(113, 19);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(112, 17);
            this.lblResp.TabIndex = 1;
            this.lblResp.Text = "Ribero. Joaquín";
            this.lblResp.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Gold;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEstado.Location = new System.Drawing.Point(304, 45);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(91, 19);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Finalizada";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(332, 15);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(32, 17);
            this.lblOrden.TabIndex = 20;
            this.lblOrden.Text = "145";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(244, 113);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(444, 40);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Titulo de prueba de orden";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha de inicio;";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(373, 170);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 19);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "14/03/1996";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha de fin:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(353, 199);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(85, 19);
            this.lblFechaFin.TabIndex = 25;
            this.lblFechaFin.Text = "08/11/2018";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDetalle);
            this.groupBox2.Location = new System.Drawing.Point(251, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 228);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(6, 22);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(647, 200);
            this.txtDetalle.TabIndex = 0;
            this.txtDetalle.Text = "este saoigasdgas uyiegbasiugbabgag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 476);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Premio:";
            // 
            // lblPremio
            // 
            this.lblPremio.AutoSize = true;
            this.lblPremio.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremio.Location = new System.Drawing.Point(312, 478);
            this.lblPremio.Name = "lblPremio";
            this.lblPremio.Size = new System.Drawing.Size(48, 17);
            this.lblPremio.TabIndex = 28;
            this.lblPremio.Text = "$1500";
            // 
            // frmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblPremio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.iconcerrar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPremio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RApel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}