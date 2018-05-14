namespace Projeto_LP2.Views
{
    partial class NovaListaForm
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
            this.lblNomeLista = new System.Windows.Forms.Label();
            this.txtNomeLista = new System.Windows.Forms.TextBox();
            this.lblTipoRecebimento = new System.Windows.Forms.Label();
            this.lblPrecoEntrega = new System.Windows.Forms.Label();
            this.txtPrecoEntrega = new System.Windows.Forms.TextBox();
            this.lblPrecoCombustivel = new System.Windows.Forms.Label();
            this.txtPrecoCombustivel = new System.Windows.Forms.TextBox();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.btnSalvarNovaLista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.radioButtonEntrega = new System.Windows.Forms.RadioButton();
            this.radioButtonVeiculoParticular = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNomeLista
            // 
            this.lblNomeLista.AutoSize = true;
            this.lblNomeLista.Location = new System.Drawing.Point(10, 20);
            this.lblNomeLista.Name = "lblNomeLista";
            this.lblNomeLista.Size = new System.Drawing.Size(78, 13);
            this.lblNomeLista.TabIndex = 0;
            this.lblNomeLista.Text = "Nome da Lista:";
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Location = new System.Drawing.Point(94, 17);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(205, 20);
            this.txtNomeLista.TabIndex = 1;
            // 
            // lblTipoRecebimento
            // 
            this.lblTipoRecebimento.AutoSize = true;
            this.lblTipoRecebimento.Location = new System.Drawing.Point(81, 58);
            this.lblTipoRecebimento.Name = "lblTipoRecebimento";
            this.lblTipoRecebimento.Size = new System.Drawing.Size(157, 13);
            this.lblTipoRecebimento.TabIndex = 2;
            this.lblTipoRecebimento.Text = "Tipo de recebimento da compra";
            // 
            // lblPrecoEntrega
            // 
            this.lblPrecoEntrega.AutoSize = true;
            this.lblPrecoEntrega.Location = new System.Drawing.Point(13, 129);
            this.lblPrecoEntrega.Name = "lblPrecoEntrega";
            this.lblPrecoEntrega.Size = new System.Drawing.Size(92, 13);
            this.lblPrecoEntrega.TabIndex = 5;
            this.lblPrecoEntrega.Text = "Preço da entrega:";
            this.lblPrecoEntrega.Visible = false;
            // 
            // txtPrecoEntrega
            // 
            this.txtPrecoEntrega.Location = new System.Drawing.Point(133, 129);
            this.txtPrecoEntrega.Name = "txtPrecoEntrega";
            this.txtPrecoEntrega.Size = new System.Drawing.Size(166, 20);
            this.txtPrecoEntrega.TabIndex = 6;
            this.txtPrecoEntrega.Visible = false;
            // 
            // lblPrecoCombustivel
            // 
            this.lblPrecoCombustivel.AutoSize = true;
            this.lblPrecoCombustivel.Location = new System.Drawing.Point(13, 129);
            this.lblPrecoCombustivel.Name = "lblPrecoCombustivel";
            this.lblPrecoCombustivel.Size = new System.Drawing.Size(114, 13);
            this.lblPrecoCombustivel.TabIndex = 7;
            this.lblPrecoCombustivel.Text = "Preço combustível (L):";
            this.lblPrecoCombustivel.Visible = false;
            this.lblPrecoCombustivel.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPrecoCombustivel
            // 
            this.txtPrecoCombustivel.Location = new System.Drawing.Point(133, 129);
            this.txtPrecoCombustivel.Name = "txtPrecoCombustivel";
            this.txtPrecoCombustivel.Size = new System.Drawing.Size(166, 20);
            this.txtPrecoCombustivel.TabIndex = 8;
            this.txtPrecoCombustivel.Visible = false;
            // 
            // txtRendimento
            // 
            this.txtRendimento.Location = new System.Drawing.Point(133, 156);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(166, 20);
            this.txtRendimento.TabIndex = 10;
            this.txtRendimento.Visible = false;
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(13, 156);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(103, 13);
            this.lblRendimento.TabIndex = 9;
            this.lblRendimento.Text = "Rendimento (KM/L):";
            this.lblRendimento.Visible = false;
            // 
            // btnSalvarNovaLista
            // 
            this.btnSalvarNovaLista.Location = new System.Drawing.Point(39, 201);
            this.btnSalvarNovaLista.Name = "btnSalvarNovaLista";
            this.btnSalvarNovaLista.Size = new System.Drawing.Size(98, 57);
            this.btnSalvarNovaLista.TabIndex = 11;
            this.btnSalvarNovaLista.Text = "Salvar";
            this.btnSalvarNovaLista.UseVisualStyleBackColor = true;
            this.btnSalvarNovaLista.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 57);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButtonEntrega
            // 
            this.radioButtonEntrega.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonEntrega.AutoSize = true;
            this.radioButtonEntrega.Location = new System.Drawing.Point(84, 85);
            this.radioButtonEntrega.Name = "radioButtonEntrega";
            this.radioButtonEntrega.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEntrega.TabIndex = 13;
            this.radioButtonEntrega.TabStop = true;
            this.radioButtonEntrega.Text = "Entrega";
            this.radioButtonEntrega.UseVisualStyleBackColor = true;
            this.radioButtonEntrega.CheckedChanged += new System.EventHandler(this.radioButtonEntrega_CheckedChanged);
            // 
            // radioButtonVeiculoParticular
            // 
            this.radioButtonVeiculoParticular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonVeiculoParticular.AutoSize = true;
            this.radioButtonVeiculoParticular.Location = new System.Drawing.Point(168, 85);
            this.radioButtonVeiculoParticular.Name = "radioButtonVeiculoParticular";
            this.radioButtonVeiculoParticular.Size = new System.Drawing.Size(109, 17);
            this.radioButtonVeiculoParticular.TabIndex = 14;
            this.radioButtonVeiculoParticular.TabStop = true;
            this.radioButtonVeiculoParticular.Text = "Veículo Particular";
            this.radioButtonVeiculoParticular.UseVisualStyleBackColor = true;
            this.radioButtonVeiculoParticular.CheckedChanged += new System.EventHandler(this.radioButtonVeiculoParticular_CheckedChanged);
            // 
            // NovaListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 270);
            this.Controls.Add(this.radioButtonVeiculoParticular);
            this.Controls.Add(this.radioButtonEntrega);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarNovaLista);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.txtPrecoCombustivel);
            this.Controls.Add(this.lblPrecoCombustivel);
            this.Controls.Add(this.txtPrecoEntrega);
            this.Controls.Add(this.lblPrecoEntrega);
            this.Controls.Add(this.lblTipoRecebimento);
            this.Controls.Add(this.txtNomeLista);
            this.Controls.Add(this.lblNomeLista);
            this.Name = "NovaListaForm";
            this.Text = "NovaListaForm";
            this.Load += new System.EventHandler(this.NovaListaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeLista;
        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Label lblTipoRecebimento;
        private System.Windows.Forms.Label lblPrecoEntrega;
        private System.Windows.Forms.TextBox txtPrecoEntrega;
        private System.Windows.Forms.Label lblPrecoCombustivel;
        private System.Windows.Forms.TextBox txtPrecoCombustivel;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Button btnSalvarNovaLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton radioButtonEntrega;
        private System.Windows.Forms.RadioButton radioButtonVeiculoParticular;
    }
}