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
            this.itemAñadir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnAsignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnNominas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAnMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.itemModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoAsignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoNominas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMoMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElAsignaturas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElNominas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElProfesores = new System.Windows.Forms.ToolStripMenuItem();
            this.itemElMatricula = new System.Windows.Forms.ToolStripMenuItem();
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
            this.item2Editar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAñadir,
            this.itemModificar,
            this.itemEliminar});
            this.item2Editar.Name = "item2Editar";
            this.item2Editar.Size = new System.Drawing.Size(49, 20);
            this.item2Editar.Text = "Editar";
            // 
            // itemAñadir
            // 
            this.itemAñadir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAnAlumnos,
            this.itemAnAsignaturas,
            this.itemAnCursos,
            this.itemAnNominas,
            this.itemAnNotas,
            this.itemAnProfesores,
            this.itemAnMatricula});
            this.itemAñadir.Name = "itemAñadir";
            this.itemAñadir.Size = new System.Drawing.Size(152, 22);
            this.itemAñadir.Text = "Añadir";
            // 
            // itemAnAlumnos
            // 
            this.itemAnAlumnos.Name = "itemAnAlumnos";
            this.itemAnAlumnos.Size = new System.Drawing.Size(189, 22);
            this.itemAnAlumnos.Text = "Alumnos";
            this.itemAnAlumnos.Click += new System.EventHandler(this.itemAnAlumnos_Click);
            // 
            // itemAnAsignaturas
            // 
            this.itemAnAsignaturas.Name = "itemAnAsignaturas";
            this.itemAnAsignaturas.Size = new System.Drawing.Size(189, 22);
            this.itemAnAsignaturas.Text = "Asignaturas";
            this.itemAnAsignaturas.Click += new System.EventHandler(this.itemAnAsignaturas_Click);
            // 
            // itemAnCursos
            // 
            this.itemAnCursos.Name = "itemAnCursos";
            this.itemAnCursos.Size = new System.Drawing.Size(189, 22);
            this.itemAnCursos.Text = "Cursos";
            this.itemAnCursos.Click += new System.EventHandler(this.itemAnCursos_Click);
            // 
            // itemAnNominas
            // 
            this.itemAnNominas.Name = "itemAnNominas";
            this.itemAnNominas.Size = new System.Drawing.Size(189, 22);
            this.itemAnNominas.Text = "Nominas";
            this.itemAnNominas.Click += new System.EventHandler(this.itemAnNominas_Click);
            // 
            // itemAnNotas
            // 
            this.itemAnNotas.Name = "itemAnNotas";
            this.itemAnNotas.Size = new System.Drawing.Size(189, 22);
            this.itemAnNotas.Text = "Notas";
            this.itemAnNotas.Click += new System.EventHandler(this.itemAnNotas_Click);
            // 
            // itemAnProfesores
            // 
            this.itemAnProfesores.Name = "itemAnProfesores";
            this.itemAnProfesores.Size = new System.Drawing.Size(189, 22);
            this.itemAnProfesores.Text = "Profesores";
            this.itemAnProfesores.Click += new System.EventHandler(this.itemAnProfesores_Click);
            // 
            // itemAnMatricula
            // 
            this.itemAnMatricula.Name = "itemAnMatricula";
            this.itemAnMatricula.Size = new System.Drawing.Size(189, 22);
            this.itemAnMatricula.Text = "Solicitud de matricula";
            this.itemAnMatricula.Click += new System.EventHandler(this.itemAnMatricula_Click);
            // 
            // itemModificar
            // 
            this.itemModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMoAlumnos,
            this.itemMoAsignaturas,
            this.itemMoCursos,
            this.itemMoNominas,
            this.itemMoNotas,
            this.itemMoProfesores,
            this.itemMoMatricula});
            this.itemModificar.Name = "itemModificar";
            this.itemModificar.Size = new System.Drawing.Size(152, 22);
            this.itemModificar.Text = "Modificar";
            // 
            // itemMoAlumnos
            // 
            this.itemMoAlumnos.Name = "itemMoAlumnos";
            this.itemMoAlumnos.Size = new System.Drawing.Size(189, 22);
            this.itemMoAlumnos.Text = "Alumnos";
            this.itemMoAlumnos.Click += new System.EventHandler(this.itemMoAlumnos_Click);
            // 
            // itemMoAsignaturas
            // 
            this.itemMoAsignaturas.Name = "itemMoAsignaturas";
            this.itemMoAsignaturas.Size = new System.Drawing.Size(189, 22);
            this.itemMoAsignaturas.Text = "Asignaturas";
            this.itemMoAsignaturas.Click += new System.EventHandler(this.itemMoAsignaturas_Click);
            // 
            // itemMoCursos
            // 
            this.itemMoCursos.Name = "itemMoCursos";
            this.itemMoCursos.Size = new System.Drawing.Size(189, 22);
            this.itemMoCursos.Text = "Cursos";
            this.itemMoCursos.Click += new System.EventHandler(this.itemMoCursos_Click);
            // 
            // itemMoNominas
            // 
            this.itemMoNominas.Name = "itemMoNominas";
            this.itemMoNominas.Size = new System.Drawing.Size(189, 22);
            this.itemMoNominas.Text = "Nominas";
            this.itemMoNominas.Click += new System.EventHandler(this.itemMoNominas_Click);
            // 
            // itemMoNotas
            // 
            this.itemMoNotas.Name = "itemMoNotas";
            this.itemMoNotas.Size = new System.Drawing.Size(189, 22);
            this.itemMoNotas.Text = "Notas";
            this.itemMoNotas.Click += new System.EventHandler(this.itemMoNotas_Click);
            // 
            // itemMoProfesores
            // 
            this.itemMoProfesores.Name = "itemMoProfesores";
            this.itemMoProfesores.Size = new System.Drawing.Size(189, 22);
            this.itemMoProfesores.Text = "Profesores";
            this.itemMoProfesores.Click += new System.EventHandler(this.itemMoProfesores_Click);
            // 
            // itemMoMatricula
            // 
            this.itemMoMatricula.Name = "itemMoMatricula";
            this.itemMoMatricula.Size = new System.Drawing.Size(189, 22);
            this.itemMoMatricula.Text = "Solicitud de matricula";
            this.itemMoMatricula.Click += new System.EventHandler(this.itemMoMatricula_Click);
            // 
            // itemEliminar
            // 
            this.itemEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemElAlumnos,
            this.itemElAsignaturas,
            this.itemElCursos,
            this.itemElNominas,
            this.itemElNotas,
            this.itemElProfesores,
            this.itemElMatricula});
            this.itemEliminar.Name = "itemEliminar";
            this.itemEliminar.Size = new System.Drawing.Size(152, 22);
            this.itemEliminar.Text = "Eliminar";
            // 
            // itemElAlumnos
            // 
            this.itemElAlumnos.Name = "itemElAlumnos";
            this.itemElAlumnos.Size = new System.Drawing.Size(189, 22);
            this.itemElAlumnos.Text = "Alumnos";
            this.itemElAlumnos.Click += new System.EventHandler(this.itemElAlumnos_Click);
            // 
            // itemElAsignaturas
            // 
            this.itemElAsignaturas.Name = "itemElAsignaturas";
            this.itemElAsignaturas.Size = new System.Drawing.Size(189, 22);
            this.itemElAsignaturas.Text = "Asignaturas";
            this.itemElAsignaturas.Click += new System.EventHandler(this.itemElAsignaturas_Click);
            // 
            // itemElCursos
            // 
            this.itemElCursos.Name = "itemElCursos";
            this.itemElCursos.Size = new System.Drawing.Size(189, 22);
            this.itemElCursos.Text = "Cursos";
            this.itemElCursos.Click += new System.EventHandler(this.itemElCursos_Click);
            // 
            // itemElNominas
            // 
            this.itemElNominas.Name = "itemElNominas";
            this.itemElNominas.Size = new System.Drawing.Size(189, 22);
            this.itemElNominas.Text = "Nominas";
            this.itemElNominas.Click += new System.EventHandler(this.itemElNominas_Click);
            // 
            // itemElNotas
            // 
            this.itemElNotas.Name = "itemElNotas";
            this.itemElNotas.Size = new System.Drawing.Size(189, 22);
            this.itemElNotas.Text = "Notas";
            this.itemElNotas.Click += new System.EventHandler(this.itemElNotas_Click);
            // 
            // itemElProfesores
            // 
            this.itemElProfesores.Name = "itemElProfesores";
            this.itemElProfesores.Size = new System.Drawing.Size(189, 22);
            this.itemElProfesores.Text = "Profesores";
            this.itemElProfesores.Click += new System.EventHandler(this.itemElProfesores_Click);
            // 
            // itemElMatricula
            // 
            this.itemElMatricula.Name = "itemElMatricula";
            this.itemElMatricula.Size = new System.Drawing.Size(189, 22);
            this.itemElMatricula.Text = "Solicitud de matricula";
            this.itemElMatricula.Click += new System.EventHandler(this.itemElMatricula_Click);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem itemAñadir;
        private System.Windows.Forms.ToolStripMenuItem itemModificar;
        private System.Windows.Forms.ToolStripMenuItem itemEliminar;
        private System.Windows.Forms.ToolStripMenuItem itemAnAlumnos;
        private System.Windows.Forms.ToolStripMenuItem itemAnAsignaturas;
        private System.Windows.Forms.ToolStripMenuItem itemAnCursos;
        private System.Windows.Forms.ToolStripMenuItem itemAnNominas;
        private System.Windows.Forms.ToolStripMenuItem itemAnNotas;
        private System.Windows.Forms.ToolStripMenuItem itemAnProfesores;
        private System.Windows.Forms.ToolStripMenuItem itemAnMatricula;
        private System.Windows.Forms.ToolStripMenuItem itemMoAlumnos;
        private System.Windows.Forms.ToolStripMenuItem itemMoAsignaturas;
        private System.Windows.Forms.ToolStripMenuItem itemMoCursos;
        private System.Windows.Forms.ToolStripMenuItem itemMoNominas;
        private System.Windows.Forms.ToolStripMenuItem itemMoNotas;
        private System.Windows.Forms.ToolStripMenuItem itemMoProfesores;
        private System.Windows.Forms.ToolStripMenuItem itemMoMatricula;
        private System.Windows.Forms.ToolStripMenuItem itemElAlumnos;
        private System.Windows.Forms.ToolStripMenuItem itemElAsignaturas;
        private System.Windows.Forms.ToolStripMenuItem itemElCursos;
        private System.Windows.Forms.ToolStripMenuItem itemElNominas;
        private System.Windows.Forms.ToolStripMenuItem itemElNotas;
        private System.Windows.Forms.ToolStripMenuItem itemElProfesores;
        private System.Windows.Forms.ToolStripMenuItem itemElMatricula;
    }
}

