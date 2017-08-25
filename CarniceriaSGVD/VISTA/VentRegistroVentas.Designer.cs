namespace CarniceriaSGVD.VISTA
{
    partial class VentRegistroVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBtEfectivo = new System.Windows.Forms.RadioButton();
            this.radioBtCtaCte = new System.Windows.Forms.RadioButton();
            this.radioBtCredito = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxtarjeta = new System.Windows.Forms.ComboBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIDProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtCantPeso = new System.Windows.Forms.TextBox();
            this.listBoxProd = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantPeso);
            this.groupBox1.Controls.Add(this.txtNombreProd);
            this.groupBox1.Controls.Add(this.textIDProd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnBuscarProd);
            this.groupBox1.Location = new System.Drawing.Point(60, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxProd);
            this.groupBox2.Location = new System.Drawing.Point(520, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 167);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDniCliente);
            this.groupBox3.Controls.Add(this.comboBoxtarjeta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radioBtCredito);
            this.groupBox3.Controls.Add(this.radioBtCtaCte);
            this.groupBox3.Controls.Add(this.radioBtEfectivo);
            this.groupBox3.Location = new System.Drawing.Point(60, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 143);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mediio de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "fecha";
            // 
            // radioBtEfectivo
            // 
            this.radioBtEfectivo.AutoSize = true;
            this.radioBtEfectivo.Checked = true;
            this.radioBtEfectivo.Location = new System.Drawing.Point(20, 33);
            this.radioBtEfectivo.Name = "radioBtEfectivo";
            this.radioBtEfectivo.Size = new System.Drawing.Size(64, 17);
            this.radioBtEfectivo.TabIndex = 0;
            this.radioBtEfectivo.TabStop = true;
            this.radioBtEfectivo.Text = "Efectivo";
            this.radioBtEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioBtCtaCte
            // 
            this.radioBtCtaCte.AutoSize = true;
            this.radioBtCtaCte.Location = new System.Drawing.Point(130, 33);
            this.radioBtCtaCte.Name = "radioBtCtaCte";
            this.radioBtCtaCte.Size = new System.Drawing.Size(104, 17);
            this.radioBtCtaCte.TabIndex = 0;
            this.radioBtCtaCte.Text = "Cuenta Corriente";
            this.radioBtCtaCte.UseVisualStyleBackColor = true;
            // 
            // radioBtCredito
            // 
            this.radioBtCredito.AutoSize = true;
            this.radioBtCredito.Location = new System.Drawing.Point(247, 33);
            this.radioBtCredito.Name = "radioBtCredito";
            this.radioBtCredito.Size = new System.Drawing.Size(94, 17);
            this.radioBtCredito.TabIndex = 0;
            this.radioBtCredito.Text = "Crédito/Débito";
            this.radioBtCredito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Tarjeta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNI Cliente";
            // 
            // comboBoxtarjeta
            // 
            this.comboBoxtarjeta.FormattingEnabled = true;
            this.comboBoxtarjeta.Location = new System.Drawing.Point(38, 99);
            this.comboBoxtarjeta.Name = "comboBoxtarjeta";
            this.comboBoxtarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxtarjeta.TabIndex = 2;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(202, 99);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDniCliente.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(60, 396);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(190, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(441, 396);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total $";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(520, 385);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(286, 28);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProd.TabIndex = 0;
            this.btnBuscarProd.Text = "Buscar Producto";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 128);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad/Peso Kg";
            // 
            // textIDProd
            // 
            this.textIDProd.Location = new System.Drawing.Point(130, 28);
            this.textIDProd.Name = "textIDProd";
            this.textIDProd.Size = new System.Drawing.Size(100, 20);
            this.textIDProd.TabIndex = 2;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(130, 57);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProd.TabIndex = 2;
            // 
            // txtCantPeso
            // 
            this.txtCantPeso.Location = new System.Drawing.Point(130, 87);
            this.txtCantPeso.Name = "txtCantPeso";
            this.txtCantPeso.Size = new System.Drawing.Size(100, 20);
            this.txtCantPeso.TabIndex = 2;
            // 
            // listBoxProd
            // 
            this.listBoxProd.FormattingEnabled = true;
            this.listBoxProd.Location = new System.Drawing.Point(7, 20);
            this.listBoxProd.Name = "listBoxProd";
            this.listBoxProd.Size = new System.Drawing.Size(324, 147);
            this.listBoxProd.TabIndex = 0;
            // 
            // VentRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 447);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VentRegistroVentas";
            this.Text = "VentRegistroVentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.ComboBox comboBoxtarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtCredito;
        private System.Windows.Forms.RadioButton radioBtCtaCte;
        private System.Windows.Forms.RadioButton radioBtEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantPeso;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox textIDProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ListBox listBoxProd;
    }
}