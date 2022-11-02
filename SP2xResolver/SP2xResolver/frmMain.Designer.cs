
namespace SP2xResolver
{
    partial class frmMain
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
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.lblDistanciaTotal = new System.Windows.Forms.Label();
            this.txtDistanciaTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(49, 39);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(219, 37);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Distancia [km]";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(49, 204);
            this.lblDias.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(81, 37);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(308, 31);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(308, 44);
            this.txtDistancia.TabIndex = 2;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(308, 196);
            this.cmbDias.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(308, 45);
            this.cmbDias.TabIndex = 3;
            // 
            // lblDistanciaTotal
            // 
            this.lblDistanciaTotal.AutoSize = true;
            this.lblDistanciaTotal.Location = new System.Drawing.Point(899, 105);
            this.lblDistanciaTotal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblDistanciaTotal.Name = "lblDistanciaTotal";
            this.lblDistanciaTotal.Size = new System.Drawing.Size(421, 37);
            this.lblDistanciaTotal.TabIndex = 4;
            this.lblDistanciaTotal.Text = "Distancia Total (ida y vuelta)";
            // 
            // txtDistanciaTotal
            // 
            this.txtDistanciaTotal.Location = new System.Drawing.Point(1365, 97);
            this.txtDistanciaTotal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtDistanciaTotal.Name = "txtDistanciaTotal";
            this.txtDistanciaTotal.ReadOnly = true;
            this.txtDistanciaTotal.Size = new System.Drawing.Size(308, 44);
            this.txtDistanciaTotal.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(1796, 97);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(307, 114);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(49, 395);
            this.lblCostoTotal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(182, 37);
            this.lblCostoTotal.TabIndex = 7;
            this.lblCostoTotal.Text = "Costo Total";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(308, 387);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(308, 44);
            this.txtImporte.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1796, 270);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(307, 114);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 510);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDistanciaTotal);
            this.Controls.Add(this.lblDistanciaTotal);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDistancia);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "frmMain";
            this.Text = "Organizacion Ferrocarril";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label lblDistanciaTotal;
        private System.Windows.Forms.TextBox txtDistanciaTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnCerrar;
    }
}

