using System;
using System.Windows.Forms;
using VaccineTrackerDemo.DataAccess;
using VaccineTrackerDemo.ViewModel;

namespace VaccineTrackerDemo.WinForms
{
    public partial class MainForm : Form
    {
        private readonly MainViewModel viewModel;

        public MainForm()
        {
            InitializeComponent();
            viewModel = new MainViewModel(new VaccineUserDataProvider());
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


            // Hide Regsiter Details, Only Show when Clicked On Save
            HideRegisterDetailsControls();

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

                // radioMale.DataBindings.Add("Checked", usersBindingSource, "Gender");

                // radioFemale.DataBindings.Add("Checked", usersBindingSource, "Gender");

                btnSave.DataBindings.Add("Enabled", usersBindingSource, "CanSave");


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ShowRegisterDetailsControls();

            SetRegisterControlsValues();
        }

        private void SetRegisterControlsValues()
        {
            lblRegUsrname.Text = txtUserName.Text;
            lblRegGender.Text = radioMale.Text;
            lblRegAge.Text = txtAge.Text;
            lblRegAddress.Text = txtAddress.Text;
            lblRegContactNumber.Text = txtContactNumber.Text;
            lblRegVaccineName.Text = txtVaccineName.Text;
        }

        private void ShowRegisterDetailsControls()
        {
            btnRegister.Show();
            lblRegAddress.Show();
            lblRegAge.Show();
            lblRegContactNumber.Show();
            lblRegGender.Show();
            lblRegVaccineName.Show();
            lblRegUsrname.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Register?", "Register", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                if (usersBindingSource.Current is VaccineUserViewModel vaccineUserViewModel &&
                vaccineUserViewModel.CanSave)
                {
                    vaccineUserViewModel.Save();
                }

                SetRegisterLablesEmpty();
                HideRegisterDetailsControls();
                ShowConfirmationDetailsForm();
            }
            else
            {
                SetRegisterLablesEmpty();
                HideRegisterDetailsControls();
            }
        }

        private void HideRegisterDetailsControls()
        {
            btnRegister.Hide();
            lblRegAddress.Hide();
            lblRegAge.Hide();
            lblRegContactNumber.Hide();
            lblRegGender.Hide();
            lblRegVaccineName.Hide();
            lblRegUsrname.Hide();
        }

        private void SetRegisterLablesEmpty()
        {
            lblRegUsrname.Text = string.Empty;
            lblRegGender.Text = string.Empty;
            lblRegAge.Text = string.Empty;
            lblRegAddress.Text = string.Empty;
            lblRegContactNumber.Text = string.Empty;
            lblRegVaccineName.Text = string.Empty;
        }

        private void ShowConfirmationDetailsForm()
        {
            var confirmationForm = new ConfirmationForm();
            confirmationForm.Show();
        }
    }
}
