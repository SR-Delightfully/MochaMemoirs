using System.IO;
using Microsoft.Data.Sqlite;

namespace DatabaseLib;

public class DatabaseSystem {
    private readonly string DB_Path;

    public DatabaseSystem(string DB_Path) {
        DB_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ressources", "database.db");
    }

    public void testConnection() {
        using var connection = new SqliteConnection($"Data Source={DB_Path}");
        connection.Open();
    }
}