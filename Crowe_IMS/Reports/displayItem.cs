using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe_IMS
{
    class displayItem
    {

        public displayItem(int id, string name, int inStock, decimal Total_Value)
        {
            this.id = id;
            Name = name;
            InStock = inStock;
            this.Total_Value = Total_Value;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Total_Value { get; set; }
    }
}
