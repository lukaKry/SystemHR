using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Forms.Contracts
{
    public partial class ContractsForm : Form
    {
        public static ContractsForm _instance = null;

        public static ContractsForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ContractsForm();
            return _instance;
            }
        
        }

        public ContractsForm()
        {
            InitializeComponent();
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {

        }

        private void ContractsForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
