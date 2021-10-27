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
        private readonly VaccineUser vaccineUser;

        public ConfirmationForm(VaccineUser vaccineUser)
        {
            InitializeComponent();
            this.vaccineUser = vaccineUser;
            this.SetLabels();
        }

        private void SetLabels()
        {
            lblThanks.Text = $"Thanks For Registering {this.vaccineUser.Username}";
            lblVaccine.Text = $"You Have opted for {this.vaccineUser.VaccineName}";
            lblSms.Text = $"You will get confirmation sms on {this.vaccineUser.ContactNumber} once slot is allocated";
        }
    }
}
