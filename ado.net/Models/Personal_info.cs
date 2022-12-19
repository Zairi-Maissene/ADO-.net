using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ado.net.Models
{
    public class Personal_info
    {
        public static List<Person> getAllPerson()
        {
            SQLiteConnection conn = MyCon.CreateConnection();
            using (conn)
            {
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info", conn);
                SQLiteDataReader reader = command.ExecuteReader();
                List<Person> result = new List<Person>();


                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string firstName = (string)reader["first_name"];
                        string lastName = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];

                        Person person = new Person(id, firstName, lastName, email, DateTime.Now, image, country);
                        result.Add(person);
                    }
                    return result;

                }

            }
        }
        public static Person getPerson(int ID)
        {
            SQLiteConnection conn = MyCon.CreateConnection();
            using (conn)
            {
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM personal_info where id ={ID}", conn);
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        string firstName = (string)reader["first_name"];
                        string lastName = (string)reader["last_name"];
                        string email = (string)reader["email"];
                        string image = (string)reader["image"];
                        string country = (string)reader["country"];

                        Person person = new Person(id, firstName, lastName, email, DateTime.Now, image, country);
                        return person;
                    }
                }

            }
            return null;
        }
        public static int getByFirstNameAndCountry(string firstName, string country)
        {
            SQLiteConnection conn = MyCon.CreateConnection();
            using (conn)
            {
                SQLiteCommand command = new SQLiteCommand($"SELECT id FROM personal_info where UPPER(first_name) ='{firstName.ToUpper()}' and UPPER(country) ='{country.ToUpper()}'", conn);
                Debug.WriteLine(command);
                SQLiteDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        int id = (int)reader["id"];
                        return id;

                    }

                }
                return -1;
            }
        }
    }
}