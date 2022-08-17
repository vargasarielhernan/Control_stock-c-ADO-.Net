namespace Stock
{
    partial class Windowsagregar
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblimageurl = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtboxcodigo = new System.Windows.Forms.TextBox();
            this.txtboxnombre = new System.Windows.Forms.TextBox();
            this.txtboxdescripcion = new System.Windows.Forms.TextBox();
            this.txtboxurl = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.cbcategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnagregarfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(21, 349);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(162, 348);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 1;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(21, 12);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 3;
            this.lblcodigo.Text = "Codigo";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(21, 51);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(21, 80);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 5;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblimageurl
            // 
            this.lblimageurl.AutoSize = true;
            this.lblimageurl.Location = new System.Drawing.Point(21, 122);
            this.lblimageurl.Name = "lblimageurl";
            this.lblimageurl.Size = new System.Drawing.Size(55, 13);
            this.lblimageurl.TabIndex = 6;
            this.lblimageurl.Text = "ImagenUrl";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(21, 163);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(37, 13);
            this.lblmarca.TabIndex = 7;
            this.lblmarca.Text = "Marca";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(21, 206);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(52, 13);
            this.lblcategoria.TabIndex = 8;
            this.lblcategoria.Text = "Categoria";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(21, 254);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 9;
            this.lblprecio.Text = "Precio";
            // 
            // txtboxcodigo
            // 
            this.txtboxcodigo.Location = new System.Drawing.Point(108, 12);
            this.txtboxcodigo.Name = "txtboxcodigo";
            this.txtboxcodigo.Size = new System.Drawing.Size(259, 20);
            this.txtboxcodigo.TabIndex = 11;
            // 
            // txtboxnombre
            // 
            this.txtboxnombre.Location = new System.Drawing.Point(108, 44);
            this.txtboxnombre.Name = "txtboxnombre";
            this.txtboxnombre.Size = new System.Drawing.Size(259, 20);
            this.txtboxnombre.TabIndex = 12;
            // 
            // txtboxdescripcion
            // 
            this.txtboxdescripcion.Location = new System.Drawing.Point(108, 77);
            this.txtboxdescripcion.Name = "txtboxdescripcion";
            this.txtboxdescripcion.Size = new System.Drawing.Size(259, 20);
            this.txtboxdescripcion.TabIndex = 13;
            // 
            // txtboxurl
            // 
            this.txtboxurl.Location = new System.Drawing.Point(108, 115);
            this.txtboxurl.Name = "txtboxurl";
            this.txtboxurl.Size = new System.Drawing.Size(259, 20);
            this.txtboxurl.TabIndex = 14;
            this.txtboxurl.Leave += new System.EventHandler(this.txtboxurl_Leave);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(108, 247);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(259, 20);
            this.txtprecio.TabIndex = 17;
            // 
            // cbmarca
            // 
            this.cbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Location = new System.Drawing.Point(108, 163);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(259, 21);
            this.cbmarca.TabIndex = 18;
            // 
            // cbcategoria
            // 
            this.cbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcategoria.FormattingEnabled = true;
            this.cbcategoria.Location = new System.Drawing.Point(108, 197);
            this.cbcategoria.Name = "cbcategoria";
            this.cbcategoria.Size = new System.Drawing.Size(259, 21);
            this.cbcategoria.TabIndex = 19;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(436, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(328, 255);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // btnagregarfile
            // 
            this.btnagregarfile.Location = new System.Drawing.Point(374, 115);
            this.btnagregarfile.Name = "btnagregarfile";
            this.btnagregarfile.Size = new System.Drawing.Size(19, 20);
            this.btnagregarfile.TabIndex = 21;
            this.btnagregarfile.Text = "+";
            this.btnagregarfile.UseVisualStyleBackColor = true;
            this.btnagregarfile.Click += new System.EventHandler(this.btnagregarfile_Click);
            // 
            // Windowsagregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btnagregarfile);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cbcategoria);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtboxurl);
            this.Controls.Add(this.txtboxdescripcion);
            this.Controls.Add(this.txtboxnombre);
            this.Controls.Add(this.txtboxcodigo);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblimageurl);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Windowsagregar";
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.Windowsagregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblimageurl;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtboxcodigo;
        private System.Windows.Forms.TextBox txtboxnombre;
        private System.Windows.Forms.TextBox txtboxdescripcion;
        private System.Windows.Forms.TextBox txtboxurl;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.ComboBox cbcategoria;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnagregarfile;
    }
}