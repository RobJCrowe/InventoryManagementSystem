using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    class UnitTesting
    {
        public static void RunTests()
        {
            int counter = 0;
            int testPartsCounter = TestPart();
            int testProductCounter = testProduct();
            counter = counter + testPartsCounter;
            counter = counter + testProductCounter;
            partsCount();
            productsCount();
            if (counter > 0)
            {
                cl("*************" + counter + " of 6 tests have passed.");
                MessageBox.Show(counter + " of 6 tests have passed.");
            }
            else
            {
                cl("*************" + "All tests have failed.");
                MessageBox.Show("All tests have failed.");
            }
            partsCount();
            productsCount();
        }

        private static void partsCount()
        {
            List<partsdb> partHolder = dbHelper.GetAllParts();
            cl("# of parts: " + partHolder.Count());
        }

        private static void productsCount()
        {
            List<productsdb> productHolder = dbHelper.GetAllProducts();
            cl("# of parts: " + productHolder.Count());
        }

        private static void cl(string st)
        {
            System.Diagnostics.Debug.WriteLine(st);

        }


        private static int TestPart()
        {
            DateTime dateTimenow = DateTime.Now;
            int testsPassed = 0;
            partsdb part1 = new partsdb();
            part1.name = "PartTest"; part1.price = 12.34M; part1.instock = 666;part1.min = 5;part1.max = 999;part1.type = "i";part1.details = "ABC100";part1.lastmodified = dateTimenow;
            cl("");
            cl("---Running part creation test.");

            int idIndex = dbHelper.AddPart(part1);
            if (dbHelper.PartExists(idIndex)) {
                cl("Part creation test PASSED");
                testsPassed++;
                cl("---Running part retrieval test.");
                partsdb testpart = dbHelper.GetPart(idIndex);
                if((testpart.partid==idIndex) && (testpart.instock==part1.instock))
                {
                    testsPassed++;
                    cl("Part retrieval test PASSED.");
                    cl("---Running part deletion test.");
                    dbHelper.RemovePart(idIndex);
                    if (!dbHelper.PartExists(idIndex))
                    {
                        testsPassed++;
                        cl("Part deletion test has PASSED.");
                    }
                    else
                    {
                        cl("Part deletion test has FAILED.");
                    }
                }
                else
                {
                    cl("Part retrieval test FAILED.");
                }
            }
            else
            {
                cl("Part creation test FAILED.");
            }
            return testsPassed;
        }

        private static int testProduct()
        {
            DateTime dateTimenow = DateTime.Now;
            int testsPassed = 0;
            productsdb productTemp = new productsdb();

            productTemp.name = "productTest"; productTemp.min = 1; productTemp.max = 40; productTemp.instock = 11;productTemp.price = 19.23M;productTemp.lastmodified = dateTimenow;
            cl("");
            cl("---Running product creation test.");

            int idIndex = dbHelper.AddProduct(productTemp);
            if (dbHelper.ProductExists(idIndex))
            {
                cl("Product creation test PASSED");
                testsPassed++;
                cl("---Running product retrieval test.");
                productsdb testproduct = dbHelper.GetProduct(idIndex);
                if ((testproduct.productid == idIndex) && (testproduct.instock == productTemp.instock))
                {
                    testsPassed++;
                    cl("Product retrieval test PASSED.");
                    cl("---Running product deletion test.");
                    dbHelper.RemoveProduct(idIndex);
                    if (!dbHelper.ProductExists(idIndex))
                    {
                        testsPassed++;
                        cl("Product deletion test has PASSED.");
                    }
                    else
                    {
                        cl("Product deletion test has FAILED.");
                    }
                }
                else
                {
                    cl("Product retrieval test FAILED.");
                }
            }
            else
            {
                cl("Product creation test FAILED.");
            }
            return testsPassed;
        }
    }
}
