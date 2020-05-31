namespace ProjetoGenesys.App.model
{
    public class PojoCliente
    {
        private string tipo;

        public string getTipo()
        {
            return this.tipo;
        }
        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
    }

    public class PojoPessoaFisica : PojoCliente
    {
        private string cpf;
        private string dataNasc;

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getDataNasc()
        {
            return this.dataNasc;
        }
        public void setDataNasc(string dataNasc)
        {
            this.dataNasc = dataNasc;
        }
    }
    public class PojoPessoaJuridica : PojoCliente
    {
        private string cnpj;
        private string inscricao_estadual;
        private string razao_social;
        private string nome_fantasia;

        public string getCnpj()
        {
            return this.cnpj;
        }
        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }
        public string getInscricaoEstadual()
        {
            return this.inscricao_estadual;
        }
        public void setInscricaoEstadual(string inscricao_estadual)
        {
            this.inscricao_estadual = inscricao_estadual;
        }
        public string getRazaoSocial()
        {
            return this.razao_social;
        }
        public void setRazaoSocial(string razao_social)
        {
            this.razao_social = razao_social;
        }
        public string getNomeFantasia()
        {
            return this.nome_fantasia;
        }
        public void setNomeFantasia(string nome_fantasia)
        {
            this.nome_fantasia = nome_fantasia;
        }
    }
}
