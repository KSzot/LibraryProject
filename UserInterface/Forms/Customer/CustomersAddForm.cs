using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Forms.Base;

namespace UserInterface.Forms.Customer
{
    public partial class CustomersAddForm : BaseAddEditForm
    {
        public CustomersAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControl();
        }

        private void ValidateControl()
        {
            if (string.IsNullOrWhiteSpace(comboBoxGender.Text))
            {
                errorProviderGender.SetError(comboBoxGender, "Pole płeć jest wymagane.");
            }
            else
            {
                errorProviderGender.Clear();
            }
        }

        private void InitializeData()
        {
            IList<String> genders = new List<String>()
            {
                "M",
                "K",
                string.Empty
            };

            bindingSourceGender.DataSource = genders;
            comboBoxGender.Text = string.Empty;

        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = userControlInputLastName.GetError();
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage+"\n");
            }

            string firstNameErrorMessage = userControlInputFirstName.GetError();
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage+"\n");
            }

            string genderErrorMessage = errorProviderGender.GetError(comboBoxGender);
            if (!string.IsNullOrEmpty(genderErrorMessage))
            {
                sbErrorMessage.Append(genderErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie Klienta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            StringBuilder sbWarningMessage = new StringBuilder();

            string adressWarningMessage = "Pole adress nie zostało wypełnione.";
            string phoneWarningMessage = "Pole telefon nie zostało wypełnione.";
            string ageWarningMessage = "Pole wiek nie zostało wypełnione.";

            if (string.IsNullOrEmpty(textBoxAge.Text))
            {
                sbWarningMessage.Append(ageWarningMessage);
            }

            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                sbWarningMessage.Append(adressWarningMessage);
            }

            if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                sbWarningMessage.Append(phoneWarningMessage);
            }
            if (sbWarningMessage.Length > 0)
            {
                DialogResult answer =
                    MessageBox.Show(
                        sbWarningMessage.ToString() + Environment.NewLine + "Czy mimo to chcesz dodać klienta?",
                        "Dodawanie Klienta",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (answer == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        protected override void Save()
        {
            if (ValidateForm())
            {
                MessageBox.Show("Zapisywanie..");
                Close();
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void comboBoxGender_TextChanged(object sender, EventArgs e)
        {
            ValidateControl();
        }
    }
}
