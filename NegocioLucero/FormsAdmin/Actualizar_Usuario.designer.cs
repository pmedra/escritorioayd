namespace NegocioLucero.FormsAdmin
{
    partial class Actualizar_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textonombre = new System.Windows.Forms.TextBox();
            this.textoestado = new System.Windows.Forms.TextBox();
            this.textotipo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textocontra = new System.Windows.Forms.TextBox();
            this.textocontra2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de usuario:";
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(140, 37);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 3;
            // 
            // textoestado
            // 
            this.textoestado.Location = new System.Drawing.Point(140, 70);
            this.textoestado.Name = "textoestado";
            this.textoestado.Size = new System.Drawing.Size(100, 20);
            this.textoestado.TabIndex = 4;
            // 
            // textotipo
            // 
            this.textotipo.Location = new System.Drawing.Point(140, 107);
            this.textotipo.Name = "textotipo";
            this.textotipo.Size = new System.Drawing.Size(100, 20);
            this.textotipo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // textocontra
            // 
            this.textocontra.Location = new System.Drawing.Point(140, 147);
            this.textocontra.Name = "textocontra";
            this.textocontra.PasswordChar = '*';
            this.textocontra.Size = new System.Drawing.Size(100, 20);
            this.textocontra.TabIndex = 9;
            // 
            // textocontra2
            // 
            this.textocontra2.Location = new System.Drawing.Point(140, 188);
            this.textocontra2.Name = "textocontra2";
            this.textocontra2.PasswordChar = '*';
            this.textocontra2.Size = new System.Drawing.Size(100, 20);
            this.textocontra2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "* Llenar unicamente los \r\ncampos a modificar";
            // 
            // Actualizar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(343, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textocontra2);
            this.Controls.Add(this.textocontra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textotipo);
            this.Controls.Add(this.textoestado);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Actualizar_Usuario";
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.Actualizar_Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.TextBox textoestado;
        private System.Windows.Forms.TextBox textotipo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textocontra;
        private System.Windows.Forms.TextBox textocontra2;
        private System.Windows.Forms.Label label6;
    }
}