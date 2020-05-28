using System.Data;
using Npgsql;

namespace Parcial_2_POO
{
    public static class ConectionBD
    {

        private static string host = "127.0.0.1",
            database = "Parcial2_POO",
            userId = "postgres",
            password = "Andrea30$";

        private static string sConnection =
            $"Server={host};Port=5432;User Id={userId};Password={password};Database={database};";

        //DEVUELVE DATOS
        public static DataTable ExexuteQuery(string query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            
            connection.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            
            connection.Close();
            
            return ds.Tables[0];
        }

        //NO DEVUELVE NINGUN DATO: INSERTS, DELETE, UPDATE, ALTER
        public static void ExecuteNonQuiery(string act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        
    }
}