namespace Projeto_LP2
{
    partial class CadastroProdutoForm
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
            this.lblSelecioneProduto = new System.Windows.Forms.Label();
            this.cBoxProduto = new System.Windows.Forms.ComboBox();
            this.cBoxSupermercado = new System.Windows.Forms.ComboBox();
            this.lblSelecioneSupermercado = new System.Windows.Forms.Label();
            this.lblInformePreco = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelecioneProduto
            // 
            this.lblSelecioneProduto.AutoSize = true;
            this.lblSelecioneProduto.Location = new System.Drawing.Point(15, 20);
            this.lblSelecioneProduto.Name = "lblSelecioneProduto";
            this.lblSelecioneProduto.Size = new System.Drawing.Size(105, 13);
            this.lblSelecioneProduto.TabIndex = 0;
            this.lblSelecioneProduto.Text = "Selecione o produto:";
            // 
            // cBoxProduto
            // 
            this.cBoxProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxProduto.FormattingEnabled = true;
            this.cBoxProduto.Location = new System.Drawing.Point(160, 15);
            this.cBoxProduto.Name = "cBoxProduto";
            this.cBoxProduto.Size = new System.Drawing.Size(213, 21);
            this.cBoxProduto.TabIndex = 1;
            this.cBoxProduto.SelectedIndexChanged += new System.EventHandler(this.cBoxProduto_SelectedIndexChanged_1);
            // 
            // cBoxSupermercado
            // 
            this.cBoxSupermercado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxSupermercado.FormattingEnabled = true;
            this.cBoxSupermercado.Location = new System.Drawing.Point(160, 55);
            this.cBoxSupermercado.Name = "cBoxSupermercado";
            this.cBoxSupermercado.Size = new System.Drawing.Size(213, 21);
            this.cBoxSupermercado.TabIndex = 3;
            // 
            // lblSelecioneSupermercado
            // 
            this.lblSelecioneSupermercado.AutoSize = true;
            this.lblSelecioneSupermercado.Location = new System.Drawing.Point(15, 60);
            this.lblSelecioneSupermercado.Name = "lblSelecioneSupermercado";
            this.lblSelecioneSupermercado.Size = new System.Drawing.Size(136, 13);
            this.lblSelecioneSupermercado.TabIndex = 2;
            this.lblSelecioneSupermercado.Text = "Selecione o supermercado:";
            // 
            // lblInformePreco
            // 
            this.lblInformePreco.AutoSize = true;
            this.lblInformePreco.Location = new System.Drawing.Point(15, 100);
            this.lblInformePreco.Name = "lblInformePreco";
            this.lblInformePreco.Size = new System.Drawing.Size(84, 13);
            this.lblInformePreco.TabIndex = 4;
            this.lblInformePreco.Text = "Informe o preço:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecoProduto.Location = new System.Drawing.Point(160, 95);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(213, 20);
            this.txtPrecoProduto.TabIndex = 5;
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastraProduto.Location = new System.Drawing.Point(60, 150);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(120, 25);
            this.btnCadastraProduto.TabIndex = 6;
            this.btnCadastraProduto.Text = "Cadastrar";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.BtnCadastraProduto_click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(200, 150);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 25);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CadastroProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastraProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.lblInformePreco);
            this.Controls.Add(this.cBoxSupermercado);
            this.Controls.Add(this.lblSelecioneSupermercado);
            this.Controls.Add(this.cBoxProduto);
            this.Controls.Add(this.lblSelecioneProduto);
            this.Name = "CadastroProdutoForm";
            this.Text = "CadastroProdutoForm";
            this.Load += new System.EventHandler(this.CadastroProdutoLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelecioneProduto;
        private System.Windows.Forms.ComboBox cBoxProduto;
        private System.Windows.Forms.ComboBox cBoxSupermercado;
        private System.Windows.Forms.Label lblSelecioneSupermercado;
        private System.Windows.Forms.Label lblInformePreco;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Button btnCancelar;
    }
}