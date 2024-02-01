using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Funcionario
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        private MySqlConnection GetMySqlConnection()
        {
            return new MySqlConnection(conexaoBanco.connectDb);
        }

        private MySqlCommand CreateMySqlCommand(string query, MySqlConnection connection)
        {
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            return command;
        }

        private bool ExecuteNonQuery(string query)
        {
            try
            {
                using (MySqlConnection connection = GetMySqlConnection())
                {
                    connection.Open();
                    using (MySqlCommand sqlCommand = CreateMySqlCommand(query, connection))
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro no banco de dados: {ex.Message}");
                return false;
            }
        }

        public bool CadastrarFuncionario()
        {
            string insertQuery = $"INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES('{Nome}','{Email}','{Cpf}','{Endereco}')";
            return ExecuteNonQuery(insertQuery);
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConnect = new MySqlConnection(conexaoBanco.connectDb);
                MySqlConnect.Open();
                string select = $"SELECT id, nome, email, cpf, endereco FROM funcionarios WHERE cpf = '{Cpf}'";
                MySqlCommand comandoSql = MySqlConnect.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco de Dados - método localizarFuncionário");
                return null;
            }
        }




        public bool AtualizarFuncionario()
        {
            string updateQuery = $"UPDATE funcionarios SET nome = '{Nome}', email = '{Email}', cpf = '{Cpf}', endereco = '{Endereco}' WHERE id = {Id}";
            return ExecuteNonQuery(updateQuery);
        }

        public bool DeletarFuncionario()
        {
            string deleteQuery = $"DELETE FROM funcionarios WHERE id = {Id}";
            return ExecuteNonQuery(deleteQuery);
        }
    }
}
