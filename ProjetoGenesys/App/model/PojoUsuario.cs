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
    }
}
