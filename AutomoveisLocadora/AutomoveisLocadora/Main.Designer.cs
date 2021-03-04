namespace AutomoveisLocadora
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.lblMarcaResult = new System.Windows.Forms.Label();
            this.lblModeloResult = new System.Windows.Forms.Label();
            this.lblPlacaResult = new System.Windows.Forms.Label();
            this.lblPrecoResult = new System.Windows.Forms.Label();
            this.lblDispResult = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lbCarros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locadora de Vrum Vrum";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(47, 72);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(317, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(44, 56);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 2;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(483, 79);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(483, 115);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(483, 148);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 6;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(483, 180);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 25;
            this.lblPreco.Text = "Preço:";
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(483, 210);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(62, 13);
            this.lblDisp.TabIndex = 30;
            this.lblDisp.Text = "Disponivel: ";
            // 
            // lblMarcaResult
            // 
            this.lblMarcaResult.AutoSize = true;
            this.lblMarcaResult.Location = new System.Drawing.Point(549, 79);
            this.lblMarcaResult.Name = "lblMarcaResult";
            this.lblMarcaResult.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaResult.TabIndex = 31;
            this.lblMarcaResult.Text = "Marca";
            // 
            // lblModeloResult
            // 
            this.lblModeloResult.AutoSize = true;
            this.lblModeloResult.Location = new System.Drawing.Point(549, 115);
            this.lblModeloResult.Name = "lblModeloResult";
            this.lblModeloResult.Size = new System.Drawing.Size(42, 13);
            this.lblModeloResult.TabIndex = 32;
            this.lblModeloResult.Text = "Modelo";
            // 
            // lblPlacaResult
            // 
            this.lblPlacaResult.AutoSize = true;
            this.lblPlacaResult.Location = new System.Drawing.Point(549, 148);
            this.lblPlacaResult.Name = "lblPlacaResult";
            this.lblPlacaResult.Size = new System.Drawing.Size(34, 13);
            this.lblPlacaResult.TabIndex = 33;
            this.lblPlacaResult.Text = "Placa";
            // 
            // lblPrecoResult
            // 
            this.lblPrecoResult.AutoSize = true;
            this.lblPrecoResult.Location = new System.Drawing.Point(549, 180);
            this.lblPrecoResult.Name = "lblPrecoResult";
            this.lblPrecoResult.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoResult.TabIndex = 34;
            this.lblPrecoResult.Text = "Preço";
            // 
            // lblDispResult
            // 
            this.lblDispResult.AutoSize = true;
            this.lblDispResult.Location = new System.Drawing.Point(549, 210);
            this.lblDispResult.Name = "lblDispResult";
            this.lblDispResult.Size = new System.Drawing.Size(45, 13);
            this.lblDispResult.TabIndex = 35;
            this.lblDispResult.Text = "sim/não";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(453, 265);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(144, 416);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(96, 23);
            this.btnCriar.TabIndex = 37;
            this.btnCriar.Text = "Novo Veículo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(552, 265);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lbCarros
            // 
            this.lbCarros.FormattingEnabled = true;
            this.lbCarros.Location = new System.Drawing.Point(47, 115);
            this.lbCarros.Name = "lbCarros";
            this.lbCarros.Size = new System.Drawing.Size(317, 264);
            this.lbCarros.TabIndex = 39;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 468);
            this.Controls.Add(this.lbCarros);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblDispResult);
            this.Controls.Add(this.lblPrecoResult);
            this.Controls.Add(this.lblPlacaResult);
            this.Controls.Add(this.lblModeloResult);
            this.Controls.Add(this.lblMarcaResult);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label lblMarcaResult;
        private System.Windows.Forms.Label lblModeloResult;
        private System.Windows.Forms.Label lblPlacaResult;
        private System.Windows.Forms.Label lblPrecoResult;
        private System.Windows.Forms.Label lblDispResult;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListBox lbCarros;
    }
}

