namespace IAPEJ
{
    partial class mostrarMaestro
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fecha_nac = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.profesion = new System.Windows.Forms.Label();
            this.lugar_nac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(261, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Maestro";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblHora.Location = new System.Drawing.Point(543, 22);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(43, 17);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label2";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.lblFecha.Location = new System.Drawing.Point(607, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.nombre.Location = new System.Drawing.Point(303, 85);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(54, 21);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "label4";
            this.nombre.Click += new System.EventHandler(this.nombre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(39, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(155, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(121, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Profesión";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(371, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Lugar de Nacimiento";
            // 
            // fecha_nac
            // 
            this.fecha_nac.AutoSize = true;
            this.fecha_nac.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nac.ForeColor = System.Drawing.Color.Black;
            this.fecha_nac.Location = new System.Drawing.Point(214, 155);
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.Size = new System.Drawing.Size(43, 17);
            this.fecha_nac.TabIndex = 8;
            this.fecha_nac.Text = "label8";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.ForeColor = System.Drawing.Color.Black;
            this.sexo.Location = new System.Drawing.Point(214, 188);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(43, 17);
            this.sexo.TabIndex = 9;
            this.sexo.Text = "label9";
            // 
            // profesion
            // 
            this.profesion.AutoSize = true;
            this.profesion.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profesion.ForeColor = System.Drawing.Color.Black;
            this.profesion.Location = new System.Drawing.Point(214, 225);
            this.profesion.Name = "profesion";
            this.profesion.Size = new System.Drawing.Size(51, 17);
            this.profesion.TabIndex = 10;
            this.profesion.Text = "label10";
            // 
            // lugar_nac
            // 
            this.lugar_nac.AutoSize = true;
            this.lugar_nac.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lugar_nac.ForeColor = System.Drawing.Color.Black;
            this.lugar_nac.Location = new System.Drawing.Point(535, 149);
            this.lugar_nac.Name = "lugar_nac";
            this.lugar_nac.Size = new System.Drawing.Size(51, 17);
            this.lugar_nac.TabIndex = 11;
            this.lugar_nac.Text = "label11";
            // 
            // mostrarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lugar_nac);
            this.Controls.Add(this.profesion);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.fecha_nac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Name = "mostrarMaestro";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label fecha_nac;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label profesion;
        private System.Windows.Forms.Label lugar_nac;
    }
}