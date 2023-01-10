using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinancas.Model.Domain.Entities
{
    public class TransacoesEntity
    {
        public int IdTransacao { get; set; }
        public string nomeTransacao { get; set; }
        public string tipoTransacao { get; set; }
        public string dataTransacao { get; set; }
        public string descTransacao { get; set; }
        public decimal valorTransacao { get; set; }
    }
}
