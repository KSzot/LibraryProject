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
using UserInterface.Forms.Books;
using UserInterface.Forms.Customer;

namespace UserInterface.Forms
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Fields

        private TabPage CustomPage;
        private TabPage BooksPage;
        #endregion

        #region Events
        private void buttonHuman_Click(object sender, EventArgs e)
        {
            if (CustomersForm.IsNull)
            {

                ShowFormInTabPage(out CustomPage, CustomersForm.Instance);
            }
            else
            {
                tabControlMain.SelectedTab = CustomPage;
            }
        }


        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tabControlMain.TabPages.Count; i++)
            {
                var tabRect = tabControlMain.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = Properties.Resources.close_16;
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tabControlMain.TabPages[i].Controls[0] as Form;
                    frm.Close();
                    tabControlMain.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                //var tabPage = this.tcTab.TabPages[e.Index];
                //var tabRect = this.tcTab.GetTabRect(e.Index);
                var tabPage = tabControlMain.TabPages[e.Index];
                var tabRect = tabControlMain.GetTabRect(e.Index);
                var closeImage = Properties.Resources.close_16;
                e.Graphics.DrawImage(closeImage,
                   (tabRect.Right - closeImage.Width),
                   tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor, TextFormatFlags.LeftAndRightPadding);

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Functions

        private void ShowFormInTabPage(out TabPage tabPage, Form frm)
        {
            tabPage = new TabPage();
            //Form frm = new CustomersForm();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabPage.Text = frm.Text;
            tabControlMain.Controls.Add(tabPage);
            tabPage.Controls.Add(frm);
            tabControlMain.SelectedTab = tabPage;
        }
        #endregion

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (BooksForm.IsNull)
            {

                ShowFormInTabPage(out BooksPage, BooksForm.Instance);
            }
            else
            {
                tabControlMain.SelectedTab = BooksPage;
            }
        }
    }
}
