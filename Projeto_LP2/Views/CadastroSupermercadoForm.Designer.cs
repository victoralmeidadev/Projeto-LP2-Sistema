namespace Projeto_LP2.Views
{
    partial class CadastroSupermercadoForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastraSupermercado = new System.Windows.Forms.Button();
            this.txtNomeSupermercado = new System.Windows.Forms.TextBox();
            this.lblInformePreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(207, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 25);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnCadastraSupermercado
            // 
            this.btnCadastraSupermercado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCadastraSupermercado.Location = new System.Drawing.Point(67, 73);
            this.btnCadastraSupermercado.Name = "btnCadastraSupermercado";
            this.btnCadastraSupermercado.Size = new System.Drawing.Size(120, 25);
            this.btnCadastraSupermercado.TabIndex = 10;
            this.btnCadastraSupermercado.Text = "Cadastrar";
            this.btnCadastraSupermercado.UseVisualStyleBackColor = true;
            this.btnCadastraSupermercado.Click += new System.EventHandler(this.BtnCadastraSupermercado_Click);
            // 
            // txtNomeSupermercado
            // 
            this.txtNomeSupermercado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeSupermercado.Location = new System.Drawing.Point(136, 20);
            this.txtNomeSupermercado.Name = "txtNomeSupermercado";
            this.txtNomeSupermercado.Size = new System.Drawing.Size(236, 20);
            this.txtNomeSupermercado.TabIndex = 9;
            // 
            // lblInformePreco
            // 
            this.lblInformePreco.AutoSize = true;
            this.lblInformePreco.Location = new System.Drawing.Point(22, 23);
            this.lblInformePreco.Name = "lblInformePreco";
            this.lblInformePreco.Size = new System.Drawing.Size(108, 13);
            this.lblInformePreco.TabIndex = 8;
            this.lblInformePreco.Text = "Nome supermercado:";
            // 
            // CadastroSupermercadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastraSupermercado);
            this.Controls.Add(this.txtNomeSupermercado);
            this.Controls.Add(this.lblInformePreco);
            this.Name = "CadastroSupermercadoForm";
            this.Text = "CadastroSupermercadoForm";
            this.Load += new System.EventHandler(this.CadastroSupermercadoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastraSupermercado;
        private System.Windows.Forms.TextBox txtNomeSupermercado;
        private System.Windows.Forms.Label lblInformePreco;
    }
}