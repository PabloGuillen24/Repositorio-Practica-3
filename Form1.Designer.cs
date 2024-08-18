namespace Practica03
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
            this.gradosC = new System.Windows.Forms.TextBox();
            this.gradosF = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cafahren = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gradosC
            // 
            this.gradosC.Location = new System.Drawing.Point(197, 118);
            this.gradosC.Name = "gradosC";
            this.gradosC.Size = new System.Drawing.Size(100, 20);
            this.gradosC.TabIndex = 0;
            this.gradosC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gradosF
            // 
            this.gradosF.Location = new System.Drawing.Point(524, 118);
            this.gradosF.Name = "gradosF";
            this.gradosF.Size = new System.Drawing.Size(100, 20);
            this.gradosF.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Celsius <--  Fahrenheit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cafahren
            // 
            this.cafahren.Location = new System.Drawing.Point(349, 167);
            this.cafahren.Name = "cafahren";
            this.cafahren.Size = new System.Drawing.Size(126, 23);
            this.cafahren.TabIndex = 3;
            this.cafahren.Text = "Celsius --> Fahrenheit";
            this.cafahren.UseVisualStyleBackColor = true;
            this.cafahren.Click += new System.EventHandler(this.cafahren_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(372, 216);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(75, 23);
            this.clear_button.TabIndex = 4;
            this.clear_button.Text = "Limpiar";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Convertidor de Grados Fahrenheit y Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grados Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grados Fahrenheit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.cafahren);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gradosF);
            this.Controls.Add(this.gradosC);
            this.Name = "Form1";
            this.Text = "Practica 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gradosC;
        private System.Windows.Forms.TextBox gradosF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cafahren;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

