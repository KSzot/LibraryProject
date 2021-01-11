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
using UserInterface.Api;
using UserInterface.Classes;

namespace UserInterface.Forms.Customer
{
    public partial class CustomersForm : BaseForm
    {
        #region Fields
        private static CustomersForm _instance = null;

        #endregion

        #region Properties
        public static CustomersForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomersForm();
                }

                return _instance;

            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                    return true;
                return false;
            }
        }


        #endregion
        private CustomersForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            LibraryServiceClient libraryService = new LibraryServiceClient();
            //Nie wiem dlaczego moja tablica ma fixed size (stały rozmair)
            IList<Klienci> clients = libraryService.GetAllClient();
            IList<Klienci> tab = new List<Klienci>();
            foreach (Klienci item in clients)
            {
                tab.Add(item);
            }
            klienciBindingSource.DataSource = tab;
        }


        #region Events
        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
        #endregion

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CustomersAddForm frm = new CustomersAddForm();
            frm.ReloadCustomers += (s, ea) =>
            {
                CustomersEventArgs eventArgs = ea as CustomersEventArgs;
                if (eventArgs != null)
                {
                    LibraryServiceClient api = new LibraryServiceClient();
                    api.AddClientToDatabase(eventArgs.Klienci);
                    Klienci client = api.GetLastClient();
                    klienciBindingSource.Add(api.GetLastClient());
                    dataGridViewCustomers.ClearSelection();
                    dataGridViewCustomers.Rows[dataGridViewCustomers.Rows.Count - 1].Selected = true;
                }
                    
                
            };
            frm.ShowDialog();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells[0].Value);
            int selectedRowIndex = dataGridViewCustomers.CurrentRow.Index;
            CustomersEditForm frm = new CustomersEditForm(findClientAfterId(clientId));
            frm.ReloadCustomers += (s, ea) =>
             {
                 CustomersEventArgs eventArgs = ea as CustomersEventArgs;
                 if(eventArgs!=null)
                 {
                     klienciBindingSource[selectedRowIndex] = eventArgs.Klienci;
                     LibraryServiceClient api = new LibraryServiceClient();
                     api.ModifyClient(eventArgs.Klienci);
                     //foreach (Klienci person in clients)
                     //{
                     //    if(person.IDKlienta == eventArgs.Klienci.IDKlienta)
                     //    {
                     //        person.Imie = eventArgs.Klienci.Imie;
                     //        person.Nazwisko = eventArgs.Klienci.Nazwisko;
                     //        person.Plec = eventArgs.Klienci.Plec;
                     //        person.Wiek = eventArgs.Klienci.Wiek;
                     //        person.Adres = eventArgs.Klienci.Adres;
                     //        person.Telefon = eventArgs.Klienci.Telefon;
                     //    }
                     //}
                 }
             };

            frm.ShowDialog();
        }

        private Klienci findClientAfterId(int index)
        {
            LibraryServiceClient api = new LibraryServiceClient();
            return api.FetchClientAfterID(index);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int clientId = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells[0].Value);

            Klienci person = findClientAfterId(clientId);
            if(person != null)
            {
                klienciBindingSource.Remove(person);

                LibraryServiceClient api = new LibraryServiceClient();
                api.DeleteClientAfterID(clientId);
                if (dataGridViewCustomers.Rows.Count > 1)
                {
                    dataGridViewCustomers.ClearSelection();
                    dataGridViewCustomers.Rows[dataGridViewCustomers.Rows.Count - 1].Selected = true;
                }
            }

        }
    }
}
