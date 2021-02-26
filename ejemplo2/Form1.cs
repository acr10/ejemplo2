using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ejemplo2
{
    public partial class Form1 : Form
    {
        int x, y;
        int i;
        int i2;
        int i3;
        int rgb1;
        int rgb2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ciruculo");
            listBox1.Items.Add("Rectangulo");
        }
        private void Click()
        {



        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
          

          
            if (listBox1.SelectedIndex == 0)
                {
              
                for (i2 = 10; i2 <= 200; i2++)
                {
                    for(i3=0; i3 <= 150; i3+=50)
                    {

                        SolidBrush sb = new SolidBrush(Color.FromArgb(i3, i2, i2));
                        g.DrawEllipse(lapiz, x - 50, y - 50, i, i);
                        g.FillEllipse(sb, x - 50, y - 50, i, i);

                    }

                }

            }




            if ( listBox1.SelectedIndex == 1)
            {

                for (i2 = 10; i2 <= 200; i2++)
                {
                    for (i3 = 0; i3 <= 150; i3 += 50)
                    {
                        SolidBrush sb = new SolidBrush(Color.FromArgb(i2, i3, i2));
                        g.DrawRectangle(lapiz, x - 50, y - 50, i, i);
                        g.FillRectangle(sb, x - 50, y - 50, i, i);

                    }

                }

            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();

            // me incrementa la variable i 
            int count = i;
            count+=10;
            i = count;
            

        }
    }
}
