using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_ArtChik
{
    class DAL
    {
        public static void InsereLembrete(string descrição, string data, string horahora, string horamin, string alarme1hora, string alarme1min, 
            string alarme2hora, string alarme2min)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "InsereLembrete";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descrição", descrição);
            cmd.Parameters.AddWithValue("@Data", data);
            cmd.Parameters.AddWithValue("@HoraHora", horahora);
            cmd.Parameters.AddWithValue("@HoraMin", horamin);
            cmd.Parameters.AddWithValue("@Alarme1Hora", alarme1hora);
            cmd.Parameters.AddWithValue("@Alarme1Min", alarme1min);
            cmd.Parameters.AddWithValue("@Alarme2Hora", alarme2hora);
            cmd.Parameters.AddWithValue("@Alarme2Min", alarme2min);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static DataTable ListaLembrte(string data)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "ListaLembrete";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Data", data);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static void Atualiza(string id, string descrição)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "atualiza";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@descrição", descrição);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static void Atualiza2(string id, string dados)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "atualiza2";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
            cmd.Parameters.AddWithValue("@Dados", dados);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static DataTable ListaSenha()
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "Lista_Senha";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static void cancela(string id)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "cancela";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",Convert.ToInt32( id));


            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static void exclui(string id)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "exclui";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));


            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static void finaliza(string id, string data)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "finaliza";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",Convert.ToInt32( id));
            cmd.Parameters.AddWithValue("@data_fechamento", data);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static void InsereRegistro(string cliente, string data_inicio, string os, string data_fechamento, string descrição, string tipo, string situação)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";
                       
            String strSQL = "insere_registro";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@data_inicio", data_inicio);
            cmd.Parameters.AddWithValue("@os", os);
            cmd.Parameters.AddWithValue("@data_fechamento", data_fechamento);
            cmd.Parameters.AddWithValue("@descrição", descrição);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@situação", situação);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static DataTable ListaRegistro(string consulta)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = consulta;
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static DataTable Lista(string consulta,string cliente)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = consulta;
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cliente", cliente);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static void InsereCliente(string cliente)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";
                       
            String strSQL = "insere_cliente";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", cliente);
            

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();

        }
        public static DataTable ListaCliente()
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "lista_cliente";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static DataTable ListaCliente2(string consulta)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "lista_cliente2";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cliente", consulta);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
        public static DataTable ListaCliente3(string consulta)
        {

            string strConnection = "Data Source=.\\SQLEXPRESS;Initial Catalog=agenda;User ID=sa;Password=#lecoteco1975 ;Provider=SQLOLEDB";

            String strSQL = "lista_cliente3";
            //cria a conexão com o banco de dados
            OleDbConnection dbConnection = new OleDbConnection(strConnection);
            //cria a conexão com o banco de dados
            OleDbConnection con = new OleDbConnection(strConnection);
            //cria o objeto command para executar a instruçao sql
            OleDbCommand cmd = new OleDbCommand(strSQL, con);
            //abre a conexao
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Consulta", consulta);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            //cria um objeto datatable
            DataTable clientes = new DataTable();
            //preenche o datatable via dataadapter
            da.Fill(clientes);
            con.Dispose();
            con.Close();
            cmd.Dispose();
            dbConnection.Dispose();
            dbConnection.Close();
            return clientes;
        }
    }
        
    
}
