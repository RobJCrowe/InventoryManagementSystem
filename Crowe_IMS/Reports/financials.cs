using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowe_IMS
{
    class financials
    {
        private List<partsdb> partList = new List<partsdb>();
        private List<productsdb> productList = new List<productsdb>();
        private List<displayItem> displayList = new List<displayItem>();

        bool isProduct = false;
        public financials(bool isProduct)
        {
            this.isProduct = isProduct;
            if (isProduct == true)
            {
                productList = dbHelper.GetAllProducts();
            }
            else
            {
                partList = dbHelper.GetAllParts();
            }
            generateDisplayItems();
        }

        public bool IsProduct()
        {
            return isProduct;
        }

        public int getCount()
        {
            if (isProduct == true)
            {
                return productList.Count();
            }
            return partList.Count();
        }

        private void generateDisplayItems()
        {
            int count = isProduct ? productList.Count() : partList.Count();
            for (int i = 0; i < count; i++)
            {
                if (isProduct == true)
                {
                    displayList.Add(new displayItem(productList[i].productid, productList[i].name, productList[i].instock, productList[i].instock * productList[i].price));
                }
                else
                {
                    displayList.Add(new displayItem(partList[i].partid, partList[i].name, partList[i].instock, partList[i].instock * partList[i].price));
                }
            }
        }

        public decimal getTotal()
        {
            decimal total = 0;
            for (int i = 0; i < displayList.Count(); i++)
            {
                total = total + displayList[i].Total_Value;
            }
            return total;
        }

        public List<displayItem> getDisplayItems()
        {
            return displayList;
        }

    }
}
