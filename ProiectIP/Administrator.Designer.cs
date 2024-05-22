
namespace ProiectIP
{
    partial class Administrator
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
            this.buttonEditeazaFilm = new System.Windows.Forms.Button();
            this.buttonFilmeAdmin = new System.Windows.Forms.Button();
            this.buttonStergeFilm = new System.Windows.Forms.Button();
            this.buttonAdaugaFilmAdmin = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDate = new System.Windows.Forms.Panel();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonDelogareAdmin = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonMini = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditeazaFilm
            // 
            this.buttonEditeazaFilm.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditeazaFilm.Location = new System.Drawing.Point(1338, 288);
            this.buttonEditeazaFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditeazaFilm.Name = "buttonEditeazaFilm";
            this.buttonEditeazaFilm.Size = new System.Drawing.Size(199, 62);
            this.buttonEditeazaFilm.TabIndex = 0;
            this.buttonEditeazaFilm.Text = "Editează film";
            this.buttonEditeazaFilm.UseVisualStyleBackColor = true;
            // 
            // buttonFilmeAdmin
            // 
            this.buttonFilmeAdmin.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilmeAdmin.Location = new System.Drawing.Point(1338, 531);
            this.buttonFilmeAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilmeAdmin.Name = "buttonFilmeAdmin";
            this.buttonFilmeAdmin.Size = new System.Drawing.Size(199, 62);
            this.buttonFilmeAdmin.TabIndex = 1;
            this.buttonFilmeAdmin.Text = "Vezi filme";
            this.buttonFilmeAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonStergeFilm
            // 
            this.buttonStergeFilm.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeFilm.Location = new System.Drawing.Point(1338, 410);
            this.buttonStergeFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStergeFilm.Name = "buttonStergeFilm";
            this.buttonStergeFilm.Size = new System.Drawing.Size(199, 62);
            this.buttonStergeFilm.TabIndex = 2;
            this.buttonStergeFilm.Text = "Șterge film";
            this.buttonStergeFilm.UseVisualStyleBackColor = true;
            // 
            // buttonAdaugaFilmAdmin
            // 
            this.buttonAdaugaFilmAdmin.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaFilmAdmin.Location = new System.Drawing.Point(1338, 172);
            this.buttonAdaugaFilmAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdaugaFilmAdmin.Name = "buttonAdaugaFilmAdmin";
            this.buttonAdaugaFilmAdmin.Size = new System.Drawing.Size(199, 62);
            this.buttonAdaugaFilmAdmin.TabIndex = 3;
            this.buttonAdaugaFilmAdmin.Text = "Adaugă film";
            this.buttonAdaugaFilmAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(39, 115);
            this.dataGridViewAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowHeadersVisible = false;
            this.dataGridViewAdmin.RowHeadersWidth = 62;
            this.dataGridViewAdmin.RowTemplate.Height = 28;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(836, 438);
            this.dataGridViewAdmin.TabIndex = 4;
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
            this.panelMenu.Size = new System.Drawing.Size(934, 898);
            this.panelMenu.TabIndex = 14;
            // 
            // panelDate
            // 
            this.panelDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDate.Controls.Add(this.labelAdmin);
            this.panelDate.Controls.Add(this.dataGridViewAdmin);
            this.panelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelDate.Location = new System.Drawing.Point(29, 172);
            this.panelDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(901, 590);
            this.panelDate.TabIndex = 16;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.BackColor = System.Drawing.Color.Wheat;
            this.labelAdmin.Font = new System.Drawing.Font("Constantia", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.ForeColor = System.Drawing.Color.Black;
            this.labelAdmin.Location = new System.Drawing.Point(299, 32);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(316, 54);
            this.labelAdmin.TabIndex = 9;
            this.labelAdmin.Text = "Administrator";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDelogareAdmin
            // 
            this.buttonDelogareAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelogareAdmin.Location = new System.Drawing.Point(1338, 666);
            this.buttonDelogareAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelogareAdmin.Name = "buttonDelogareAdmin";
            this.buttonDelogareAdmin.Size = new System.Drawing.Size(199, 59);
            this.buttonDelogareAdmin.TabIndex = 4;
            this.buttonDelogareAdmin.Text = "Delogare";
            this.buttonDelogareAdmin.UseVisualStyleBackColor = true;
            this.buttonDelogareAdmin.Click += new System.EventHandler(this.buttonDelogareAdmin_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.Maroon;
            this.panelNavigation.Controls.Add(this.buttonResize);
            this.panelNavigation.Controls.Add(this.buttonMini);
            this.panelNavigation.Controls.Add(this.buttonClose);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavigation.Location = new System.Drawing.Point(934, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(644, 68);
            this.panelNavigation.TabIndex = 15;
            // 
            // buttonResize
            // 
            this.buttonResize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResize.BackColor = System.Drawing.Color.Wheat;
            this.buttonResize.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResize.ForeColor = System.Drawing.Color.Maroon;
            this.buttonResize.Location = new System.Drawing.Point(510, 11);
            this.buttonResize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(48, 39);
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
            this.buttonMini.Location = new System.Drawing.Point(461, 11);
            this.buttonMini.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMini.Name = "buttonMini";
            this.buttonMini.Size = new System.Drawing.Size(48, 39);
            this.buttonMini.TabIndex = 2;
            this.buttonMini.Text = "-";
            this.buttonMini.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Wheat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Maroon;
            this.buttonClose.Location = new System.Drawing.Point(554, 11);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(48, 39);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.cinema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 898);
            this.Controls.Add(this.buttonDelogareAdmin);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.buttonAdaugaFilmAdmin);
            this.Controls.Add(this.buttonFilmeAdmin);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonStergeFilm);
            this.Controls.Add(this.buttonEditeazaFilm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditeazaFilm;
        private System.Windows.Forms.Button buttonFilmeAdmin;
        private System.Windows.Forms.Button buttonStergeFilm;
        private System.Windows.Forms.Button buttonAdaugaFilmAdmin;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonMini;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonDelogareAdmin;
    }
}