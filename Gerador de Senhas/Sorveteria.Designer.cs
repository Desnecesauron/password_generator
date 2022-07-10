namespace Sorveteria
{
    partial class Sorveteria
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
            this.sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Label();
            this.pedido = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.qtd = new System.Windows.Forms.Label();
            this.qtdcasq = new System.Windows.Forms.TextBox();
            this.qtdacai1 = new System.Windows.Forms.TextBox();
            this.qtdacai2 = new System.Windows.Forms.TextBox();
            this.qtdpic = new System.Windows.Forms.TextBox();
            this.qtdsorv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.pagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(307, 363);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(96, 26);
            this.sair.TabIndex = 9;
            this.sair.Text = "&Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.name);
            this.panel1.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 40);
            this.panel1.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(149, 8);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(127, 28);
            this.name.TabIndex = 2;
            this.name.Text = "Sorveteria ";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(32, 363);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(96, 26);
            this.calc.TabIndex = 7;
            this.calc.Text = "&Calcular";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(12, 63);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(48, 16);
            this.cliente.TabIndex = 4;
            this.cliente.Text = "Nome:";
            // 
            // pedido
            // 
            this.pedido.AutoSize = true;
            this.pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pedido.Location = new System.Drawing.Point(9, 97);
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(62, 16);
            this.pedido.TabIndex = 3;
            this.pedido.Text = "Pedidos:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(66, 62);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(155, 20);
            this.nome.TabIndex = 1;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // qtd
            // 
            this.qtd.AutoSize = true;
            this.qtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtd.Location = new System.Drawing.Point(151, 97);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(81, 16);
            this.qtd.TabIndex = 10;
            this.qtd.Text = "Quantidade:";
            this.qtd.Click += new System.EventHandler(this.qtd_Click);
            // 
            // qtdcasq
            // 
            this.qtdcasq.Location = new System.Drawing.Point(167, 116);
            this.qtdcasq.Name = "qtdcasq";
            this.qtdcasq.Size = new System.Drawing.Size(54, 20);
            this.qtdcasq.TabIndex = 2;
            this.qtdcasq.TextChanged += new System.EventHandler(this.qtdcasq_TextChanged);
            // 
            // qtdacai1
            // 
            this.qtdacai1.Location = new System.Drawing.Point(167, 142);
            this.qtdacai1.Name = "qtdacai1";
            this.qtdacai1.Size = new System.Drawing.Size(54, 20);
            this.qtdacai1.TabIndex = 3;
            // 
            // qtdacai2
            // 
            this.qtdacai2.Location = new System.Drawing.Point(167, 168);
            this.qtdacai2.Name = "qtdacai2";
            this.qtdacai2.Size = new System.Drawing.Size(54, 20);
            this.qtdacai2.TabIndex = 4;
            // 
            // qtdpic
            // 
            this.qtdpic.Location = new System.Drawing.Point(167, 217);
            this.qtdpic.Name = "qtdpic";
            this.qtdpic.Size = new System.Drawing.Size(54, 20);
            this.qtdpic.TabIndex = 6;
            // 
            // qtdsorv
            // 
            this.qtdsorv.Location = new System.Drawing.Point(167, 194);
            this.qtdsorv.Name = "qtdsorv";
            this.qtdsorv.Size = new System.Drawing.Size(54, 20);
            this.qtdsorv.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.p1);
            this.panel2.Controls.Add(this.total);
            this.panel2.Controls.Add(this.pagar);
            this.panel2.Location = new System.Drawing.Point(238, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 139);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.p1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.White;
            this.p1.Location = new System.Drawing.Point(3, 23);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(0, 16);
            this.p1.TabIndex = 23;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.LightSeaGreen;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(3, 7);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(112, 16);
            this.total.TabIndex = 22;
            this.total.Text = "Total da Compra:";
            this.total.Click += new System.EventHandler(this.label1_Click);
            // 
            // pagar
            // 
            this.pagar.AutoSize = true;
            this.pagar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar.ForeColor = System.Drawing.Color.White;
            this.pagar.Location = new System.Drawing.Point(3, 97);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(35, 16);
            this.pagar.TabIndex = 21;
            this.pagar.Text = "R$ 0";
            this.pagar.Click += new System.EventHandler(this.pagar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Casquinha (Sabores)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Açaí (250gr)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Açaí (500gr)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sorvete (1L)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Picolé (Sabores)";
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(167, 363);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(96, 26);
            this.limpar.TabIndex = 8;
            this.limpar.Text = "&Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Sorveteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(426, 414);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.qtdsorv);
            this.Controls.Add(this.qtdpic);
            this.Controls.Add(this.qtdacai2);
            this.Controls.Add(this.qtdacai1);
            this.Controls.Add(this.qtdcasq);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.pedido);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sair);
            this.Name = "Sorveteria";
            this.Text = "Sorveteria";
            this.Load += new System.EventHandler(this.Sorveteria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label cliente;
        private System.Windows.Forms.Label pedido;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label qtd;
        private System.Windows.Forms.TextBox qtdcasq;
        private System.Windows.Forms.TextBox qtdacai1;
        private System.Windows.Forms.TextBox qtdacai2;
        private System.Windows.Forms.TextBox qtdpic;
        private System.Windows.Forms.TextBox qtdsorv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pagar;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button limpar;
    }
}

