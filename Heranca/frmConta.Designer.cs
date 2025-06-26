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
            this.rdbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.rdbContaCorrente = new System.Windows.Forms.RadioButton();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.ltbExtrato = new System.Windows.Forms.ListBox();
            this.txtPorcentagem = new System.Windows.Forms.TextBox();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepositar
            // 
            this.btnDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepositar.Location = new System.Drawing.Point(303, 372);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(150, 45);
            this.btnDepositar.TabIndex = 8;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.Controls.Add(this.rdbContaPoupanca);
            this.gpbInformacoes.Controls.Add(this.rdbContaCorrente);
            this.gpbInformacoes.Controls.Add(this.lblExtrato);
            this.gpbInformacoes.Controls.Add(this.ltbExtrato);
            this.gpbInformacoes.Controls.Add(this.txtPorcentagem);
            this.gpbInformacoes.Controls.Add(this.lblPorcentagem);
            this.gpbInformacoes.Controls.Add(this.txtDepositar);
            this.gpbInformacoes.Controls.Add(this.lblDepositar);
            this.gpbInformacoes.Controls.Add(this.txtValor);
            this.gpbInformacoes.Controls.Add(this.lblValor);
            this.gpbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoes.Location = new System.Drawing.Point(85, 53);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(789, 270);
            this.gpbInformacoes.TabIndex = 0;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações da Conta";
            // 
            // rdbContaPoupanca
            // 
            this.rdbContaPoupanca.AutoSize = true;
            this.rdbContaPoupanca.Location = new System.Drawing.Point(254, 168);
            this.rdbContaPoupanca.Name = "rdbContaPoupanca";
            this.rdbContaPoupanca.Size = new System.Drawing.Size(160, 24);
            this.rdbContaPoupanca.TabIndex = 5;
            this.rdbContaPoupanca.TabStop = true;
            this.rdbContaPoupanca.Text = "Conta Poupança";
            this.rdbContaPoupanca.UseVisualStyleBackColor = true;
            this.rdbContaPoupanca.CheckedChanged += new System.EventHandler(this.rdbContaPoupanca_CheckedChanged);
            // 
            // rdbContaCorrente
            // 
            this.rdbContaCorrente.AutoSize = true;
            this.rdbContaCorrente.Location = new System.Drawing.Point(254, 108);
            this.rdbContaCorrente.Name = "rdbContaCorrente";
            this.rdbContaCorrente.Size = new System.Drawing.Size(150, 24);
            this.rdbContaCorrente.TabIndex = 4;
            this.rdbContaCorrente.TabStop = true;
            this.rdbContaCorrente.Text = "Conta Corrente";
            this.rdbContaCorrente.UseVisualStyleBackColor = true;
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
            // ltbExtrato
            // 
            this.ltbExtrato.FormattingEnabled = true;
            this.ltbExtrato.ItemHeight = 20;
            this.ltbExtrato.Location = new System.Drawing.Point(523, 72);
            this.ltbExtrato.Name = "ltbExtrato";
            this.ltbExtrato.Size = new System.Drawing.Size(221, 184);
            this.ltbExtrato.TabIndex = 6;
            // 
            // txtPorcentagem
            // 
            this.txtPorcentagem.Location = new System.Drawing.Point(40, 195);
            this.txtPorcentagem.MaxLength = 10;
            this.txtPorcentagem.Name = "txtPorcentagem";
            this.txtPorcentagem.Size = new System.Drawing.Size(110, 26);
            this.txtPorcentagem.TabIndex = 3;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(36, 172);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(115, 20);
            this.lblPorcentagem.TabIndex = 4;
            this.lblPorcentagem.Text = "Porcentagem";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(40, 133);
            this.txtDepositar.MaxLength = 10;
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(123, 26);
            this.txtDepositar.TabIndex = 2;
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
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(40, 72);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(123, 26);
            this.txtValor.TabIndex = 1;
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
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(85, 372);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(150, 45);
            this.btnSacar.TabIndex = 7;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(518, 372);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(150, 45);
            this.btnTransferir.TabIndex = 9;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldo.Location = new System.Drawing.Point(724, 372);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(150, 45);
            this.btnSaldo.TabIndex = 10;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
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
        private System.Windows.Forms.TextBox txtPorcentagem;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Label lblDepositar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ListBox ltbExtrato;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblExtrato;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.RadioButton rdbContaPoupanca;
        private System.Windows.Forms.RadioButton rdbContaCorrente;
    }
}