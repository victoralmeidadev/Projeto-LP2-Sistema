namespace Projeto_LP2.Views
{
    partial class SupermercadosView
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoverSupermercado = new System.Windows.Forms.Button();
            this.btnVisualizarSupermercado = new System.Windows.Forms.Button();
            this.btnEditarSupermercado = new System.Windows.Forms.Button();
            this.btnCadastrarSupermercado = new System.Windows.Forms.Button();
            this.dataGridViewSupermercados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txtFiltroSupermercado = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupermercados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridViewSupermercados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 550);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoverSupermercado);
            this.panel3.Controls.Add(this.btnVisualizarSupermercado);
            this.panel3.Controls.Add(this.btnEditarSupermercado);
            this.panel3.Controls.Add(this.btnCadastrarSupermercado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 505);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 45);
            this.panel3.TabIndex = 3;
            // 
            // btnRemoverSupermercado
            // 
            this.btnRemoverSupermercado.FlatAppearance.BorderSize = 0;
            this.btnRemoverSupermercado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoverSupermercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRemoverSupermercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverSupermercado.Location = new System.Drawing.Point(484, 0);
            this.btnRemoverSupermercado.Name = "btnRemoverSupermercado";
            this.btnRemoverSupermercado.Size = new System.Drawing.Size(75, 47);
            this.btnRemoverSupermercado.TabIndex = 7;
            this.btnRemoverSupermercado.Text = "Remover";
            this.btnRemoverSupermercado.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarSupermercado
            // 
            this.btnVisualizarSupermercado.FlatAppearance.BorderSize = 0;
            this.btnVisualizarSupermercado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVisualizarSupermercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVisualizarSupermercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarSupermercado.Location = new System.Drawing.Point(403, 0);
            this.btnVisualizarSupermercado.Name = "btnVisualizarSupermercado";
            this.btnVisualizarSupermercado.Size = new System.Drawing.Size(75, 47);
            this.btnVisualizarSupermercado.TabIndex = 6;
            this.btnVisualizarSupermercado.Text = "Visualizar";
            this.btnVisualizarSupermercado.UseVisualStyleBackColor = true;
            // 
            // btnEditarSupermercado
            // 
            this.btnEditarSupermercado.FlatAppearance.BorderSize = 0;
            this.btnEditarSupermercado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarSupermercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEditarSupermercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSupermercado.Location = new System.Drawing.Point(322, 0);
            this.btnEditarSupermercado.Name = "btnEditarSupermercado";
            this.btnEditarSupermercado.Size = new System.Drawing.Size(75, 47);
            this.btnEditarSupermercado.TabIndex = 5;
            this.btnEditarSupermercado.Text = "Editar";
            this.btnEditarSupermercado.UseVisualStyleBackColor = true;
            this.btnEditarSupermercado.Click += new System.EventHandler(this.btnEditarSupermercado_Click);
            // 
            // btnCadastrarSupermercado
            // 
            this.btnCadastrarSupermercado.FlatAppearance.BorderSize = 0;
            this.btnCadastrarSupermercado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarSupermercado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCadastrarSupermercado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarSupermercado.Location = new System.Drawing.Point(241, 0);
            this.btnCadastrarSupermercado.Name = "btnCadastrarSupermercado";
            this.btnCadastrarSupermercado.Size = new System.Drawing.Size(75, 47);
            this.btnCadastrarSupermercado.TabIndex = 4;
            this.btnCadastrarSupermercado.Text = "Cadastrar";
            this.btnCadastrarSupermercado.UseVisualStyleBackColor = true;
            this.btnCadastrarSupermercado.Click += new System.EventHandler(this.btnCadastrarSupermercado_Click);
            // 
            // dataGridViewSupermercados
            // 
            this.dataGridViewSupermercados.AllowUserToAddRows = false;
            this.dataGridViewSupermercados.AllowUserToDeleteRows = false;
            this.dataGridViewSupermercados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSupermercados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSupermercados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupermercados.Location = new System.Drawing.Point(-3, 53);
            this.dataGridViewSupermercados.Name = "dataGridViewSupermercados";
            this.dataGridViewSupermercados.ReadOnly = true;
            this.dataGridViewSupermercados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewSupermercados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupermercados.Size = new System.Drawing.Size(800, 446);
            this.dataGridViewSupermercados.TabIndex = 0;
            this.dataGridViewSupermercados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupermercados_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.txtFiltroSupermercado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(500, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 44);
            this.button5.TabIndex = 4;
            this.button5.Text = "Filtrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtFiltroSupermercado
            // 
            this.txtFiltroSupermercado.Location = new System.Drawing.Point(230, 15);
            this.txtFiltroSupermercado.Name = "txtFiltroSupermercado";
            this.txtFiltroSupermercado.Size = new System.Drawing.Size(260, 20);
            this.txtFiltroSupermercado.TabIndex = 3;
            this.txtFiltroSupermercado.TextChanged += new System.EventHandler(this.lblFiltroSupermercado_TextChanged);
            // 
            // SupermercadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupermercadosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupermercadosView";
            this.Load += new System.EventHandler(this.SupermercadosView_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupermercados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewSupermercados;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtFiltroSupermercado;
        private System.Windows.Forms.Button btnRemoverSupermercado;
        private System.Windows.Forms.Button btnVisualizarSupermercado;
        private System.Windows.Forms.Button btnEditarSupermercado;
        private System.Windows.Forms.Button btnCadastrarSupermercado;
    }
}