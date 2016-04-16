using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        List<Figura> figuras;
        enum TipoFigura { Rectangulo, Circulo };
        private TipoFigura figura_actual;
        public Form1()
        {

            figuras = new List<Figura>();
            InitializeComponent();
            circuloToolStripMenuItem.Checked = true;
            figura_actual = TipoFigura.Circulo;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                contextMenuStrip1.Show(this, e.X, e.Y);
            }
            if (MouseButtons.Left == e.Button && circuloToolStripMenuItem.Checked == true)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);
            }
            else if (MouseButtons.Left == e.Button && rectanguloToolStripMenuItem.Checked == true)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figuras)
            {
                f.Dibuja(this);

            }
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circuloToolStripMenuItem.Checked = true;
            rectanguloToolStripMenuItem.Checked = false;
            
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectanguloToolStripMenuItem.Checked = true;
            circuloToolStripMenuItem.Checked = false;
            
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
