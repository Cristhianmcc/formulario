namespace formulario.vista.ElementosUI
{
    partial class SidebarItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SidebarItem));
            this.imgicon = new System.Windows.Forms.PictureBox();
            this.lblmenu = new System.Windows.Forms.Label();
            this.lblnoti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgicon)).BeginInit();
            this.SuspendLayout();
            // 
            // imgicon
            // 
            this.imgicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgicon.Image = ((System.Drawing.Image)(resources.GetObject("imgicon.Image")));
            this.imgicon.Location = new System.Drawing.Point(12, 14);
            this.imgicon.Name = "imgicon";
            this.imgicon.Size = new System.Drawing.Size(40, 75);
            this.imgicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgicon.TabIndex = 0;
            this.imgicon.TabStop = false;
            this.imgicon.Click += new System.EventHandler(this.imgicon_Click);
            // 
            // lblmenu
            // 
            this.lblmenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmenu.Location = new System.Drawing.Point(58, 14);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(161, 75);
            this.lblmenu.TabIndex = 1;
            this.lblmenu.Text = "label1";
            this.lblmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblmenu.Click += new System.EventHandler(this.lblmenu_Click);
            // 
            // lblnoti
            // 
            this.lblnoti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnoti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblnoti.Location = new System.Drawing.Point(225, 14);
            this.lblnoti.Name = "lblnoti";
            this.lblnoti.Size = new System.Drawing.Size(97, 75);
            this.lblnoti.TabIndex = 2;
            this.lblnoti.Text = "hola";
            this.lblnoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SidebarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblnoti);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.imgicon);
            this.Name = "SidebarItem";
            this.Size = new System.Drawing.Size(325, 101);
            ((System.ComponentModel.ISupportInitialize)(this.imgicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgicon;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Label lblnoti;
    }
}
