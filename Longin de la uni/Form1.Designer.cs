namespace Longin_de_la_uni
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Panel();
            this.lblSiguiente = new System.Windows.Forms.Label();
            this.lblAcceder = new System.Windows.Forms.Label();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblVacio = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.pbLlave = new System.Windows.Forms.PictureBox();
            this.lblTerminos = new System.Windows.Forms.LinkLabel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.lblCookies = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btnSiguiente.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLlave)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlPrincipal.Controls.Add(this.panel1);
            this.pnlPrincipal.Controls.Add(this.lblVacio);
            this.pnlPrincipal.Controls.Add(this.pnlInfo);
            this.pnlPrincipal.Controls.Add(this.pictureBox1);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Location = new System.Drawing.Point(290, 103);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(412, 362);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.lblAcceder);
            this.panel1.Controls.Add(this.lblBarra);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 111);
            this.panel1.TabIndex = 14;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(34, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "\"nombre.apellido@***.uni.edu.ni\"";
            this.txtCorreo.Size = new System.Drawing.Size(310, 20);
            this.txtCorreo.TabIndex = 12;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(182)))));
            this.btnSiguiente.Controls.Add(this.lblSiguiente);
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.ForeColor = System.Drawing.Color.Snow;
            this.btnSiguiente.Location = new System.Drawing.Point(278, 66);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(103, 31);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSiguiente_MouseClick);
            this.btnSiguiente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSiguiente_MouseDown);
            this.btnSiguiente.MouseEnter += new System.EventHandler(this.btnSiguiente_MouseEnter);
            this.btnSiguiente.MouseLeave += new System.EventHandler(this.btnSiguiente_MouseLeave);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.AutoSize = true;
            this.lblSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.505F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSiguiente.ForeColor = System.Drawing.Color.White;
            this.lblSiguiente.Location = new System.Drawing.Point(15, 5);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(73, 20);
            this.lblSiguiente.TabIndex = 8;
            this.lblSiguiente.Text = "Siguiente";
            this.lblSiguiente.Click += new System.EventHandler(this.label5_Click);
            this.lblSiguiente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSiguiente_MouseDown);
            this.lblSiguiente.MouseEnter += new System.EventHandler(this.btnSiguiente_MouseEnter);
            this.lblSiguiente.MouseLeave += new System.EventHandler(this.btnSiguiente_MouseLeave);
            // 
            // lblAcceder
            // 
            this.lblAcceder.AutoSize = true;
            this.lblAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAcceder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcceder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAcceder.Location = new System.Drawing.Point(34, 43);
            this.lblAcceder.Name = "lblAcceder";
            this.lblAcceder.Size = new System.Drawing.Size(199, 17);
            this.lblAcceder.TabIndex = 11;
            this.lblAcceder.Text = "¿No puede acceder a su cuenta?";
            this.lblAcceder.Click += new System.EventHandler(this.lblAcceder_Click);
            this.lblAcceder.MouseEnter += new System.EventHandler(this.lblAcceder_MouseEnter);
            this.lblAcceder.MouseLeave += new System.EventHandler(this.lblAcceder_MouseLeave);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.BackColor = System.Drawing.Color.White;
            this.lblBarra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBarra.Location = new System.Drawing.Point(34, 17);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(347, 15);
            this.lblBarra.TabIndex = 3;
            this.lblBarra.Text = "____________________________________________________________________\r\n";
            this.lblBarra.MouseEnter += new System.EventHandler(this.lblBarra_MouseEnter);
            this.lblBarra.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // lblVacio
            // 
            this.lblVacio.AutoSize = true;
            this.lblVacio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVacio.ForeColor = System.Drawing.Color.Red;
            this.lblVacio.Location = new System.Drawing.Point(34, 103);
            this.lblVacio.Name = "lblVacio";
            this.lblVacio.Size = new System.Drawing.Size(327, 40);
            this.lblVacio.TabIndex = 0;
            this.lblVacio.Text = "Escriba una dirección de correo electrónico, un \r\nnúmero de teléfono o un nombre " +
    "Skype válidos.";
            this.lblVacio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVacio.Visible = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Location = new System.Drawing.Point(0, 267);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(437, 131);
            this.pnlInfo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Universidad Nacional de Ingenieria - UNI Nic \r\ncorreo@nic.uni.edu.ni Teléfono: 22" +
    "784984";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Longin_de_la_uni.Properties.Resources.bannerlogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar sesión";
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.Color.White;
            this.pnlOpciones.Controls.Add(this.lblOpciones);
            this.pnlOpciones.Controls.Add(this.pbLlave);
            this.pnlOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlOpciones.Location = new System.Drawing.Point(290, 482);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(412, 56);
            this.pnlOpciones.TabIndex = 1;
            this.pnlOpciones.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseEnter);
            this.pnlOpciones.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblOpciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOpciones.Location = new System.Drawing.Point(73, 19);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(198, 20);
            this.lblOpciones.TabIndex = 1;
            this.lblOpciones.Text = "Opciones de inicio de sesión";
            this.lblOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLlave
            // 
            this.pbLlave.BackgroundImage = global::Longin_de_la_uni.Properties.Resources.llave;
            this.pbLlave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLlave.Location = new System.Drawing.Point(34, 13);
            this.pbLlave.Name = "pbLlave";
            this.pbLlave.Size = new System.Drawing.Size(33, 30);
            this.pbLlave.TabIndex = 0;
            this.pbLlave.TabStop = false;
            this.pbLlave.MouseEnter += new System.EventHandler(this.pnlOpciones_MouseLeave);
            this.pbLlave.MouseLeave += new System.EventHandler(this.pnlOpciones_MouseLeave);
            // 
            // lblTerminos
            // 
            this.lblTerminos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTerminos.AutoSize = true;
            this.lblTerminos.BackColor = System.Drawing.Color.Transparent;
            this.lblTerminos.Font = new System.Drawing.Font("Segoe UI", 7.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerminos.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblTerminos.LinkColor = System.Drawing.Color.White;
            this.lblTerminos.Location = new System.Drawing.Point(748, 6);
            this.lblTerminos.Name = "lblTerminos";
            this.lblTerminos.Size = new System.Drawing.Size(91, 13);
            this.lblTerminos.TabIndex = 2;
            this.lblTerminos.TabStop = true;
            this.lblTerminos.Text = "Términos de uso";
            this.lblTerminos.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTerminos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnl3
            // 
            this.pnl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl3.AutoSize = true;
            this.pnl3.BackColor = System.Drawing.Color.Transparent;
            this.pnl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl3.Location = new System.Drawing.Point(960, 2);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(33, 25);
            this.pnl3.TabIndex = 4;
            this.pnl3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl3_Paint);
            this.pnl3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl3_MouseClick);
            // 
            // lblCookies
            // 
            this.lblCookies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCookies.AutoSize = true;
            this.lblCookies.BackColor = System.Drawing.Color.Transparent;
            this.lblCookies.Font = new System.Drawing.Font("Segoe UI", 7.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCookies.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblCookies.LinkColor = System.Drawing.Color.White;
            this.lblCookies.Location = new System.Drawing.Point(845, 6);
            this.lblCookies.Name = "lblCookies";
            this.lblCookies.Size = new System.Drawing.Size(109, 13);
            this.lblCookies.TabIndex = 3;
            this.lblCookies.TabStop = true;
            this.lblCookies.Text = "Privacidad y cookies";
            this.lblCookies.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCookies.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblCookies);
            this.panel2.Controls.Add(this.lblTerminos);
            this.panel2.Controls.Add(this.pnl3);
            this.panel2.Location = new System.Drawing.Point(0, 613);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 30);
            this.panel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Longin_de_la_uni.Properties.Resources.fondoUni;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlPrincipal);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnSiguiente.ResumeLayout(false);
            this.btnSiguiente.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLlave)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlPrincipal;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblBarra;
        private Panel btnSiguiente;
        private Label lblSiguiente;
        private Label lblAcceder;
        private TextBox txtCorreo;
        private Panel pnlInfo;
        private Label label3;
        private Panel pnlOpciones;
        private PictureBox pbLlave;
        private Label lblOpciones;
        private Label lblVacio;
        private Panel panel1;
        private LinkLabel lblTerminos;
        private Panel pnl3;
        private LinkLabel lblCookies;
        private Panel panel2;
    }
}