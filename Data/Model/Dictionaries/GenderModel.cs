using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Model.Dictionaries
{
    public class GenderModel : EntityModel
    {
        public string Value { get; set; }

        public GenderModel(string value)
        {
            Value = value;
        }
    }
}
