using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhiC_Assign2
{   //CSIS-1175-003 Nhi Cao 300367933
    internal class Grocery
    {
        //properties
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public double UnitPrice { get; set; }
        public int QtyMinForRestock { get; set; }
        public int InitialQty { get; set; }
        public int QtySold { get; set; }
        public int QtyRestocked { get; set; }

        public int AvailableQty
        {
            get
            {
                int availableQty = 0;
                availableQty = InitialQty - QtySold + QtyRestocked; 
                return availableQty;
            }
        }

        public double TotalSales
        {
            get
            {
                double totalSales = 0;
                totalSales = QtySold * UnitPrice;
                return totalSales;
            }
        }

        //constructor
        public Grocery (string itemCode, string itemName, double unitPrice, 
            int qtyMinForRestock, int initialQty, int qtySold, int qtyRestocked)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice = unitPrice;
            QtyMinForRestock = qtyMinForRestock;
            InitialQty = initialQty;
            QtySold = qtySold;
            QtyRestocked = qtyRestocked;

        }

        //ToString 
        public override string ToString()
        {
                        
            string dataRow = String.Format("{0, -15}{1, -23}{2, -12}" +
                "{3, -18}{4, -12}{5, -10}" +
                "{6, -15}{7, -15}{8, -15}"
               , ItemCode, ItemName, UnitPrice.ToString("C"),
               QtyMinForRestock, InitialQty, QtySold,
               QtyRestocked, AvailableQty, TotalSales.ToString("C"));

            return dataRow;


        }
    }
}
