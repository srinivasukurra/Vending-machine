using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace VendingMachine.cs
{
    public partial class Home : Form
    {
        customefunctions cfs = new customefunctions();
        public Home()
        {
            InitializeComponent();
        }

        private void Btn_AdMoney_Click(object sender, EventArgs e)
        {
            Cb_AdMoney.Visible = true;
            Btn_Ok.Visible = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label7.Text = cfs.rs2converter(cfs.ReturnData("SELECT ISNULL(SUM(AMOUNT),0) FROM AmountDetails"));
            Txt_No.Text = (cfs.ReturnData("SELECT ISNULL(TransNo+1,1) FROM TransNos")); 
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (Cb_AdMoney.Text.Trim() != string.Empty)
            {
                string que = "INSERT INTO AmountDetails VALUES('" + cfs.sqlSdate(System.DateTime.Now) + "','" + Cb_AdMoney.Text + "')";
                cfs.ExecuteData(que);
                MessageBox.Show("Money Added to Wallet", "Vending Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Text = cfs.rs2converter(cfs.ReturnData("SELECT ISNULL(SUM(AMOUNT),0) FROM AmountDetails"));                 
            }
            else
            {
                MessageBox.Show("Please Provide the Proper Denomination", "Vending Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Price.Text = cfs.rs2converter(cfs.ReturnData("SELECT PRICE FROM MENU WHERE ITEM = '" + Cb_items.Text + "'"));
        }

        private void Txt_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Txt_amount.Text = cfs.rs2converter((Convert.ToDecimal(Txt_Price.Text) * Convert.ToDecimal(Txt_qty.Text)).ToString());
            }
            catch (Exception ee) { Txt_amount.Text = "0.00"; }
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string que = "INSERT INTO OrderDetails VALUES('" + cfs.sqlSdate(System.DateTime.Now) + "','" + Cb_items.Text + "','" + Txt_qty.Text + "','" + Txt_Price.Text + "','" + Txt_amount.Text + "','" + Txt_No.Text + "')";
            cfs.ExecuteData(que);
            
            try
            {
                string query = "select Item,qty,price,total from OrderDetails where Transno = '" + Txt_No.Text + "'";
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["VendingMachine"].ConnectionString);
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                Details_Grid.DataSource = table;
                Details_Grid.Columns["Total"].DefaultCellStyle.Format = "N2";
            }
            catch (Exception EE) { }
            CellSum();
            Txt_qty.Text = "";
        }

        void CellSum()
        {
            double tot = 0;
            try
            {
                foreach (DataGridViewRow dr in Details_Grid.Rows)
                {
                    tot += Convert.ToDouble(dr.Cells["Total"].Value.ToString()); 
                }
            }
            catch (Exception Ex) { }

            Txt_total.Text = cfs.rs2converter(tot.ToString());
            tot = 0;
        }

        private void Btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(label7.Text) < Convert.ToDouble(Txt_total.Text))
            {
                MessageBox.Show("Please Add Currency to Wallet to Move Further", "Vending Machine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string _que = "INSERT INTO AmountDetails VALUES('" + cfs.sqlSdate(System.DateTime.Now) + "','" + Convert.ToDouble(Txt_total.Text) * -1 + "')";
                cfs.ExecuteData(_que);
                string ique = "UPDATE TransNos SET TransNo = '" + Txt_No.Text + "'";
                cfs.ExecuteData(ique);
                panel1.Visible = false;
                label8.Visible = true;
                label7.Text = cfs.rs2converter(cfs.ReturnData("SELECT ISNULL(SUM(AMOUNT),0) FROM AmountDetails"));
            }
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        //void Get
    }
}
