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
            this.lblCargo = new System.Windows.Forms.Label();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.pnlPF = new System.Windows.Forms.Panel();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblInscEst = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.pnlPJ = new System.Windows.Forms.Panel();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.mskInscEst = new System.Windows.Forms.MaskedTextBox();
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlDadosContato = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSetor = new System.Windows.Forms.Label();
            this.pnlEndereco = new System.Windows.Forms.Panel();
            this.pnlCargo = new System.Windows.Forms.Panel();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.pnlPF.SuspendLayout();
            this.pnlPJ.SuspendLayout();
            this.pnlDadosContato.SuspendLayout();
            this.pnlEndereco.SuspendLayout();
            this.pnlCargo.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(13, 15);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(123, 52);
            this.mskDataNasc.Mask = "00/00/0000";
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(171, 23);
            this.mskDataNasc.TabIndex = 6;
            this.mskDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(123, 12);
            this.mskCpf.Mask = "99.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(171, 23);
            this.mskCpf.TabIndex = 5;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(13, 15);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(34, 17);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(13, 55);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(116, 17);
            this.lblDataNasc.TabIndex = 3;
            this.lblDataNasc.Text = "Data Nascimento";
            // 
            // pnlPF
            // 
            this.pnlPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlPF.Controls.Add(this.mskDataNasc);
            this.pnlPF.Controls.Add(this.mskCpf);
            this.pnlPF.Controls.Add(this.lblCpf);
            this.pnlPF.Controls.Add(this.lblDataNasc);
            this.pnlPF.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPF.ForeColor = System.Drawing.Color.Silver;
            this.pnlPF.Location = new System.Drawing.Point(0, 131);
            this.pnlPF.Name = "pnlPF";
            this.pnlPF.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlPF.Size = new System.Drawing.Size(678, 86);
            this.pnlPF.TabIndex = 7;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(123, 92);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(171, 23);
            this.txtPais.TabIndex = 19;
            // 
            // txtUf
            // 
            this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUf.Location = new System.Drawing.Point(611, 52);
            this.txtUf.MaxLength = 2;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(23, 23);
            this.txtUf.TabIndex = 18;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(265, 52);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(137, 23);
            this.txtBairro.TabIndex = 17;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(472, 52);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(106, 23);
            this.txtCidade.TabIndex = 14;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(472, 9);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(162, 23);
            this.txtNumero.TabIndex = 15;
            // 
            // lblInscEst
            // 
            this.lblInscEst.AutoSize = true;
            this.lblInscEst.Location = new System.Drawing.Point(13, 55);
            this.lblInscEst.Name = "lblInscEst";
            this.lblInscEst.Size = new System.Drawing.Size(123, 17);
            this.lblInscEst.TabIndex = 5;
            this.lblInscEst.Text = "Inscrição Estadual";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.Location = new System.Drawing.Point(13, 95);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(91, 17);
            this.lblRazaoSocial.TabIndex = 4;
            this.lblRazaoSocial.Text = "Razão Social";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Location = new System.Drawing.Point(13, 135);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(103, 17);
            this.lblNomeFantasia.TabIndex = 3;
            this.lblNomeFantasia.Text = "Nome Fantasia";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(123, 7);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(279, 23);
            this.txtLogradouro.TabIndex = 16;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(123, 52);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(84, 23);
            this.mskCep.TabIndex = 9;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 95);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(35, 17);
            this.lblPais.TabIndex = 8;
            this.lblPais.Text = "Pais";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(408, 55);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(52, 17);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Location = new System.Drawing.Point(13, 15);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(43, 17);
            this.lblCnpj.TabIndex = 6;
            this.lblCnpj.Text = "CNPJ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(213, 55);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(46, 17);
            this.lblBairro.TabIndex = 6;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(13, 55);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(35, 17);
            this.lblCep.TabIndex = 4;
            this.lblCep.Text = "CEP";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(579, 55);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(26, 17);
            this.lblUf.TabIndex = 3;
            this.lblUf.Text = "UF";
            // 
            // pnlPJ
            // 
            this.pnlPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlPJ.Controls.Add(this.txtRazaoSocial);
            this.pnlPJ.Controls.Add(this.txtNomeFantasia);
            this.pnlPJ.Controls.Add(this.mskInscEst);
            this.pnlPJ.Controls.Add(this.mskCnpj);
            this.pnlPJ.Controls.Add(this.lblCnpj);
            this.pnlPJ.Controls.Add(this.lblInscEst);
            this.pnlPJ.Controls.Add(this.lblRazaoSocial);
            this.pnlPJ.Controls.Add(this.lblNomeFantasia);
            this.pnlPJ.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPJ.ForeColor = System.Drawing.Color.Silver;
            this.pnlPJ.Location = new System.Drawing.Point(0, 217);
            this.pnlPJ.Name = "pnlPJ";
            this.pnlPJ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlPJ.Size = new System.Drawing.Size(678, 166);
            this.pnlPJ.TabIndex = 8;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(123, 92);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(171, 23);
            this.txtRazaoSocial.TabIndex = 10;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Location = new System.Drawing.Point(123, 132);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(171, 23);
            this.txtNomeFantasia.TabIndex = 9;
            // 
            // mskInscEst
            // 
            this.mskInscEst.Location = new System.Drawing.Point(123, 52);
            this.mskInscEst.Name = "mskInscEst";
            this.mskInscEst.Size = new System.Drawing.Size(171, 23);
            this.mskInscEst.TabIndex = 8;
            // 
            // mskCnpj
            // 
            this.mskCnpj.Location = new System.Drawing.Point(123, 12);
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(171, 23);
            this.mskCnpj.TabIndex = 7;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(13, 12);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(82, 17);
            this.lblLogradouro.TabIndex = 5;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(408, 12);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(62, -112);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            // 
            // pnlDadosContato
            // 
            this.pnlDadosContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlDadosContato.Controls.Add(this.txtEmail);
            this.pnlDadosContato.Controls.Add(this.txtNome);
            this.pnlDadosContato.Controls.Add(this.mskSenha);
            this.pnlDadosContato.Controls.Add(this.lblNome);
            this.pnlDadosContato.Controls.Add(this.lblSenha);
            this.pnlDadosContato.Controls.Add(this.lblEmail);
            this.pnlDadosContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDadosContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDadosContato.ForeColor = System.Drawing.Color.Silver;
            this.pnlDadosContato.Location = new System.Drawing.Point(0, 0);
            this.pnlDadosContato.Name = "pnlDadosContato";
            this.pnlDadosContato.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlDadosContato.Size = new System.Drawing.Size(678, 131);
            this.pnlDadosContato.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 52);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 12);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 23);
            this.txtNome.TabIndex = 5;
            // 
            // mskSenha
            // 
            this.mskSenha.Location = new System.Drawing.Point(123, 92);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '●';
            this.mskSenha.Size = new System.Drawing.Size(171, 23);
            this.mskSenha.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(13, 95);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 55);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(13, 55);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(42, 17);
            this.lblSetor.TabIndex = 7;
            this.lblSetor.Text = "Setor";
            // 
            // pnlEndereco
            // 
            this.pnlEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlEndereco.Controls.Add(this.txtPais);
            this.pnlEndereco.Controls.Add(this.txtUf);
            this.pnlEndereco.Controls.Add(this.txtBairro);
            this.pnlEndereco.Controls.Add(this.txtCidade);
            this.pnlEndereco.Controls.Add(this.txtNumero);
            this.pnlEndereco.Controls.Add(this.txtLogradouro);
            this.pnlEndereco.Controls.Add(this.mskCep);
            this.pnlEndereco.Controls.Add(this.lblPais);
            this.pnlEndereco.Controls.Add(this.lblCidade);
            this.pnlEndereco.Controls.Add(this.lblBairro);
            this.pnlEndereco.Controls.Add(this.lblLogradouro);
            this.pnlEndereco.Controls.Add(this.lblCep);
            this.pnlEndereco.Controls.Add(this.lblUf);
            this.pnlEndereco.Controls.Add(this.lblNumero);
            this.pnlEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEndereco.ForeColor = System.Drawing.Color.Silver;
            this.pnlEndereco.Location = new System.Drawing.Point(0, 511);
            this.pnlEndereco.Name = "pnlEndereco";
            this.pnlEndereco.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlEndereco.Size = new System.Drawing.Size(678, 126);
            this.pnlEndereco.TabIndex = 5;
            // 
            // pnlCargo
            // 
            this.pnlCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlCargo.Controls.Add(this.txtTurno);
            this.pnlCargo.Controls.Add(this.txtSetor);
            this.pnlCargo.Controls.Add(this.txtCargo);
            this.pnlCargo.Controls.Add(this.lblTurno);
            this.pnlCargo.Controls.Add(this.lblSetor);
            this.pnlCargo.Controls.Add(this.lblCargo);
            this.pnlCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCargo.ForeColor = System.Drawing.Color.Silver;
            this.pnlCargo.Location = new System.Drawing.Point(0, 383);
            this.pnlCargo.Name = "pnlCargo";
            this.pnlCargo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlCargo.Size = new System.Drawing.Size(678, 128);
            this.pnlCargo.TabIndex = 6;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(123, 92);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(171, 23);
            this.txtTurno.TabIndex = 11;
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(123, 52);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(171, 23);
            this.txtSetor.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(123, 12);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(171, 23);
            this.txtCargo.TabIndex = 13;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(13, 95);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.Text = "Turno";
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlContainer.Controls.Add(this.pnlBotoes);
            this.pnlContainer.Controls.Add(this.pnlEndereco);
            this.pnlContainer.Controls.Add(this.pnlCargo);
            this.pnlContainer.Controls.Add(this.pnlPJ);
            this.pnlContainer.Controls.Add(this.pnlPF);
            this.pnlContainer.Controls.Add(this.pnlDadosContato);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(695, 696);
            this.pnlContainer.TabIndex = 11;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnDeletar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnAtualizar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 637);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(678, 62);
            this.pnlBotoes.TabIndex = 9;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(235, 20);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(338, 20);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(29, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(132, 20);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FormDetalhesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 696);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlContainer);
            this.MinimumSize = new System.Drawing.Size(711, 510);
            this.Name = "FormDetalhesUsuario";
            this.Text = "FormDetalhesUsuario";
            this.pnlPF.ResumeLayout(false);
            this.pnlPF.PerformLayout();
            this.pnlPJ.ResumeLayout(false);
            this.pnlPJ.PerformLayout();
            this.pnlDadosContato.ResumeLayout(false);
            this.pnlDadosContato.PerformLayout();
            this.pnlEndereco.ResumeLayout(false);
            this.pnlEndereco.PerformLayout();
            this.pnlCargo.ResumeLayout(false);
            this.pnlCargo.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Panel pnlPF;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblInscEst;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Panel pnlPJ;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.MaskedTextBox mskInscEst;
        private System.Windows.Forms.MaskedTextBox mskCnpj;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlDadosContato;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mskSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.Panel pnlEndereco;
        private System.Windows.Forms.Panel pnlCargo;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
    }
}