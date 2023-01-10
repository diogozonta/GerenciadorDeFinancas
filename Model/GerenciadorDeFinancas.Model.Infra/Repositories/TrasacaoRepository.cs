using Dapper;
using GerenciadorDeFinancas.Model.Domain.Entities;
using MySql.Data.MySqlClient;
using System.Data;

namespace GerenciadorDeFinancas.Model.Infra.Repositories
{
    public class TrasacaoRepository
    {
        public bool Inserir(string nomeTransacao, string tipoTransacao, DateTime dataTransacao, string descTransacao, decimal valorTransacao)
        {
            var dataConvertida = dataTransacao.ToString("yyyy-MM-dd"); 

            var sql = $"insert into transacoes(nomeTransacao, tipoTransacao, dataTransacao, descTransacao, valorTransacao) values('{nomeTransacao}', '{tipoTransacao}', '{dataConvertida}', '{descTransacao}', '{valorTransacao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

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
