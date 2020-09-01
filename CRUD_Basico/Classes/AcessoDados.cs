using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Basico.Classes
{
    public class AcessoDados
    {
        private string StringDeConexao
        {
            get
            {
                ConnectionStringSettings conn = ConfigurationManager.ConnectionStrings["BancoDeDados"];
                if (conn != null)
                    return conn.ConnectionString;
                else
                    return string.Empty;
            }
        }

        protected DataSet Consultar(string nomeProcedure, List<SqlParameter> parametros)
        {
            SqlConnection conexao = new SqlConnection(StringDeConexao);
            SqlCommand comando = new SqlCommand(nomeProcedure, conexao);
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 30;

            if (parametros != null)
            {
                foreach(var item in parametros)
                {
                    comando.Parameters.Add(item);
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();

            try
            {
                conexao.Open();
                adapter.Fill(ds);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return ds;
        }
    }
}
