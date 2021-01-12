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
            //IList<Klienci> clients = libraryService.GetAllClient();
            //IList<Klienci> tab = new List<Klienci>();
            //foreach (Klienci item in clients)
            //{
            //    tab.Add(item);
            //}
            List<Klienci> temp = libraryService.GetAllClient().ToList();
            klienciBindingSource.DataSource = temp;
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
                    //klienciBindingSource.Add(api.GetLastClient());
                    //List<Klienci> customersList = (List<Klienci>)klienciBindingSource.DataSource;
                    api.AddClientToDatabase(eventArgs.Klienci);
                    //customersList.Add(api.GetLastClient());
                    // klienciBindingSource.DataSource = customersList;
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

            if (person != null)
            {
                //klienciBindingSource.Remove(person);
                LibraryServiceClient api = new LibraryServiceClient();
                var customersList = (List<Klienci>)klienciBindingSource.DataSource;
                var customerRemove = customersList.FirstOrDefault(el => el.IDKlienta == person.IDKlienta);
                customersList.Remove(customerRemove);
                klienciBindingSource.DataSource = customersList.ToList();
                api.DeleteClientAfterID(clientId);
                //klienciBindingSource.DataSource = api.GetAllClient();
                if (dataGridViewCustomers.Rows.Count > 1)
                {
                    dataGridViewCustomers.ClearSelection();
                    dataGridViewCustomers.Rows[dataGridViewCustomers.Rows.Count - 1].Selected = true;
                }
            }

        }
    }
}
