using Microsoft.Data.SqlClient;
using System;

Console.WriteLine($"Versioni i runtime-it: {Environment.Version}");
string connectionString = @"Server=.\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";

try
{
    using var connection = new SqlConnection(connectionString);
    connection.Open();
    using var command = new SqlCommand("SELECT COUNT(*) FROM Studentet", connection);
    int numri = (int)command.ExecuteScalar();
    Console.WriteLine($"Numri i rrehstave ne tabelen Studentet: {numri}");
}
catch(SqlException ex)
{
    Console.WriteLine($"Gabim lidhjeje me databazen: {ex.Message}");
}
