namespace Stock
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
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtboxfiltro = new System.Windows.Forms.TextBox();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblbuscarpor = new System.Windows.Forms.Label();
            this.cbcampo = new System.Windows.Forms.ComboBox();
            this.cbcriterio = new System.Windows.Forms.ComboBox();
            this.txtbusquedaavanzada = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.lblbusquedaavanzada = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstock
            // 
            this.dgvstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvstock.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvstock.Location = new System.Drawing.Point(14, 117);
            this.dgvstock.MultiSelect = false;
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstock.Size = new System.Drawing.Size(639, 240);
            this.dgvstock.TabIndex = 0;
            this.dgvstock.SelectionChanged += new System.EventHandler(this.dgvstock_SelectionChanged);
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturebox.Location = new System.Drawing.Point(659, 117);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(318, 240);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 1;
            this.picturebox.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(15, 364);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(116, 363);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(218, 363);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(138, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar fisico";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtboxfiltro
            // 
            this.txtboxfiltro.Location = new System.Drawing.Point(101, 88);
            this.txtboxfiltro.Name = "txtboxfiltro";
            this.txtboxfiltro.Size = new System.Drawing.Size(306, 20);
            this.txtboxfiltro.TabIndex = 5;
            this.txtboxfiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(15, 91);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(80, 13);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Buscar articulo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Stock de articulos";
            // 
            // lblbuscarpor
            // 
            this.lblbuscarpor.AutoSize = true;
            this.lblbuscarpor.Location = new System.Drawing.Point(381, 373);
            this.lblbuscarpor.Name = "lblbuscarpor";
            this.lblbuscarpor.Size = new System.Drawing.Size(61, 13);
            this.lblbuscarpor.TabIndex = 8;
            this.lblbuscarpor.Text = "Buscar por:";
            // 
            // cbcampo
            // 
            this.cbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(464, 371);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 21);
            this.cbcampo.TabIndex = 9;
            this.cbcampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // cbcriterio
            // 
            this.cbcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(464, 398);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 21);
            this.cbcriterio.TabIndex = 10;
            // 
            // txtbusquedaavanzada
            // 
            this.txtbusquedaavanzada.Location = new System.Drawing.Point(464, 429);
            this.txtbusquedaavanzada.Name = "txtbusquedaavanzada";
            this.txtbusquedaavanzada.Size = new System.Drawing.Size(121, 20);
            this.txtbusquedaavanzada.TabIndex = 11;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(591, 374);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 12;
            this.lblCampo.Text = "Campo";
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Location = new System.Drawing.Point(592, 406);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(39, 13);
            this.lblcriterio.TabIndex = 13;
            this.lblcriterio.Text = "Criterio";
            // 
            // lblbusquedaavanzada
            // 
            this.lblbusquedaavanzada.AutoSize = true;
            this.lblbusquedaavanzada.Location = new System.Drawing.Point(591, 432);
            this.lblbusquedaavanzada.Name = "lblbusquedaavanzada";
            this.lblbusquedaavanzada.Size = new System.Drawing.Size(99, 13);
            this.lblbusquedaavanzada.TabIndex = 14;
            this.lblbusquedaavanzada.Text = "Texto de busqueda";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(464, 455);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 490);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblbusquedaavanzada);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtbusquedaavanzada);
            this.Controls.Add(this.cbcriterio);
            this.Controls.Add(this.cbcampo);
            this.Controls.Add(this.lblbuscarpor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.txtboxfiltro);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.dgvstock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtboxfiltro;
        private System.Windows.Forms.Label lblbuscarpor;
        private System.Windows.Forms.ComboBox cbcampo;
        private System.Windows.Forms.ComboBox cbcriterio;
        private System.Windows.Forms.TextBox txtbusquedaavanzada;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.Label lblbusquedaavanzada;
        private System.Windows.Forms.Button btnbuscar;
    }
}

