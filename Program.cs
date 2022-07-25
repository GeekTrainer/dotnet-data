// See https://aka.ms/new-console-template for more information
using Microsoft.Data.Sqlite;

// connect to sqlite database
var connection = new SqliteConnection("Data Source=test.db");
connection.Open();

// create table with first name and last name
var command = connection.CreateCommand();
command.CommandText = "CREATE TABLE IF NOT EXISTS people (first_name TEXT, last_name TEXT)";
command.ExecuteNonQuery();

Console.Write("Enter Last Name: ");
var lastName = Console.ReadLine();

command.CommandText = "INSERT INTO people (first_name, last_name) VALUES ('John', '" + lastName + "')";
command.ExecuteNonQuery();

// select all rows from people table
command.CommandText = "SELECT * FROM people";
var reader = command.ExecuteReader();
// print all rows
while (reader.Read())
{
    Console.WriteLine(reader["first_name"] + " " + reader["last_name"]);
}
