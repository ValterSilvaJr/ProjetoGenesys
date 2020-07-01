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
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.dtrId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtrNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtrEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtrTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtvCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtrBtnDetalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUsuario)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarUsuario
            // 
            this.dgvBuscarUsuario.AllowUserToAddRows = false;
            this.dgvBuscarUsuario.AllowUserToDeleteRows = false;
            this.dgvBuscarUsuario.AllowUserToOrderColumns = true;
            this.dgvBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtrId,
            this.dtrNome,
            this.dtrEmail,
            this.dtrTipo,
            this.dtvCargo,
            this.dtrBtnDetalhes});
            this.dgvBuscarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuscarUsuario.Location = new System.Drawing.Point(0, 0);
            this.dgvBuscarUsuario.Name = "dgvBuscarUsuario";
            this.dgvBuscarUsuario.ReadOnly = true;
            this.dgvBuscarUsuario.Size = new System.Drawing.Size(695, 471);
            this.dgvBuscarUsuario.TabIndex = 0;
            this.dgvBuscarUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarUsuario_CellContentClick);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlChildForm.Controls.Add(this.dgvBuscarUsuario);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(695, 471);
            this.pnlChildForm.TabIndex = 1;
            // 
            // dtrId
            // 
            this.dtrId.DataPropertyName = "id_usuario";
            this.dtrId.Frozen = true;
            this.dtrId.HeaderText = "Id";
            this.dtrId.Name = "dtrId";
            this.dtrId.ReadOnly = true;
            // 
            // dtrNome
            // 
            this.dtrNome.DataPropertyName = "nome";
            this.dtrNome.Frozen = true;
            this.dtrNome.HeaderText = "Nome";
            this.dtrNome.Name = "dtrNome";
            this.dtrNome.ReadOnly = true;
            // 
            // dtrEmail
            // 
            this.dtrEmail.DataPropertyName = "email";
            this.dtrEmail.Frozen = true;
            this.dtrEmail.HeaderText = "Email";
            this.dtrEmail.Name = "dtrEmail";
            this.dtrEmail.ReadOnly = true;
            // 
            // dtrTipo
            // 
            this.dtrTipo.DataPropertyName = "tipo";
            this.dtrTipo.Frozen = true;
            this.dtrTipo.HeaderText = "Tipo";
            this.dtrTipo.Name = "dtrTipo";
            this.dtrTipo.ReadOnly = true;
            // 
            // dtvCargo
            // 
            this.dtvCargo.DataPropertyName = "cargo";
            this.dtvCargo.HeaderText = "Cargo";
            this.dtvCargo.Name = "dtvCargo";
            this.dtvCargo.ReadOnly = true;
            // 
            // dtrBtnDetalhes
            // 
            this.dtrBtnDetalhes.DataPropertyName = "id_usuario";
            this.dtrBtnDetalhes.HeaderText = "";
            this.dtrBtnDetalhes.MinimumWidth = 70;
            this.dtrBtnDetalhes.Name = "dtrBtnDetalhes";
            this.dtrBtnDetalhes.ReadOnly = true;
            this.dtrBtnDetalhes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtrBtnDetalhes.Width = 70;
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 471);
            this.Controls.Add(this.pnlChildForm);
            this.MinimumSize = new System.Drawing.Size(711, 510);
            this.Name = "FormBuscarUsuario";
            this.Text = "Exibir Usuarios";
            this.Load += new System.EventHandler(this.FormBuscarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarUsuario)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarUsuario;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtrNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtrEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtrTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtvCargo;
        private System.Windows.Forms.DataGridViewButtonColumn dtrBtnDetalhes;
    }
}