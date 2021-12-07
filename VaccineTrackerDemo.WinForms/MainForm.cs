using System;
using System.Windows.Forms;
using VaccineTrackerDemo.Common.DataProvider;
using VaccineTrackerDemo.Common.Model;
using VaccineTrackerDemo.DataAccess;
using VaccineTrackerDemo.ViewModel;

namespace VaccineTrackerDemo.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel viewModel;
        private readonly IVaccineUserDataProvider vaccineUserDataProvider;

        public MainForm()
        {
            InitializeComponent();
            vaccineUserDataProvider = new SQLVaccineUserDataProvider();
            viewModel = new MainViewModel(vaccineUserDataProvider);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            viewModel.Load();
            usersBindingSource.DataSource = viewModel.VaccineUsers;

            // Set datasource for listbox
            listBoxUsers.DataSource = usersBindingSource;
            listBoxUsers.DisplayMember = "Username";

            // Check if data bindings are already intialized
            var areDataBindingsInitialized = txtUserName.DataBindings.Count > 0;


            if (areDataBindingsInitialized)
            {
                usersBindingSource.ResetBindings(false);
            }
            else
            {
                // Set datasource for user details controls
                txtUserName.DataBindings.Add("Text", usersBindingSource, "Username",
                    false, DataSourceUpdateMode.Never);

                txtContactNumber.DataBindings.Add("Text", usersBindingSource, "ContactNumber",
                    false, DataSourceUpdateMode.Never);

                txtAge.DataBindings.Add("Text", usersBindingSource, "Age",
                    false, DataSourceUpdateMode.Never);

                txtAddress.DataBindings.Add("Text", usersBindingSource, "Address",
                    false, DataSourceUpdateMode.Never);

                txtVaccineName.DataBindings.Add("Text", usersBindingSource, "VaccineName",
                    false, DataSourceUpdateMode.Never);

                btnSave.DataBindings.Add("Enabled", usersBindingSource, "CanSave");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Register?", "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                string gender = null;

                if (radioMale.Checked)
                {
                    gender = "Male";
                }
                else if (radioFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "NA";
                }

                var newUser = new VaccineUser()
                {
                    Username = txtUserName.Text,
                    ContactNumber = txtContactNumber.Text,
                    Gender = gender,
                    Address = txtAddress.Text,
                    Age = txtAge.Text,
                    VaccineName = txtVaccineName.Text
                };

                viewModel.Save(new VaccineUserViewModel(newUser, this.vaccineUserDataProvider));

                ShowConfirmationDetailsForm(newUser);
            }
        }


        private void ShowConfirmationDetailsForm(VaccineUser vaccineUser)
        {
            var confirmationForm = new ConfirmationForm(vaccineUser);
            confirmationForm.Show();
        }
    }
}
