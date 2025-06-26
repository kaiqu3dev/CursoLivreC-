namespace Heranca
{
    partial class frmConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConta));
            this.btnDepositar = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.txtTransferir = new System.Windows.Forms.TextBox();
            this.lblTransferir = new System.Windows.Forms.Label();
            this.ltbExtrato = new System.Windows.Forms.ListBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.rdbContaCorrente = new System.Windows.Forms.RadioButton();
            this.rdbContaPoupança = new System.Windows.Forms.RadioButton();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(303, 372);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(150, 45);
            this.btnDepositar.TabIndex = 0;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.rdbContaPoupança);
            this.gpbInformacoes.Controls.Add(this.rdbContaCorrente);
            this.gpbInformacoes.Controls.Add(this.lblExtrato);
            this.gpbInformacoes.Controls.Add(this.ltbExtrato);
            this.gpbInformacoes.Controls.Add(this.txtTransferir);
            this.gpbInformacoes.Controls.Add(this.lblTransferir);
            this.gpbInformacoes.Controls.Add(this.txtDepositar);
            this.gpbInformacoes.Controls.Add(this.lblDepositar);
            this.gpbInformacoes.Controls.Add(this.txtValor);
            this.gpbInformacoes.Controls.Add(this.lblValor);
            this.gpbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoes.Location = new System.Drawing.Point(85, 53);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(789, 270);
            this.gpbInformacoes.TabIndex = 1;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações da Conta";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(59, 49);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(51, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(40, 72);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 26);
            this.txtValor.TabIndex = 1;
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(40, 133);
            this.txtDepositar.MaxLength = 10;
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(123, 26);
            this.txtDepositar.TabIndex = 3;
            // 
            // lblDepositar
            // 
            this.lblDepositar.AutoSize = true;
            this.lblDepositar.Location = new System.Drawing.Point(36, 110);
            this.lblDepositar.Name = "lblDepositar";
            this.lblDepositar.Size = new System.Drawing.Size(87, 20);
            this.lblDepositar.TabIndex = 2;
            this.lblDepositar.Text = "Depositar";
            // 
            // txtTransferir
            // 
            this.txtTransferir.Location = new System.Drawing.Point(40, 195);
            this.txtTransferir.MaxLength = 10;
            this.txtTransferir.Name = "txtTransferir";
            this.txtTransferir.Size = new System.Drawing.Size(123, 26);
            this.txtTransferir.TabIndex = 5;
            // 
            // lblTransferir
            // 
            this.lblTransferir.AutoSize = true;
            this.lblTransferir.Location = new System.Drawing.Point(36, 172);
            this.lblTransferir.Name = "lblTransferir";
            this.lblTransferir.Size = new System.Drawing.Size(86, 20);
            this.lblTransferir.TabIndex = 4;
            this.lblTransferir.Text = "Transferir";
            // 
            // ltbExtrato
            // 
            this.ltbExtrato.FormattingEnabled = true;
            this.ltbExtrato.ItemHeight = 20;
            this.ltbExtrato.Location = new System.Drawing.Point(523, 72);
            this.ltbExtrato.Name = "ltbExtrato";
            this.ltbExtrato.Size = new System.Drawing.Size(221, 184);
            this.ltbExtrato.TabIndex = 7;
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(85, 372);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(150, 45);
            this.btnSacar.TabIndex = 2;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(518, 372);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(150, 45);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblExtrato
            // 
            this.lblExtrato.AutoSize = true;
            this.lblExtrato.Location = new System.Drawing.Point(585, 35);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(67, 20);
            this.lblExtrato.TabIndex = 8;
            this.lblExtrato.Text = "Extrato";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.Location = new System.Drawing.Point(724, 372);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(150, 45);
            this.btnSaldo.TabIndex = 4;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            // 
            // rdbContaCorrente
            // 
            this.rdbContaCorrente.AutoSize = true;
            this.rdbContaCorrente.Location = new System.Drawing.Point(254, 108);
            this.rdbContaCorrente.Name = "rdbContaCorrente";
            this.rdbContaCorrente.Size = new System.Drawing.Size(150, 24);
            this.rdbContaCorrente.TabIndex = 9;
            this.rdbContaCorrente.TabStop = true;
            this.rdbContaCorrente.Text = "Conta Corrente";
            this.rdbContaCorrente.UseVisualStyleBackColor = true;
            // 
            // rdbContaPoupança
            // 
            this.rdbContaPoupança.AutoSize = true;
            this.rdbContaPoupança.Location = new System.Drawing.Point(254, 168);
            this.rdbContaPoupança.Name = "rdbContaPoupança";
            this.rdbContaPoupança.Size = new System.Drawing.Size(160, 24);
            this.rdbContaPoupança.TabIndex = 10;
            this.rdbContaPoupança.TabStop = true;
            this.rdbContaPoupança.Text = "Conta Poupança";
            this.rdbContaPoupança.UseVisualStyleBackColor = true;
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 456);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.btnDepositar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContaBancaria";
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.TextBox txtTransferir;
        private System.Windows.Forms.Label lblTransferir;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Label lblDepositar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ListBox ltbExtrato;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblExtrato;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.RadioButton rdbContaPoupança;
        private System.Windows.Forms.RadioButton rdbContaCorrente;
    }
}