using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.Common.Model;
using VaccineTrackerDemo.ViewModel;

namespace VaccineTrackerDemoTests.ViewModelTests
{
    [TestClass]
    public class MainViewModelFacts
    {
        private readonly Mock<IVaccineUserDataProvider> mockVaccineUserDataProvider;

        public MainViewModelFacts()
        {
            this.mockVaccineUserDataProvider = new Mock<IVaccineUserDataProvider>();
        }

        [TestMethod]
        public void Ctor_Gets_Created()
        {
            var vm = GetMainViewModel();
            vm.ShouldNotBeNull();
        }

        [TestMethod]
        public void OnClick_Save_Calls_VaccineUserDataProvider()
        {
            // Arrange
            var vm = GetMainViewModel();
            this.mockVaccineUserDataProvider.Setup(x => x.SaveUser(It.IsAny<VaccineUser>())).Verifiable();
            var newUser = new VaccineUser()
            {
                Username = "John",
                ContactNumber = "123",
                Gender = "Male",
                Address = "Mumbai",
                Age = "30",
                VaccineName = "Covishield"
            };
            var vaccineUserViewModel = new VaccineUserViewModel(newUser, this.mockVaccineUserDataProvider.Object);


            // Act
            vm.Save(vaccineUserViewModel);

            // Assert
            this.mockVaccineUserDataProvider.Verify(x => x.SaveUser(It.IsAny<VaccineUser>()), Times.Once);
        }


        [TestMethod]
        public void LoadCommandExecute_Calls_VaccineDataProvider()
        {
            // Arrange
            var vm = GetMainViewModel();
            this.mockVaccineUserDataProvider.Setup(x => x.LoadVaccineUsers()).Verifiable();


            // Act
            vm.LoadCommand.Execute(true);

            // Assert
            this.mockVaccineUserDataProvider.Verify(x => x.LoadVaccineUsers(), Times.Once);
        }

        private MainViewModel GetMainViewModel()
        {
            return new MainViewModel(this.mockVaccineUserDataProvider.Object);
        }
    }
}
