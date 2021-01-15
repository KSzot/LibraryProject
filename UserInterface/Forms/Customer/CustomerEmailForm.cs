using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Classes;
using UserInterface.Forms.Base;

namespace UserInterface.Forms.Customer
{
    public partial class CustomerEmailForm : BaseAddEditForm
    {
        #region Fields
        private string NameClient { get; set; }
        private string LastNameClient { get; set; }
        private string Email { get; set; }
        #endregion



        public CustomerEmailForm(string name, string lastname, string email)
        {
            NameClient = name.Trim();
            LastNameClient = lastname.Trim();
            Email = email;
            InitializeComponent();
            InitialDate();
        }

        #region Func
        private void InitialDate()
        {
            labelTitle.Text = $"Wiadomość do {NameClient} {LastNameClient}";
        }

        #endregion

        #region ovveride
        protected override void Cancel()
        {
            Close();
        }

        protected override void Save()
        {
            var ms = new MailService();
            ms.SendEmail(email => email.From("horticalctest@gmail.com")
            .To(Email.Trim())
            .Subject(textBoxTopic.Text)
            .Body(richTextBoxMain.Text));
            Close();
        }

        #endregion

        #region Event
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        #endregion

    }
}
