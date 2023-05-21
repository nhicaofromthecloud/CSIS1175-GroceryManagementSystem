using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; //important- needed to use StreamReader and Writer
using System.Linq; //important- needed to use Linq Query
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CSIS-1175-003 Nhi Cao 300367933

namespace NhiC_Assign2
{
    public partial class Form1 : Form
    {
        //form data members - define form data
        List<Grocery> GroceryList = new List<Grocery>(); 
        public Form1()
        {
            InitializeComponent();
            qtyRestockedTextBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void updateDataGroupBox_Enter(object sender, EventArgs e)
        {

        }

       //method to clear the 2 TextBoxes
        private void ClearQuantityTextBox()
        {
            qtySoldTextBox.Clear();
            qtyRestockedTextBox.Clear();
        }

        //method to load objects from GroceryList to List box
        private void LoadAllGroceryToListBox()
        {
            groceryListBox.Items.Clear(); 
            //here i learned that string format in the code needs to match the tostring in class definition
            //otherwise there's an error
            groceryListBox.Items.Add(String.Format
                ("{0, -15}{1, -23}{2, -12}" +
                "{3, -18}{4, -12}{5, -10}" +
                "{6, -15}{7, -15}{8, -15}", 
                "Item ID", "Item Name", "Unit Price", 
                "QtyMinForRestock", "InitialQty", "QtySold", 
                "QtyRestocked", "AvailableQty", "Sales"));
            foreach (Grocery groceryItem in GroceryList)
            {
                groceryListBox.Items.Add(groceryItem);
            }
            
        }

      
        private void loadDataButton_Click(object sender, EventArgs e)
        {  
            try
            {   //load data from file to GroceryList with StreamReader
                using (StreamReader inputStream  = new StreamReader("superstore.csv"))
                {
                    string eachLine;
                    if (!inputStream.EndOfStream) //using if to read the first line ie. header line
                    {
                        eachLine = inputStream.ReadLine();
                        //MessageBox.Show(eachLine);
                    }
                    while (!inputStream.EndOfStream) //continue reading the file
                    {
                        eachLine = inputStream.ReadLine(); //read one line

                        //split the data in one line and put corresponding values into an array
                        string[] eachgroceryItem = eachLine.Split(',');

                        //assign each array value to corresponding object's property
                        string itemCode = eachgroceryItem[0];
                        string itemName = eachgroceryItem[1];
                        string unitPriceStr = eachgroceryItem[2];
                        double.TryParse(unitPriceStr, out double unitPrice);

                        string qtyMinForRestockStr = eachgroceryItem[3];
                        int.TryParse(qtyMinForRestockStr, out int qtyMinForRestock);

                        string initialQtyStr = eachgroceryItem[4];
                        int.TryParse(initialQtyStr, out int initialQty);

                        string qtySoldStr = eachgroceryItem[5];
                        int.TryParse(qtySoldStr, out int qtySold);

                        string qtyRestockedStr = eachgroceryItem[6];
                        int.TryParse(qtyRestockedStr, out int qtyRestocked);

                        //create new object from the properties
                        Grocery groceryItem = new Grocery
                            (itemCode, itemName, unitPrice, qtyMinForRestock, initialQty, qtySold, qtyRestocked);

                        //add object to GroceryList- store data
                        GroceryList.Add(groceryItem);
                    }
                }
                //display GroceryList data to list box
                LoadAllGroceryToListBox();
                //update status label
                operationStatusLabel.Text = "Loaded " + GroceryList.Count + " items from the input file";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method to load qtySold & qtyRestocked to textboxes when item is selected
        private void groceryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lbIndex = groceryListBox.SelectedIndex;
            if (lbIndex > -1) //if listbox is not cleared
            {
                if (lbIndex == 0) //headerline
                {   
                    //MessageBox.Show("You have selected the header line."); 
                    ClearQuantityTextBox();
                }
                else if (GroceryList.Count > 0)
                {
                    qtySoldTextBox.Text = GroceryList[lbIndex - 1].QtySold.ToString();
                    qtyRestockedTextBox.Text = GroceryList[lbIndex - 1].QtyRestocked.ToString();
                    //We use lbIndex - 1 because GroceryList starts with an item while
                    //groceryListBox starts with a header line. 
                }
            }
        }

        private void updateSoldQtyButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                operationStatusLabel.Text = "Please select a grocery item to increment sold qty.";
            }
            else if (qtySoldTextBox.Text == "")
            {
                operationStatusLabel.Text = "Quantity sold cannot be empty.";
            }
            else if (!int.TryParse(qtySoldTextBox.Text, out int qtySold)
                            || qtySold <= 0)
            {
                operationStatusLabel.Text = "Quantity sold must be whole number > 0";
            }
            else if (qtySold > GroceryList[lbIndex - 1].AvailableQty)
            {
                operationStatusLabel.Text = "Quantity sold cannot be larger than quantity available.";
            }
            else if (GroceryList.Count > 0) //checks if there is any data
            {
                //process valid data
                Grocery groceryItem = new Grocery(GroceryList[lbIndex - 1].ItemCode, GroceryList[lbIndex - 1].ItemName, GroceryList[lbIndex - 1].UnitPrice,
                GroceryList[lbIndex - 1].QtyMinForRestock, GroceryList[lbIndex - 1].InitialQty, qtySold, GroceryList[lbIndex - 1].QtyRestocked);
                GroceryList[lbIndex - 1] = groceryItem; //updating the data
                groceryListBox.Items[lbIndex] = GroceryList[lbIndex - 1]; //updating the listbox with the new data
                //updating the status label
                operationStatusLabel.Text = "Incremented Qty Sold for item with Item Code " + GroceryList[lbIndex - 1].ItemCode;
            }
        }

