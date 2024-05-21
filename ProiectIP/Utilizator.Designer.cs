﻿
namespace ProiectIP
{
    /// <summary>
    ///  Aceasta clasa implementeaza metodele accesibile de un utilizator
    /// </summary>
    partial class Utilizator
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
            this.dataGridViewUtilizator = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelDate = new System.Windows.Forms.Panel();
            this.labelFilme = new System.Windows.Forms.Label();
            this.buttonVeziRute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizator)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.Transparent;
            this.panelAbout.BackgroundImage = global::ProiectIP.Properties.Resources.about;
            this.panelAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelAbout.Location = new System.Drawing.Point(126, 372);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(90, 71);
            this.panelAbout.TabIndex = 12;
            // 
            // dataGridViewUtilizator
            // 
            this.dataGridViewUtilizator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilizator.Location = new System.Drawing.Point(69, 131);
            this.dataGridViewUtilizator.Name = "dataGridViewUtilizator";
            this.dataGridViewUtilizator.RowHeadersWidth = 62;
            this.dataGridViewUtilizator.RowTemplate.Height = 28;
            this.dataGridViewUtilizator.Size = new System.Drawing.Size(834, 474);
            this.dataGridViewUtilizator.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSize = true;
            this.panelMenu.BackColor = System.Drawing.Color.Maroon;
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.panelAbout);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(336, 897);
            this.panelMenu.TabIndex = 30;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(70, 662);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(200, 62);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseMnemonic = false;
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProiectIP.Properties.Resources.help;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(126, 574);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 98);
            this.panel1.TabIndex = 14;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(70, 451);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(200, 62);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseMnemonic = false;
            this.buttonAbout.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::ProiectIP.Properties.Resources.movie;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(0, 72);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(332, 186);
            this.panelLogo.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Maroon;
            this.panelNavigation.Controls.Add(this.buttonMini);
            this.panelNavigation.Controls.Add(this.buttonResize);
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(336, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(1128, 68);
            this.panelNavigation.TabIndex = 31;
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.Maroon;
            this.buttonMini.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMini.ForeColor = System.Drawing.Color.White;
            this.buttonMini.Location = new System.Drawing.Point(970, 14);
            this.buttonMini.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(45, 46);
            this.buttonMini.TabIndex = 2;
            this.buttonMini.Text = "-";
            this.buttonMini.UseVisualStyleBackColor = false;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.Maroon;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.ForeColor = System.Drawing.Color.White;
            this.buttonResize.Location = new System.Drawing.Point(1020, 14);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(45, 46);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = "O";
            this.buttonResize.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Maroon;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1070, 14);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 46);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.White;
            this.panelDate.Controls.Add(this.labelFilme);
            this.panelDate.Controls.Add(this.buttonVeziRute);
            this.panelDate.Controls.Add(this.dataGridViewUtilizator);
            this.panelDate.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.panelDate.Location = new System.Drawing.Point(417, 100);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(968, 734);
            this.panelDate.TabIndex = 32;
            // 
            // labelFilme
            // 
            this.labelFilme.AutoSize = true;
            this.labelFilme.BackColor = System.Drawing.Color.Transparent;
            this.labelFilme.Font = new System.Drawing.Font("Constantia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilme.ForeColor = System.Drawing.Color.Black;
            this.labelFilme.Location = new System.Drawing.Point(411, 35);
            this.labelFilme.Name = "labelFilme";
            this.labelFilme.Size = new System.Drawing.Size(139, 54);
            this.labelFilme.TabIndex = 9;
            this.labelFilme.Text = "Filme";
            this.labelFilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVeziRute
            // 
            this.buttonVeziRute.BackColor = System.Drawing.Color.Maroon;
            this.buttonVeziRute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVeziRute.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVeziRute.ForeColor = System.Drawing.Color.White;
            this.buttonVeziRute.Location = new System.Drawing.Point(369, 637);
            this.buttonVeziRute.Name = "buttonVeziRute";
            this.buttonVeziRute.Size = new System.Drawing.Size(256, 57);
            this.buttonVeziRute.TabIndex = 6;
            this.buttonVeziRute.Text = "Vezi filme";
            this.buttonVeziRute.UseVisualStyleBackColor = false;
            // 
            // Utilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 897);
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelMenu);
            this.Name = "Utilizator";
            this.Text = "Utilizator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilizator)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewUtilizator;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.Panel panelDate;
        public System.Windows.Forms.Label labelFilme;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Button buttonVeziRute;
    }
}