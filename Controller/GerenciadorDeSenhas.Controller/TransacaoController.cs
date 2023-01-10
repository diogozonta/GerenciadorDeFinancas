using GerenciadorDeFinancas.Model.Domain.Entities;
using GerenciadorDeFinancas.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeSenhas.Controller
{
    public class TransacaoController
    {
        public bool InserirTransacao(string nomeTransacao, string tipoTransacao, DateTime dataTransacao, string descTransacao, decimal valorTransacao)
        {
            var repositorio = new TrasacaoRepository();
            var resposta = repositorio.Inserir(nomeTransacao, tipoTransacao, dataTransacao, descTransacao, valorTransacao);
            return resposta;
        }

        public IEnumerable<TransacoesEntity> ObterTransacoes()
        {
            var repositorio = new TrasacaoRepository();
            var resposta = repositorio.ObterTransacoes();
            return resposta;
        }
    }
}
