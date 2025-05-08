using System.Data;
using System.IO;
using Microsoft.Data.Sqlite;

namespace DatabaseLib;

public class DatabaseSystem {
    private readonly string DB_Path;

    public DatabaseSystem(string DB_Path) {
        DB_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "database.db");
    }

    public void testConnection() {
        using var connection = new SqliteConnection($"Data Source={DB_Path}");
        connection.Open();
    }
    
    // public DataTable GetAllBooks()
    // {
    //     using var connection = new SQLiteConnection(_connectionString);
    //     connection.Open();
    //
    //     string query = "SELECT * FROM Books;";
    //     using var cmd = new SQLiteCommand(query, connection);
    //     using var adapter = new SQLiteDataAdapter(cmd);
    //
    //     DataTable result = new DataTable();
    //     adapter.Fill(result);
    //     return result;
    // }
}