using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEntornos
{
    public partial class Form_AñAlumnos : Form
    {
        public Form_AñAlumnos()
        {
            InitializeComponent();
            comboBox2.Items.Add("Hola");
        }

        private void Form_AñAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
