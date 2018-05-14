namespace Projeto_LP2.Views
{
    partial class ListasForm
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
            this.cBoxListas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.btnAtualizarListas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxListas
            // 
            this.cBoxListas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cBoxListas.FormattingEnabled = true;
            this.cBoxListas.Location = new System.Drawing.Point(310, 30);
            this.cBoxListas.Name = "cBoxListas";
            this.cBoxListas.Size = new System.Drawing.Size(254, 21);
            this.cBoxListas.TabIndex = 0;
            this.cBoxListas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a lista que deseja visualizar";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView.Location = new System.Drawing.Point(12, 57);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(776, 337);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdicionarProduto.Location = new System.Drawing.Point(426, 400);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(75, 38);
            this.btnAdicionarProduto.TabIndex = 3;
            this.btnAdicionarProduto.Text = "Adicionar produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovaLista.Location = new System.Drawing.Point(331, 400);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(75, 38);
            this.btnNovaLista.TabIndex = 4;
            this.btnNovaLista.Text = "Nova Lista";
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // btnAtualizarListas
            // 
            this.btnAtualizarListas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtualizarListas.Location = new System.Drawing.Point(585, 27);
            this.btnAtualizarListas.Name = "btnAtualizarListas";
            this.btnAtualizarListas.Size = new System.Drawing.Size(138, 23);
            this.btnAtualizarListas.TabIndex = 5;
            this.btnAtualizarListas.Text = "Atualizar Listas";
            this.btnAtualizarListas.UseVisualStyleBackColor = true;
            this.btnAtualizarListas.Click += new System.EventHandler(this.btnAtualizarListas_Click);
            // 
            // ListasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtualizarListas);
            this.Controls.Add(this.btnNovaLista);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxListas);
            this.Name = "ListasForm";
            this.Text = "ListasForm";
            this.Load += new System.EventHandler(this.ListasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxListas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.Button btnAtualizarListas;
    }
}