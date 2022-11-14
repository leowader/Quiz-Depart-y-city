namespace Presentacion
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.radioCity = new System.Windows.Forms.RadioButton();
            this.radioDepart = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnADepart = new System.Windows.Forms.Button();
            this.btnACity = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listCity = new System.Windows.Forms.ListBox();
            this.listDepart = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearText);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.radioCity);
            this.groupBox1.Controls.Add(this.radioDepart);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar Datos";
            // 
            // btnClearText
            // 
            this.btnClearText.Location = new System.Drawing.Point(357, 56);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(156, 23);
            this.btnClearText.TabIndex = 5;
            this.btnClearText.Text = "Limpiart Texto";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.BtnClearText_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(438, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(357, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(142, 20);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(193, 20);
            this.textBox.TabIndex = 2;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // radioCity
            // 
            this.radioCity.AutoSize = true;
            this.radioCity.Location = new System.Drawing.Point(7, 44);
            this.radioCity.Name = "radioCity";
            this.radioCity.Size = new System.Drawing.Size(58, 17);
            this.radioCity.TabIndex = 1;
            this.radioCity.TabStop = true;
            this.radioCity.Text = "Ciudad";
            this.radioCity.UseVisualStyleBackColor = true;
            // 
            // radioDepart
            // 
            this.radioDepart.AutoSize = true;
            this.radioDepart.Location = new System.Drawing.Point(7, 20);
            this.radioDepart.Name = "radioDepart";
            this.radioDepart.Size = new System.Drawing.Size(92, 17);
            this.radioDepart.TabIndex = 0;
            this.radioDepart.TabStop = true;
            this.radioDepart.Text = "Departamento";
            this.radioDepart.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnADepart);
            this.groupBox2.Controls.Add(this.btnACity);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listCity);
            this.groupBox2.Controls.Add(this.listDepart);
            this.groupBox2.Location = new System.Drawing.Point(21, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listas";
            // 
            // btnADepart
            // 
            this.btnADepart.Image = ((System.Drawing.Image)(resources.GetObject("btnADepart.Image")));
            this.btnADepart.Location = new System.Drawing.Point(213, 164);
            this.btnADepart.Name = "btnADepart";
            this.btnADepart.Size = new System.Drawing.Size(93, 23);
            this.btnADepart.TabIndex = 6;
            this.btnADepart.UseVisualStyleBackColor = true;
            this.btnADepart.Click += new System.EventHandler(this.BtnADepart_Click);
            // 
            // btnACity
            // 
            this.btnACity.Image = ((System.Drawing.Image)(resources.GetObject("btnACity.Image")));
            this.btnACity.Location = new System.Drawing.Point(213, 105);
            this.btnACity.Name = "btnACity";
            this.btnACity.Size = new System.Drawing.Size(93, 23);
            this.btnACity.TabIndex = 5;
            this.btnACity.UseVisualStyleBackColor = true;
            this.btnACity.Click += new System.EventHandler(this.BtnACity_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(330, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Borrar Listas";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ciudades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamentos";
            // 
            // listCity
            // 
            this.listCity.FormattingEnabled = true;
            this.listCity.Location = new System.Drawing.Point(330, 48);
            this.listCity.Name = "listCity";
            this.listCity.Size = new System.Drawing.Size(183, 199);
            this.listCity.TabIndex = 1;
            this.listCity.SelectedIndexChanged += new System.EventHandler(this.ListCity_SelectedIndexChanged);
            // 
            // listDepart
            // 
            this.listDepart.FormattingEnabled = true;
            this.listDepart.Location = new System.Drawing.Point(7, 46);
            this.listDepart.Name = "listDepart";
            this.listDepart.Size = new System.Drawing.Size(183, 199);
            this.listDepart.TabIndex = 0;
            this.listDepart.SelectedIndexChanged += new System.EventHandler(this.ListDepart_SelectedIndexChanged);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quiz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.RadioButton radioCity;
        private System.Windows.Forms.RadioButton radioDepart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnADepart;
        private System.Windows.Forms.Button btnACity;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listCity;
        private System.Windows.Forms.ListBox listDepart;
        private System.Windows.Forms.Button btnClearText;
    }
}

