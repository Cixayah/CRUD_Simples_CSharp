using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class Form1 : Form
    {
        private CadastroFuncionarios cadFuncionarios;

        public Form1()
        {
            InitializeComponent();
            cadFuncionarios = new CadastroFuncionarios();
        }

        private bool AreFieldsFilled()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                   !string.IsNullOrWhiteSpace(txtCpf.Text) &&
                   !string.IsNullOrWhiteSpace(txtEndereco.Text);
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreFieldsFilled())
                {
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Cpf = txtCpf.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.CadastrarFuncionario())
                    {
                        ShowMessageBox($"O funcion�rio {cadFuncionarios.Nome} foi cadastrado com sucesso!");
                    }
                    else
                    {
                        ShowMessageBox("N�o foi poss�vel cadastrar funcion�rio!");
                    }
                }
                else
                {
                    ShowMessageBox("Campo faltando");
                    ClearFields();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Erro ao cadastrar funcion�rio: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            lblId.Text = "";
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCpf.Text))
                {
                    cadFuncionarios.Cpf = txtCpf.Text;
                    MySqlDataReader reader = cadFuncionarios.LocalizarFuncionario();

                    if (reader != null && reader.HasRows)
                    {
                        reader.Read();
                        lblId.Text = reader["id"].ToString();
                        txtNome.Text = reader["nome"].ToString();
                        txtEmail.Text = reader["email"].ToString();
                        txtEndereco.Text = reader["endereco"].ToString();
                    }
                    else
                    {
                        ShowMessageBox("Funcion�rio n�o localizado.");
                        ClearFields();
                        txtCpf.Focus();
                    }
                }
                else
                {
                    ClearFields();
                    txtCpf.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Funcion�rio n�o encontrado: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ClearFields();
            txtNome.Focus();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreFieldsFilled())
                {
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Cpf = txtCpf.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.AtualizarFuncionario())
                    {
                        ShowMessageBox("Dados do funcion�rio foram atualizados com sucesso");
                        ClearFields();
                        txtNome.Focus();
                    }
                    else
                    {
                        ShowMessageBox("N�o foi poss�vel atualizar");
                        ClearFields();
                        txtNome.Focus();
                    }
                }
                else
                {
                    ShowMessageBox("Localize o funcion�rio");
                    ClearFields();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Erro ao atualizar o funcion�rio" + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreFieldsFilled())
                {
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    if (cadFuncionarios.DeletarFuncionario())
                    {
                        ShowMessageBox("O funcion�rio foi exclu�do com sucesso!");
                        ClearFields();
                    }
                    else
                    {
                        ShowMessageBox("N�o foi poss�vel deletar funcion�rio");
                    }
                }
                else
                {
                    ShowMessageBox("Qual funcion�rio deseja excluir?");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                ShowMessageBox("Erro ao deletar o funcion�rio: " + ex.Message);
            }
        }
    }
}
