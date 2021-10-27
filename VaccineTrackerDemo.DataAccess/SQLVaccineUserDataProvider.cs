using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.Common.Model;

namespace VaccineTrackerDemo.DataAccess
{
    public class SQLVaccineUserDataProvider : IVaccineUserDataProvider
    {
        string connectionString;

        public SQLVaccineUserDataProvider()
        {
            this.connectionString = "server=DESKTOP-OOA4QA5; initial catalog=VaccineDB; Trusted_Connection=True; MultipleActiveResultSets=true";
        }

        public IEnumerable<VaccineUser> LoadVaccineUsers()
        {
            var users = new List<VaccineUser>();

            string queryString = "SELECT * FROM dbo.VaccineUsers;";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new VaccineUser()
                        {
                            Username = reader[0].ToString(),
                            Gender = reader[1].ToString(),
                            ContactNumber = reader[2].ToString(),
                            Age = reader[3].ToString(),
                            VaccineName = reader[4].ToString(),
                            Address = reader[5].ToString()
                        };

                        users.Add(user);
                    }
                }
            }

            return users;
        }

        public void SaveUser(VaccineUser user)
        {
            string queryString = $"insert into dbo.VaccineUsers values ('{user.Username}', '{user.Gender}', '{user.ContactNumber}', '{user.Age}', '{user.VaccineName}', '{user.Address}')";
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            };
        }
    }
}
