using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoGenesys.App.model
{
    class UsuarioDao
    {
        SqlConnection sqlConnection = Conexao.SqlServer.getConnection();

        public int CadastrarUsuario(PojoUsuario pojoUsuario, PojoPessoaFisica pojoPf, PojoPessoaJuridica pojoPj, PojoFuncionario pojoFunc)
        {
            string sqlQuery = "INSERT INTO usuario VALUES("
                + "nome, email, senha)";/*
                + "cargo, setor, turno,"
                + "cpf, dataNasc,"
                + "cnpj, inscricao_estadual, razao_social, nome_fantasia,"
                + "logradouro, numero, cep, bairro, cidade, uf, pais,"
                + "tipo"
                + ")";*/

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

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

                #region PojoPessoaFisica
                sqlCommand.Parameters.Add(new SqlParameter("@cpf", pojoPf.getCpf()));
                sqlCommand.Parameters.Add(new SqlParameter("@dataNasc", pojoPf.getDataNasc()));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPj.getTipo()));
                #endregion

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
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar dados: Delta-" + ex, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
