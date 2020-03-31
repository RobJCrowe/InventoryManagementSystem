using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    class dbHelper
    {
        public static bool userExists(string user)
        {
            using (var con = new InventoryMgmtEntities())
            {
                bool result = con.usertables.Any(n => n.username == user);
                if(result == false)
                {
                    MessageBox.Show("No user by that name exists.");
                    return false;
                }
                return true;
            }
        }
        public static usertable currentUser{ get; set; }
        
        public static bool isPassword(string user, string password)
        {
            using (var con = new InventoryMgmtEntities())
            {
                usertable userObj = con.usertables.First(j=>j.username== user);
                if (userObj.useractive != "t")
                {
                    MessageBox.Show("This user does not have database priviledges. Please contact your supervisor.");
                    return false;
                }
                if (userObj.userpassword == password)
                {
                    currentUser = userObj;
                    return true;
                }
                else
                {
                    MessageBox.Show("Your password is incorrect.");
                }
                return false;
            }

        }

        public static List<usertable> getOrderedeUsers()
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.usertables.OrderBy(n=>n.username).ToList();
            }
        }

        //Parts

        public static int AddPart(partsdb part)
        {
            using (var con = new InventoryMgmtEntities())
            {
                con.partsdbs.Add(part);
                con.SaveChanges();
                return part.partid;
            }
        }

        public static void UpdatePart(partsdb part)
        {
            partsdb updatedPart = part;
            using (var con = new InventoryMgmtEntities())
            {
                partsdb tempPart = con.partsdbs.Find(updatedPart.partid);
                tempPart.name = updatedPart.name; tempPart.instock = updatedPart.instock; tempPart.min = updatedPart.min; tempPart.max = updatedPart.max;
                tempPart.type = updatedPart.type; tempPart.details = updatedPart.details; tempPart.price=updatedPart.price; tempPart.lastmodified = DateTime.Now;
                
                if (updatedPart.createdby != null) { tempPart.createdby = updatedPart.createdby; }

                con.SaveChanges();
                
            }
        }
        public static bool PartExists(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
               return con.partsdbs.Any(n=>n.partid==index);
            }
        }

        public static void RemovePart(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                partsdb partTemp = con.partsdbs.Find(index);
                con.partsdbs.Remove(partTemp);
                con.SaveChanges();
            }
        }

        public static partsdb GetPart(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.partsdbs.Find(index);
            }
        }

        public static List<partsdb> GetAllParts()
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.partsdbs.ToList();
            }
        }

        public static List<partsdb> GetAllPartsByUser(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {

                List<partsdb>  parts = con.partsdbs.ToList();
                List<partsdb> toSend = new List<partsdb>();
                for (int i = 0; i < parts.Count(); i++)
                {
                    if (parts[i].createdby == index) toSend.Add(parts[i]);
                }
                return toSend;
            }
        }

        //Products

        public static int AddProduct(productsdb product)
        {
            using (var con = new InventoryMgmtEntities())
            {
                con.productsdbs.Add(product);
                con.SaveChanges();
                return product.productid;
            }
        }

        public static bool ProductExists(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.productsdbs.Any(n => n.productid == index);
            }
        }

        public static void RemoveProduct(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                productsdb productTemp = con.productsdbs.Find(index);
                con.productsdbs.Remove(productTemp);
                con.SaveChanges();
            }
        }
        
        public static productsdb GetProduct(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.productsdbs.Find(index);
            }
        }

        public static List<productsdb> GetAllProducts()
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.productsdbs.ToList();
            }
        }

        public static List<productsdb> GetAllProductsByUser(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {

                List<productsdb> products = con.productsdbs.ToList();
                List<productsdb> toSend = new List<productsdb>();
                for (int i = 0; i < products.Count(); i++)
                {
                    if (products[i].createdby == index) toSend.Add(products[i]);
                }
                return toSend;
            }
        }

        public static bool ModifyProductImproved(productsdb product, List<partsdb> partsList, List<productspart> originalParts)
        {

            using (var con = new InventoryMgmtEntities())
            {
                //Update Part Details
                productsdb productTemp = con.productsdbs.Find(product.productid); ;
                productTemp.name = product.name; productTemp.min = product.min; productTemp.max = product.max; productTemp.instock = product.instock;
                productTemp.price = product.price; productTemp.lastmodified = DateTime.Now;

                //Split list into associated parts that already exist and new parts
                List<partDerived> partDerivedList = new List<partDerived>();
                List<partsdb> realParts = new List<partsdb>();
                for (int i = 0; i < partsList.Count(); i++)
                {
                    if (partsList[i].GetType() == typeof(partDerived))
                    {
                        partDerived tempPart = (partDerived)(object)partsList[i];
                        partDerivedList.Add(tempPart);
                    }
                    else
                    {
                        realParts.Add(partsList[i]);
                    }

                }

                //Take original list and derived part list, where there is a match remove part from partListfinal
                List<productspart> partListFinal = originalParts;

                for (int i = 0; i < originalParts.Count(); i++)
                {
                    for (int j = 0; j < partDerivedList.Count(); j++)
                    {
                        if(originalParts[i].productpartid == partDerivedList[j].zproductpartid)
                        {
                                partListFinal.RemoveAll(u => u.productpartid == (int)partDerivedList[j].zproductpartid);
                        }
                    }
                    var temp = partListFinal;
                }
                
                //Remove all productparts from the db that are in the list partListFinal
                if (partListFinal.Count() > 0)
                {
                    for (int k = 0; k < partListFinal.Count(); k++)
                    {
                        productspart tempProductPart = con.productsparts.Find(partListFinal[k].productpartid);
                        con.productsparts.Remove(tempProductPart);
                    }
                }
                
                //Add new associated parts
                for (int l = 0; l < realParts.Count(); l++)
                {
                    productspart temp = new productspart();
                    temp.productid = product.productid;
                    temp.partid = realParts[l].partid;
                    con.productsparts.Add(temp);
                }
                con.SaveChanges();
                return true;
            }
        }

        //Associated Parts

        public static void AddAssocPart(int product, int part)
        {
            using (var con = new InventoryMgmtEntities())
            {
                productspart temp = new productspart();
                temp.productid = product;
                temp.partid = part;
                con.productsparts.Add(temp);
                con.SaveChanges();
            }
        }

        public static void RemoveAssocPartByid(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                productspart tempProductPart = con.productsparts.Find(index);
                con.productsparts.Remove(tempProductPart);
                con.SaveChanges();
            }
        }

        public static List<productspart> GetAllAssocParts(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.productsparts.Where(n => n.productid == index).ToList();
            }
        }

        public static List<productspart> GetAllAssocPartsBasedOnPart(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                return con.productsparts.Where(n => n.partid == index).ToList();
            }
        }

        public static List<partsdb> GetAllAssocPartsFull(int index)
        {
            using (var con = new InventoryMgmtEntities())
            {
                var prodpart = con.productsparts.Where(n => n.productid == index).ToList();
                List<partsdb> partsList = new List<partsdb>();
                for (int i = 0; i < prodpart.Count(); i++)
                {
                    partsList.Add(con.partsdbs.Find(prodpart[i].partid));
                }
                return partsList;
            }
        }

        public static List<partsdb> GetDerivedParts(int productIndex)
        {
            using(var con = new InventoryMgmtEntities())
            {
                List<productspart> productPartList = con.productsparts.Where(n => n.productid == productIndex).ToList();
                List<partsdb> tempList = new List<partsdb>();
                
                for (int i = 0; i < productPartList.Count(); i++)
                {
                    //Get part based on productPartLists.partID
                    partsdb partTemp = con.partsdbs.Find(productPartList[i].partid);
                    partDerived tempDerivedPart = new partDerived();
                    tempDerivedPart.zproductpartid = productPartList[i].productpartid;
                    tempDerivedPart.name = partTemp.name; tempDerivedPart.instock = partTemp.instock; tempDerivedPart.max = partTemp.max; tempDerivedPart.min = partTemp.min;
                    tempDerivedPart.partid = partTemp.partid; tempDerivedPart.price = partTemp.price; tempDerivedPart.type = partTemp.type;
                    tempDerivedPart.createdby = partTemp.createdby; tempDerivedPart.details = partTemp.details; tempDerivedPart.lastmodified = partTemp.lastmodified;
                    //partDerived tempDerived = (partDerived)partTemp;               //cast operation instead?
                    tempList.Add(tempDerivedPart);
                }
                return tempList;
            }
        }
    }
}
