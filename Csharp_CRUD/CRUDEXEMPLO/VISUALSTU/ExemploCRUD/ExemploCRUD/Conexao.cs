using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD
{
    public class Conexao
    {
        private SqlConnection con;
        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(local)\Laboratorio;
                                     Initial Catalog = VEICULO;
                                     Integrated Security = true;";
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }



    }
}