using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static string connectionString =
        "Server=localhost;Database=CompanyDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        con.Open();

        // Insert
        SqlCommand insert = new SqlCommand(
            "INSERT INTO Employees (Name, Salary) VALUES ('Aryan', 50000)", con);
        insert.ExecuteNonQuery();

        // Read using SqlDataReader
        SqlCommand read = new SqlCommand(
            "SELECT * FROM Employees", con);

        using (SqlDataReader reader = read.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Name"] + " " + reader["Salary"]);
            }
        }

        // Update
        SqlCommand update = new SqlCommand(
            "UPDATE Employees SET Salary = 60000 WHERE Name = 'Aryan'", con);
        update.ExecuteNonQuery();

        // DataAdapter
        SqlDataAdapter adapter =
            new SqlDataAdapter("SELECT * FROM Employees", con);

        DataTable table = new DataTable();
        adapter.Fill(table);

        Console.WriteLine("Total Employees: " + table.Rows.Count);

        // Delete
        SqlCommand delete = new SqlCommand(
            "DELETE FROM Employees WHERE Name = 'Aryan'", con);
        delete.ExecuteNonQuery();

        Console.WriteLine("CRUD operations completed");
    }
}