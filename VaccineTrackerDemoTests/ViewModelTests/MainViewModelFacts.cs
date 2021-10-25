using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineTrackerDemo.Common.DataProvider;
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

        private object GetMainViewModel()
        {
            return new MainViewModel(this.mockVaccineUserDataProvider.Object);
        }
    }
}
