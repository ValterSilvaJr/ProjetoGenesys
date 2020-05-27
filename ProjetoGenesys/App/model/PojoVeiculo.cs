namespace ProjetoGenesys.App.model
{
    class PojoVeiculo
    {
        private int id_veiculo;
        private string tipo; //Recebera P ou L no banco de dados;
        private string nome;
        private string marca;
        private string modelo;
        private string placa;

        private int getIdVeiculo()
        {
            return this.id_veiculo;
        }
        private void setIdVeiculo(int id_veiculo)
        {
            this.id_veiculo = id_veiculo;
        }
        private string getTipo()
        {
            return this.tipo;
        }
        private void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        private string getNome()
        {
            return this.nome;
        }
        private void setNome(string nome)
        {
            this.nome = nome;
        }
        private string getMarca()
        {
            return this.marca;
        }
        private void setMarca(string marca)
        {
            this.marca = marca;
        }
        private string getModelo()
        {
            return this.modelo;
        }
        private void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        private string getPlaca()
        {
            return this.placa;
        }
        private void setPlaca(string placa)
        {
            this.placa = placa;
        }
    }
    class PojoVeiculoLeve : PojoVeiculo
    {
        private int qtd_rodas;
        private string categoria;
        private int getQtdRodas()
        {
            return this.qtd_rodas;
        }
        private void setQtdRodas(int qtd_rodas)
        {
            this.qtd_rodas = qtd_rodas;
        }
        private string getCategoria()
        {
            return this.categoria;
        }
        private void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
    }
    class PojoVeiculoPesado : PojoVeiculo
    {
        private int qtd_eixos;
        private string carroceria;

        private int getQtdEixos()
        {
            return this.qtd_eixos;
        }
        private void setQtdEixos(int qtd_eixos)
        {
            this.qtd_eixos = qtd_eixos;
        }
        private string getCarroceria()
        {
            return this.carroceria;
        }
        private void setCarroceria(string carroceria)
        {
            this.carroceria = carroceria;
        }
    }
}
