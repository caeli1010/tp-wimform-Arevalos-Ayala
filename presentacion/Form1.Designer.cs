namespace presentacion
{
    partial class frmCatalogo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ibtnDetalle = new FontAwesome.Sharp.IconButton();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnAgregar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconBtnEliminar = new FontAwesome.Sharp.IconButton();
            this.iconBtnModificar = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmAgregarArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmAgregarArticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Italic);
            this.txtFiltro.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFiltro.Location = new System.Drawing.Point(25, 170);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(172, 28);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltro.Click += new System.EventHandler(this.txtFiltro_Click);
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.ColumnHeadersHeight = 50;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDetalle.Location = new System.Drawing.Point(250, 48);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDetalle.MaximumSize = new System.Drawing.Size(400, 600);
            this.dgvDetalle.MinimumSize = new System.Drawing.Size(300, 400);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 55;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.AliceBlue;
            this.dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalle.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDetalle.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDetalle.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dgvDetalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.AliceBlue;
            this.dgvDetalle.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDetalle.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DarkTurquoise;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(400, 445);
            this.dgvDetalle.TabIndex = 7;
            this.dgvDetalle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDetalle_MouseClick);
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 113;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(dominio.Articulo);
            // 
            // ibtnDetalle
            // 
            this.ibtnDetalle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ibtnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.ibtnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDetalle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtnDetalle.ForeColor = System.Drawing.Color.White;
            this.ibtnDetalle.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnDetalle.IconColor = System.Drawing.Color.White;
            this.ibtnDetalle.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnDetalle.IconSize = 32;
            this.ibtnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnDetalle.Location = new System.Drawing.Point(24, 415);
            this.ibtnDetalle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ibtnDetalle.Name = "ibtnDetalle";
            this.ibtnDetalle.Size = new System.Drawing.Size(173, 37);
            this.ibtnDetalle.TabIndex = 9;
            this.ibtnDetalle.Text = "Detalle";
            this.ibtnDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDetalle.UseVisualStyleBackColor = false;
            this.ibtnDetalle.Click += new System.EventHandler(this.ibtnDetalle_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImagen.ErrorImage")));
            this.pbxImagen.Location = new System.Drawing.Point(673, 48);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(387, 445);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 8;
            this.pbxImagen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(45)))), ((int)(((byte)(91)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 30);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(45)))), ((int)(((byte)(91)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 497);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 60);
            this.panel2.TabIndex = 10;
            // 
            // ibtnAgregar
            // 
            this.ibtnAgregar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ibtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.ibtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAgregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.ibtnAgregar.ForeColor = System.Drawing.Color.White;
            this.ibtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAgregar.IconColor = System.Drawing.Color.AliceBlue;
            this.ibtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.ibtnAgregar.IconSize = 32;
            this.ibtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAgregar.Location = new System.Drawing.Point(25, 286);
            this.ibtnAgregar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ibtnAgregar.Name = "ibtnAgregar";
            this.ibtnAgregar.Size = new System.Drawing.Size(171, 37);
            this.ibtnAgregar.TabIndex = 10;
            this.ibtnAgregar.Text = "Agregar";
            this.ibtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAgregar.UseVisualStyleBackColor = false;
            this.ibtnAgregar.Click += new System.EventHandler(this.ibtnAgregar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.iconBtnEliminar);
            this.panel3.Controls.Add(this.iconBtnModificar);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Controls.Add(this.ibtnAgregar);
            this.panel3.Controls.Add(this.ibtnDetalle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 467);
            this.panel3.TabIndex = 11;
            // 
            // iconBtnEliminar
            // 
            this.iconBtnEliminar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconBtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.iconBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.iconBtnEliminar.ForeColor = System.Drawing.Color.White;
            this.iconBtnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconBtnEliminar.IconColor = System.Drawing.Color.AliceBlue;
            this.iconBtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnEliminar.IconSize = 32;
            this.iconBtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnEliminar.Location = new System.Drawing.Point(25, 372);
            this.iconBtnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconBtnEliminar.Name = "iconBtnEliminar";
            this.iconBtnEliminar.Size = new System.Drawing.Size(171, 37);
            this.iconBtnEliminar.TabIndex = 14;
            this.iconBtnEliminar.Text = "Eliminar";
            this.iconBtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnEliminar.UseVisualStyleBackColor = false;
            this.iconBtnEliminar.Click += new System.EventHandler(this.iconBtnEliminar_Click);
            // 
            // iconBtnModificar
            // 
            this.iconBtnModificar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.iconBtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.iconBtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnModificar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.iconBtnModificar.ForeColor = System.Drawing.Color.White;
            this.iconBtnModificar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconBtnModificar.IconColor = System.Drawing.Color.AliceBlue;
            this.iconBtnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnModificar.IconSize = 32;
            this.iconBtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnModificar.Location = new System.Drawing.Point(25, 329);
            this.iconBtnModificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.iconBtnModificar.Name = "iconBtnModificar";
            this.iconBtnModificar.Size = new System.Drawing.Size(171, 37);
            this.iconBtnModificar.TabIndex = 13;
            this.iconBtnModificar.Text = "Modificar";
            this.iconBtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnModificar.UseVisualStyleBackColor = false;
            this.iconBtnModificar.Click += new System.EventHandler(this.iconBtnModificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarArticuloBindingSource
            // 
            this.frmAgregarArticuloBindingSource.DataSource = typeof(presentacion.frmAgregarArticulo);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1060, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.dgvDetalle);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CATALOGO ";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmAgregarArticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.BindingSource frmAgregarArticuloBindingSource;
		private FontAwesome.Sharp.IconButton ibtnDetalle;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconBtnEliminar;
        private FontAwesome.Sharp.IconButton iconBtnModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}

