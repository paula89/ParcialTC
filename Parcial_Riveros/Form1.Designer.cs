namespace Parcial_Riveros
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
            this.textBoxNroCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMsgSaldo = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.textBoxNroCuentaTransferir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNroCuenta
            // 
            this.textBoxNroCuenta.Location = new System.Drawing.Point(13, 12);
            this.textBoxNroCuenta.Name = "textBoxNroCuenta";
            this.textBoxNroCuenta.Size = new System.Drawing.Size(120, 20);
            this.textBoxNroCuenta.TabIndex = 0;
            this.textBoxNroCuenta.TextChanged += new System.EventHandler(this.textBoxTitular_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nro cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMsgSaldo
            // 
            this.labelMsgSaldo.AutoSize = true;
            this.labelMsgSaldo.Location = new System.Drawing.Point(48, 214);
            this.labelMsgSaldo.Name = "labelMsgSaldo";
            this.labelMsgSaldo.Size = new System.Drawing.Size(0, 13);
            this.labelMsgSaldo.TabIndex = 6;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(335, 214);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 7;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(335, 253);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(75, 23);
            this.btnExtraer.TabIndex = 8;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(259, 14);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMonto.TabIndex = 9;
            this.textBoxMonto.TextChanged += new System.EventHandler(this.textBoxMonto_TextChanged);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(381, 20);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(37, 13);
            this.labelMonto.TabIndex = 10;
            this.labelMonto.Text = "Monto";
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Location = new System.Drawing.Point(335, 160);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(75, 38);
            this.btnConsultarSaldo.TabIndex = 13;
            this.btnConsultarSaldo.Text = "Consultar Saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(335, 122);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 23);
            this.btnTransferir.TabIndex = 14;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            // 
            // textBoxNroCuentaTransferir
            // 
            this.textBoxNroCuentaTransferir.Location = new System.Drawing.Point(12, 68);
            this.textBoxNroCuentaTransferir.Name = "textBoxNroCuentaTransferir";
            this.textBoxNroCuentaTransferir.Size = new System.Drawing.Size(120, 20);
            this.textBoxNroCuentaTransferir.TabIndex = 15;
            this.textBoxNroCuentaTransferir.Text = "A transferir";
            this.textBoxNroCuentaTransferir.TextChanged += new System.EventHandler(this.textBoxNroCuentaTransferir_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nro cuenta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNroCuentaTransferir);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnConsultarSaldo);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.labelMsgSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNroCuenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNroCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMsgSaldo;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.TextBox textBoxNroCuentaTransferir;
        private System.Windows.Forms.Label label2;
    }
}

