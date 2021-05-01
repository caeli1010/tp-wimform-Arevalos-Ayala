namespace presentacion
{
    partial class frmNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevo));
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.iBtnAceptar = new FontAwesome.Sharp.IconButton();
            this.ibtnCerrar = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.ForeColor = System.Drawing.Color.Turquoise;
            this.lblNuevo.Location = new System.Drawing.Point(66, 27);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(173, 18);
            this.lblNuevo.TabIndex = 0;
            this.lblNuevo.Text = "AGREGAR CATEGORIA";
            // 
            // txtNuevo
            // 
            this.txtNuevo.BackColor = System.Drawing.Color.Silver;
            this.txtNuevo.Location = new System.Drawing.Point(69, 61);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(164, 20);
            this.txtNuevo.TabIndex = 1;
            // 
            // iBtnAceptar
            // 
            this.iBtnAceptar.FlatAppearance.BorderSize = 0;
            this.iBtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iBtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iBtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnAceptar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iBtnAceptar.IconColor = System.Drawing.Color.Turquoise;
            this.iBtnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnAceptar.IconSize = 50;
            this.iBtnAceptar.Location = new System.Drawing.Point(69, 103);
            this.iBtnAceptar.Name = "iBtnAceptar";
            this.iBtnAceptar.Size = new System.Drawing.Size(50, 50);
            this.iBtnAceptar.TabIndex = 2;
            this.iBtnAceptar.UseVisualStyleBackColor = true;
            this.iBtnAceptar.Click += new System.EventHandler(this.iBtnAceptar_Click);
            // 
            // ibtnCerrar
            // 
            this.ibtnCerrar.FlatAppearance.BorderSize = 0;
            this.ibtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ibtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ibtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCerrar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnCerrar.IconColor = System.Drawing.Color.Turquoise;
            this.ibtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCerrar.IconSize = 50;
            this.ibtnCerrar.Location = new System.Drawing.Point(183, 103);
            this.ibtnCerrar.Name = "ibtnCerrar";
            this.ibtnCerrar.Size = new System.Drawing.Size(50, 50);
            this.ibtnCerrar.TabIndex = 3;
            this.ibtnCerrar.UseVisualStyleBackColor = true;
            this.ibtnCerrar.Click += new System.EventHandler(this.ibtnCerrar_Click);
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(45)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(303, 196);
            this.Controls.Add(this.ibtnCerrar);
            this.Controls.Add(this.iBtnAceptar);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.lblNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevo";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Categoria";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.TextBox txtNuevo;
        private FontAwesome.Sharp.IconButton iBtnAceptar;
        private FontAwesome.Sharp.IconButton ibtnCerrar;
    }
}