namespace Formularios_lpms
{
    partial class Proyecto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.GroupBox gbxpokedex;
            this.dgvpokedex = new System.Windows.Forms.DataGridView();
            this.panelpokedex = new System.Windows.Forms.Panel();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.gbxDatosPokemon = new System.Windows.Forms.GroupBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txthabilidad = new System.Windows.Forms.TextBox();
            this.lblhabilidad = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnliberar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            gbxpokedex = new System.Windows.Forms.GroupBox();
            gbxpokedex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokedex)).BeginInit();
            this.panelpokedex.SuspendLayout();
            this.gbxDatosPokemon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxpokedex
            // 
            gbxpokedex.BackColor = System.Drawing.Color.Gainsboro;
            gbxpokedex.Controls.Add(this.dgvpokedex);
            gbxpokedex.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbxpokedex.Location = new System.Drawing.Point(18, 82);
            gbxpokedex.Name = "gbxpokedex";
            gbxpokedex.Size = new System.Drawing.Size(606, 467);
            gbxpokedex.TabIndex = 0;
            gbxpokedex.TabStop = false;
            // 
            // dgvpokedex
            // 
            this.dgvpokedex.BackgroundColor = System.Drawing.Color.White;
            this.dgvpokedex.ColumnHeadersHeight = 29;
            this.dgvpokedex.Location = new System.Drawing.Point(18, 17);
            this.dgvpokedex.Name = "dgvpokedex";
            this.dgvpokedex.RowHeadersWidth = 51;
            this.dgvpokedex.Size = new System.Drawing.Size(567, 429);
            this.dgvpokedex.TabIndex = 0;
            // 
            // panelpokedex
            // 
            this.panelpokedex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpokedex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(29)))), ((int)(((byte)(47)))));
            this.panelpokedex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpokedex.Controls.Add(this.txtbuscar);
            this.panelpokedex.Controls.Add(this.btnbuscar);
            this.panelpokedex.Controls.Add(this.gbxDatosPokemon);
            this.panelpokedex.Controls.Add(this.btnlimpiar);
            this.panelpokedex.Controls.Add(this.btnliberar);
            this.panelpokedex.Controls.Add(this.btnmodificar);
            this.panelpokedex.Controls.Add(this.btnregistrar);
            this.panelpokedex.Controls.Add(gbxpokedex);
            this.panelpokedex.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelpokedex.Location = new System.Drawing.Point(12, 12);
            this.panelpokedex.Name = "panelpokedex";
            this.panelpokedex.Size = new System.Drawing.Size(1290, 660);
            this.panelpokedex.TabIndex = 0;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.Location = new System.Drawing.Point(225, 29);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(395, 36);
            this.txtbuscar.TabIndex = 8;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(18, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(189, 45);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // gbxDatosPokemon
            // 
            this.gbxDatosPokemon.BackColor = System.Drawing.Color.White;
            this.gbxDatosPokemon.Controls.Add(this.lblpeso);
            this.gbxDatosPokemon.Controls.Add(this.txthabilidad);
            this.gbxDatosPokemon.Controls.Add(this.lblhabilidad);
            this.gbxDatosPokemon.Controls.Add(this.txttipo);
            this.gbxDatosPokemon.Controls.Add(this.txtaltura);
            this.gbxDatosPokemon.Controls.Add(this.txtpeso);
            this.gbxDatosPokemon.Controls.Add(this.txtnombre);
            this.gbxDatosPokemon.Controls.Add(this.txtid);
            this.gbxDatosPokemon.Controls.Add(this.lbltipo);
            this.gbxDatosPokemon.Controls.Add(this.lblaltura);
            this.gbxDatosPokemon.Controls.Add(this.lblnombre);
            this.gbxDatosPokemon.Controls.Add(this.lblid);
            this.gbxDatosPokemon.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPokemon.ForeColor = System.Drawing.Color.Black;
            this.gbxDatosPokemon.Location = new System.Drawing.Point(674, 82);
            this.gbxDatosPokemon.Name = "gbxDatosPokemon";
            this.gbxDatosPokemon.Size = new System.Drawing.Size(595, 467);
            this.gbxDatosPokemon.TabIndex = 5;
            this.gbxDatosPokemon.TabStop = false;
            this.gbxDatosPokemon.Text = "DATOS DEL POKEMON";
            this.gbxDatosPokemon.Enter += new System.EventHandler(this.gbxDatosPokemon_Enter);
            // 
            // lblpeso
            // 
            this.lblpeso.Location = new System.Drawing.Point(20, 305);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(161, 25);
            this.lblpeso.TabIndex = 13;
            this.lblpeso.Text = "Peso:";
            this.lblpeso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txthabilidad
            // 
            this.txthabilidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthabilidad.Location = new System.Drawing.Point(187, 351);
            this.txthabilidad.Name = "txthabilidad";
            this.txthabilidad.Size = new System.Drawing.Size(376, 32);
            this.txthabilidad.TabIndex = 12;
            // 
            // lblhabilidad
            // 
            this.lblhabilidad.Location = new System.Drawing.Point(20, 354);
            this.lblhabilidad.Name = "lblhabilidad";
            this.lblhabilidad.Size = new System.Drawing.Size(161, 25);
            this.lblhabilidad.TabIndex = 11;
            this.lblhabilidad.Text = "Habilidad:";
            this.lblhabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttipo
            // 
            this.txttipo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.Location = new System.Drawing.Point(187, 206);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(376, 32);
            this.txttipo.TabIndex = 10;
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.Location = new System.Drawing.Point(187, 254);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(376, 32);
            this.txtaltura.TabIndex = 9;
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.Location = new System.Drawing.Point(187, 302);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(376, 32);
            this.txtpeso.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(187, 158);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(376, 32);
            this.txtnombre.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(187, 110);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(376, 32);
            this.txtid.TabIndex = 6;
            // 
            // lbltipo
            // 
            this.lbltipo.Location = new System.Drawing.Point(20, 209);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(161, 25);
            this.lbltipo.TabIndex = 5;
            this.lbltipo.Text = "Tipo:";
            this.lbltipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblaltura
            // 
            this.lblaltura.Location = new System.Drawing.Point(20, 257);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(161, 25);
            this.lblaltura.TabIndex = 4;
            this.lblaltura.Text = "Altura:";
            this.lblaltura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnombre
            // 
            this.lblnombre.Location = new System.Drawing.Point(20, 161);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(161, 25);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre:";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(20, 113);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(161, 25);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID:";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnlimpiar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Location = new System.Drawing.Point(484, 574);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(140, 60);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnliberar
            // 
            this.btnliberar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.btnliberar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliberar.ForeColor = System.Drawing.Color.Black;
            this.btnliberar.Location = new System.Drawing.Point(335, 574);
            this.btnliberar.Name = "btnliberar";
            this.btnliberar.Size = new System.Drawing.Size(140, 60);
            this.btnliberar.TabIndex = 3;
            this.btnliberar.Text = "Liberar";
            this.btnliberar.UseVisualStyleBackColor = false;
            this.btnliberar.Click += new System.EventHandler(this.btnliberar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmodificar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Location = new System.Drawing.Point(177, 574);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(149, 60);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(175)))), ((int)(((byte)(242)))));
            this.btnregistrar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(18, 574);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(140, 60);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(27)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1314, 684);
            this.Controls.Add(this.panelpokedex);
            this.Name = "Proyecto";
            this.Text = "Pokédex";
            this.Load += new System.EventHandler(this.Proyecto_Load);
            gbxpokedex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokedex)).EndInit();
            this.panelpokedex.ResumeLayout(false);
            this.panelpokedex.PerformLayout();
            this.gbxDatosPokemon.ResumeLayout(false);
            this.gbxDatosPokemon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelpokedex;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnliberar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.GroupBox gbxDatosPokemon;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblhabilidad;
        private System.Windows.Forms.TextBox txthabilidad;
        private System.Windows.Forms.DataGridView dgvpokedex;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblpeso;
    }
}