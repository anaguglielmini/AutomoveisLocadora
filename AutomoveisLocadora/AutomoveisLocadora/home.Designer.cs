namespace AutomoveisLocadora
{
    partial class Home
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
            this.dgVeiculos = new System.Windows.Forms.DataGridView();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbDisponivel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblEmprestimo = new System.Windows.Forms.Label();
            this.lblDevolucao = new System.Windows.Forms.Label();
            this.lblMulta = new System.Windows.Forms.Label();
            this.lblDiasAtraso = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelVeiculo = new System.Windows.Forms.Panel();
            this.lbModelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).BeginInit();
            this.panelVeiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgVeiculos
            // 
            this.dgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVeiculos.Location = new System.Drawing.Point(28, 43);
            this.dgVeiculos.Name = "dgVeiculos";
            this.dgVeiculos.Size = new System.Drawing.Size(285, 279);
            this.dgVeiculos.TabIndex = 0;
            this.dgVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculos_CellClick);
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(122, 362);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(75, 23);
            this.btnNewCar.TabIndex = 1;
            this.btnNewCar.Text = "Novo Carro";
            this.btnNewCar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Locadora de Automóveis";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(31, 23);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 13);
            this.lbId.TabIndex = 3;
            this.lbId.Text = "lbId";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(32, 49);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 13);
            this.lbPlaca.TabIndex = 4;
            this.lbPlaca.Text = "lbPlaca";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(31, 76);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(40, 13);
            this.lbDesc.TabIndex = 5;
            this.lbDesc.Text = "lbDesc";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(31, 114);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(45, 13);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "lbMarca";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(31, 169);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(43, 13);
            this.lbPreco.TabIndex = 7;
            this.lbPreco.Text = "lbPreco";
            // 
            // lbDisponivel
            // 
            this.lbDisponivel.AutoSize = true;
            this.lbDisponivel.Location = new System.Drawing.Point(31, 200);
            this.lbDisponivel.Name = "lbDisponivel";
            this.lbDisponivel.Size = new System.Drawing.Size(59, 13);
            this.lbDisponivel.TabIndex = 8;
            this.lbDisponivel.Text = "lbDiponivel";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(237, 245);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // lblEmprestimo
            // 
            this.lblEmprestimo.AutoSize = true;
            this.lblEmprestimo.Location = new System.Drawing.Point(31, 229);
            this.lblEmprestimo.Name = "lblEmprestimo";
            this.lblEmprestimo.Size = new System.Drawing.Size(61, 13);
            this.lblEmprestimo.TabIndex = 11;
            this.lblEmprestimo.Text = "Emprestimo";
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.Location = new System.Drawing.Point(234, 229);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(59, 13);
            this.lblDevolucao.TabIndex = 12;
            this.lblDevolucao.Text = "Devolução";
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(31, 284);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(41, 13);
            this.lblMulta.TabIndex = 13;
            this.lblMulta.Text = "label10";
            this.lblMulta.Click += new System.EventHandler(this.lblMulta_Click);
            // 
            // lblDiasAtraso
            // 
            this.lblDiasAtraso.AutoSize = true;
            this.lblDiasAtraso.Location = new System.Drawing.Point(31, 312);
            this.lblDiasAtraso.Name = "lblDiasAtraso";
            this.lblDiasAtraso.Size = new System.Drawing.Size(41, 13);
            this.lblDiasAtraso.TabIndex = 14;
            this.lblDiasAtraso.Text = "label11";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(131, 337);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(237, 337);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // panelVeiculo
            // 
            this.panelVeiculo.Controls.Add(this.lbModelo);
            this.panelVeiculo.Controls.Add(this.lbId);
            this.panelVeiculo.Controls.Add(this.lbDisponivel);
            this.panelVeiculo.Controls.Add(this.btnExcluir);
            this.panelVeiculo.Controls.Add(this.lbPlaca);
            this.panelVeiculo.Controls.Add(this.btnEditar);
            this.panelVeiculo.Controls.Add(this.lbDesc);
            this.panelVeiculo.Controls.Add(this.lblDiasAtraso);
            this.panelVeiculo.Controls.Add(this.lbMarca);
            this.panelVeiculo.Controls.Add(this.lblMulta);
            this.panelVeiculo.Controls.Add(this.lbPreco);
            this.panelVeiculo.Controls.Add(this.lblDevolucao);
            this.panelVeiculo.Controls.Add(this.dateTimePicker1);
            this.panelVeiculo.Controls.Add(this.lblEmprestimo);
            this.panelVeiculo.Controls.Add(this.dateTimePicker2);
            this.panelVeiculo.Location = new System.Drawing.Point(338, 25);
            this.panelVeiculo.Name = "panelVeiculo";
            this.panelVeiculo.Size = new System.Drawing.Size(418, 413);
            this.panelVeiculo.TabIndex = 17;
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(31, 143);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(50, 13);
            this.lbModelo.TabIndex = 17;
            this.lbModelo.Text = "lbModelo";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewCar);
            this.Controls.Add(this.dgVeiculos);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).EndInit();
            this.panelVeiculo.ResumeLayout(false);
            this.panelVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVeiculos;
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbDisponivel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblEmprestimo;
        private System.Windows.Forms.Label lblDevolucao;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.Label lblDiasAtraso;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panelVeiculo;
        private System.Windows.Forms.Label lbModelo;
    }
}