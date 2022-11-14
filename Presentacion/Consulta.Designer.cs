namespace Presentacion
{
    partial class Consulta
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
            this.GrillaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaProductos
            // 
            this.GrillaProductos.AllowUserToAddRows = false;
            this.GrillaProductos.AllowUserToDeleteRows = false;
            this.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nombrecolu,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GrillaProductos.Location = new System.Drawing.Point(29, 96);
            this.GrillaProductos.Name = "GrillaProductos";
            this.GrillaProductos.ReadOnly = true;
            this.GrillaProductos.Size = new System.Drawing.Size(534, 342);
            this.GrillaProductos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Referencia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // nombrecolu
            // 
            this.nombrecolu.HeaderText = "Nombre";
            this.nombrecolu.Name = "nombrecolu";
            this.nombrecolu.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(154, 61);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(253, 20);
            this.textBuscar.TabIndex = 1;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.GrillaProductos);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBuscar;
    }
}