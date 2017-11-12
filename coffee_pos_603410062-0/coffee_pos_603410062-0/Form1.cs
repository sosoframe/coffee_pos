using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410062_0
{
    public partial class Form1 : Form
    {
        int F = 0, P = 1;
        double Totel;
        string[] Menu = new string[50];
        string[] RaCar = new string[50];
        string Pi;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BT_Cl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            Totel += 35;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Esspresso Hot";
            RaCar[F] = "35";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            Totel += 45;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Esspresso Ice";
            RaCar[F] = "45";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            Totel += 50;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Esspresso Frappe";
            RaCar[F] = "50";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            Totel += 35;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Americano Hot";
            RaCar[F] = "35";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            Totel += 45;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Americano Ice";
            RaCar[F] = "45";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            Totel += 35;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Latte Hot";
            RaCar[F] = "35";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            Totel += 45;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Latte Ice";
            RaCar[F] = "45";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            Totel += 50;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Latte Frappe";
            RaCar[F] = "50";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            Totel += 35;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Mocha Hot";
            RaCar[F] = "35";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT10_Click(object sender, EventArgs e)
        {
            Totel += 45;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Mocha Ice";
            RaCar[F] = "45";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT11_Click(object sender, EventArgs e)
        {
            Totel += 50;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Mocha Frappe";
            RaCar[F] = "50";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT12_Click(object sender, EventArgs e)
        {
            Totel += 35;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Cappuccino Hot";
            RaCar[F] = "35";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT13_Click(object sender, EventArgs e)
        {
            Totel += 45;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Cappuccino Ice";
            RaCar[F] = "45";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT14_Click(object sender, EventArgs e)
        {
            Totel += 50;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Cappuccino Frappe";
            RaCar[F] = "50";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT15_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "GreenTea Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT16_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "GreenTea Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT17_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "GreenTea Hot";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT18_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "ThaiTea Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT19_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "ThaiTea Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT20_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "ThaiTea Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT21_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "CoCoa Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT22_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "CoCoa Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT23_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "CoCoa Hot";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT24_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milk Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT25_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milk Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT26_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milk Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT27_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "MilkTea Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT28_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "MilkTea Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT29_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "LemonTea Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT30_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "LemonTea Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT31_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milo Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT32_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milo Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT33_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Milo Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT34_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Nescafe Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT35_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Nescafe Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT36_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Nescafe Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT37_Click(object sender, EventArgs e)
        {
            Totel += 20;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "NesteaTea Hot";
            RaCar[F] = "20";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT38_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "NesteaTea Ice";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT39_Click(object sender, EventArgs e)
        {
            Totel += 30;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "NesteaTea Frappe";
            RaCar[F] = "30";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT40_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Strawbery Soda";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT41_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Apple Soda";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT42_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "BlueHawaii";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT43_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Red lime Soda";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT44_Click(object sender, EventArgs e)
        {
            Totel += 25;
            TB1.Text = Totel.ToString() + ".00 บาท";
            Menu[F] = "Honey lime Soda";
            RaCar[F] = "25";
            Pi += Menu[F] + " " + RaCar[F] + Environment.NewLine;
            Gift();
        }

        private void BT_C_Click(object sender, EventArgs e)
        {
            F = 0;
            TB1.Text = "";
            Totel = 0;
            LV1.Items.Clear();
        }

        private void BT_A_Click(object sender, EventArgs e)
        {
            if (TB1.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเมนูก่อนทำรายการ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("ยืนยันการทำรายการ", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            F = 0;
            TB1.Text = "";
            LV1.Items.Clear();
            Totel = 0;
            File.WriteAllText("list" + (P) + ".txt", Pi);
            P++;
        }

        public void Gift()
        {
            ListViewItem Frame = new ListViewItem();
            Frame.Text = Menu[F];
            Frame.SubItems.Add(RaCar[F]);
            LV1.Items.Add(Frame);
        }
    }
}
