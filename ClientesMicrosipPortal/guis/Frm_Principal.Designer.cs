namespace ClientesMicrosipPortal.guis
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gridClientesMicrosip = new DevExpress.XtraGrid.GridControl();
            this.gvClientesMicrosip = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.gridClientesAExportar = new DevExpress.XtraGrid.GridControl();
            this.gvClientesAExportar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesAExportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesAExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(784, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Exportar clientes al portal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridClientesMicrosip
            // 
            this.gridClientesMicrosip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridClientesMicrosip.Location = new System.Drawing.Point(9, 64);
            this.gridClientesMicrosip.MainView = this.gvClientesMicrosip;
            this.gridClientesMicrosip.Name = "gridClientesMicrosip";
            this.gridClientesMicrosip.Size = new System.Drawing.Size(357, 454);
            this.gridClientesMicrosip.TabIndex = 1;
            this.gridClientesMicrosip.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientesMicrosip});
            // 
            // gvClientesMicrosip
            // 
            this.gvClientesMicrosip.GridControl = this.gridClientesMicrosip;
            this.gvClientesMicrosip.Name = "gvClientesMicrosip";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente:";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBusqueda.Location = new System.Drawing.Point(67, 35);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(647, 23);
            this.txbBusqueda.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCliente.AutoSize = true;
            this.btnBuscarCliente.Location = new System.Drawing.Point(720, 33);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(56, 26);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // gridClientesAExportar
            // 
            this.gridClientesAExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gridClientesAExportar.Location = new System.Drawing.Point(419, 65);
            this.gridClientesAExportar.MainView = this.gvClientesAExportar;
            this.gridClientesAExportar.Name = "gridClientesAExportar";
            this.gridClientesAExportar.Size = new System.Drawing.Size(357, 453);
            this.gridClientesAExportar.TabIndex = 5;
            this.gridClientesAExportar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientesAExportar});
            // 
            // gvClientesAExportar
            // 
            this.gvClientesAExportar.GridControl = this.gridClientesAExportar;
            this.gvClientesAExportar.Name = "gvClientesAExportar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(372, 141);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 26);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(372, 173);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(40, 26);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportar.AutoSize = true;
            this.btnExportar.Location = new System.Drawing.Point(355, 524);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 26);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridClientesAExportar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridClientesMicrosip);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Principal";
            this.Text = "Exportar Clientes de Microsip al Portal www.loscorrales.com.mx";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesMicrosip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientesAExportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientesAExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridClientesMicrosip;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientesMicrosip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBuscarCliente;
        private DevExpress.XtraGrid.GridControl gridClientesAExportar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientesAExportar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnExportar;
    }
}