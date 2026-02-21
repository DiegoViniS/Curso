namespace AppTempo
{
    partial class frmTempo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFechar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblUmidade = new System.Windows.Forms.Label();
            this.lblPressao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(458, 125);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(235, 72);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(41, 37);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 15);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "CIDADE";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(44, 55);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(356, 20);
            this.txtCidade.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(458, 37);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(235, 63);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "CIDADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PAÍS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "TEMPERATURA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "DESCRIÇÃO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "UMIDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "PRESSÃO";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(210, 149);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(35, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "label8";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(210, 184);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(35, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "label9";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(210, 214);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(41, 13);
            this.lblTemperatura.TabIndex = 12;
            this.lblTemperatura.Text = "label10";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(210, 254);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(41, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "label11";
            // 
            // lblUmidade
            // 
            this.lblUmidade.AutoSize = true;
            this.lblUmidade.Location = new System.Drawing.Point(210, 285);
            this.lblUmidade.Name = "lblUmidade";
            this.lblUmidade.Size = new System.Drawing.Size(41, 13);
            this.lblUmidade.TabIndex = 14;
            this.lblUmidade.Text = "label12";
            // 
            // lblPressao
            // 
            this.lblPressao.AutoSize = true;
            this.lblPressao.Location = new System.Drawing.Point(210, 316);
            this.lblPressao.Name = "lblPressao";
            this.lblPressao.Size = new System.Drawing.Size(41, 13);
            this.lblPressao.TabIndex = 15;
            this.lblPressao.Text = "label13";
            // 
            // frmTempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPressao);
            this.Controls.Add(this.lblUmidade);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTempo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmTempo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblUmidade;
        private System.Windows.Forms.Label lblPressao;
    }
}

