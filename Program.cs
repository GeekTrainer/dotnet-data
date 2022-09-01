// See https://aka.ms/new-console-template for more information
using Microsoft.Data.Sqlite;

// connect to sqlite database
var connection = new SqliteConnection("Data Source=test.db");
connection.Open();

var command = connection.CreateCommand();

// create table with first name and last name
command.CommandText = "CREATE TABLE IF NOT EXISTS people (first_name TEXT, last_name TEXT)";
if(command.ExecuteNonQuery() > 0) {
    // insert sample data into people table
    command.CommandText = "INSERT INTO people (first_name, last_name) VALUES ('John', 'Doe')";
    command.ExecuteNonQuery();
    command.CommandText = "INSERT INTO people (first_name, last_name) VALUES ('Jane', 'Doe')";
    command.ExecuteNonQuery();
};

Console.Write("Enter last name: ");
var lastName = Console.ReadLine();

command.CommandText = "INSERT INTO people (first_name, last_name) VALUES ('John', '" + lastName + "')";
command.ExecuteNonQuery();
