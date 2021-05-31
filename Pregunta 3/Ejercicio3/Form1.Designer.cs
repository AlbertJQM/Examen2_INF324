namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReconocer = new System.Windows.Forms.Button();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.picColorProm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picPaletaL = new System.Windows.Forms.PictureBox();
            this.picPaletaT = new System.Windows.Forms.PictureBox();
            this.picPaletaV = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picModificado = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorProm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "EJERCICIO 3";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(46, 53);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(71, 40);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir Imagen";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(139, 42);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(19, 13);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "R:";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(164, 39);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(45, 20);
            this.txtR.TabIndex = 5;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(164, 65);
            this.txtG.Name = "txtG";
            this.txtG.ReadOnly = true;
            this.txtG.Size = new System.Drawing.Size(45, 20);
            this.txtG.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(164, 91);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(45, 20);
            this.txtB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B:";
            // 
            // picColor
            // 
            this.picColor.Location = new System.Drawing.Point(236, 65);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(40, 40);
            this.picColor.TabIndex = 10;
            this.picColor.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color:";
            // 
            // btnReconocer
            // 
            this.btnReconocer.Location = new System.Drawing.Point(388, 38);
            this.btnReconocer.Name = "btnReconocer";
            this.btnReconocer.Size = new System.Drawing.Size(87, 23);
            this.btnReconocer.TabIndex = 12;
            this.btnReconocer.Text = "Reconocer";
            this.btnReconocer.UseVisualStyleBackColor = true;
            this.btnReconocer.Click += new System.EventHandler(this.btnReconocer_Click);
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Location = new System.Drawing.Point(388, 67);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(87, 23);
            this.btnRestablecer.TabIndex = 14;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Color Prom:";
            // 
            // picColorProm
            // 
            this.picColorProm.Location = new System.Drawing.Point(293, 65);
            this.picColorProm.Name = "picColorProm";
            this.picColorProm.Size = new System.Drawing.Size(40, 40);
            this.picColorProm.TabIndex = 16;
            this.picColorProm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.picPaletaL);
            this.panel1.Controls.Add(this.picPaletaT);
            this.panel1.Controls.Add(this.picPaletaV);
            this.panel1.Location = new System.Drawing.Point(46, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 97);
            this.panel1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tierra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Lago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Vegetal";
            // 
            // picPaletaL
            // 
            this.picPaletaL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaletaL.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPaletaL.Location = new System.Drawing.Point(307, 33);
            this.picPaletaL.Name = "picPaletaL";
            this.picPaletaL.Size = new System.Drawing.Size(261, 55);
            this.picPaletaL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaletaL.TabIndex = 18;
            this.picPaletaL.TabStop = false;
            this.picPaletaL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaL_MouseClick);
            // 
            // picPaletaT
            // 
            this.picPaletaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaletaT.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPaletaT.Location = new System.Drawing.Point(17, 33);
            this.picPaletaT.Name = "picPaletaT";
            this.picPaletaT.Size = new System.Drawing.Size(261, 55);
            this.picPaletaT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaletaT.TabIndex = 17;
            this.picPaletaT.TabStop = false;
            this.picPaletaT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaT_MouseClick);
            // 
            // picPaletaV
            // 
            this.picPaletaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaletaV.Cursor = System.Windows.Forms.Cursors.Default;
            this.picPaletaV.Location = new System.Drawing.Point(596, 33);
            this.picPaletaV.Name = "picPaletaV";
            this.picPaletaV.Size = new System.Drawing.Size(261, 55);
            this.picPaletaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPaletaV.TabIndex = 16;
            this.picPaletaV.TabStop = false;
            this.picPaletaV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picPaletaV_MouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.picImagen);
            this.panel2.Location = new System.Drawing.Point(12, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 361);
            this.panel2.TabIndex = 19;
            // 
            // picImagen
            // 
            this.picImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagen.Location = new System.Drawing.Point(5, 4);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(496, 354);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagen.TabIndex = 1;
            this.picImagen.TabStop = false;
            this.picImagen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImagen_MouseClick_1);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.picModificado);
            this.panel3.Location = new System.Drawing.Point(531, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 361);
            this.panel3.TabIndex = 20;
            // 
            // picModificado
            // 
            this.picModificado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picModificado.Location = new System.Drawing.Point(3, 4);
            this.picModificado.Name = "picModificado";
            this.picModificado.Size = new System.Drawing.Size(434, 354);
            this.picModificado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picModificado.TabIndex = 1;
            this.picModificado.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(545, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(63, 20);
            this.textBox2.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(520, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 609);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picColorProm);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.btnReconocer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColorProm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaletaV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picModificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReconocer;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picColorProm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPaletaV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picModificado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picPaletaL;
        private System.Windows.Forms.PictureBox picPaletaT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

    }
}

