namespace PAV
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpsGestionCateg = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpsGestionCurs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpcGestionObjet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSoporte,
            this.MenuOperaciones,
            this.MenuReportes,
            this.MenuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuSoporte
            // 
            this.MenuSoporte.Name = "MenuSoporte";
            this.MenuSoporte.Size = new System.Drawing.Size(60, 20);
            this.MenuSoporte.Text = "&Soporte";
            // 
            // MenuOperaciones
            // 
            this.MenuOperaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpsGestionCateg,
            this.MenuOpsGestionCurs,
            this.MenuOpcGestionObjet,
            this.MenuOpsSalir});
            this.MenuOperaciones.Name = "MenuOperaciones";
            this.MenuOperaciones.Size = new System.Drawing.Size(85, 20);
            this.MenuOperaciones.Text = "&Operaciones";
            // 
            // MenuOpsGestionCateg
            // 
            this.MenuOpsGestionCateg.Name = "MenuOpsGestionCateg";
            this.MenuOpsGestionCateg.Size = new System.Drawing.Size(183, 22);
            this.MenuOpsGestionCateg.Text = "Gestionar Categorias";
            this.MenuOpsGestionCateg.Click += new System.EventHandler(this.MenuOpsGestionCateg_Click);
            // 
            // MenuOpsGestionCurs
            // 
            this.MenuOpsGestionCurs.Name = "MenuOpsGestionCurs";
            this.MenuOpsGestionCurs.Size = new System.Drawing.Size(183, 22);
            this.MenuOpsGestionCurs.Text = "Gestionar Cursos";
            this.MenuOpsGestionCurs.Click += new System.EventHandler(this.MenuOpsGestionCurs_Click);
            // 
            // MenuOpcGestionObjet
            // 
            this.MenuOpcGestionObjet.Name = "MenuOpcGestionObjet";
            this.MenuOpcGestionObjet.Size = new System.Drawing.Size(183, 22);
            this.MenuOpcGestionObjet.Text = "Gestionar Objetivos";
            this.MenuOpcGestionObjet.Click += new System.EventHandler(this.MenuOpcGestionObjet_Click);
            // 
            // MenuOpsSalir
            // 
            this.MenuOpsSalir.Name = "MenuOpsSalir";
            this.MenuOpsSalir.Size = new System.Drawing.Size(183, 22);
            this.MenuOpsSalir.Text = "Salir";
            this.MenuOpsSalir.Click += new System.EventHandler(this.MenuOpsSalir_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(65, 20);
            this.MenuReportes.Text = "&Reportes";
            // 
            // MenuAyuda
            // 
            this.MenuAyuda.Name = "MenuAyuda";
            this.MenuAyuda.Size = new System.Drawing.Size(53, 20);
            this.MenuAyuda.Text = "&Ayuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 24);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem MenuOperaciones;
        private System.Windows.Forms.ToolStripMenuItem MenuSoporte;
        private System.Windows.Forms.ToolStripMenuItem MenuOpsGestionCateg;
        private System.Windows.Forms.ToolStripMenuItem MenuOpsGestionCurs;
        private System.Windows.Forms.ToolStripMenuItem MenuOpcGestionObjet;
        private System.Windows.Forms.ToolStripMenuItem MenuOpsSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripMenuItem MenuAyuda;
    }
}