using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoGenesys.App.model
{
    class UsuarioDao
    {
        SqlConnection sqlConnection = Conexao.SqlServer.getConnection();

        public int CadastrarUsuario(PojoUsuario pojoUsuario, PojoPessoaFisica pojoPf)
        {
            string sqlTransaction =
                "BEGIN TRANSACTION "
                + "INSERT INTO usuario(nome, email, senha) values(@nome, @email, @senha) "
                + "INSERT INTO endereco(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY, @logradouro, @numero, @cep, @bairro, @cidade, @uf, @pais) "
                + "INSERT INTO cliente(id_usuario, tipo) values(@@IDENTITY, @tipo) "
                + "INSERT INTO pessoa_fisica(cpf, id_cliente, dataNasc) values(@cpf, @@IDENTITY, @dataNasc) "
                + "COMMIT";

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlTransaction, sqlConnection);

                #region PojoUsuario
                sqlCommand.Parameters.Add(new SqlParameter("@nome", pojoUsuario.getNome()));
                sqlCommand.Parameters.Add(new SqlParameter("@email", pojoUsuario.getEmail()));
                sqlCommand.Parameters.Add(new SqlParameter("@senha", pojoUsuario.getSenha()));
                sqlCommand.Parameters.Add(new SqlParameter("@logradouro", pojoUsuario.getLogradouro()));
                sqlCommand.Parameters.Add(new SqlParameter("@numero", pojoUsuario.getNumero()));
                sqlCommand.Parameters.Add(new SqlParameter("@cep", pojoUsuario.getCep()));
                sqlCommand.Parameters.Add(new SqlParameter("@bairro", pojoUsuario.getBairro()));
                sqlCommand.Parameters.Add(new SqlParameter("@cidade", pojoUsuario.getCidade()));
                sqlCommand.Parameters.Add(new SqlParameter("@uf", pojoUsuario.getUf()));
                sqlCommand.Parameters.Add(new SqlParameter("@pais", pojoUsuario.getPais()));
                #endregion
                /*
                #region PojoFuncionario
                sqlCommand.Parameters.Add(new SqlParameter("@cargo", pojoFunc.getCargo()));
                sqlCommand.Parameters.Add(new SqlParameter("@setor", pojoFunc.getSetor()));
                sqlCommand.Parameters.Add(new SqlParameter("@turno", pojoFunc.getTurno()));
                //sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoFunc.getTipo()));
                #endregion
                */

                #region PojoPessoaFisica
                sqlCommand.Parameters.Add(new SqlParameter("@cpf", pojoPf.getCpf()));
                sqlCommand.Parameters.Add(new SqlParameter("@dataNasc", Convert.ToDateTime(pojoPf.getDataNasc())));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPf.getTipo()));
                #endregion

                /*
                #region PojoPessoaJuridica
                sqlCommand.Parameters.Add(new SqlParameter("@cnpj", pojoPj.getCnpj()));
                sqlCommand.Parameters.Add(new SqlParameter("@inscricao_estadual", pojoPj.getInscricaoEstadual()));
                sqlCommand.Parameters.Add(new SqlParameter("@razao_social", pojoPj.getRazaoSocial()));
                sqlCommand.Parameters.Add(new SqlParameter("@nome_fantasia", pojoPj.getNomeFantasia()));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPj.getTipo()));
                #endregion              
                */
                sqlCommand.ExecuteNonQuery();

                return 1;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar dados: " + ex.Message, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            finally
            {
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
