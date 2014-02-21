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
    public partial class Frm_Principal : Form
    {
        private ConfiguracionMicrosip confMicrosip;
        private ConfiguracionMysql confMysql;

        public Frm_Principal(ConfiguracionMicrosip confMicorsip, ConfiguracionMysql confMysql)
        {
            InitializeComponent();
            this.confMicrosip = confMicorsip;
            this.confMysql = confMysql;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
