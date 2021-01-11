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
        private static IList<Klienci> clients;
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
            //klienciBindingSource.DataSource = libraryService.GetAllClient();
            clients = libraryService.GetAllClient();
            foreach (var item in clients)
            {
                klienciBindingSource.Add(item);
            }
            //IList<Klienci> kliencis = (IList<Klienci>)(IEnumerable<Klienci>)libraryService.GetAllClient();
            //klienciBindingSource.DataSource = kliencis.AsEnumerable();
            //dataGridViewCustomers.DataSource = klienciBindingSource;
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
                    //klienciBindingSource.DataSource = api.GetAllClient();
                    clients.Add(client);
                    klienciBindingSource.Add(client);
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
                     foreach (Klienci person in clients)
                     {
                         if(person.IDKlienta == eventArgs.Klienci.IDKlienta)
                         {
                             person.Imie = eventArgs.Klienci.Imie;
                             person.Nazwisko = eventArgs.Klienci.Nazwisko;
                             person.Plec = eventArgs.Klienci.Plec;
                             person.Wiek = eventArgs.Klienci.Wiek;
                             person.Adres = eventArgs.Klienci.Adres;
                             person.Telefon = eventArgs.Klienci.Telefon;
                         }
                     }
                 }
             };

            frm.ShowDialog();
        }

        private Klienci findClientAfterId(int index)
        {
            Klienci client = new Klienci();
            foreach (Klienci item in clients)
            {
                if (item.IDKlienta == index)client = item;
            }
            return client;
        }
    }
}
