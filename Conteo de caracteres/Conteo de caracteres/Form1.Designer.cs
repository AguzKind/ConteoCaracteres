namespace Conteo_de_caracteres
{
    partial class Form1
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
            this.txt_cuadro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tarea1 = new System.Windows.Forms.Button();
            this.btn_tarea2 = new System.Windows.Forms.Button();
            this.btn_tarea3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cuadro
            // 
            this.txt_cuadro.Location = new System.Drawing.Point(6, 19);
            this.txt_cuadro.Multiline = true;
            this.txt_cuadro.Name = "txt_cuadro";
            this.txt_cuadro.Size = new System.Drawing.Size(276, 139);
            this.txt_cuadro.TabIndex = 1;
            this.txt_cuadro.TextChanged += new System.EventHandler(this.txt_cuadro_TextChanged);
            this.txt_cuadro.DoubleClick += new System.EventHandler(this.txt_cuadro_DoubleClick);
            this.txt_cuadro.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_cuadro_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cuadro);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese el texto que desee:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btn_tarea3);
            this.groupBox2.Controls.Add(this.btn_tarea2);
            this.groupBox2.Controls.Add(this.btn_tarea1);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Que accion desea realizar?";
            // 
            // btn_tarea1
            // 
            this.btn_tarea1.Location = new System.Drawing.Point(7, 20);
            this.btn_tarea1.Name = "btn_tarea1";
            this.btn_tarea1.Size = new System.Drawing.Size(129, 31);
            this.btn_tarea1.TabIndex = 0;
            this.btn_tarea1.Text = "Contar caracteres y \'A\'";
            this.btn_tarea1.UseVisualStyleBackColor = true;
            this.btn_tarea1.Click += new System.EventHandler(this.btn_tarea1_Click);
            // 
            // btn_tarea2
            // 
            this.btn_tarea2.Location = new System.Drawing.Point(153, 20);
            this.btn_tarea2.Name = "btn_tarea2";
            this.btn_tarea2.Size = new System.Drawing.Size(129, 31);
            this.btn_tarea2.TabIndex = 1;
            this.btn_tarea2.Text = "Guardar Texto";
            this.btn_tarea2.UseVisualStyleBackColor = true;
            this.btn_tarea2.Click += new System.EventHandler(this.btn_tarea2_Click);
            // 
            // btn_tarea3
            // 
            this.btn_tarea3.Location = new System.Drawing.Point(7, 64);
            this.btn_tarea3.Name = "btn_tarea3";
            this.btn_tarea3.Size = new System.Drawing.Size(129, 31);
            this.btn_tarea3.TabIndex = 2;
            this.btn_tarea3.Text = "Contar total de Palabras";
            this.btn_tarea3.UseVisualStyleBackColor = true;
            this.btn_tarea3.Click += new System.EventHandler(this.btn_tarea3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Limpiar Texto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conteo de Caracteres";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cuadro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_tarea3;
        private System.Windows.Forms.Button btn_tarea2;
        private System.Windows.Forms.Button btn_tarea1;

    }
}

