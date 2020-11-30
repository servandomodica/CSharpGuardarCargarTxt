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

namespace Proyecto125filedialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grabarElArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter archivo = new StreamWriter(saveFileDialog1.FileName);
                archivo.Write(textBox1.Text);
                archivo.Close();
                MessageBox.Show("Los datos fueron grabados");
            }
        }

        private void recuperarElArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader archivo = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = archivo.ReadToEnd();
                archivo.Close();
            }
        }

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void cambiarColorDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog2.Color;
            }
        }
    }
}
