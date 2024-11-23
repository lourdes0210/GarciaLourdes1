using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarciaLourdes1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea una nueva instancia del formulario Actividades_Producto
            Actividades frm = new frmActividades();
            frm.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea una nueva instancia del formulario Usuarios_Producto
            Usuarios frm = new frmUsuarios();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Crea una nueva instancia del formulario Reporte_Producto
            Reporte frm = new frmReporte();
            frm.ShowDialog();
        }

        private void btnConexionBD_Click(object sender, EventArgs e)
        {
            ConexionBD frm = new ConexionBD();
            frm.ToString();
        }
    }
}
