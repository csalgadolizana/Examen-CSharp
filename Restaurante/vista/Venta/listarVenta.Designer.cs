namespace vista.Venta
{
    partial class listarVenta
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
            this.dtgvVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvVenta
            // 
            this.dtgvVenta.AllowUserToAddRows = false;
            this.dtgvVenta.AllowUserToDeleteRows = false;
            this.dtgvVenta.AllowUserToOrderColumns = true;
            this.dtgvVenta.AllowUserToResizeColumns = false;
            this.dtgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVenta.Location = new System.Drawing.Point(12, 30);
            this.dtgvVenta.Name = "dtgvVenta";
            this.dtgvVenta.Size = new System.Drawing.Size(451, 253);
            this.dtgvVenta.TabIndex = 3;
            // 
            // listarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 295);
            this.Controls.Add(this.dtgvVenta);
            this.Name = "listarVenta";
            this.Text = "listarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvVenta;
    }
}