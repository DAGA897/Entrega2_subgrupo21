namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.G_4 = new System.Windows.Forms.PictureBox();
            this.G_3 = new System.Windows.Forms.PictureBox();
            this.G_2 = new System.Windows.Forms.PictureBox();
            this.G_1 = new System.Windows.Forms.PictureBox();
            this.Points = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.G_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // G_4
            // 
            this.G_4.BackColor = System.Drawing.Color.Transparent;
            this.G_4.Image = global::WindowsFormsApp1.Properties.Resources.Globo2;
            this.G_4.Location = new System.Drawing.Point(67, 46);
            this.G_4.Name = "G_4";
            this.G_4.Size = new System.Drawing.Size(136, 152);
            this.G_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G_4.TabIndex = 4;
            this.G_4.TabStop = false;
            this.G_4.Click += new System.EventHandler(this.G_4_Click);
            // 
            // G_3
            // 
            this.G_3.BackColor = System.Drawing.Color.Transparent;
            this.G_3.Image = global::WindowsFormsApp1.Properties.Resources.Globo2;
            this.G_3.Location = new System.Drawing.Point(67, 260);
            this.G_3.Name = "G_3";
            this.G_3.Size = new System.Drawing.Size(136, 152);
            this.G_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G_3.TabIndex = 3;
            this.G_3.TabStop = false;
            this.G_3.Click += new System.EventHandler(this.G_3_Click);
            // 
            // G_2
            // 
            this.G_2.BackColor = System.Drawing.Color.Transparent;
            this.G_2.Image = global::WindowsFormsApp1.Properties.Resources.Globo2;
            this.G_2.Location = new System.Drawing.Point(332, 149);
            this.G_2.Name = "G_2";
            this.G_2.Size = new System.Drawing.Size(136, 152);
            this.G_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G_2.TabIndex = 2;
            this.G_2.TabStop = false;
            this.G_2.Click += new System.EventHandler(this.G_2_Click);
            // 
            // G_1
            // 
            this.G_1.BackColor = System.Drawing.Color.Transparent;
            this.G_1.Image = global::WindowsFormsApp1.Properties.Resources.Globo2;
            this.G_1.Location = new System.Drawing.Point(611, 119);
            this.G_1.Name = "G_1";
            this.G_1.Size = new System.Drawing.Size(136, 152);
            this.G_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.G_1.TabIndex = 1;
            this.G_1.TabStop = false;
            this.G_1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(660, 9);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(121, 31);
            this.Points.TabIndex = 5;
            this.Points.Text = "Points : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.G_4);
            this.Controls.Add(this.G_3);
            this.Controls.Add(this.G_2);
            this.Controls.Add(this.G_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.G_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox G_1;
        private System.Windows.Forms.PictureBox G_2;
        private System.Windows.Forms.PictureBox G_3;
        private System.Windows.Forms.PictureBox G_4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Points;
    }
}

