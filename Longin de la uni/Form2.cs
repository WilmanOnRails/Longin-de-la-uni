using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Longin_de_la_uni
{
    public partial class Form2 : Form
    {
        private Rectangle formDimensions, rTerminos, rCookies, rPuntos, r2;

        private void Form2_Resize(object sender, EventArgs e)
        {
            infoChangeSize(r2, panel1);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            r2 = new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            formDimensions = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
        }

        private void infoChangeSize(Rectangle r, Control c)
        {
            float diffX = (float)(this.Width) / (float)(formDimensions.Width);
            float diffY = (float)(this.Height) / (float)(formDimensions.Height);

            int newX = (int)(r.Location.X * diffX);
            int newY = (int)(r.Location.Y * diffY);



            c.Location = new Point(newX, newY);


            newX = (int)(r.Width * diffX);
            newY = (int)(r.Height * diffY);
            c.Size = new Size(newX, newY);


        }

    }
}
