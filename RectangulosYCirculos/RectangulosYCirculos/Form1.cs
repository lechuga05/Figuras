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
            figura_actual = TipoFigura.Circulo;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                Rectangulo r = new Rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);
            }
            if (MouseButtons.Left == e.Button)
            {
                Circulo c = new Circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figuras)
            {
                f.Dibuja(this);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
