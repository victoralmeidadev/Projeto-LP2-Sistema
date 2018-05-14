namespace Projeto_LP2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroNovoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSupermercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPreçoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoPorProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porSupermercadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEscolheOpcao = new System.Windows.Forms.Label();
            this.cBoxEscolheVisualizacao = new System.Windows.Forms.ComboBox();
            this.graficoHistorico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblSupermercado1 = new System.Windows.Forms.Label();
            this.cBoxSupermercado1 = new System.Windows.Forms.ComboBox();
            this.cBoxSupermercado2 = new System.Windows.Forms.ComboBox();
            this.lblSupermercado2 = new System.Windows.Forms.Label();
            this.cBoxProduto = new System.Windows.Forms.ComboBox();
            this.cBoxSupermercadoProduto = new System.Windows.Forms.ComboBox();
            this.lblSupermercadoProduto = new System.Windows.Forms.Label();
            this.btnVisualizarHistorico = new System.Windows.Forms.Button();
            this.verListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.listaDeComprasToolStripMenuItem,
            this.preçosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroNovoProdutoToolStripMenuItem,
            this.novoSupermercadoToolStripMenuItem,
            this.novoPreçoProdutoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // cadastroNovoProdutoToolStripMenuItem
            // 
            this.cadastroNovoProdutoToolStripMenuItem.Name = "cadastroNovoProdutoToolStripMenuItem";
            this.cadastroNovoProdutoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cadastroNovoProdutoToolStripMenuItem.Text = "Novo produto";
            this.cadastroNovoProdutoToolStripMenuItem.Click += new System.EventHandler(this.CadastroNovoProduto_Click);
            // 
            // novoSupermercadoToolStripMenuItem
            // 
            this.novoSupermercadoToolStripMenuItem.Name = "novoSupermercadoToolStripMenuItem";
            this.novoSupermercadoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoSupermercadoToolStripMenuItem.Text = "Novo supermercado";
            this.novoSupermercadoToolStripMenuItem.Click += new System.EventHandler(this.NovoSupermercadoToolStripMenuItem_Click);
            // 
            // novoPreçoProdutoToolStripMenuItem
            // 
            this.novoPreçoProdutoToolStripMenuItem.Name = "novoPreçoProdutoToolStripMenuItem";
            this.novoPreçoProdutoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.novoPreçoProdutoToolStripMenuItem.Text = "Novo preço produto";
            this.novoPreçoProdutoToolStripMenuItem.Click += new System.EventHandler(this.NovoPreçoProdutoToolStripMenuItem_Click);
            // 
            // listaDeComprasToolStripMenuItem
            // 
            this.listaDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaListaToolStripMenuItem,
            this.verListasToolStripMenuItem});
            this.listaDeComprasToolStripMenuItem.Name = "listaDeComprasToolStripMenuItem";
            this.listaDeComprasToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.listaDeComprasToolStripMenuItem.Text = "Lista de compras";
            // 
            // novaListaToolStripMenuItem
            // 
            this.novaListaToolStripMenuItem.Name = "novaListaToolStripMenuItem";
            this.novaListaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaListaToolStripMenuItem.Text = "Nova lista";
            this.novaListaToolStripMenuItem.Click += new System.EventHandler(this.novaListaToolStripMenuItem_Click);
            // 
            // preçosToolStripMenuItem
            // 
            this.preçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historicoPorProToolStripMenuItem,
            this.porSupermercadoToolStripMenuItem});
            this.preçosToolStripMenuItem.Name = "preçosToolStripMenuItem";
            this.preçosToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.preçosToolStripMenuItem.Text = "Historico de preços";
            this.preçosToolStripMenuItem.Click += new System.EventHandler(this.preçosToolStripMenuItem_Click);
            // 
            // historicoPorProToolStripMenuItem
            // 
            this.historicoPorProToolStripMenuItem.Name = "historicoPorProToolStripMenuItem";
            this.historicoPorProToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.historicoPorProToolStripMenuItem.Text = "Por produto";
            // 
            // porSupermercadoToolStripMenuItem
            // 
            this.porSupermercadoToolStripMenuItem.Name = "porSupermercadoToolStripMenuItem";
            this.porSupermercadoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porSupermercadoToolStripMenuItem.Text = "Por supermercado";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // lblEscolheOpcao
            // 
            this.lblEscolheOpcao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEscolheOpcao.AutoSize = true;
            this.lblEscolheOpcao.Location = new System.Drawing.Point(268, 35);
            this.lblEscolheOpcao.Name = "lblEscolheOpcao";
            this.lblEscolheOpcao.Size = new System.Drawing.Size(131, 13);
            this.lblEscolheOpcao.TabIndex = 2;
            this.lblEscolheOpcao.Text = "Ver histórico de preço por:";
            // 
            // cBoxEscolheVisualizacao
            // 
            this.cBoxEscolheVisualizacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxEscolheVisualizacao.FormattingEnabled = true;
            this.cBoxEscolheVisualizacao.Items.AddRange(new object[] {
            "Produtos",
            "Supermercados"});
            this.cBoxEscolheVisualizacao.Location = new System.Drawing.Point(422, 30);
            this.cBoxEscolheVisualizacao.Name = "cBoxEscolheVisualizacao";
            this.cBoxEscolheVisualizacao.Size = new System.Drawing.Size(121, 21);
            this.cBoxEscolheVisualizacao.TabIndex = 3;
            this.cBoxEscolheVisualizacao.SelectedIndexChanged += new System.EventHandler(this.CBoxEscolheVisualizacao_SelectedIndexChanged);
            // 
            // graficoHistorico
            // 
            this.graficoHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.graficoHistorico.ChartAreas.Add(chartArea2);
            this.graficoHistorico.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.graficoHistorico.Legends.Add(legend2);
            this.graficoHistorico.Location = new System.Drawing.Point(0, 152);
            this.graficoHistorico.Name = "graficoHistorico";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Supermercado";
            this.graficoHistorico.Series.Add(series2);
            this.graficoHistorico.Size = new System.Drawing.Size(800, 286);
            this.graficoHistorico.TabIndex = 4;
            this.graficoHistorico.Text = "chart1";
            // 
            // lblProduto
            // 
            this.lblProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(411, 63);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(105, 13);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Selecione o produto:";
            this.lblProduto.Visible = false;
            // 
            // lblSupermercado1
            // 
            this.lblSupermercado1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupermercado1.AutoSize = true;
            this.lblSupermercado1.Location = new System.Drawing.Point(127, 68);
            this.lblSupermercado1.Name = "lblSupermercado1";
            this.lblSupermercado1.Size = new System.Drawing.Size(145, 13);
            this.lblSupermercado1.TabIndex = 6;
            this.lblSupermercado1.Text = "Selecione o supermercado 1:";
            this.lblSupermercado1.Visible = false;
            // 
            // cBoxSupermercado1
            // 
            this.cBoxSupermercado1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxSupermercado1.FormattingEnabled = true;
            this.cBoxSupermercado1.Location = new System.Drawing.Point(278, 63);
            this.cBoxSupermercado1.Name = "cBoxSupermercado1";
            this.cBoxSupermercado1.Size = new System.Drawing.Size(121, 21);
            this.cBoxSupermercado1.TabIndex = 8;
            this.cBoxSupermercado1.Visible = false;
            // 
            // cBoxSupermercado2
            // 
            this.cBoxSupermercado2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxSupermercado2.FormattingEnabled = true;
            this.cBoxSupermercado2.Location = new System.Drawing.Point(278, 93);
            this.cBoxSupermercado2.Name = "cBoxSupermercado2";
            this.cBoxSupermercado2.Size = new System.Drawing.Size(121, 21);
            this.cBoxSupermercado2.TabIndex = 10;
            this.cBoxSupermercado2.Visible = false;
            // 
            // lblSupermercado2
            // 
            this.lblSupermercado2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupermercado2.AutoSize = true;
            this.lblSupermercado2.Location = new System.Drawing.Point(127, 98);
            this.lblSupermercado2.Name = "lblSupermercado2";
            this.lblSupermercado2.Size = new System.Drawing.Size(145, 13);
            this.lblSupermercado2.TabIndex = 9;
            this.lblSupermercado2.Text = "Selecione o supermercado 2:";
            this.lblSupermercado2.Visible = false;
            // 
            // cBoxProduto
            // 
            this.cBoxProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxProduto.FormattingEnabled = true;
            this.cBoxProduto.Location = new System.Drawing.Point(553, 60);
            this.cBoxProduto.Name = "cBoxProduto";
            this.cBoxProduto.Size = new System.Drawing.Size(121, 21);
            this.cBoxProduto.TabIndex = 11;
            this.cBoxProduto.Visible = false;
            // 
            // cBoxSupermercadoProduto
            // 
            this.cBoxSupermercadoProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxSupermercadoProduto.FormattingEnabled = true;
            this.cBoxSupermercadoProduto.Location = new System.Drawing.Point(553, 95);
            this.cBoxSupermercadoProduto.Name = "cBoxSupermercadoProduto";
            this.cBoxSupermercadoProduto.Size = new System.Drawing.Size(121, 21);
            this.cBoxSupermercadoProduto.TabIndex = 13;
            this.cBoxSupermercadoProduto.Visible = false;
            // 
            // lblSupermercadoProduto
            // 
            this.lblSupermercadoProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSupermercadoProduto.AutoSize = true;
            this.lblSupermercadoProduto.Location = new System.Drawing.Point(411, 98);
            this.lblSupermercadoProduto.Name = "lblSupermercadoProduto";
            this.lblSupermercadoProduto.Size = new System.Drawing.Size(136, 13);
            this.lblSupermercadoProduto.TabIndex = 12;
            this.lblSupermercadoProduto.Text = "Selecione o supermercado:";
            this.lblSupermercadoProduto.Visible = false;
            // 
            // btnVisualizarHistorico
            // 
            this.btnVisualizarHistorico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVisualizarHistorico.Location = new System.Drawing.Point(411, 126);
            this.btnVisualizarHistorico.Name = "btnVisualizarHistorico";
            this.btnVisualizarHistorico.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarHistorico.TabIndex = 14;
            this.btnVisualizarHistorico.Text = "Visualizar";
            this.btnVisualizarHistorico.UseVisualStyleBackColor = true;
            this.btnVisualizarHistorico.Visible = false;
            this.btnVisualizarHistorico.Click += new System.EventHandler(this.btnVisualizarHistorico_Click);
            // 
            // verListasToolStripMenuItem
            // 
            this.verListasToolStripMenuItem.Name = "verListasToolStripMenuItem";
            this.verListasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListasToolStripMenuItem.Text = "Ver listas";
            this.verListasToolStripMenuItem.Click += new System.EventHandler(this.verListasToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizarHistorico);
            this.Controls.Add(this.cBoxSupermercadoProduto);
            this.Controls.Add(this.lblSupermercadoProduto);
            this.Controls.Add(this.cBoxProduto);
            this.Controls.Add(this.cBoxSupermercado2);
            this.Controls.Add(this.lblSupermercado2);
            this.Controls.Add(this.cBoxSupermercado1);
            this.Controls.Add(this.lblSupermercado1);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.graficoHistorico);
            this.Controls.Add(this.cBoxEscolheVisualizacao);
            this.Controls.Add(this.lblEscolheOpcao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroNovoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoSupermercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoPorProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porSupermercadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPreçoProdutoToolStripMenuItem;
        private System.Windows.Forms.Label lblEscolheOpcao;
        private System.Windows.Forms.ComboBox cBoxEscolheVisualizacao;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistorico;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblSupermercado1;
        private System.Windows.Forms.ComboBox cBoxSupermercado1;
        private System.Windows.Forms.ComboBox cBoxSupermercado2;
        private System.Windows.Forms.Label lblSupermercado2;
        private System.Windows.Forms.ComboBox cBoxProduto;
        private System.Windows.Forms.ComboBox cBoxSupermercadoProduto;
        private System.Windows.Forms.Label lblSupermercadoProduto;
        private System.Windows.Forms.Button btnVisualizarHistorico;
        private System.Windows.Forms.ToolStripMenuItem verListasToolStripMenuItem;
    }
}