        //similar to updateSoldQty method above
        private void updateRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                operationStatusLabel.Text = "Please select a grocery item to increment restocked qty.";
            }
            else if (qtyRestockedTextBox.Text == "")
            {
                operationStatusLabel.Text = "Restocked quantity cannot be empty.";
            }
            else if (!int.TryParse(qtyRestockedTextBox.Text, out int qtyRestocked)
                            || qtyRestocked <= 0)
            {
                operationStatusLabel.Text = "Restocked quantity must be whole number > 0";
            }
            else if (GroceryList.Count > 0) //checks if there is any data
            {
                //process valid data
                Grocery groceryItem = new Grocery(GroceryList[lbIndex - 1].ItemCode, GroceryList[lbIndex - 1].ItemName, GroceryList[lbIndex - 1].UnitPrice,
                GroceryList[lbIndex - 1].QtyMinForRestock, GroceryList[lbIndex - 1].InitialQty, GroceryList[lbIndex - 1].QtySold, qtyRestocked);
                GroceryList[lbIndex - 1] = groceryItem; //updating the data
                groceryListBox.Items[lbIndex] = GroceryList[lbIndex - 1]; //updating the listbox with the new data
                //updating the status label
                operationStatusLabel.Text = "Incremented Restocked Qty for the item with Item Code " + GroceryList[lbIndex - 1].ItemCode;
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int lbIndex = groceryListBox.SelectedIndex;
            if (lbIndex <= 0)
            {
                operationStatusLabel.Text = "Please select a grocery item to delete.";
            }
            else if (GroceryList.Count > 0)
            {
                //update status label - user name of deleted user
                operationStatusLabel.Text = "Deleted item with Item Code " + GroceryList[lbIndex - 1].ItemCode; ;

                //delete data from list of grocery item objects
                GroceryList.RemoveAt(lbIndex - 1);

                //delete entry in listbox
                groceryListBox.Items.RemoveAt(lbIndex);

                ClearQuantityTextBox();
                
            }
        }

