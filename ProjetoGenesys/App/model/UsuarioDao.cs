using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProjetoGenesys.App.model
{
    class UsuarioDao
    {
        SqlConnection sqlConnection = Conexao.SqlServer.getConnection();

        public int CadastrarUsuario(PojoUsuario pojoUsuario, PojoPessoaFisica pojoPf, PojoPessoaJuridica pojoPj, PojoFuncionario pojoFcn, string tipoUsuario)
        {
            string sqlQuery = "";

            switch (tipoUsuario)
            {
                case "PF":
                    sqlQuery =  "INSERT INTO cliente(id_usuario, tipo) values(@@IDENTITY, @tipo) "
                             +  "INSERT INTO pessoa_fisica(cpf, id_cliente, dataNasc) values(@cpf, @@IDENTITY, @dataNasc)";
                    break;
                case "PJ":
                    sqlQuery = "INSERT INTO cliente(id_usuario, tipo) values(@@IDENTITY, @tipo) "
                             + "INSERT INTO pessoa_juridica(cnpj, id_cliente, inscricao_estadual, razao_social, nome_fantasia) values(@cnpj, @@IDENTITY, @inscricao_estadual, @razao_social, @nome_fantasia)";
                    break;
                case "FCN":
                    sqlQuery = "INSERT INTO funcionario(id_usuario, cargo, setor, turno) values(@@IDENTITY, @cargo, @setor, @turno)";
                    break;
            }
            
            string sqlTransaction =
                "BEGIN TRANSACTION "
                + "INSERT INTO usuario(nome, email, senha) values(@nome, @email, @senha) "
                + "INSERT INTO endereco(id_usuario ,logradouro, numero, cep, bairro, cidade, uf, pais) values(@@IDENTITY, @logradouro, @numero, @cep, @bairro, @cidade, @uf, @pais) "
                + sqlQuery
                + " COMMIT";

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

                switch (tipoUsuario)
                {
                    case "PF":
                        #region PojoPessoaFisica
                        sqlCommand.Parameters.Add(new SqlParameter("@cpf", pojoPf.getCpf()));
                        sqlCommand.Parameters.Add(new SqlParameter("@dataNasc", Convert.ToDateTime(pojoPf.getDataNasc())));
                        sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPf.getTipo()));
                        #endregion
                        break;
                    case "PJ":
                        #region PojoPessoaJuridica
                        sqlCommand.Parameters.Add(new SqlParameter("@cnpj", pojoPj.getCnpj()));
                        sqlCommand.Parameters.Add(new SqlParameter("@inscricao_estadual", pojoPj.getInscricaoEstadual()));
                        sqlCommand.Parameters.Add(new SqlParameter("@razao_social", pojoPj.getRazaoSocial()));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome_fantasia", pojoPj.getNomeFantasia()));
                        sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPj.getTipo()));
                        #endregion
                        break;
                    case "FCN":
                        #region PojoFuncionario
                        sqlCommand.Parameters.Add(new SqlParameter("@cargo", pojoFcn.getCargo()));
                        sqlCommand.Parameters.Add(new SqlParameter("@setor", pojoFcn.getSetor()));
                        sqlCommand.Parameters.Add(new SqlParameter("@turno", pojoFcn.getTurno()));
                        #endregion
                        break;
                }
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
        public bool ListarUsuarios(DataGridView dgvUsuarios)
        {
            string sqlQuery = "SELECT u.id_usuario, u.nome, u.email, c.tipo FROM USUARIO u " +
                              "INNER JOIN CLIENTE c on u.id_usuario = c.id_usuario";

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dgvUsuarios.DataSource = dataTable;

                dgvUsuarios.RowsDefaultCellStyle.BackColor = Color.White;
                dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

                return true;

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao consultar os dados" + ex.Message, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if(sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public bool ListarDetalhesUsuario(string idUsuario, string tipoUsuario, PojoUsuario pojoUsuario, PojoPessoaFisica pojoPf, PojoPessoaJuridica pojoPj, PojoFuncionario pojoFcn)
        {
            string sqlQueryJoin = "";
            string sqlQueryColumns = "";

            switch (tipoUsuario)
            {
                case "PF":
                    sqlQueryColumns = ", c.tipo, pf.cpf, pf.dataNasc";
                    sqlQueryJoin    = "INNER JOIN CLIENTE c ON c.id_usuario = u.id_usuario  "
                                    + "INNER JOIN PESSOA_FISICA pf ON pf.id_cliente = c.id_cliente ";
                    break;
                case "PJ":
                    sqlQueryColumns = ", c.tipo, pj.cnpj, pj.inscricao_estadual, pj.razao_social, pj.nome_fantasia";
                    sqlQueryJoin    = "INNER JOIN CLIENTE c ON c.id_usuario = u.id_usuario "
                                    + "INNER JOIN PESSOA_JURIDICA pj ON pj.id_cliente = c.id_cliente ";
                    break;
                case "FCN":
                    sqlQueryColumns = ", f.cargo, f.setor, f.turno";
                    sqlQueryJoin    = "INNER JOIN FUNCIONARIO f ON f.id_usuario = u.id_usuario ";
                    break;
            }
            
            string sqlQueryDetalhes =   "SELECT u.nome, u.email, u.senha, e.logradouro, e.numero, e.cep, e.bairro, e.cidade, e.uf, e.pais"
                                      + sqlQueryColumns
                                      + " FROM USUARIO u "
                                      + "INNER JOIN ENDERECO e ON e.id_usuario = u.id_usuario "
                                      + sqlQueryJoin
                                      + "WHERE u.id_usuario =" + idUsuario;

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQueryDetalhes, sqlConnection);
                SqlDataReader reader;
                
                //READER
                reader = sqlCommand.ExecuteReader();
                reader.Read();

                pojoUsuario.setNome(reader["nome"].ToString());
                pojoUsuario.setEmail(reader["email"].ToString());
                pojoUsuario.setSenha(reader["senha"].ToString());
                pojoUsuario.setLogradouro(reader["logradouro"].ToString());
                pojoUsuario.setNumero(reader["numero"].ToString());
                pojoUsuario.setCep(reader["cep"].ToString());
                pojoUsuario.setBairro(reader["bairro"].ToString());
                pojoUsuario.setCidade(reader["cidade"].ToString());
                pojoUsuario.setUf(reader["uf"].ToString());
                pojoUsuario.setPais(reader["pais"].ToString());

                switch (tipoUsuario)
                {
                    case "PF":
                        pojoPf.setCpf(reader["cpf"].ToString());
                        pojoPf.setDataNasc(reader["dataNasc"].ToString());
                        break;
                    case "PJ":
                        pojoPj.setCnpj(reader["cnpj"].ToString());
                        pojoPj.setInscricaoEstadual(reader["inscricao_estadual"].ToString());
                        pojoPj.setRazaoSocial(reader["razao_social"].ToString());
                        pojoPj.setNomeFantasia(reader["nome_fantasia"].ToString());
                        break;
                    case "FCN":
                        pojoFcn.setCargo(reader["cargo"].ToString());
                        pojoFcn.setSetor(reader["setor"].ToString());
                        pojoFcn.setTurno(reader["turno"].ToString());
                        break;
                }

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao consultar os dados " + ex.Message, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        public int AtualizarUsuario(string idUsuario, string tipoUsuario, PojoUsuario pojoUsuario, PojoPessoaFisica pojoPf, PojoPessoaJuridica pojoPj, PojoFuncionario pojoFcn)
        {
            string sqlQuery = "UPDATE USUARIO SET nome=@nome WHERE id_usuario=" + idUsuario;

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

                switch (tipoUsuario)
                {
                    case "PF":
                        #region PojoPessoaFisica
                        sqlCommand.Parameters.Add(new SqlParameter("@cpf", pojoPf.getCpf()));
                        sqlCommand.Parameters.Add(new SqlParameter("@dataNasc", Convert.ToDateTime(pojoPf.getDataNasc())));
                        sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPf.getTipo()));
                        #endregion
                        break;
                    case "PJ":
                        #region PojoPessoaJuridica
                        sqlCommand.Parameters.Add(new SqlParameter("@cnpj", pojoPj.getCnpj()));
                        sqlCommand.Parameters.Add(new SqlParameter("@inscricao_estadual", pojoPj.getInscricaoEstadual()));
                        sqlCommand.Parameters.Add(new SqlParameter("@razao_social", pojoPj.getRazaoSocial()));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome_fantasia", pojoPj.getNomeFantasia()));
                        sqlCommand.Parameters.Add(new SqlParameter("@tipo", pojoPj.getTipo()));
                        #endregion
                        break;
                    case "FCN":
                        #region PojoFuncionario
                        sqlCommand.Parameters.Add(new SqlParameter("@cargo", pojoFcn.getCargo()));
                        sqlCommand.Parameters.Add(new SqlParameter("@setor", pojoFcn.getSetor()));
                        sqlCommand.Parameters.Add(new SqlParameter("@turno", pojoFcn.getTurno()));
                        #endregion
                        break;
                }
                sqlCommand.ExecuteNonQuery();

                return 1;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados " + ex.Message, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
        public bool DeletarUsuario(string idUsuario)
        {
            string sqlQuery = "DELETE FROM USUARIO WHERE id_usuario=" + idUsuario;

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.Parameters.Add(new SqlParameter("@id_usuario", idUsuario));
                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao excluir o usuario " + ex.Message, "Projeto Genesys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
