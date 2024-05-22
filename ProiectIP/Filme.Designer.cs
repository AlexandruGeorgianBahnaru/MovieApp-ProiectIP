
using System;

namespace ProiectIP
{
    partial class Filme
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
            this.dataGridViewFilme = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.labelFilme = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonMini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilme)).BeginInit();
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
            this.panelAbout.Location = new System.Drawing.Point(1295, 78);
            this.panelAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(145, 95);
            this.panelAbout.TabIndex = 12;
            // 
            // dataGridViewFilme
            // 
            this.dataGridViewFilme.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilme.Location = new System.Drawing.Point(63, 140);
            this.dataGridViewFilme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFilme.Name = "dataGridViewFilme";
            this.dataGridViewFilme.RowHeadersWidth = 62;
            this.dataGridViewFilme.RowTemplate.Height = 28;
            this.dataGridViewFilme.Size = new System.Drawing.Size(831, 499);
            this.dataGridViewFilme.TabIndex = 6;
            this.dataGridViewFilme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilme_CellContentClick);
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
            this.panelMenu.Size = new System.Drawing.Size(1027, 898);
            this.panelMenu.TabIndex = 30;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDate.Controls.Add(this.labelFilme);
            this.panelDate.Controls.Add(this.dataGridViewFilme);
            this.panelDate.Font = new System.Drawing.Font("Bell MT", 8.25F);
            this.panelDate.Location = new System.Drawing.Point(69, 111);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(954, 689);
            this.panelDate.TabIndex = 32;
            // 
            // labelFilme
            // 
            this.labelFilme.AutoSize = true;
            this.labelFilme.BackColor = System.Drawing.Color.Wheat;
            this.labelFilme.Font = new System.Drawing.Font("Constantia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilme.ForeColor = System.Drawing.Color.Black;
            this.labelFilme.Location = new System.Drawing.Point(415, 39);
            this.labelFilme.Name = "labelFilme";
            this.labelFilme.Size = new System.Drawing.Size(139, 54);
            this.labelFilme.TabIndex = 9;
            this.labelFilme.Text = "Filme";
            this.labelFilme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.Location = new System.Drawing.Point(1295, 760);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(145, 95);
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
            this.panel1.Location = new System.Drawing.Point(1295, 658);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 95);
            this.panel1.TabIndex = 14;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(1295, 180);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(145, 95);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseMnemonic = false;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click_1);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Maroon;
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Controls.Add(this.buttonResize);
            this.panelNavigation.Controls.Add(this.buttonMini);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(1027, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(437, 68);
            this.panelNavigation.TabIndex = 31;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Wheat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClose.Location = new System.Drawing.Point(361, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 39);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.Wheat;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResize.Location = new System.Drawing.Point(313, 11);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(49, 39);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = "O";
            this.buttonResize.UseVisualStyleBackColor = false;
            // 
            // buttonMini
            // 
            this.buttonMini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMini.BackColor = System.Drawing.Color.Wheat;
            this.buttonMini.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMini.ForeColor = System.Drawing.Color.Maroon;
            this.buttonMini.Location = new System.Drawing.Point(264, 11);
            this.buttonMini.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(49, 39);
            this.buttonMini.TabIndex = 2;
            this.buttonMini.Text = "-";
            this.buttonMini.UseVisualStyleBackColor = false;
            // 
            // Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1464, 898);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAbout);
            this.Controls.Add(this.buttonAbout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Filme";
            this.Text = "Filme";
            this.Load += new System.EventHandler(this.Filme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilme)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilme;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label labelFilme;
        private System.Windows.Forms.Panel panelAbout;
    }
}