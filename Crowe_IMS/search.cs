using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Crowe_IMS
{
    class search
    {

        public static List<int> partSearch(string text, List<partsdb> partList, string filter)
        {
            List<int> selectedRows = new List<int>();

            for (int i = 0; i < partList.Count(); i++)
            {
                switch (filter)
                {
                    case "Details":
                        if (partList[i].details.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "Instock":
                        if (partList[i].instock.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "LastModified":
                        if (partList[i].lastmodified.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "Max":
                        if (partList[i].max.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "Min":
                        if (partList[i].min.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "Name":
                        if (partList[i].name.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "PartId":
                        if (partList[i].partid.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "Price":
                        if (partList[i].price.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "Type":
                        if (partList[i].type.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; } break;
                    case "All":
                        if (partList[i].details.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].instock.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].lastmodified.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].max.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].min.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].name.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].partid.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].price.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].type.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    default: return null;
                }
            }
            return selectedRows;
        }

        public static List<int> productSearch(string text, List<productsdb> partList, string filter)
        {
            List<int> selectedRows = new List<int>();

            for (int i = 0; i < partList.Count(); i++)
            {
                switch (filter)
                {
                    case "Instock":
                        if (partList[i].instock.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "LastModified":
                        if (partList[i].lastmodified.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "Max":
                        if (partList[i].max.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "Min":
                        if (partList[i].min.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "Name":
                        if (partList[i].name.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "ProductId":
                        if (partList[i].productid.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    case "All":
                        if (partList[i].instock.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].lastmodified.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].max.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].min.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].name.ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        if (partList[i].productid.ToString().ToUpper().Contains(text.ToUpper())) { selectedRows.Add(i); continue; }
                        break;
                    default: return null;
                }
            }
            return selectedRows;
        }


    }
}

