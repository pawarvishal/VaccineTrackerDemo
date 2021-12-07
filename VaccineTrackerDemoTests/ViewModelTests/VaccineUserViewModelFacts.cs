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
    public class VaccineUserViewModelFacts
    {
        private readonly Mock<IVaccineUserDataProvider> mockVaccineUserDataProvider;

        public VaccineUserViewModelFacts()
        {
            this.mockVaccineUserDataProvider = new Mock<IVaccineUserDataProvider>();
        }

        [TestMethod]
        public void Ctor_Gets_Created()
        {
            var vm = GetVaccineUserViewModel();
            vm.ShouldNotBeNull();
        }

        [TestMethod]
        public void SaveToDB_Calls_VaccineUserDataProvider()
        {
            // Arrange
            var vm = GetVaccineUserViewModel();
            this.mockVaccineUserDataProvider.Setup(x => x.SaveUser(It.IsAny<VaccineUser>())).Verifiable();

            // Act
            vm.SaveToDB();

            // Assert
            this.mockVaccineUserDataProvider.Verify(x => x.SaveUser(It.IsAny<VaccineUser>()), Times.Once);
        }

        private VaccineUserViewModel GetVaccineUserViewModel()
        {
            return new VaccineUserViewModel(It.IsAny<VaccineUser>(), this.mockVaccineUserDataProvider.Object);
        }
    }
}
