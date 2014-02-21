using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClientesMicrosipPortal.clases;

namespace ClientesMicrosipPortal.guis
{
    public partial class SplashInicio : Form
    {
        public SplashInicio()
        {
            InitializeComponent();
        }

        private void SlashInicio_Load(object sender, EventArgs e)
        {           
        }

        private void SplashInicio_Shown(object sender, EventArgs e)
        {
            ConfiguracionMicrosip confMicrosip = new ConfiguracionMicrosip();
            ConfiguracionMysql confMysql = new ConfiguracionMysql();

            Application.DoEvents();
            bool cargaExitosaMicrosip = confMicrosip.LoadConfiguration();
            
            Application.DoEvents();

            if (cargaExitosaMicrosip == true)
            {
                bool cargaExitosaMysql = confMysql.LoadConfiguration();
                if (cargaExitosaMysql == true)
                {
                    this.Hide();
                    new Frm_Principal(confMicrosip, confMysql).ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(confMysql.errorMessage);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(confMicrosip.errorMessage);
                this.Close();
            }
        }
    }
}
