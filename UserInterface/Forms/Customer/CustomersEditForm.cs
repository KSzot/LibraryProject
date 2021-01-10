using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Api;
using UserInterface.Classes;
using UserInterface.Forms.Base;

namespace UserInterface.Forms.Customer
{
    public partial class CustomersEditForm : BaseAddEditForm
    {
        private int clientId;
        public EventHandler ReloadCustomers;
        public CustomersEditForm(Klienci client)
        {
            InitializeComponent();
            InitializeData(client);
            PrepareClient(client);
            clientId = client.IDKlienta;
        }

        #region PrivateMethod
        private void PrepareClient(Klienci client)
        {
            userControlInputFirstName.TekstInput = client.Imie.Trim();
            userControlInputLastName.TekstInput = client.Nazwisko.Trim();
            textBoxPhone.Text = client.Telefon.Trim();
            textBoxAddress.Text = client.Adres.Trim();
            textBoxAge.Text = client.Wiek.ToString();
            labelTitle.Text = $"{client.Imie.Trim()} {client.Nazwisko.Trim()}";
        }

        private void InitializeData(Klienci obj)
        {
            IList<String> genders = new List<String>()
            {
                "M",
                "K",
            };

            bindingSourceGender.DataSource = genders;
            comboBoxGender.Text = obj.Plec;

        }

        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = userControlInputLastName.GetError();
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage + "\n");
            }

            string firstNameErrorMessage = userControlInputFirstName.GetError();
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage + "\n");
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
        #endregion

        #region override

        protected override void Save()
        {
            if (ValidateForm())
            {
                Klienci klienci = new Api.Klienci()
                {
                    IDKlienta = clientId,
                    Imie = userControlInputFirstName.TekstInput,
                    Nazwisko = userControlInputLastName.TekstInput,
                    Plec = comboBoxGender.Text,
                    Wiek = string.IsNullOrEmpty(textBoxAge.Text) ? 0 : Convert.ToInt32(textBoxAge.Text),
                    Adres = textBoxAddress.Text,
                    Telefon = textBoxPhone.Text,
                };
                ReloadCustomers?.Invoke(buttonSave, new CustomersEventArgs(klienci));
                Close();
            }
        }

        protected override void Cancel()
        {
            Cancel();
        }
        #endregion

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
