namespace SimuladorFutbol2
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libertadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copaArgentinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amistosoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipoToolStripMenuItem,
            this.torneosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // torneosToolStripMenuItem
            // 
            this.torneosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligaToolStripMenuItem,
            this.libertadoresToolStripMenuItem,
            this.copaArgentinaToolStripMenuItem,
            this.amistosoToolStripMenuItem});
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            this.torneosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.torneosToolStripMenuItem.Text = "Torneos";
            // 
            // ligaToolStripMenuItem
            // 
            this.ligaToolStripMenuItem.Name = "ligaToolStripMenuItem";
            this.ligaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ligaToolStripMenuItem.Text = "Liga";
            // 
            // libertadoresToolStripMenuItem
            // 
            this.libertadoresToolStripMenuItem.Name = "libertadoresToolStripMenuItem";
            this.libertadoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.libertadoresToolStripMenuItem.Text = "Libertadores";
            // 
            // copaArgentinaToolStripMenuItem
            // 
            this.copaArgentinaToolStripMenuItem.Name = "copaArgentinaToolStripMenuItem";
            this.copaArgentinaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copaArgentinaToolStripMenuItem.Text = "PlayOff";
            // 
            // amistosoToolStripMenuItem
            // 
            this.amistosoToolStripMenuItem.Name = "amistosoToolStripMenuItem";
            this.amistosoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.amistosoToolStripMenuItem.Text = "Amistoso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 360);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libertadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copaArgentinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem amistosoToolStripMenuItem;
    }
}

