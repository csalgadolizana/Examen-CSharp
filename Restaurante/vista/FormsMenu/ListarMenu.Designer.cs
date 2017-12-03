namespace vista
{
    partial class ListarMenu
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
            this.dtgMenus = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMenus
            // 
            this.dtgMenus.AllowUserToAddRows = false;
            this.dtgMenus.AllowUserToDeleteRows = false;
            this.dtgMenus.AllowUserToOrderColumns = true;
            this.dtgMenus.AllowUserToResizeColumns = false;
            this.dtgMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenus.Location = new System.Drawing.Point(12, 30);
            this.dtgMenus.Name = "dtgMenus";
            this.dtgMenus.Size = new System.Drawing.Size(451, 253);
            this.dtgMenus.TabIndex = 0;
            this.dtgMenus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMenus_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ListarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 295);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgMenus);
            this.Name = "ListarMenu";
            this.Text = "ListarMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMenus;
        private System.Windows.Forms.Button btnVolver;
    }
}