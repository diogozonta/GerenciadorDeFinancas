using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeFinancas.Model.Infra.Databases
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Contrutor      
        public Conexao()
        {
            con.ConnectionString = "server=localhost;database=gerenciadorfinanceiro;uid=root;password=;";
        }

        //Método para conectar ao banco
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Método para desconectar do banco
        public SqlConnection Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}
