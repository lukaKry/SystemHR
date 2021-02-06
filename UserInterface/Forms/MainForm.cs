using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms.Contracts;
using SystemHR.UserInterface.Forms.Employees;

namespace SystemHR.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        private TabPage _tpEmployees;
        private TabPage _tpContracts;
        #endregion

        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        private void btn_Employees_Click(object sender, EventArgs e)
        {

            if (EmployeesForm._instance == null)
            {
                _tpEmployees = new TabPage();
                EmployeesForm frm = EmployeesForm.Instance;
                AddTab(_tpEmployees, frm, btn_Employees.Text);
            }
            else
            {
                tcTab.SelectedTab = _tpEmployees;
            }
        }

        private void AddTab(TabPage tabOne, Form frm, string text)
        {

            tcTab.Controls.Add(tabOne);

            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabOne.Controls.Add(frm);
            tcTab.SelectedTab = tabOne;
            tabOne.Text = text;
        }

        private void btn_contracts_Click(object sender, EventArgs e)
        {

            if (ContractsForm._instance == null)
            {
                _tpContracts = new TabPage();
                ContractsForm frm = ContractsForm.Instance;
                AddTab(_tpContracts, frm, btn_contracts.Text);
            }
            else
            {
                tcTab.SelectedTab = _tpContracts;
            }
        }

        private void tcTab_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTab.TabPages[e.Index];
                var tabRect = this.tcTab.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);

                var closeImage = new Bitmap(UserInterface.Properties.Resources.close_161);
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTab_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till
            for (var i = 0; i < this.tcTab.TabPages.Count; i++)
            {
                var tabRect = this.tcTab.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(UserInterface.Properties.Resources.close_161);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTab.TabPages[i].Controls[0] as Form;
                    this.tcTab.TabPages.RemoveAt(i);
                    frm.Close();
                    break;
                }
            }
        }
    }
}
