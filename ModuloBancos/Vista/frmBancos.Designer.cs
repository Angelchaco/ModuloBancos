
namespace Vista
{
    partial class frmBancos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herraminetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasInteligentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasInteligentesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.estadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.consultarCuentaToolStripMenuItem,
            this.transferenciaToolStripMenuItem,
            this.disponibilidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaGeneralToolStripMenuItem,
            this.herraminetasToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // ayudaGeneralToolStripMenuItem
            // 
            this.ayudaGeneralToolStripMenuItem.Name = "ayudaGeneralToolStripMenuItem";
            this.ayudaGeneralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ayudaGeneralToolStripMenuItem.Text = "Ayuda General";
            // 
            // herraminetasToolStripMenuItem
            // 
            this.herraminetasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasInteligentesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.herraminetasToolStripMenuItem.Name = "herraminetasToolStripMenuItem";
            this.herraminetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.herraminetasToolStripMenuItem.Text = "Herraminetas";
            // 
            // consultasInteligentesToolStripMenuItem
            // 
            this.consultasInteligentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasInteligentesToolStripMenuItem1,
            this.menuConsultasToolStripMenuItem});
            this.consultasInteligentesToolStripMenuItem.Name = "consultasInteligentesToolStripMenuItem";
            this.consultasInteligentesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultasInteligentesToolStripMenuItem.Text = "Consultas Inteligentes";
            // 
            // consultasInteligentesToolStripMenuItem1
            // 
            this.consultasInteligentesToolStripMenuItem1.Name = "consultasInteligentesToolStripMenuItem1";
            this.consultasInteligentesToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.consultasInteligentesToolStripMenuItem1.Text = "Consultas Inteligentes";
            this.consultasInteligentesToolStripMenuItem1.Click += new System.EventHandler(this.consultasInteligentesToolStripMenuItem1_Click);
            // 
            // menuConsultasToolStripMenuItem
            // 
            this.menuConsultasToolStripMenuItem.Name = "menuConsultasToolStripMenuItem";
            this.menuConsultasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.menuConsultasToolStripMenuItem.Text = "Menu Consultas";
            this.menuConsultasToolStripMenuItem.Click += new System.EventHandler(this.menuConsultasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultarCuentaToolStripMenuItem
            // 
            this.consultarCuentaToolStripMenuItem.Name = "consultarCuentaToolStripMenuItem";
            this.consultarCuentaToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.consultarCuentaToolStripMenuItem.Text = "Consultar Cuenta";
            // 
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.transferenciaToolStripMenuItem.Text = "Transferencia";
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoDeCuentaToolStripMenuItem,
            this.divisaToolStripMenuItem});
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(742, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(58, 20);
            this.txtUsuario.TabIndex = 32;
            // 
            // estadoDeCuentaToolStripMenuItem
            // 
            this.estadoDeCuentaToolStripMenuItem.Name = "estadoDeCuentaToolStripMenuItem";
            this.estadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoDeCuentaToolStripMenuItem.Text = "Estado de Cuenta ";
            // 
            // divisaToolStripMenuItem
            // 
            this.divisaToolStripMenuItem.Name = "divisaToolStripMenuItem";
            this.divisaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divisaToolStripMenuItem.Text = "Divisa";
            // 
            // frmBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBancos";
            this.Text = "6001 Bancos";
            this.Load += new System.EventHandler(this.frmBancos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herraminetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasInteligentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasInteligentesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem estadoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisaToolStripMenuItem;
    }
}