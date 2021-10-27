using System.Collections.Generic;
using System.Diagnostics;
using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.Common.Model;

namespace VaccineTrackerDemo.DataAccess
{
    public class DummyVaccineUserDataProvider : IVaccineUserDataProvider
    {
        public IEnumerable<VaccineUser> LoadVaccineUsers()
        {
            return new List<VaccineUser>()
            {
                new VaccineUser()
                {
                    Username = "Vishal",
                    Gender = "Male",
                    ContactNumber = "1234994509",
                    Age = "29",
                    Address = "Pune",
                    VaccineName = "CoviSheild"
                },
                new VaccineUser()
                {
                    Username = "Sam",
                    Gender = "Male",
                    ContactNumber = "1234996456",
                    Age = "30",
                    Address = "Pune",
                    VaccineName = "CoviSheild"
                },
                new VaccineUser()
                {
                    Username = "Jo",
                    Gender = "Female",
                    ContactNumber = "1749964569",
                    Age = "32",
                    Address = "Mumbai",
                    VaccineName = "Covaxin"
                }

            };
        }

        public void SaveUser(VaccineUser user)
        {
            Debug.WriteLine($"VaccineUser saved: {user.Username}");
        }
    }
}
