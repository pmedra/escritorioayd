namespace NegocioLucero.FormsAdmin
{
    partial class BuscarFactura
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
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.dtgridfacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridfacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente:";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcliente.Location = new System.Drawing.Point(124, 20);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(185, 24);
            this.txtidcliente.TabIndex = 1;
            this.txtidcliente.TextChanged += new System.EventHandler(this.txtidcliente_TextChanged);
            this.txtidcliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtidcliente_KeyUp);
            // 
            // dtgridfacturas
            // 
            this.dtgridfacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridfacturas.Location = new System.Drawing.Point(12, 99);
            this.dtgridfacturas.Name = "dtgridfacturas";
            this.dtgridfacturas.Size = new System.Drawing.Size(723, 250);
            this.dtgridfacturas.TabIndex = 2;
            // 
            // BuscarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 361);
            this.Controls.Add(this.dtgridfacturas);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label1);
            this.Name = "BuscarFactura";
            this.Text = "BuscarFactura";
            this.Load += new System.EventHandler(this.BuscarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridfacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.DataGridView dtgridfacturas;
    }
}