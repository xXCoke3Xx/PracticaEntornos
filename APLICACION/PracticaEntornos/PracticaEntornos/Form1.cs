using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEntornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:/PracticaEntornosJorges/facultades.txt"))
            {
                MessageBox.Show("Fichero ya existe");
            }
            else
            {
                /** Creacion del fichero que contendra todas las facultades */
                FileStream fs = File.Create("C:/PracticaEntornosJorges/facultades.txt");
                fs.Close();
                StreamWriter sw;
                sw = File.CreateText("C:/PracticaEntornosJorges/facultades.txt");
                sw.WriteLine("Medicina");
                sw.WriteLine("Biologia");
                sw.WriteLine("Farmacia");
                sw.WriteLine("Veterinaria");
                sw.WriteLine("Matemáticas");
                sw.WriteLine("Físicas");
                sw.WriteLine("Químicas");
                sw.WriteLine("Telecomunicaciones");
                sw.WriteLine("Informatica");
                sw.WriteLine("Caminos");
                sw.WriteLine("Naval");
                sw.Close();

                /** Creamos los directorios de cada facultad*/
                cDirectorios();

                for (int i = 0; i < 11; i++)
                {
                    if (i == 0)
                    {
                        cSubficheros("Medicina");
                    }
                    else if (i == 1)
                    {
                        cSubficheros("Biologia");
                    }
                    else if (i == 2)
                    {
                        cSubficheros("Farmacia");
                    }
                    else if (i == 3)
                    {
                        cSubficheros("Veterinaria");
                    }
                    else if (i == 4)
                    {
                        cSubficheros("Matematicas");
                    }
                    else if (i == 5)
                    {
                        cSubficheros("Fisicas");
                    }
                    else if (i == 6)
                    {
                        cSubficheros("Quimicas");
                    }
                    else if (i == 7)
                    {
                        cSubficheros("Telecomunicaciones");
                    }
                    else if (i == 8)
                    {
                        cSubficheros("Informatica");
                    }
                    else if (i == 9)
                    {
                        cSubficheros("Caminos");
                    }
                    else if (i == 10)
                    {
                        cSubficheros("Naval");
                    }
                }
            }
        }

        public void cDirectorios()
        {
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Medicina");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Biologia");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Farmacia");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Veterinaria");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Matematicas");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Fisicas");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Quimicas");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Telecomunicaciones");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Informatica");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Caminos");
            Directory.CreateDirectory("C:/PracticaEntornosJorges/Naval");
        }

        public void cSubficheros(String _fac)
        {
            FileStream fs = File.Create("C:/PracticaEntornosJorges/" + _fac + "/asignaturas.txt");
            fs.Close();
            FileStream fs1 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/profesores.txt");
            fs1.Close();
            FileStream fs2 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/alumnos.txt");
            fs2.Close();
            FileStream fs3 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/solicitudMatricula.txt");
            fs3.Close();
            FileStream fs4 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/notas.txt");
            fs4.Close();
            FileStream fs5 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/cursos.txt");
            fs5.Close();
            FileStream fs6 = File.Create("C:/PracticaEntornosJorges/" + _fac + "/nominas.txt");
            fs6.Close();
        }
    }
}
