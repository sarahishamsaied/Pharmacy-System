using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class PrintReceipt : Form
    {

        public PrintReceipt(string id,string buyerName)
        {
            InitializeComponent();
            Product p = Dashboard.AllProducts.Find(item => item.ProductCode == id);
            receiptFormat(p, buyerName);
        }
        public void receiptFormat(Product product,string buyerName)
        {
            ReceiptResult.SelectAll();
            ReceiptResult.SelectionAlignment = HorizontalAlignment.Center;
            Receipt r = new Receipt(buyerName,product.ProductCode,DateTime.Now.ToShortDateString(),product.ProductCode,product.ProductName,product.Price);
            ReceiptResult.Text = r.ToString();
        }

        private void printReceiptButton(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(ReceiptResult.Text,new Font("Microsoft Sans Serif",16),Brushes.Black,ClientRectangle,sf);
        }
    }
}
