using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer;

namespace SystemHR.UserInterface.Forms
{
    public partial class BaseForm : Form
    {
        //protected SqlConnector Connector { get; private set; }

        public BaseForm()
        {
            InitializeComponent();
            //Connector = new SqlConnector();
        }
    }
}
