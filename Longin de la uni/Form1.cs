using System.Diagnostics;

namespace Longin_de_la_uni
{
    public partial class Form1 : Form
    {
        private bool isPressed;
        private int numClicks, n;
        private String PassWord, Correo;
        private Rectangle formDimensions, rTerminos,rCookies,rPuntos,r2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            centrar(0, false);
            PassWord = "123";
            Correo = "correoEjemplo";
            this.ActiveControl = label1;
            label1.Focus();
            formDimensions = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            rTerminos = new Rectangle(lblTerminos.Location.X, lblTerminos.Location.Y, lblTerminos.Width, lblTerminos.Height);
            rCookies = new Rectangle(lblCookies.Location.X, lblCookies.Location.Y, lblCookies.Width, lblCookies.Height);
            //rPuntos = new Rectangle(pnl3.Location.X, pnl3.Location.Y, pnl3.Width, pnl3.Height);
        }

        private void btnSiguiente_MouseClick(object sender, EventArgs e)
        {
            switch (VerifyEmail())
            {
                case 0:
                    EmptyText();
                    break;
                case 1:
                    NoMatch();
                    break;
                case 2:
                    String pass = txtCorreo.Text;
                    MessageBox.Show("Estas dentro del Sistema!");
                    break;
                default:
                    break;
            }
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            if (!lblVacio.Visible)
                lblBarra.ForeColor = SystemColors.HotTrack;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            btnSiguiente_MouseClick(sender, e);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            String x = txtCorreo.Text;
            bool check = false;
            String[] casos = { "@", "@s", "@st", "@std", "@std." };

            foreach (String i in casos)
                if (x.EndsWith(i))
                {
                    check = true;
                    break;
                }

            if (check)
                EmptyText();
            else if (!check)
            {
                backToNormalSize();
                lblVacio.Visible = false;
                lblBarra.ForeColor = SystemColors.HotTrack;
            }
        }

        public void centrar(int extraSize, bool pnlReSize)
        {
            int alturaF = this.Height;
            int anchoF = this.Width;

            int alturaPanelP = pnlPrincipal.Height;
            int anchoPanelP = pnlPrincipal.Width;

            int nuevaAlturaPl = (alturaF - alturaPanelP - 26) / 2;
            int nuevaAnchoPl = (anchoF - anchoPanelP - 16) / 2;

            pnlPrincipal.Location = new Point(nuevaAnchoPl, nuevaAlturaPl);
            if (numClicks == 0)
                pnlOpciones.Location = new Point(nuevaAnchoPl, nuevaAlturaPl + 380 + extraSize);

            else if (pnlReSize)
                pnlOpciones.Location = new Point(nuevaAnchoPl, nuevaAlturaPl + 380 + extraSize);
            else
                pnlOpciones.Location = new Point(nuevaAnchoPl, nuevaAlturaPl + 380);

        }

        private void btnSiguiente_MouseLeave(object sender, EventArgs e)
        {
            btnSiguiente.BackColor = Color.FromArgb(14, 104, 182);
            lblSiguiente.ForeColor = Color.White;
            if (isPressed)
            {
                BtnNormalSize();
                isPressed = false;
            }
        }

        private void lblAcceder_MouseLeave(object sender, EventArgs e)
        {
            lblAcceder.Font = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAcceder.ForeColor = SystemColors.HotTrack;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (numClicks == 0)
            {
                centrar(0, false);
            }
            else
            {
                centrar(40, true);
            }

        }

        private void btnSiguiente_MouseEnter(object sender, EventArgs e)
        {
            btnSiguiente.BackColor = Color.FromArgb(0, 93, 166);
            //lblSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void NoMatch()
        {
            lblVacio.Visible = true;
            lblVacio.Text = "No se ha podido encontrar una cuenta con ese \r\nnombre de usuario.";
            lblBarra.ForeColor = Color.IndianRed;
            AjustSize();
        }

        private void EmptyText()
        {
            lblVacio.Visible = true;
            lblVacio.Text = "Escriba una dirección de correo electrónico, un \r\nnúmero de teléfono o un nombre " +
    "Skype válidos.";
            lblBarra.ForeColor = Color.IndianRed;
            AjustSize();
        }

        private void lblAcceder_MouseEnter(object sender, EventArgs e)
        {
            lblAcceder.Font = new Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblAcceder.ForeColor = Color.Gray;
        }

        private void lblBarra_MouseEnter(object sender, EventArgs e)
        {
            if (!lblVacio.Visible)
                lblBarra.ForeColor = Color.Black;
        }

        private void pnlOpciones_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones.BackColor = pnlInfo.BackColor;
            pbLlave.BackgroundImage = global::Longin_de_la_uni.Properties.Resources.llave_terminada;
        }

