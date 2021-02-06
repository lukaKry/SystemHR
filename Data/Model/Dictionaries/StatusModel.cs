using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Model.Dictionaries
{
    public class StatusModel : EntityModel
    {
        public string Value { get; set; }

        public StatusModel(string value)
        {
            Value = value;
        }
    }
}
