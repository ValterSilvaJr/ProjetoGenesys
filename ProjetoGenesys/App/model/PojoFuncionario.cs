namespace ProjetoGenesys.App.model
{
    class PojoFuncionario : PojoUsuario
    {
        private string cargo;
        private string setor;
        private string turno;

        public string getCargo()
        {
            return this.cargo;
        }
        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }
        public string getSetor()
        {
            return this.setor;
        }
        public void setSetor(string setor)
        {
            this.setor = setor;
        }
        public string getTurno()
        {
            return this.turno;
        }
        public void setTurno(string turno)
        {
            this.turno = turno;
        }
    }
}
