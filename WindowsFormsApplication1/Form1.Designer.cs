namespace WindowsFormsApplication1
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.hipotenusa = new System.Windows.Forms.Button();
            this.vocales = new System.Windows.Forms.Button();
            this.inversor = new System.Windows.Forms.Button();
            this.regla3 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(101, 30);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(137, 20);
            this.input1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input2:";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(101, 65);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(137, 20);
            this.input2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input3:";
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(101, 100);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(137, 20);
            this.input3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(101, 251);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(116, 20);
            this.resultado.TabIndex = 7;
            // 
            // hipotenusa
            // 
            this.hipotenusa.Location = new System.Drawing.Point(101, 139);
            this.hipotenusa.Name = "hipotenusa";
            this.hipotenusa.Size = new System.Drawing.Size(89, 32);
            this.hipotenusa.TabIndex = 8;
            this.hipotenusa.Text = "Hipotenusa";
            this.hipotenusa.UseVisualStyleBackColor = true;
            this.hipotenusa.Click += new System.EventHandler(this.hipotenusa_Click);
            // 
            // vocales
            // 
            this.vocales.Location = new System.Drawing.Point(196, 139);
            this.vocales.Name = "vocales";
            this.vocales.Size = new System.Drawing.Size(89, 32);
            this.vocales.TabIndex = 9;
            this.vocales.Text = "Vocales";
            this.vocales.UseVisualStyleBackColor = true;
            this.vocales.Click += new System.EventHandler(this.vocales_Click);
            // 
            // inversor
            // 
            this.inversor.Location = new System.Drawing.Point(101, 177);
            this.inversor.Name = "inversor";
            this.inversor.Size = new System.Drawing.Size(89, 32);
            this.inversor.TabIndex = 10;
            this.inversor.Text = "Invertir";
            this.inversor.UseVisualStyleBackColor = true;
            this.inversor.Click += new System.EventHandler(this.inversor_Click);
            // 
            // regla3
            // 
            this.regla3.Location = new System.Drawing.Point(196, 177);
            this.regla3.Name = "regla3";
            this.regla3.Size = new System.Drawing.Size(89, 32);
            this.regla3.TabIndex = 11;
            this.regla3.Text = "Regla de 3";
            this.regla3.UseVisualStyleBackColor = true;
            this.regla3.Click += new System.EventHandler(this.regla3_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(37, 220);
            this.error.MaximumSize = new System.Drawing.Size(248, 30);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 293);
            this.Controls.Add(this.error);
            this.Controls.Add(this.regla3);
            this.Controls.Add(this.inversor);
            this.Controls.Add(this.vocales);
            this.Controls.Add(this.hipotenusa);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HT1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button hipotenusa;
        private System.Windows.Forms.Button vocales;
        private System.Windows.Forms.Button inversor;
        private System.Windows.Forms.Button regla3;
        private System.Windows.Forms.Label error;
    }
}

