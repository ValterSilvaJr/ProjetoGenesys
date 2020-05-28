namespace ProjetoGenesys.App.model
{
    class PojoUsuario
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        //private string tipo;

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        { 
            this.id = id;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getEmail()
        {
            return this.email;
        }
        public void getEmail(string email)
        {
            this.email = email;
        }
        public string getSenha()
        {
            return this.senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        class PojoEndereco : PojoUsuario
        {
            private int id_endereco;
            private string logradouro;
            private string numero;
            private string cep;
            private string bairro;
            private string cidade;
            private string uf;
            private string pais;

            public int getIdEndereco()
            {
                return this.id_endereco;
            }
            public void setIdEndereco(int id_endereco)
            {
                this.id_endereco = id_endereco;
            }
            public string getLogradouro()
            {
                return this.logradouro;
            }
            public void setLogradouro(string logradouro)
            {
                this.logradouro = logradouro;
            }
            public string getNumero()
            {
                return this.numero;
            }
            public void setNumero(string numero)
            {
                this.numero = numero;
            }
            public string getCep()
            {
                return this.cep;
            }
            public void setCep(string cep)
            {
                this.cep = cep;
            }
            public string getBairro()
            {
                return this.bairro;
            }
            public void setBairro(string bairro)
            {
                this.bairro = bairro;
            }
            public string getCidade()
            {
                return this.cidade;
            }
            public void setCidade(string cidade)
            {
                this.cidade = cidade;
            }
            public string getUf()
            {
                return this.uf;
            }
            public void setUf(string uf)
            {
                this.uf = uf;
            }
            public string getPais()
            {
                return this.pais;
            }
            public void setPais(string pais)
            {
                this.pais = pais;
            }
        }
    }
}
