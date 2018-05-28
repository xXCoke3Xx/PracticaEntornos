namespace PracticaEntornos
{
    partial class Form_AñAlumnos
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.Location = new System.Drawing.Point(12, 12);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(116, 21);
            this.lblSeleccione.TabIndex = 2;
            this.lblSeleccione.Text = "Sleccione una facultad";
            this.lblSeleccione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_AñAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 490);
            this.Controls.Add(this.lblSeleccione);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form_AñAlumnos";
            this.Text = "Form_AñAlumnos";
            this.Load += new System.EventHandler(this.Form_AñAlumnos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSeleccione;
    }
}