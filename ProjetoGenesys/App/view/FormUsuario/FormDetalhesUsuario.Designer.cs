namespace ProjetoGenesys.App.view
{
    partial class FormDetalhesUsuario
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
            this.dgvDetalhes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalhes
            // 
            this.dgvDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDetalhes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalhes.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalhes.Name = "dgvDetalhes";
            this.dgvDetalhes.Size = new System.Drawing.Size(800, 450);
            this.dgvDetalhes.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "email";
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            // 
            // FormDetalhesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetalhes);
            this.Name = "FormDetalhesUsuario";
            this.Text = "FormDetalhesUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}