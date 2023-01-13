using Dapper;
using GerenciadorDeFinancas.Model.Domain.Entities;
using GerenciadorDeFinancas.Model.Infra.Databases;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace GerenciadorDeFinancas.Model.Infra.Repositories
{
    public class TrasacaoRepository
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string mensagem = "";

        public bool Inserir(String nomeTransacao, String tipoTransacao, DateTime dataTransacao, String descTransacao, decimal valorTransacao)
        {
            //Comando SQL
            cmd.CommandText = "insert into transacoes(nomeTransacao, tipoTransacao, dataTransacao, descTransacao, valorTransacao) values('{@nomeTransacao}', '{@tipoTransacao}', '{@dataConvertida}', '{@descTransacao}', '{@valorTransacao}')";

            //Paramêtros
            cmd.Parameters.AddWithValue("@nomeTransacao", nomeTransacao);
            cmd.Parameters.AddWithValue("@tipoTransacao", tipoTransacao);
            cmd.Parameters.AddWithValue("@dataTransacao", dataTransacao);
            cmd.Parameters.AddWithValue("@descTransacao", descTransacao);
            cmd.Parameters.AddWithValue("@valorTransacao", valorTransacao);


            //Conectar com o banco
            try
            {
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //deconectar
                conexao.Desconectar();
                //mostrar mensagem de sucesso
                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados";
                throw;
            }

            //Executar comando

            //Desconectar

            //Mostrar mensagem de erro
        }

        //public bool Inserir(string nomeTransacao, string tipoTransacao, DateTime dataTransacao, string descTransacao, decimal valorTransacao)
        //{
        //    var dataConvertida = dataTransacao.ToString("yyyy-MM-dd");

        //    var sql = $"insert into transacoes(nomeTransacao, tipoTransacao, dataTransacao, descTransacao, valorTransacao) values('{nomeTransacao}', '{tipoTransacao}', '{dataConvertida}', '{descTransacao}', '{valorTransacao}')";
        //    using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
        //    var resultado = conexaoBd.Execute(sql);
        //    return resultado > 0;
        //}

        public IEnumerable<TransacoesEntity> ObterTransacoes()
        {
            var sql = $"select * from transacoes";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Query<TransacoesEntity>(sql);
            return resultado;
        }

        public bool Deletar()
        {
            return 1 > 0;
        }
    }
}
