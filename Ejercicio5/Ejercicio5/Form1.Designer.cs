namespace Ejercicio5
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
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(15, 51);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(180, 23);
            this.btnEncolar.TabIndex = 0;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Location = new System.Drawing.Point(15, 80);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(180, 23);
            this.btnAtender.TabIndex = 1;
            this.btnAtender.Text = "Atender";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Location = new System.Drawing.Point(15, 138);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(312, 95);
            this.lstCola.TabIndex = 4;
            this.lstCola.SelectedIndexChanged += new System.EventHandler(this.lstCola_SelectedIndexChanged);
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(206, 25);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(121, 21);
            this.cmbMotivo.TabIndex = 5;
            this.cmbMotivo.SelectedIndexChanged += new System.EventHandler(this.cmbMotivo_SelectedIndexChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(35, 13);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "label1";
            this.lblMensaje.Click += new System.EventHandler(this.lblMensaje_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(334, 138);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(307, 95);
            this.lstHistorial.TabIndex = 7;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.btnEncolar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

