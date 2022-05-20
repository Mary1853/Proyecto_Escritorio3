namespace Proyecto_Escritorio3
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
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkRefrigeradora = new System.Windows.Forms.CheckBox();
            this.txtCocina = new System.Windows.Forms.TextBox();
            this.txtTelevisor = new System.Windows.Forms.TextBox();
            this.txtRefrigeradora = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(164, 61);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(71, 20);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(164, 88);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(86, 20);
            this.chkTelevisor.TabIndex = 1;
            this.chkTelevisor.Text = "Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkRefrigeradora
            // 
            this.chkRefrigeradora.AutoSize = true;
            this.chkRefrigeradora.Location = new System.Drawing.Point(164, 115);
            this.chkRefrigeradora.Name = "chkRefrigeradora";
            this.chkRefrigeradora.Size = new System.Drawing.Size(113, 20);
            this.chkRefrigeradora.TabIndex = 2;
            this.chkRefrigeradora.Text = "Refrigeradora";
            this.chkRefrigeradora.UseVisualStyleBackColor = true;
            // 
            // txtCocina
            // 
            this.txtCocina.Location = new System.Drawing.Point(275, 61);
            this.txtCocina.Name = "txtCocina";
            this.txtCocina.Size = new System.Drawing.Size(100, 22);
            this.txtCocina.TabIndex = 3;
            // 
            // txtTelevisor
            // 
            this.txtTelevisor.Location = new System.Drawing.Point(275, 90);
            this.txtTelevisor.Name = "txtTelevisor";
            this.txtTelevisor.Size = new System.Drawing.Size(100, 22);
            this.txtTelevisor.TabIndex = 4;
            // 
            // txtRefrigeradora
            // 
            this.txtRefrigeradora.Location = new System.Drawing.Point(275, 119);
            this.txtRefrigeradora.Name = "txtRefrigeradora";
            this.txtRefrigeradora.Size = new System.Drawing.Size(100, 22);
            this.txtRefrigeradora.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(472, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(275, 158);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 22);
            this.txtResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRefrigeradora);
            this.Controls.Add(this.txtTelevisor);
            this.Controls.Add(this.txtCocina);
            this.Controls.Add(this.chkRefrigeradora);
            this.Controls.Add(this.chkTelevisor);
            this.Controls.Add(this.chkCocina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkRefrigeradora;
        private System.Windows.Forms.TextBox txtCocina;
        private System.Windows.Forms.TextBox txtTelevisor;
        private System.Windows.Forms.TextBox txtRefrigeradora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

