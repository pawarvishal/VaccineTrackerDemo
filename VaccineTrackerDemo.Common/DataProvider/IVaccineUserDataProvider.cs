using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackerDemo.Common.Model;

namespace VaccineTrackerDemo.Common.DataProvider
{
    public interface IVaccineUserDataProvider
    {
        IEnumerable<VaccineUser> LoadVaccineUsers();

        void SaveUser(VaccineUser user);
    }
}
