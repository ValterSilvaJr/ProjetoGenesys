namespace ProjetoGenesys.App.view
{
    partial class FormBuscarUsuario
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
            this.dgvBuscarUsuario = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarUsuario
            // 
            this.dgvBuscarUsuario.AllowUserToAddRows = false;
            this.dgvBuscarUsuario.AllowUserToOrderColumns = true;
            this.dgvBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvNome,
            this.dgvEmail,
            this.dgvTipo,
            this.dgvDetalhes});
            this.dgvBuscarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuscarUsuario.Location = new System.Drawing.Point(0, 0);
            this.dgvBuscarUsuario.Name = "dgvBuscarUsuario";
            this.dgvBuscarUsuario.Size = new System.Drawing.Size(695, 471);
            this.dgvBuscarUsuario.TabIndex = 0;
            // 
            // dgvId
            // 
            this.dgvId.HeaderText = "Id";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            // 
            // dgvNome
            // 
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvTipo
            // 
            this.dgvTipo.HeaderText = "Tipo";
            this.dgvTipo.Name = "dgvTipo";
            this.dgvTipo.ReadOnly = true;
            // 
            // dgvDetalhes
            // 
            this.dgvDetalhes.HeaderText = "Detalhes";
            this.dgvDetalhes.Name = "dgvDetalhes";
            this.dgvDetalhes.ReadOnly = true;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 471);
            this.Controls.Add(this.dgvBuscarUsuario);
            this.MinimumSize = new System.Drawing.Size(711, 510);
            this.Name = "FormBuscarUsuario";
            this.Text = "Exibir Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipo;
        private System.Windows.Forms.DataGridViewButtonColumn dgvDetalhes;
    }
}