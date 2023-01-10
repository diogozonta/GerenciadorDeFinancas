using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinancas.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=localhost;database=gerenciadorfinanceiro;uid=root;password=;";
            return conn;
        }
    }
}
