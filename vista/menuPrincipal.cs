using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario.vista
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sidebarItem1_Load(object sender, EventArgs e)
        {

        }

        private void sidebarItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
