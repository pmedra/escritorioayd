namespace NegocioLucero.FormsAdmin
{
    partial class ReporteGanancias
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
            this.dtgridganancias = new System.Windows.Forms.DataGridView();
            this.txtganancias = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridganancias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ganancias";
            // 
            // dtgridganancias
            // 
            this.dtgridganancias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgridganancias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridganancias.Location = new System.Drawing.Point(12, 101);
            this.dtgridganancias.Name = "dtgridganancias";
            this.dtgridganancias.Size = new System.Drawing.Size(719, 281);
            this.dtgridganancias.TabIndex = 1;
            // 
            // txtganancias
            // 
            this.txtganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtganancias.Location = new System.Drawing.Point(128, 48);
            this.txtganancias.Name = "txtganancias";
            this.txtganancias.ReadOnly = true;
            this.txtganancias.Size = new System.Drawing.Size(100, 24);
            this.txtganancias.TabIndex = 2;
            // 
            // ReporteGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 495);
            this.Controls.Add(this.txtganancias);
            this.Controls.Add(this.dtgridganancias);
            this.Controls.Add(this.label1);
            this.Name = "ReporteGanancias";
            this.Text = "ReporteGanancias";
            this.Load += new System.EventHandler(this.ReporteGanancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridganancias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgridganancias;
        private System.Windows.Forms.TextBox txtganancias;
    }
}