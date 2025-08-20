using MySql.Data.MySqlClient; 
using System;

namespace Projeto1
{
    class Conexao
    {
        MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=DBProjeto;user=root;pwd=12345678"); //Instância: ato de apelidar algo e uma string de conexão
        public static string msg; //criação de variável estática para armazenar mensagens de erro
        public MySqlConnection ConnectarBD()
        {
            try //tratamento de erros
            {
                con.Open(); //abre a instância de conexão com o banco de dados

            }
            catch (Exception erro) //exceção para capturar erros
            {

                msg = "Ocorreu um erro ao se conectar" + erro.Message;//mensagem de erro
            }
            return con; //retorna a conexão com o banco de dados
        }

        public MySqlConnection DesConnectarBD()
        {
            try
            {
                con.Close(); //fecha a instância de conexão com o banco de dados

            }
            catch (Exception erro)
            {

                msg = "Ocorreu um erro ao se desconectar" + erro.Message;
            }
            return con;
        }
    }
}
