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
            this.btnSalvarNovaLista = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeLista
            // 
            this.lblNomeLista.AutoSize = true;
            this.lblNomeLista.Location = new System.Drawing.Point(70, 66);
            this.lblNomeLista.Name = "lblNomeLista";
            this.lblNomeLista.Size = new System.Drawing.Size(78, 13);
            this.lblNomeLista.TabIndex = 0;
            this.lblNomeLista.Text = "Nome da Lista:";
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Location = new System.Drawing.Point(154, 63);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(202, 20);
            this.txtNomeLista.TabIndex = 1;
            // 
            // btnSalvarNovaLista
            // 
            this.btnSalvarNovaLista.FlatAppearance.BorderSize = 0;
            this.btnSalvarNovaLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvarNovaLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalvarNovaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarNovaLista.Location = new System.Drawing.Point(91, 113);
            this.btnSalvarNovaLista.Name = "btnSalvarNovaLista";
            this.btnSalvarNovaLista.Size = new System.Drawing.Size(98, 57);
            this.btnSalvarNovaLista.TabIndex = 11;
            this.btnSalvarNovaLista.Text = "Concluir";
            this.btnSalvarNovaLista.UseVisualStyleBackColor = true;
            this.btnSalvarNovaLista.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(195, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 57);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AC Brodie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nova lista de compras";
            // 
            // NovaListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(387, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarNovaLista);
            this.Controls.Add(this.txtNomeLista);
            this.Controls.Add(this.lblNomeLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovaListaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NovaListaForm";
            this.Load += new System.EventHandler(this.NovaListaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeLista;
        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Button btnSalvarNovaLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}