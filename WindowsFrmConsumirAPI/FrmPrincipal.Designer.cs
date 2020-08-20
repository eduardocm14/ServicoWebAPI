namespace ServicoWebAPI
{
    partial class FrmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUriWebAPI = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnRetornarDados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço URI-WebAPI:";
            // 
            // txtUriWebAPI
            // 
            this.txtUriWebAPI.BackColor = System.Drawing.Color.LightGray;
            this.txtUriWebAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUriWebAPI.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUriWebAPI.Location = new System.Drawing.Point(172, 30);
            this.txtUriWebAPI.Name = "txtUriWebAPI";
            this.txtUriWebAPI.Size = new System.Drawing.Size(939, 23);
            this.txtUriWebAPI.TabIndex = 1;
            this.txtUriWebAPI.Text = "https://localhost:44347/api/Clientes/listagem";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(32, 71);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(1079, 440);
            this.dgvDados.TabIndex = 2;
            // 
            // btnRetornarDados
            // 
            this.btnRetornarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetornarDados.Location = new System.Drawing.Point(32, 533);
            this.btnRetornarDados.Name = "btnRetornarDados";
            this.btnRetornarDados.Size = new System.Drawing.Size(210, 49);
            this.btnRetornarDados.TabIndex = 3;
            this.btnRetornarDados.Text = "Retornar Dados";
            this.btnRetornarDados.UseVisualStyleBackColor = true;
            this.btnRetornarDados.Click += new System.EventHandler(this.BtnRetornarDados_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 594);
            this.Controls.Add(this.btnRetornarDados);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtUriWebAPI);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumir API - .NET CORE(Clientes)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUriWebAPI;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnRetornarDados;
    }
}

