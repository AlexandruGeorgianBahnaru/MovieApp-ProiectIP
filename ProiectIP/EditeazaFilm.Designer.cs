
using System;
using System.Windows.Forms;

namespace ProiectIP
{
    partial class EditeazaFilm
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
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonEditeaza = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.labelEditeazaFilm = new System.Windows.Forms.Label();
            this.labelDenumireFilm = new System.Windows.Forms.Label();
            this.textBoxDenumireFilm = new System.Windows.Forms.TextBox();
            this.textBoxDurataFilm = new System.Windows.Forms.TextBox();
            this.textBoxDataFilm = new System.Windows.Forms.TextBox();
            this.labelDurataFilm = new System.Windows.Forms.Label();
            this.labelDataFilm = new System.Windows.Forms.Label();
            this.labelGenFilm = new System.Windows.Forms.Label();
            this.labelOraFilm = new System.Windows.Forms.Label();
            this.textBoxGenFilm = new System.Windows.Forms.TextBox();
            this.textBoxOraFilm = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Wheat;
            this.panelAbout.BackgroundImage = global::ProiectIP.Properties.Resources.about;
            this.panelAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAbout.Location = new System.Drawing.Point(996, 108);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(146, 95);
            this.panelAbout.TabIndex = 12;
            // 
            // buttonEditeaza
            // 
            this.buttonEditeaza.BackColor = System.Drawing.Color.Wheat;
            this.buttonEditeaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditeaza.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.buttonEditeaza.ForeColor = System.Drawing.Color.Maroon;
            this.buttonEditeaza.Location = new System.Drawing.Point(226, 651);
            this.buttonEditeaza.Name = "buttonEditeaza";
            this.buttonEditeaza.Size = new System.Drawing.Size(256, 57);
            this.buttonEditeaza.TabIndex = 33;
            this.buttonEditeaza.Text = "Editeaza";
            this.buttonEditeaza.UseVisualStyleBackColor = false;
            this.buttonEditeaza.Click += new System.EventHandler(this.buttonEditeaza_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelMenu.Controls.Add(this.panelDate);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(777, 898);
            this.panelMenu.TabIndex = 49;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDate.Controls.Add(this.labelEditeazaFilm);
            this.panelDate.Controls.Add(this.labelDenumireFilm);
            this.panelDate.Controls.Add(this.textBoxDenumireFilm);
            this.panelDate.Controls.Add(this.buttonEditeaza);
            this.panelDate.Controls.Add(this.textBoxDurataFilm);
            this.panelDate.Controls.Add(this.textBoxDataFilm);
            this.panelDate.Controls.Add(this.labelDurataFilm);
            this.panelDate.Controls.Add(this.labelDataFilm);
            this.panelDate.Controls.Add(this.labelGenFilm);
            this.panelDate.Controls.Add(this.labelOraFilm);
            this.panelDate.Controls.Add(this.textBoxGenFilm);
            this.panelDate.Controls.Add(this.textBoxOraFilm);
            this.panelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelDate.Location = new System.Drawing.Point(45, 72);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(728, 757);
            this.panelDate.TabIndex = 51;
            // 
            // labelEditeazaFilm
            // 
            this.labelEditeazaFilm.AutoSize = true;
            this.labelEditeazaFilm.BackColor = System.Drawing.Color.Wheat;
            this.labelEditeazaFilm.Font = new System.Drawing.Font("Constantia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditeazaFilm.ForeColor = System.Drawing.Color.Black;
            this.labelEditeazaFilm.Location = new System.Drawing.Point(216, 46);
            this.labelEditeazaFilm.Name = "labelEditeazaFilm";
            this.labelEditeazaFilm.Size = new System.Drawing.Size(294, 54);
            this.labelEditeazaFilm.TabIndex = 9;
            this.labelEditeazaFilm.Text = "Editează film";
            this.labelEditeazaFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDenumireFilm
            // 
            this.labelDenumireFilm.AutoSize = true;
            this.labelDenumireFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelDenumireFilm.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenumireFilm.Location = new System.Drawing.Point(99, 178);
            this.labelDenumireFilm.Name = "labelDenumireFilm";
            this.labelDenumireFilm.Size = new System.Drawing.Size(208, 37);
            this.labelDenumireFilm.TabIndex = 28;
            this.labelDenumireFilm.Text = "Denumire film";
            // 
            // textBoxDenumireFilm
            // 
            this.textBoxDenumireFilm.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDenumireFilm.Font = new System.Drawing.Font("Constantia", 12F);
            this.textBoxDenumireFilm.Location = new System.Drawing.Point(357, 175);
            this.textBoxDenumireFilm.Name = "textBoxDenumireFilm";
            this.textBoxDenumireFilm.Size = new System.Drawing.Size(298, 37);
            this.textBoxDenumireFilm.TabIndex = 27;
            // 
            // textBoxDurataFilm
            // 
            this.textBoxDurataFilm.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDurataFilm.Font = new System.Drawing.Font("Constantia", 12F);
            this.textBoxDurataFilm.Location = new System.Drawing.Point(357, 358);
            this.textBoxDurataFilm.Name = "textBoxDurataFilm";
            this.textBoxDurataFilm.Size = new System.Drawing.Size(298, 37);
            this.textBoxDurataFilm.TabIndex = 25;
            // 
            // textBoxDataFilm
            // 
            this.textBoxDataFilm.BackColor = System.Drawing.Color.Wheat;
            this.textBoxDataFilm.Font = new System.Drawing.Font("Constantia", 12F);
            this.textBoxDataFilm.Location = new System.Drawing.Point(357, 452);
            this.textBoxDataFilm.Name = "textBoxDataFilm";
            this.textBoxDataFilm.Size = new System.Drawing.Size(298, 37);
            this.textBoxDataFilm.TabIndex = 11;
            // 
            // labelDurataFilm
            // 
            this.labelDurataFilm.AutoSize = true;
            this.labelDurataFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelDurataFilm.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurataFilm.Location = new System.Drawing.Point(112, 369);
            this.labelDurataFilm.Name = "labelDurataFilm";
            this.labelDurataFilm.Size = new System.Drawing.Size(107, 37);
            this.labelDurataFilm.TabIndex = 23;
            this.labelDurataFilm.Text = "Durată";
            // 
            // labelDataFilm
            // 
            this.labelDataFilm.AutoSize = true;
            this.labelDataFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelDataFilm.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataFilm.Location = new System.Drawing.Point(112, 458);
            this.labelDataFilm.Name = "labelDataFilm";
            this.labelDataFilm.Size = new System.Drawing.Size(79, 37);
            this.labelDataFilm.TabIndex = 12;
            this.labelDataFilm.Text = "Data";
            // 
            // labelGenFilm
            // 
            this.labelGenFilm.AutoSize = true;
            this.labelGenFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelGenFilm.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenFilm.Location = new System.Drawing.Point(122, 266);
            this.labelGenFilm.Name = "labelGenFilm";
            this.labelGenFilm.Size = new System.Drawing.Size(69, 37);
            this.labelGenFilm.TabIndex = 22;
            this.labelGenFilm.Text = "Gen";
            // 
            // labelOraFilm
            // 
            this.labelOraFilm.AutoSize = true;
            this.labelOraFilm.BackColor = System.Drawing.Color.Transparent;
            this.labelOraFilm.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOraFilm.Location = new System.Drawing.Point(114, 543);
            this.labelOraFilm.Name = "labelOraFilm";
            this.labelOraFilm.Size = new System.Drawing.Size(66, 37);
            this.labelOraFilm.TabIndex = 13;
            this.labelOraFilm.Text = "Ora";
            // 
            // textBoxGenFilm
            // 
            this.textBoxGenFilm.BackColor = System.Drawing.Color.Wheat;
            this.textBoxGenFilm.Font = new System.Drawing.Font("Constantia", 12F);
            this.textBoxGenFilm.Location = new System.Drawing.Point(357, 266);
            this.textBoxGenFilm.Name = "textBoxGenFilm";
            this.textBoxGenFilm.Size = new System.Drawing.Size(298, 37);
            this.textBoxGenFilm.TabIndex = 21;
            // 
            // textBoxOraFilm
            // 
            this.textBoxOraFilm.BackColor = System.Drawing.Color.Wheat;
            this.textBoxOraFilm.Font = new System.Drawing.Font("Constantia", 12F);
            this.textBoxOraFilm.Location = new System.Drawing.Point(357, 542);
            this.textBoxOraFilm.Name = "textBoxOraFilm";
            this.textBoxOraFilm.Size = new System.Drawing.Size(298, 37);
            this.textBoxOraFilm.TabIndex = 17;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(1005, 735);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(146, 95);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseMnemonic = false;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.BackgroundImage = global::ProiectIP.Properties.Resources.help;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(1005, 632);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 95);
            this.panel1.TabIndex = 14;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(996, 209);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(146, 95);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseMnemonic = false;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Maroon;
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Controls.Add(this.buttonMini);
            this.panelNavigation.Controls.Add(this.buttonResize);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(777, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(401, 68);
            this.panelNavigation.TabIndex = 50;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Wheat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClose.Location = new System.Drawing.Point(316, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(51, 38);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.Wheat;
            this.buttonMini.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMini.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMini.Location = new System.Drawing.Point(228, 11);
            this.buttonMini.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(51, 38);
            this.buttonMini.TabIndex = 2;
            this.buttonMini.Text = "-";
            this.buttonMini.UseVisualStyleBackColor = false;
            this.buttonMini.Click += new System.EventHandler(this.buttonMini_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.Wheat;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResize.Location = new System.Drawing.Point(272, 11);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(51, 38);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = "O";
            this.buttonResize.UseVisualStyleBackColor = false;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // EditeazaFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 898);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.buttonAbout);
            this.Name = "EditeazaFilm";
            this.Text = "EditeazaFilm";
            this.panelMenu.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonEditeaza;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label labelEditeazaFilm;
        private System.Windows.Forms.Label labelDenumireFilm;
        private System.Windows.Forms.TextBox textBoxDenumireFilm;
        private System.Windows.Forms.TextBox textBoxDurataFilm;
        private System.Windows.Forms.TextBox textBoxDataFilm;
        private System.Windows.Forms.Label labelDurataFilm;
        private System.Windows.Forms.Label labelDataFilm;
        private System.Windows.Forms.Label labelGenFilm;
        private System.Windows.Forms.Label labelOraFilm;
        private System.Windows.Forms.TextBox textBoxGenFilm;
        private System.Windows.Forms.TextBox textBoxOraFilm;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonMini;
    }
}