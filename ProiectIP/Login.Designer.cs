
using System.Drawing;

namespace ProiectIP
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.labelParola = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.buttonInregistrare = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Wheat;
            this.panelAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelAbout.BackgroundImage")));
            this.panelAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAbout.Location = new System.Drawing.Point(1008, 119);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(145, 95);
            this.panelAbout.TabIndex = 12;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Maroon;
            this.buttonLogin.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonLogin.Location = new System.Drawing.Point(248, 444);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(256, 72);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Constantia", 20F);
            this.labelEmail.Location = new System.Drawing.Point(132, 248);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(135, 49);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.Wheat;
            this.textBoxEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(280, 255);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(324, 41);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.Color.Wheat;
            this.textBoxParola.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(280, 371);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(324, 41);
            this.textBoxParola.TabIndex = 4;
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.Transparent;
            this.labelParola.Font = new System.Drawing.Font("Constantia", 20F);
            this.labelParola.Location = new System.Drawing.Point(148, 371);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(130, 49);
            this.labelParola.TabIndex = 3;
            this.labelParola.Text = "Parolă";
            this.labelParola.Click += new System.EventHandler(this.labelParola_Click);
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.Wheat;
            this.labelTitlu.Font = new System.Drawing.Font("Constantia", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTitlu.ForeColor = System.Drawing.Color.Black;
            this.labelTitlu.Location = new System.Drawing.Point(144, 49);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(490, 111);
            this.labelTitlu.TabIndex = 9;
            this.labelTitlu.Text = "Rezervare online bilete la cinema \r\n\r\nLogin\r\n";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInregistrare
            // 
            this.buttonInregistrare.BackColor = System.Drawing.Color.White;
            this.buttonInregistrare.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrare.Location = new System.Drawing.Point(248, 519);
            this.buttonInregistrare.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonInregistrare.Name = "buttonInregistrare";
            this.buttonInregistrare.Size = new System.Drawing.Size(256, 61);
            this.buttonInregistrare.TabIndex = 10;
            this.buttonInregistrare.Text = "Înregistrare";
            this.buttonInregistrare.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.panelDate);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(781, 899);
            this.panelMenu.TabIndex = 13;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDate.Controls.Add(this.pictureBox1);
            this.panelDate.Controls.Add(this.textBoxParola);
            this.panelDate.Controls.Add(this.labelTitlu);
            this.panelDate.Controls.Add(this.buttonLogin);
            this.panelDate.Controls.Add(this.labelEmail);
            this.panelDate.Controls.Add(this.textBoxEmail);
            this.panelDate.Controls.Add(this.buttonInregistrare);
            this.panelDate.Controls.Add(this.labelParola);
            this.panelDate.Controls.Add(this.pictureBoxUser);
            this.panelDate.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.panelDate.ForeColor = System.Drawing.Color.Black;
            this.panelDate.Location = new System.Drawing.Point(48, 148);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(701, 588);
            this.panelDate.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
           this.pictureBox1.BackgroundImage = global::ProiectIP.Properties.Resources.cheie;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(26, 371);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 65);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.BackgroundImage = global::ProiectIP.Properties.Resources.user;
            this.pictureBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUser.Location = new System.Drawing.Point(26, 248);
            this.pictureBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(130, 65);
            this.pictureBoxUser.TabIndex = 11;
            this.pictureBoxUser.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(1008, 771);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(145, 61);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseMnemonic = false;
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BackgroundImage = global::ProiectIP.Properties.Resources.help;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1008, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 99);
            this.panel1.TabIndex = 14;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(1008, 226);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(145, 61);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseMnemonic = false;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Maroon;
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavigation.Controls.Add(this.buttonMini);
            this.panelNavigation.Controls.Add(this.buttonResize);
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1178, 83);
            this.panelNavigation.TabIndex = 14;
            this.panelNavigation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNavigation_Paint);
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.Wheat;
            this.buttonMini.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMini.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMini.Location = new System.Drawing.Point(971, 14);
            this.buttonMini.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(48, 39);
            this.buttonMini.TabIndex = 2;
            this.buttonMini.Text = "-";
            this.buttonMini.UseVisualStyleBackColor = false;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.Wheat;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResize.Location = new System.Drawing.Point(1020, 14);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(48, 39);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = "O";
            this.buttonResize.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Wheat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClose.Location = new System.Drawing.Point(1070, 14);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(48, 39);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 899);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Login";
            this.Text = "Sistem de rezervari bilete cinema";
            this.TransparencyKey = this.BackColor;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button buttonInregistrare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

