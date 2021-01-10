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
            klienciBindingSource.DataSource = libraryService.GetAllClient();
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
            frm.ShowDialog();
        }
    }
}
