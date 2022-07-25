// See https://aka.ms/new-console-template for more information
using Microsoft.Data.Sqlite;

// connect to sqlite database
var connection = new SqliteConnection("Data Source=test.db");
connection.Open();

// create table with first name and last name
var command = connection.CreateCommand();
command.CommandText = "CREATE TABLE IF NOT EXISTS people (first_name TEXT, last_name TEXT)";
command.ExecuteNonQuery();
