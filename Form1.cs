using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoSalesDataSheetGeneratorCsharp
{
    public partial class AutoSalesGeneratorForm : Form
    {
        public AutoSalesGeneratorForm()
        {
            InitializeComponent();
        }

        public static string filePath;

        private void PrimaryActionButton_Click(object sender, EventArgs e)
        {
            Random entropy = new Random();
            
            if(filePath != null)
            {
                string[] customerArray = {"Qualcomm","Samsung","Elpida","ZTE","Hauwei","Nokia","Apple"};
                double[] hiPrices = {8.88,12,10,9.25,9.5,9.75,5};
                double[] loPrices = {5.85,8.5,6.25,6.5,8.5,4.9,4.95};
                int[] maxQTY = {25000,8500,4500,8000,7500,15000,20000};
                int[] minQTY = {20000,1000,2500,8000,5000,10000,1000};

            

                int recordsToCreateCount = 1000;

                using(StreamWriter theWriter = new StreamWriter(filePath))
                {
                    for(int i = 0; i < recordsToCreateCount; i++)
                    {

                        int manufacturerINDEX = entropy.Next(0,customerArray.Length);
                        string customer = customerArray[manufacturerINDEX];
                        string qty = entropy.Next(minQTY[manufacturerINDEX],maxQTY[manufacturerINDEX]).ToString();
                        string price = entropy.Next((int)loPrices[manufacturerINDEX],(int)hiPrices[manufacturerINDEX]).ToString();
                        string chipType;
                        double coinFlipForChip = entropy.NextDouble();
                        if(coinFlipForChip >= 0.7)
                        {                       
                            chipType = "BitShareA";                           
                        }
                        else
                        {
                            price = (Convert.ToInt32(price) + 1).ToString();
                            chipType = "BitShareB";
                        }

                        theWriter.WriteLine(customer + "," + chipType + "," + qty + "," + price);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a File Name");
            }
        }

        private void UIfilenameBOX_TextChanged(object sender, EventArgs e)
        {
            filePath = UIfilenameBOX.Text + ".csv";
        }
    }
}
