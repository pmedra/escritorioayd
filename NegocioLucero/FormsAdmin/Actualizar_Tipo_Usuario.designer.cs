namespace NegocioLucero.FormsAdmin
{
    partial class Actualizar_Tipo_Usuario
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
            this.textonombre = new System.Windows.Forms.TextBox();
            this.textodescripcion = new System.Windows.Forms.TextBox();
            this.botonactualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // textonombre
            // 
            this.textonombre.Location = new System.Drawing.Point(66, 23);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(100, 20);
            this.textonombre.TabIndex = 2;
            // 
            // textodescripcion
            // 
            this.textodescripcion.Location = new System.Drawing.Point(15, 94);
            this.textodescripcion.Multiline = true;
            this.textodescripcion.Name = "textodescripcion";
            this.textodescripcion.Size = new System.Drawing.Size(496, 156);
            this.textodescripcion.TabIndex = 3;
            // 
            // botonactualizar
            // 
            this.botonactualizar.Location = new System.Drawing.Point(15, 283);
            this.botonactualizar.Name = "botonactualizar";
            this.botonactualizar.Size = new System.Drawing.Size(75, 23);
            this.botonactualizar.TabIndex = 4;
            this.botonactualizar.Text = "Actualizar";
            this.botonactualizar.UseVisualStyleBackColor = true;
            this.botonactualizar.Click += new System.EventHandler(this.botonactualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "*Rellenar únicamente \r\nel campo a actualizar";
            // 
            // Actualizar_Tipo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(627, 337);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonactualizar);
            this.Controls.Add(this.textodescripcion);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Actualizar_Tipo_Usuario";
            this.Text = "Actualizar Tipo de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textonombre;
        private System.Windows.Forms.TextBox textodescripcion;
        private System.Windows.Forms.Button botonactualizar;
        private System.Windows.Forms.Label label3;
    }
}