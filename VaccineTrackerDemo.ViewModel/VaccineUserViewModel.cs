using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.Common.Model;
using VaccineTrackerDemo.ViewModel.Command;

namespace VaccineTrackerDemo.ViewModel
{
    public class VaccineUserViewModel : ViewModelBase
    {
        private readonly VaccineUser vaccineUser;
        private readonly IVaccineUserDataProvider vaccineUserDataProvider;

        public VaccineUserViewModel(VaccineUser vaccineUser, IVaccineUserDataProvider vaccineUserDataProvider)
        {
            this.vaccineUser = vaccineUser;
            this.vaccineUserDataProvider = vaccineUserDataProvider;
        }

        public DelegateCommand SaveCommand { get; }

        public string Username
        {
            get => this.vaccineUser.Username;
            set
            {
                if (this.vaccineUser.Username != value)
                {
                    this.vaccineUser.Username = value;
                    RaisePropertyChanged();

                }
            }
        }

        public string Gender
        {
            get => this.vaccineUser.Gender;
            set
            {
                if (this.vaccineUser.Gender != value)
                {
                    this.vaccineUser.Gender = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Age
        {
            get => this.vaccineUser.Age;
            set
            {
                if (this.vaccineUser.Age != value)
                {
                    this.vaccineUser.Age = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string ContactNumber
        {
            get => this.vaccineUser.ContactNumber;
            set
            {
                if (this.vaccineUser.ContactNumber != value)
                {
                    this.vaccineUser.ContactNumber = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string VaccineName
        {
            get => this.vaccineUser.VaccineName;
            set
            {
                if (this.vaccineUser.VaccineName != value)
                {
                    this.vaccineUser.VaccineName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Address
        {
            get => this.vaccineUser.Address;
            set
            {
                if (this.vaccineUser.Address != value)
                {
                    this.vaccineUser.Address = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(Address);

        public void SaveToDB()
        {
            this.vaccineUserDataProvider.SaveUser(this.vaccineUser);
        }

    }
}
