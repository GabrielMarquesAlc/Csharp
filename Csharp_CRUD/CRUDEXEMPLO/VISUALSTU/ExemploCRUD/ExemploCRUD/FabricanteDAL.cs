using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using System.Data.SqlClient;

namespace ExemploCRUD
{
    public class FabricanteDAL
    {


        private Conexao con;
        public FabricanteDAL()
        {
            con = new Conexao();
        }
            public DataTable Consultar(Fabricante c)
                {
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = @"
                        SELECT * FROM FABRICANTE WHERE NOME LIKE @busca";
                    cmd.Parameters.AddWithValue("@busca", "%" + c.Nome + "%");
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    return dt;
                }

                public void Cadastrar(Fabricante c)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = @"
                        INSERT INTO FABRICANTE(NOME)
                            VALUES(@n)";
                    cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = c.Nome;
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                }
                public void Atualizar(Fabricante c)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = @"
                        UPDATE FABRICANTE SET
                            NOME     = @n ,
                        WHERE ID = @i";
                    cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = c.Nome;
                    cmd.Parameters.Add("@i", SqlDbType.Int).Value = c.ID;
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                }
                public void Excluir(Fabricante c)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = @"
                        DELETE FROM FABRICANTE 
                        WHERE ID = @i";
                    cmd.Parameters.AddWithValue("@i", c.ID);
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                }
         
    }
}