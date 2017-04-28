using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesMicrosipPortal.clases;
using System.Globalization;

namespace ClientesMicrosipPortal.guis
{
    public partial class Frm_Principal : Form
    {
        public List<Cliente> lstClientes;
        public List<Cliente> lstClientesAExportar;
        private ConfiguracionMicrosip confMicrosip;
        private ConfiguracionMysql confMysql;

        public Frm_Principal(ConfiguracionMicrosip confMicorsip, ConfiguracionMysql confMysql)
        {
            InitializeComponent();
            this.confMicrosip = confMicorsip;
            this.confMysql = confMysql;

            lstClientesAExportar = new List<Cliente>();
        }

        private void Frm_Principal_Shown(object sender, EventArgs e)
        {
            //Dibujar el Formulario
            Application.DoEvents();
            gridClientesMicrosip.DataSource = lstClientes;
            gvClientesMicrosip.BestFitColumns();
        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Cliente> lstClientesAux = new List<Cliente>();
            lstClientesAux = lstClientes.FindAll(o => o.Nombre.Contains(txbBusqueda.Text.ToUpper()));
            gridClientesMicrosip.DataSource = lstClientesAux;
            gvClientesMicrosip.BestFitColumns();
            Application.DoEvents();
        }
       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int iSelected = gvClientesMicrosip.GetSelectedRows()[0];
            Cliente clienteSeleccionado = (Cliente)gvClientesMicrosip.GetRow(iSelected);

            AgregarClienteLista(clienteSeleccionado);
            btnExportar.Enabled = true;
        }
        private void AgregarClienteLista(Cliente cliente)
        {
            lstClientesAExportar.Add(cliente);
            lstClientesAExportar = lstClientesAExportar.Distinct().ToList();

            gridClientesAExportar.DataSource = lstClientesAExportar;
            gvClientesAExportar.BestFitColumns();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gvClientesAExportar.DataRowCount > 0)
            {
                int iSelected = gvClientesAExportar.GetSelectedRows()[0];
                Cliente clienteSeleccionado = (Cliente)gvClientesAExportar.GetRow(iSelected);

                QuitarClienteLista(clienteSeleccionado);
            }
            
            if (gvClientesAExportar.DataRowCount == 0)
            {
                btnExportar.Enabled = false;
            }
        }
        private void QuitarClienteLista(Cliente cliente)
        {
            lstClientesAExportar.Remove(cliente);
            lstClientesAExportar = lstClientesAExportar.Distinct().ToList();

            gridClientesAExportar.DataSource = lstClientesAExportar;
            gvClientesAExportar.BestFitColumns();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            bool esCorrecto = ValidarExportar();
            if (esCorrecto == true)
            {
                Exportar();
            }
        }
        private bool ValidarExportar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Se van a exportar {0} clientes...", gvClientesAExportar.DataRowCount));
            sb.AppendLine("¿Son datos correctos?");

            DialogResult dr = MessageBox.Show(sb.ToString(), "Validar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
                return true;
            else
                return false;
        }
        private void Exportar()
        {            
            try
            {
                List<Cliente> lstClientesAExportar = (List<Cliente>)gridClientesAExportar.DataSource;

                Mysql_DAL myDAL = new Mysql_DAL(confMysql);
                myDAL.InsertarClientes(lstClientesAExportar);

                MessageBox.Show("¡La exportacion ha finalizado con exito!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string error;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Error:");
                sb.AppendLine();
                error = ex.Message.Replace("Duplicate entry", string.Empty);
                error = error.Replace("for key", string.Empty);
                error = error.Replace("'nombre'", string.Empty);
                error = error + Environment.NewLine + "Ya existe en en portal...";
                sb.AppendLine(error);
                MessageBox.Show(sb.ToString(), (ex.GetType()).ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
