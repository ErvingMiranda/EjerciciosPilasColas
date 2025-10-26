namespace VerificadorParentesis
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnEnunciado;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslHint;
        private System.Windows.Forms.ToolTip toolTip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnEnunciado = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslHint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelHeader.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.panelHeader.Size = new System.Drawing.Size(720, 58);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(18, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Verificación de Paréntesis Balanceados";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblInstruccion.Location = new System.Drawing.Point(22, 74);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(331, 19);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Ingresa una expresión y presiona Verificar (Enter):";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Font = new System.Drawing.Font("Consolas", 12.5F);
            this.txtExpresion.Location = new System.Drawing.Point(26, 100);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(665, 27);
            this.txtExpresion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtExpresion, "Sugerencia: Presiona Tab para autocompletar con un ejemplo cuando esté vacío.");
            this.txtExpresion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtExpresion_PreviewKeyDown);
            this.txtExpresion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExpresion_KeyDown);
            this.txtExpresion.TextChanged += new System.EventHandler(this.txtExpresion_TextChanged);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnVerificar.ForeColor = System.Drawing.Color.White;
            this.btnVerificar.Location = new System.Drawing.Point(26, 146);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 36);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnEnunciado
            // 
            this.btnEnunciado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnunciado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnunciado.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnEnunciado.Location = new System.Drawing.Point(160, 146);
            this.btnEnunciado.Name = "btnEnunciado";
            this.btnEnunciado.Size = new System.Drawing.Size(150, 36);
            this.btnEnunciado.TabIndex = 2;
            this.btnEnunciado.Text = "Ver enunciado";
            this.btnEnunciado.UseVisualStyleBackColor = false;
            this.btnEnunciado.Click += new System.EventHandler(this.btnEnunciado_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(322, 146);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 36);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lblResultado.Location = new System.Drawing.Point(26, 198);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.lblResultado.Size = new System.Drawing.Size(665, 70);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslHint});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslHint
            // 
            this.tslHint.Name = "tslHint";
            this.tslHint.Size = new System.Drawing.Size(396, 17);
            this.tslHint.Text = "Tip: Presiona Tab en la caja de texto (vacía) para autocompletar un ejemplo.";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnVerificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(720, 321);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEnunciado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3 • Pila de paréntesis";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
