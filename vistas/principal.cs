using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ares2._0
{
    public partial class principal : Form
    {
        private  OpenFileDialog ventana;
        private string ruta;
        public principal()
        {
            InitializeComponent();
        }

        private void archivo_Click(object sender, EventArgs e)

        {

            ventana = new OpenFileDialog();
            ventana.InitialDirectory = "C:\\Users\\Leonel\\Desktop";
            ventana.ShowDialog();       
            ruta = ventana.FileName;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Codigo para abrir y leer el archivo
                textBox1.Text = openFileDialog1.FileName;
            }

        }

        private void remaudio_Click(object sender, EventArgs e)
        {
            ffmpeg.enviarcmd($"ffmpeg -i {ruta} -c copy -an C:\\Users\\Leonel\\Desktop\\kata_sinaudio.mp4");
        }

        private void formato_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox2.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            ffmpeg.enviarcmd($"ffmpeg -i {ruta} C:\\Users\\Leonel\\Desktop\\nuevovideo{checkedButton.Text}");
        }

        private void resolucion_Click(object sender, EventArgs e)
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            ffmpeg.enviarcmd($"ffmpeg -i {ruta} -vf scale={checkedButton.Text} C:\\Users\\Leonel\\Desktop\\resolucioncambiada.mp4 -hide_banner");


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }               
    }
