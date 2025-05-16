using Microsoft.Data.Sqlite;

namespace DatabaseLib;

public interface IDatabaseService { }
public class DatabaseSystem : IDatabaseService {
    private readonly string DB_Path;

    public string DbPath => DB_Path;

    public DatabaseSystem() {
        DB_Path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "database.db");
        testConnection(DB_Path);
    }

    public void testConnection(string database_path) {
        try {
            using var connection = new SqliteConnection($"Data Source={database_path}");
            connection.Open();
        } catch (SqliteException e) { Console.WriteLine("[ERROR : connection failed : " + e.Message + "]"); } finally {
            Console.WriteLine("[INFO : database connection established]");
        }
    }

    public void createUsersTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS Users 
                        (user_id TEXT PRIMARY KEY AUTOINCREMENT,
                        name TEXT NOT NULL,
                        email TEXT NOT NULL UNIQUE,
                        password TEXT NOT NULL DEFAULT 'qwerty123456'
                    );
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    public void createBooksTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS Books 
                        (isbn TEXT PRIMARY KEY, 
                        title TEXT NOT NULL, 
                        author TEXT NOT NULL,
                        publisher TEXT NOT NULL,
                        cover BLOB);
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    public void createGenresTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS Genres 
                        (genre_id INTEGER PRIMARY KEY AUTOINCREMENT,
                         name TEXT NOT NULL UNIQUE
                        );
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    public void createBookGenresTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS BookGenres (
                        isbn TEXT NOT NULL,
                        genre_id INTEGER NOT NULL,
                        PRIMARY KEY (isbn, genre_id),
                        FOREIGN KEY (isbn) REFERENCES Books(isbn) ON DELETE CASCADE,
                        FOREIGN KEY (genre_id) REFERENCES Genres(genre_id) ON DELETE CASCADE
                    );
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    // public void createLibrariesTable() {
    //     using var connection = new SqliteConnection(DB_Path);
    //     connection.Open();
    //     
    //     string query = """
    //                    CREATE TABLE IF NOT EXISTS Libraries 
    //                        (lib_id INTEGER PRIMARY KEY AUTOINCREMENT);
    //                    """;
    //     try {
    //         using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
    //     } catch (SqliteException e) {
    //         Console.WriteLine(e.Message);
    //     }
    //     connection.Close();
    // }

    public void createUserLibrariesTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS UserLibraries 
                        (lib_id INTEGER PRIMARY KEY AUTOINCREMENT,
                        user_id TEXT NOT NULL,
                        name TEXT NOT NULL,
                        FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE
                    );
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    public void createUserLibraryBooksTable() {
        using var connection = new SqliteConnection(DB_Path);
        connection.Open();

        var query = """
                    CREATE TABLE IF NOT EXISTS UserLibraryBooks 
                        (lib_id INTEGER NOT NULL,
                        isbn TEXT NOT NULL,
                        PRIMARY KEY (lib_id, isbn),
                        FOREIGN KEY (lib_id) REFERENCES UserLibraries(lib_id) ON DELETE CASCADE,
                        FOREIGN KEY (isbn) REFERENCES Books(isbn) ON DELETE CASCADE
                    );
                    """;
        try {
            using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
        } catch (SqliteException e) { Console.WriteLine(e.Message); }

        connection.Close();
    }

    // public void createGenreLibrariesTable() {
    //     using var connection = new SqliteConnection(DB_Path);
    //     connection.Open();
    //     
    //     string query = """
    //                    CREATE TABLE IF NOT EXISTS GenreLibraries 
    //                        (lib_id INTEGER PRIMARY KEY AUTOINCREMENT,
    //                        genre_id INTEGER NOT NULL,
    //                        name TEXT NOT NULL UNIQUE,
    //                        FOREIGN KEY (genre_id) REFERENCES Genres(genre_id) ON DELETE CASCADE
    //                    );
    //                    """;
    //     try {
    //         using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
    //     } catch (SqliteException e) {
    //         Console.WriteLine(e.Message);
    //     }
    //     connection.Close();
    // }

    // public void createGenreLibraryBooksTable() {
    //     using var connection = new SqliteConnection(DB_Path);
    //     connection.Open();
    //
    //     string query = """
    //                    CREATE TABLE IF NOT EXISTS GenreLibraryBooks 
    //                        (lib_id INTEGER NOT NULL,
    //                        isbn TEXT NOT NULL,
    //                        PRIMARY KEY (lib_id, isbn),
    //                        FOREIGN KEY (lib_id) REFERENCES GenreLibraries(lib_id) ON DELETE CASCADE,
    //                        FOREIGN KEY (isbn) REFERENCES Books(isbn) ON DELETE CASCADE
    //                    );
    //                    """;
    //     try {
    //         using (var command = new SqliteCommand(query, connection)) { command.ExecuteNonQuery(); }
    //     } catch (SqliteException e) {
    //         Console.WriteLine(e.Message);
    //     }
    // }

    public string[] getUserByID(string user_id) {
        var query = "SELECT * FROM Users WHERE user_id = @user_id";

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@user_id", user_id);

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var name     = reader.GetString(reader.GetOrdinal("name"));
                var email    = reader.GetString(reader.GetOrdinal("email"));
                var password = reader.GetString(reader.GetOrdinal("password"));

                string[] result = { user_id, name, email, password };
                return result;
            }
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve user: " + e.Message + "]"); }

        return null;
    }
    
    public string[] getUserByEmail(string email) {
        var query = "SELECT * FROM Users WHERE email = @email";

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@email", email);

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var user_id    = reader.GetString(reader.GetOrdinal("user_id"));
                var name     = reader.GetString(reader.GetOrdinal("name"));
                var password = reader.GetString(reader.GetOrdinal("password"));

                string[] result = { user_id, name, email, password };
                return result;
            }
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve user: " + e.Message + "]"); }

        return null;
    }
    
    public string[][] getUserLibraries(string user_id) {
        var query = "SELECT * FROM UserLibraryBooks WHERE lib_id IN (SELECT lib_id FROM UserLibraries WHERE user_id = @user_id)";;

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@user_id", user_id);
        var result = new List<string[]>();

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var lib_id  = reader.GetString(reader.GetOrdinal("lib_id"));
                var isbn     = reader.GetString(reader.GetOrdinal("isbn"));
                string[] library = { lib_id, isbn };
                result.Add(library);
            }
            
            return result.ToArray();
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve libraries : " + e.Message + "]"); }

        return null;
    }

    public string[] getLibraryContentsById(int lib_id) {
        var query = "SELECT * FROM FROM UserLibraryBooks WHERE lib_id = @lib_id";

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@lib_id", lib_id);

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var      isbn   = reader.GetString(reader.GetOrdinal("isbn"));
                string[] result = { lib_id + "", isbn };
                return result;
            }
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve user: " + e.Message + "]"); }

        return null;
    }

    public string[] getBookById(string isbn) {
        var query = "SELECT * FROM FROM Books WHERE isbn = @isbn";

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@isbn", isbn);

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var      title     = reader.GetString(reader.GetOrdinal("title"));
                var      author    = reader.GetString(reader.GetOrdinal("author"));
                var      publisher = reader.GetString(reader.GetOrdinal("publisher"));
                string[] result    = { isbn, title, author, publisher };
                return result;
            }
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve user: " + e.Message + "]"); }

        return null;
    }

    public string[] getBookGenres(string isbn) {
        var query = "SELECT name FROM Genres WHERE genre_id IN (SELECT genre_id FROM BookGenres WHERE isbn = @isbn)";

        using var connection = new SqliteConnection(DB_Path);
        connection.Open();
        using var cmd = new SqliteCommand(query, connection);
        cmd.Parameters.AddWithValue("@isbn", isbn);
        var result = new List<string>();

        try {
            using var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                result.Add(reader.GetString(0));
                return result.ToArray();
            }
        } catch (SqliteException e) { Console.WriteLine("[ERROR : unable to retrieve user: " + e.Message + "]"); }

        return null;
    }
}