        //sort method using OrderByDescending
        private void sortItemButton_Click(object sender, EventArgs e)
        {
            List<Grocery> SortedList; //create a new list named SortedList that contains Grocery objects
            SortedList = GroceryList.OrderByDescending(item => item.TotalSales).ToList(); //ordered by sales then by name
            GroceryList = SortedList; 
            LoadAllGroceryToListBox();
        }

        private void saveDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter myOutputStream =
                                new StreamWriter("updatedgrocery.csv"))
                {
                    string headerLine = "ItemCode,ItemName,UnitPrice,QtyMinForRestock,InitialQty,QtySold,QtyRestocked";
                    myOutputStream.WriteLine(headerLine);
                    foreach (Grocery item in GroceryList)
                    {
                        string itemLine = item.ItemCode + ","+ item.ItemName + ","
                                        + item.UnitPrice.ToString("C") + "," + item.QtyMinForRestock
                                        + ","+ item.InitialQty + "," + item.QtySold + "," + item.QtyRestocked;
                  
                        myOutputStream.WriteLine(itemLine);
                    }
                }
                operationStatusLabel.Text = "Saved "+ GroceryList.Count + " records into the output inventory file";
                //this assignment does not require to clear everything after saved
                //GroceryList.Clear();
                //groceryListBox.Items.Clear();
                //ClearQuantityTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveSalesReportButton_Click(object sender, EventArgs e)
        {
            List<Grocery> SortedList
                = GroceryList.OrderBy(item => item.TotalSales).ToList();


            SortedList = (from item in GroceryList
                          orderby item.ItemName
                          where item.QtySold > 0
                          select item).ToList();

            try
            {
                using (StreamWriter myOutputStream =
                                new StreamWriter("grocerysales.csv"))
                {
                    string headerLine = "ItemCode,ItemName,UnitPrice,QtySold,Total Sales";
                    myOutputStream.WriteLine(headerLine);
                    foreach (Grocery item in SortedList) //note here we SortedList instead of GroceryList because we don't want the 
                                                         //data in the list box to be affected. GroceryList=SortedList will be bad design here as the user will not be able to go back with other functions once the list is updated.
                                                         //I discovered this while testing the application 
                    {
                        string itemLine = item.ItemCode + "," + item.ItemName + ","
                                        + item.UnitPrice + "," + item.QtySold + "," + item.TotalSales.ToString("C");

                        myOutputStream.WriteLine(itemLine);
                    }
                }
                operationStatusLabel.Text = "Saved " + SortedList.Count + " records into the output sales file";
                //GroceryList.Clear();
                //groceryListBox.Items.Clear();
                //ClearQuantityTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveRestockNeedsButton_Click(object sender, EventArgs e)
        {
            List<Grocery> SortedList
                = GroceryList.OrderBy(item => item.TotalSales).ToList();

            //use a LINQ query to find those items that have AvailableQty lesser than
            //QtyMinForRestock from the list
            SortedList = (from item in GroceryList
                          //orderby item.ItemName
                          where item.AvailableQty < item.QtyMinForRestock
                          select item).ToList();

            try
            {
                using (StreamWriter myOutputStream =
                                new StreamWriter("groceryrestocks.csv"))
                {
                    string headerLine = "ItemCode,ItemName,AvailableQty,QtyMinForRestock";
                    myOutputStream.WriteLine(headerLine);
                    foreach (Grocery item in SortedList) //We use SortedList because we want to keep GroceryList intact.
                                                         //GroceryList=SortedList will be bad design here as the user will not be able to go back with other functions once the list is updated.
                    {
                        string itemLine = item.ItemCode + "," + item.ItemName + ","
                                        + item.AvailableQty + "," + item.QtyMinForRestock;

                        myOutputStream.WriteLine(itemLine);
                    }
                }
                operationStatusLabel.Text = "Saved " + SortedList.Count + " records into the restocks needed output file";
                //GroceryList.Clear();
                //groceryListBox.Items.Clear();
                //ClearQuantityTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
