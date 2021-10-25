using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (areDataBindingsInitialized)
            {
                usersBindingSource.ResetBindings(false);
            }
            else
            {
                // Set datasource for user details controls
                txtUserName.DataBindings.Add("Text", usersBindingSource, "Username",
                    false, DataSourceUpdateMode.OnPropertyChanged);

                txtContactNumber.DataBindings.Add("Text", usersBindingSource, "ContactNumber",
                    false, DataSourceUpdateMode.OnPropertyChanged);

                txtAge.DataBindings.Add("Text", usersBindingSource, "Age",
                    false, DataSourceUpdateMode.OnPropertyChanged);

                txtAddress.DataBindings.Add("Text", usersBindingSource, "Address",
                    false, DataSourceUpdateMode.OnPropertyChanged);

                txtVaccineName.DataBindings.Add("Text", usersBindingSource, "VaccineName",
                    false, DataSourceUpdateMode.OnPropertyChanged);

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
            if(usersBindingSource.Current is VaccineUserViewModel vaccineUserViewModel &&
                vaccineUserViewModel.CanSave)
            {
                vaccineUserViewModel.Save();
            }
        }
    }
}
