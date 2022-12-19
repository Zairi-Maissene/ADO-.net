using System.Data.Entity;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;

public class MyCon
{
    public static SQLiteConnection CreateConnection()
    {

        SQLiteConnection sqlite_conn;
        // Create a new database connection:
        sqlite_conn = new SQLiteConnection("Data source =D:\\Web Dev\\.NET\\database.db ");
       
         // Open the connection:
         try
        {
            sqlite_conn.Open();
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        return sqlite_conn;
    }
}