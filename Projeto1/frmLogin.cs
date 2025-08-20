using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class frmLogin : Form
    {
        //instanciando a string de conexão 
        Conexao con = new Conexao();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "") 
            {
                MessageBox.Show("Usuário e senha inválidos.");
            }
            try
            {
                string sql = "select * from tbLogin where usuario=@user and senha=@senha"; //criando uma string chamada sql que seleciona da tabela tbLogin os dados do usuário e senha e os apelida
                MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //instanciando a variável cmd como umm comando MySqlCommand, passando os paramêtros a variável sql e o con.ConnectarBD() que é o método para chegar ao banco
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUsuario.Text;//adiciona o parâmetro @user de tipo varchar e atribui o valor do txtUsuario
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;//adiciona o parâmetro @senha de tipo varchar e atribui o valor do txtSenha
                MySqlDataReader dados = cmd.ExecuteReader(); //instanciando a variável dados como um MySqlDataReader que executa o comando cmd

                if (dados.HasRows) //se os dados tiverem as linhas que queremos executa
                {
                    MessageBox.Show("Seja bem vindo ao sistema!");
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                con.DesConnectarBD();
            }
        } 
    }
}
