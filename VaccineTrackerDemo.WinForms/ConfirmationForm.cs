using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VaccineTrackerDemo.Common.Model;
using VaccineTrackerDemo.ViewModel;

namespace VaccineTrackerDemo.WinForms
{
    public partial class ConfirmationForm : Form
    {
        private readonly VaccineUserViewModel vaccineUserViewModel;

        public ConfirmationForm(VaccineUserViewModel vaccineUserViewModel)
        {
            InitializeComponent();
            this.vaccineUserViewModel = vaccineUserViewModel;
            this.SetLabels();
        }

        private void SetLabels()
        {
            lblThanks.Text = $"Thanks For Registering {this.vaccineUserViewModel.Username}";
            lblVaccine.Text = $"You Have opted for {this.vaccineUserViewModel.VaccineName}";
            lblSms.Text = $"You will get confirmation sms on {this.vaccineUserViewModel.ContactNumber} once slot is allocated";
        }
    }
}
