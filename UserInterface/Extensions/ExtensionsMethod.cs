using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR.UserInterface.Extensions
{
    public static class ExtensionsMethod
    {
        public static void DateTimePickerValueChanged(this DateTimePicker dtp)
        {
            dtp.Format = DateTimePickerFormat.Short;
        }
    }
}
