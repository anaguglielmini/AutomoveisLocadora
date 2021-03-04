namespace AutomoveisLocadora
{
    partial class Editar
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblDisp = new System.Windows.Forms.Label();
            this.txtDisp = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRetirada = new System.Windows.Forms.Label();
            this.lblDevo = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblMulta = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(453, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 36);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(25, 283);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 26;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(28, 299);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(110, 20);
            this.txtModelo.TabIndex = 25;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(25, 333);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 24;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(28, 349);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(110, 20);
            this.txtPreco.TabIndex = 23;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 231);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(28, 247);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(110, 20);
            this.txtMarca.TabIndex = 21;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(28, 84);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(110, 13);
            this.lblDesc.TabIndex = 20;
            this.lblDesc.Text = "Descrição do Veículo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(25, 34);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 19;
            this.lblPlaca.Text = "Placa";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(28, 100);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(228, 118);
            this.txtDesc.TabIndex = 18;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(28, 50);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(110, 20);
            this.txtPlaca.TabIndex = 17;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Location = new System.Drawing.Point(433, 34);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(78, 13);
            this.lblDisp.TabIndex = 29;
            this.lblDisp.Text = "Disponibilidade";
            this.lblDisp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDisp
            // 
            this.txtDisp.Location = new System.Drawing.Point(433, 50);
            this.txtDisp.Name = "txtDisp";
            this.txtDisp.Size = new System.Drawing.Size(110, 20);
            this.txtDisp.TabIndex = 28;
            this.txtDisp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // lblRetirada
            // 
            this.lblRetirada.AutoSize = true;
            this.lblRetirada.Location = new System.Drawing.Point(430, 84);
            this.lblRetirada.Name = "lblRetirada";
            this.lblRetirada.Size = new System.Drawing.Size(47, 13);
            this.lblRetirada.TabIndex = 31;
            this.lblRetirada.Text = "Retirada";
            // 
            // lblDevo
            // 
            this.lblDevo.AutoSize = true;
            this.lblDevo.Location = new System.Drawing.Point(430, 157);
            this.lblDevo.Name = "lblDevo";
            this.lblDevo.Size = new System.Drawing.Size(59, 13);
            this.lblDevo.TabIndex = 33;
            this.lblDevo.Text = "Devolução";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(433, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 32;
            // 
            // lblMulta
            // 
            this.lblMulta.AutoSize = true;
            this.lblMulta.Location = new System.Drawing.Point(430, 231);
            this.lblMulta.Name = "lblMulta";
            this.lblMulta.Size = new System.Drawing.Size(36, 13);
            this.lblMulta.TabIndex = 34;
            this.lblMulta.Text = "Multa:";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(474, 231);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.ReadOnly = true;
            this.txtMulta.Size = new System.Drawing.Size(110, 20);
            this.txtMulta.TabIndex = 35;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.lblMulta);
            this.Controls.Add(this.lblDevo);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblRetirada);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.txtDisp);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtPlaca);
            this.Name = "Editar";
            this.Text = "Editar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.TextBox txtDisp;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblRetirada;
        private System.Windows.Forms.Label lblDevo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblMulta;
        private System.Windows.Forms.TextBox txtMulta;
    }
}