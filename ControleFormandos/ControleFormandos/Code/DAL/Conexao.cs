﻿using System;
using System.Data;
using MySqlConnector;

namespace ControleFormandos.Code.DAL
{
    class Conexao
    {
        MySqlConnection conexao;

        public void Conectar()
        {
            try
            {
                string conn = "Persist Security Info = false; " +
                    "server = localhost; " +
                    "database = controleformandos; " +
                    "uid = root; pwd=";

                conexao = new MySqlConnection(conn);
                conexao.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível conectar ao banco de dados.\n" + ex.Message);
            }
        }

        public void ExecutarComando(string sql)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.ExecuteNonQuery();

        }

        public DataTable ExecutarConsulta(string sql)
        {
            Conectar();
            MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            return dt;
        }
    }
}
