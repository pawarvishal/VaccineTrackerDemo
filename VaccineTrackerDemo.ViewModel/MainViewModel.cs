using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.ViewModel.Command;

namespace VaccineTrackerDemo.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private VaccineUserViewModel selectedVaccineUser;
        private readonly IVaccineUserDataProvider vaccineUserDataProvider;

        public MainViewModel(IVaccineUserDataProvider vaccineUserDataProvider)
        {
            this.vaccineUserDataProvider = vaccineUserDataProvider;
            LoadCommand = new DelegateCommand(Load);
        }

        public DelegateCommand LoadCommand { get; }

        public ObservableCollection<VaccineUserViewModel> VaccineUsers { get; } = new();

        public VaccineUserViewModel SelectedVaccineUser
        {
            get => this.selectedVaccineUser;
            set
            {
                if (this.selectedVaccineUser != value)
                {
                    this.selectedVaccineUser = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(IsUserSelected));
                }
            }
        }

        public bool IsUserSelected => SelectedVaccineUser != null;

        public void Load()
        {
            var users = vaccineUserDataProvider.LoadVaccineUsers();

            VaccineUsers.Clear();
            foreach (var user in users)
            {
                VaccineUsers.Add(new VaccineUserViewModel(user, vaccineUserDataProvider));
            }
        }

    }
}
