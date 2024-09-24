using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario.vista.ElementosUI
{
    [DefaultEvent("Click")]  
    public partial class SidebarItem : UserControl
    {
        public Image ItemIcon
        {
            get {
                return imgicon.Image;
            }
            set
            {
                imgicon.Image = value;
            }

        }

        public string ItemText
        {
            get
            {
                return lblmenu.Text;
            }
            set
            {
                lblmenu.Text = value;
            }
        }

        public String ItemTextNotfy
        {
            get
            {
                return lblnoti.Text;
            }
            set
            {
                if (value == "" || value == null)
                {
                    lblnoti.Visible = false;
                    lblnoti.Text = value;
                }
                else
                {
                    lblnoti.Visible = true;
                    lblnoti.Text = value;
                }
            }

         
    }
        public Font ItemTextFont { get => lblmenu.Font; set => lblmenu.Font = value; }
        public Font ItemNotifyFont { get => lblnoti.Font; set => lblnoti.Font = value; }
        
        public SidebarItem()
        {
            InitializeComponent();
        }

        private void imgicon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblmenu_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
