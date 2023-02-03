namespace Ejercicio1_Iparcial
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
            this.label1 = new System.Windows.Forms.Label();
            this.ingresarnumtextBox1 = new System.Windows.Forms.TextBox();
            this.elnumeroestextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ejecutarbutton1 = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un numero:";
            // 
            // ingresarnumtextBox1
            // 
            this.ingresarnumtextBox1.Location = new System.Drawing.Point(179, 43);
            this.ingresarnumtextBox1.Name = "ingresarnumtextBox1";
            this.ingresarnumtextBox1.Size = new System.Drawing.Size(129, 20);
            this.ingresarnumtextBox1.TabIndex = 1;
            // 
            // elnumeroestextBox2
            // 
            this.elnumeroestextBox2.Location = new System.Drawing.Point(179, 199);
            this.elnumeroestextBox2.Name = "elnumeroestextBox2";
            this.elnumeroestextBox2.Size = new System.Drawing.Size(136, 20);
            this.elnumeroestextBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "El numero es";
            // 
            // ejecutarbutton1
            // 
            this.ejecutarbutton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.ejecutarbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarbutton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ejecutarbutton1.Location = new System.Drawing.Point(202, 109);
            this.ejecutarbutton1.Name = "ejecutarbutton1";
            this.ejecutarbutton1.Size = new System.Drawing.Size(89, 51);
            this.ejecutarbutton1.TabIndex = 4;
            this.ejecutarbutton1.Text = "Calcular";
            this.ejecutarbutton1.UseVisualStyleBackColor = true;
            this.ejecutarbutton1.Click += new System.EventHandler(this.ejecutarbutton1_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(202, 283);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(89, 41);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 401);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.ejecutarbutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elnumeroestextBox2);
            this.Controls.Add(this.ingresarnumtextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresarnumtextBox1;
        private System.Windows.Forms.TextBox elnumeroestextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ejecutarbutton1;
        private System.Windows.Forms.Button buttonLimpiar;
    }
}

