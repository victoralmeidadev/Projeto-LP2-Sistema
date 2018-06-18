namespace Projeto_LP2.Views
{
    partial class CadastroNovoProduto
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
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto1 = new System.Windows.Forms.Label();
            this.lblSupermercadoProduto1 = new System.Windows.Forms.Label();
            this.txtNomeNovoProduto = new System.Windows.Forms.TextBox();
            this.txtCodigoNovoProduto = new System.Windows.Forms.TextBox();
            this.cBoxSupermercadoNovoProduto = new System.Windows.Forms.ComboBox();
            this.BtnCadastraNovoProduto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.cBoxCategoriaNovoProduto = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtPrecoNovoProduto = new System.Windows.Forms.TextBox();
            this.lblNovaCategoria = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(12, 30);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(38, 13);
            this.lblNomeProduto.TabIndex = 0;
            this.lblNomeProduto.Text = "Nome:";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(12, 70);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoProduto.TabIndex = 1;
            this.lblCodigoProduto.Text = "Código:";
            // 
            // lblPrecoProduto1
            // 
            this.lblPrecoProduto1.AutoSize = true;
            this.lblPrecoProduto1.Location = new System.Drawing.Point(12, 110);
            this.lblPrecoProduto1.Name = "lblPrecoProduto1";
            this.lblPrecoProduto1.Size = new System.Drawing.Size(38, 13);
            this.lblPrecoProduto1.TabIndex = 2;
            this.lblPrecoProduto1.Text = "Preço:";
            // 
            // lblSupermercadoProduto1
            // 
            this.lblSupermercadoProduto1.AutoSize = true;
            this.lblSupermercadoProduto1.Location = new System.Drawing.Point(12, 150);
            this.lblSupermercadoProduto1.Name = "lblSupermercadoProduto1";
            this.lblSupermercadoProduto1.Size = new System.Drawing.Size(79, 13);
            this.lblSupermercadoProduto1.TabIndex = 3;
            this.lblSupermercadoProduto1.Text = "Supermercado:";
            // 
            // txtNomeNovoProduto
            // 
            this.txtNomeNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeNovoProduto.Location = new System.Drawing.Point(110, 30);
            this.txtNomeNovoProduto.Name = "txtNomeNovoProduto";
            this.txtNomeNovoProduto.Size = new System.Drawing.Size(308, 20);
            this.txtNomeNovoProduto.TabIndex = 5;
            this.txtNomeNovoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeNovoProduto_KeyPress);
            // 
            // txtCodigoNovoProduto
            // 
            this.txtCodigoNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoNovoProduto.Location = new System.Drawing.Point(110, 70);
            this.txtCodigoNovoProduto.MaxLength = 7;
            this.txtCodigoNovoProduto.Name = "txtCodigoNovoProduto";
            this.txtCodigoNovoProduto.Size = new System.Drawing.Size(308, 20);
            this.txtCodigoNovoProduto.TabIndex = 6;
            this.txtCodigoNovoProduto.TextChanged += new System.EventHandler(this.txtCodigoNovoProduto_TextChanged);
            this.txtCodigoNovoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoNovoProduto_KeyPress);
            // 
            // cBoxSupermercadoNovoProduto
            // 
            this.cBoxSupermercadoNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxSupermercadoNovoProduto.FormattingEnabled = true;
            this.cBoxSupermercadoNovoProduto.Location = new System.Drawing.Point(110, 150);
            this.cBoxSupermercadoNovoProduto.Name = "cBoxSupermercadoNovoProduto";
            this.cBoxSupermercadoNovoProduto.Size = new System.Drawing.Size(308, 21);
            this.cBoxSupermercadoNovoProduto.TabIndex = 8;
            // 
            // BtnCadastraNovoProduto
            // 
            this.BtnCadastraNovoProduto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCadastraNovoProduto.Location = new System.Drawing.Point(147, 242);
            this.BtnCadastraNovoProduto.Name = "BtnCadastraNovoProduto";
            this.BtnCadastraNovoProduto.Size = new System.Drawing.Size(75, 40);
            this.BtnCadastraNovoProduto.TabIndex = 15;
            this.BtnCadastraNovoProduto.Text = "Cadastrar";
            this.BtnCadastraNovoProduto.UseVisualStyleBackColor = true;
            this.BtnCadastraNovoProduto.Click += new System.EventHandler(this.BtnCadastrarNovoProduto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCancelar.Location = new System.Drawing.Point(228, 242);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 40);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cBoxCategoriaNovoProduto
            // 
            this.cBoxCategoriaNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBoxCategoriaNovoProduto.FormattingEnabled = true;
            this.cBoxCategoriaNovoProduto.Location = new System.Drawing.Point(110, 191);
            this.cBoxCategoriaNovoProduto.Name = "cBoxCategoriaNovoProduto";
            this.cBoxCategoriaNovoProduto.Size = new System.Drawing.Size(308, 21);
            this.cBoxCategoriaNovoProduto.TabIndex = 20;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 191);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 19;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtPrecoNovoProduto
            // 
            this.txtPrecoNovoProduto.Location = new System.Drawing.Point(110, 107);
            this.txtPrecoNovoProduto.Name = "txtPrecoNovoProduto";
            this.txtPrecoNovoProduto.Size = new System.Drawing.Size(308, 20);
            this.txtPrecoNovoProduto.TabIndex = 22;
            this.txtPrecoNovoProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoNovoProduto_KeyPress_1);
            // 
            // lblNovaCategoria
            // 
            this.lblNovaCategoria.AutoSize = true;
            this.lblNovaCategoria.Location = new System.Drawing.Point(210, 215);
            this.lblNovaCategoria.Name = "lblNovaCategoria";
            this.lblNovaCategoria.Size = new System.Drawing.Size(208, 13);
            this.lblNovaCategoria.TabIndex = 23;
            this.lblNovaCategoria.TabStop = true;
            this.lblNovaCategoria.Text = "Não encontrou a categoria? Cadastre aqui";
            this.lblNovaCategoria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNovaCategoria_LinkClicked);
            // 
            // CadastroNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 303);
            this.Controls.Add(this.lblNovaCategoria);
            this.Controls.Add(this.txtPrecoNovoProduto);
            this.Controls.Add(this.cBoxCategoriaNovoProduto);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastraNovoProduto);
            this.Controls.Add(this.cBoxSupermercadoNovoProduto);
            this.Controls.Add(this.txtCodigoNovoProduto);
            this.Controls.Add(this.txtNomeNovoProduto);
            this.Controls.Add(this.lblSupermercadoProduto1);
            this.Controls.Add(this.lblPrecoProduto1);
            this.Controls.Add(this.lblCodigoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Name = "CadastroNovoProduto";
            this.Text = "CadastroNovoProduto";
            this.Load += new System.EventHandler(this.CadastroNovoProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label lblPrecoProduto1;
        private System.Windows.Forms.Label lblSupermercadoProduto1;
        private System.Windows.Forms.TextBox txtNomeNovoProduto;
        private System.Windows.Forms.TextBox txtCodigoNovoProduto;
        private System.Windows.Forms.ComboBox cBoxSupermercadoNovoProduto;
        private System.Windows.Forms.Button BtnCadastraNovoProduto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox cBoxCategoriaNovoProduto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtPrecoNovoProduto;
        private System.Windows.Forms.LinkLabel lblNovaCategoria;
    }
}