        private void pnlOpciones_MouseLeave(object sender, EventArgs e)
        {
            pbLlave.BackgroundImage = global::Longin_de_la_uni.Properties.Resources.llave;
            pnlOpciones.BackColor = Color.White;
        }

        private void lblAcceder_Click(object sender, EventArgs e)
        {
            var uri = "https://www.google.com";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pnlOpciones_MouseEnter(sender, e);
        }

        private int VerifyEmail()
        {
            if (String.IsNullOrWhiteSpace(txtCorreo.Text))
                return 0;
            else if (!txtCorreo.Text.Equals(Correo))
                return 1;
            else
                return 2;
        }

        private void AjustSize()
        {
            if (lblVacio.Visible && numClicks == 0)
            {
                int y = 40;
                int Y_pnl1 = panel1.Location.Y;
                int Y_pnlInfo = pnlInfo.Location.Y;

                int AnpanelPr = pnlPrincipal.Width;
                int AlpanelPr = pnlPrincipal.Height;
                pnlPrincipal.Size = new Size(AnpanelPr, AlpanelPr + y);

                panel1.Location = new Point(0, Y_pnl1 + y);
                pnlInfo.Location = new Point(0, Y_pnlInfo + y);

                centrar(y, false);
                numClicks++;
            }
        }

        private void backToNormalSize()
        {
            if (lblVacio.Visible)
            {
                int y = 40;
                int Y_pnl1 = panel1.Location.Y;
                int Y_pnlInfo = pnlInfo.Location.Y;

                int AnpanelPr = pnlPrincipal.Width;
                int AlpanelPr = pnlPrincipal.Height;
                pnlPrincipal.Size = new Size(AnpanelPr, AlpanelPr - y);

                panel1.Location = new Point(0, Y_pnl1 - y);
                pnlInfo.Location = new Point(0, Y_pnlInfo - y);

                centrar(y, false);
                numClicks = 0;
            }
        }

        private void ChangeBtnSize()
        {
            btnSiguiente.Size = new Size(btnSiguiente.Width - 4, btnSiguiente.Height - 2);
            btnSiguiente.Location = new Point(btnSiguiente.Location.X + 2, btnSiguiente.Location.Y + 1);
            lblSiguiente.Location = new Point(lblSiguiente.Location.X - 2, lblSiguiente.Location.Y - 1);
        }

        private void btnSiguiente_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!isPressed)
                ChangeBtnSize();
            isPressed = true;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://www.microsoft.com/es-ES/servicesagreement/";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

            //infoChangeSize(rTerminos, lblTerminos);
            //infoChangeSize(rCookies, lblCookies);
            //infoChangeSize(rPuntos,pnl3);
            //infoChangeSize(r2, panel2);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "https://privacy.microsoft.com/es-ES/privacystatement";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            Process.Start(psi);
        }

        private void pnl3_Paint(object sender, PaintEventArgs e)
        {
            //borrar
        }

        private void pnl3_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void BtnNormalSize()
        {
            btnSiguiente.Size = new Size(btnSiguiente.Width + 4, btnSiguiente.Height + 2);
            btnSiguiente.Location = new Point(btnSiguiente.Location.X - 2, btnSiguiente.Location.Y - 1);
            lblSiguiente.Location = new Point(lblSiguiente.Location.X + 2, lblSiguiente.Location.Y + 1);
        }

        private void infoChangeSize(Rectangle r, Control c)
        {
            float diffX = (float)(this.Width) / (float)(formDimensions.Width);
            float diffY = (float)(this.Height) / (float)(formDimensions.Height);

            int newX = (int)(r.Location.X * diffX);
            //int newY = (int)(r.Location.Y * diffY);



            c.Location = new Point(newX, c.Location.Y);


            //newX = (int)(r.Width * diffX);
            //newY = (int)(r.Height * diffY);
            //c.Size = new Size(newX, newY);
            
            
        }
    }
}