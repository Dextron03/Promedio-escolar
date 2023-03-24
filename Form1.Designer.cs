
namespace CalcularNota
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPnota = new System.Windows.Forms.Label();
            this.lblSnota = new System.Windows.Forms.Label();
            this.lblTnota = new System.Windows.Forms.Label();
            this.lblCnota = new System.Windows.Forms.Label();
            this.respuesta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblProRe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblPnota
            // 
            this.lblPnota.AutoSize = true;
            this.lblPnota.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPnota.Location = new System.Drawing.Point(65, 72);
            this.lblPnota.Name = "lblPnota";
            this.lblPnota.Size = new System.Drawing.Size(37, 14);
            this.lblPnota.TabIndex = 3;
            this.lblPnota.Text = "Nota";
            // 
            // lblSnota
            // 
            this.lblSnota.AutoSize = true;
            this.lblSnota.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSnota.Location = new System.Drawing.Point(65, 114);
            this.lblSnota.Name = "lblSnota";
            this.lblSnota.Size = new System.Drawing.Size(37, 14);
            this.lblSnota.TabIndex = 4;
            this.lblSnota.Text = "Nota";
            // 
            // lblTnota
            // 
            this.lblTnota.AutoSize = true;
            this.lblTnota.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTnota.Location = new System.Drawing.Point(233, 74);
            this.lblTnota.Name = "lblTnota";
            this.lblTnota.Size = new System.Drawing.Size(37, 14);
            this.lblTnota.TabIndex = 5;
            this.lblTnota.Text = "Nota";
            // 
            // lblCnota
            // 
            this.lblCnota.AutoSize = true;
            this.lblCnota.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCnota.Location = new System.Drawing.Point(233, 114);
            this.lblCnota.Name = "lblCnota";
            this.lblCnota.Size = new System.Drawing.Size(37, 14);
            this.lblCnota.TabIndex = 6;
            this.lblCnota.Text = "Nota";
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(65, 160);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(16, 15);
            this.respuesta.TabIndex = 7;
            this.respuesta.Text = "...";
            this.respuesta.Click += new System.EventHandler(this.respuesta_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(109, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(109, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(277, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(277, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblProRe
            // 
            this.lblProRe.AutoSize = true;
            this.lblProRe.Location = new System.Drawing.Point(65, 175);
            this.lblProRe.Name = "lblProRe";
            this.lblProRe.Size = new System.Drawing.Size(16, 15);
            this.lblProRe.TabIndex = 12;
            this.lblProRe.Text = "...";
            this.lblProRe.Click += new System.EventHandler(this.lblProRe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 332);
            this.Controls.Add(this.lblProRe);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.lblCnota);
            this.Controls.Add(this.lblTnota);
            this.Controls.Add(this.lblSnota);
            this.Controls.Add(this.lblPnota);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPnota;
        private System.Windows.Forms.Label lblSnota;
        private System.Windows.Forms.Label lblTnota;
        private System.Windows.Forms.Label lblCnota;
        private System.Windows.Forms.Label respuesta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblProRe;
    }
}

