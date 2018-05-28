namespace PracticaEntornos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item1Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.item2Editar = new System.Windows.Forms.ToolStripMenuItem();
            this.item3Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1Archivo,
            this.item2Editar,
            this.item3Ver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item1Archivo
            // 
            this.item1Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSalir});
            this.item1Archivo.Name = "item1Archivo";
            this.item1Archivo.Size = new System.Drawing.Size(60, 20);
            this.item1Archivo.Text = "Archivo";
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(96, 22);
            this.itemSalir.Text = "Salir";
            // 
            // item2Editar
            // 
            this.item2Editar.Name = "item2Editar";
            this.item2Editar.Size = new System.Drawing.Size(49, 20);
            this.item2Editar.Text = "Editar";
            // 
            // item3Ver
            // 
            this.item3Ver.Name = "item3Ver";
            this.item3Ver.Size = new System.Drawing.Size(36, 20);
            this.item3Ver.Text = "Ver";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 609);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gestion Universidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item1Archivo;
        private System.Windows.Forms.ToolStripMenuItem item2Editar;
        private System.Windows.Forms.ToolStripMenuItem item3Ver;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
    }
}

