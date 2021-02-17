namespace VendingMachine.cs
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Btn_AdMoney = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cb_AdMoney = new System.Windows.Forms.ComboBox();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Cb_items = new System.Windows.Forms.ComboBox();
            this.Txt_qty = new System.Windows.Forms.TextBox();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Details_Grid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.Btn_PlaceOrder = new System.Windows.Forms.Button();
            this.Txt_No = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Details_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AdMoney
            // 
            this.Btn_AdMoney.Location = new System.Drawing.Point(241, 29);
            this.Btn_AdMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_AdMoney.Name = "Btn_AdMoney";
            this.Btn_AdMoney.Size = new System.Drawing.Size(87, 28);
            this.Btn_AdMoney.TabIndex = 0;
            this.Btn_AdMoney.Text = "Add Money";
            this.Btn_AdMoney.UseVisualStyleBackColor = true;
            this.Btn_AdMoney.Click += new System.EventHandler(this.Btn_AdMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Bal :";
            // 
            // Cb_AdMoney
            // 
            this.Cb_AdMoney.FormattingEnabled = true;
            this.Cb_AdMoney.Items.AddRange(new object[] {
            "0.10",
            "0.20",
            "0.25"});
            this.Cb_AdMoney.Location = new System.Drawing.Point(344, 29);
            this.Cb_AdMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cb_AdMoney.Name = "Cb_AdMoney";
            this.Cb_AdMoney.Size = new System.Drawing.Size(140, 24);
            this.Cb_AdMoney.TabIndex = 2;
            this.Cb_AdMoney.Visible = false;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(498, 29);
            this.Btn_Ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(87, 28);
            this.Btn_Ok.TabIndex = 3;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Visible = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_add
            // 
            this.Btn_add.Location = new System.Drawing.Point(585, 3);
            this.Btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(61, 28);
            this.Btn_add.TabIndex = 6;
            this.Btn_add.Text = "Add";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Cb_items
            // 
            this.Cb_items.FormattingEnabled = true;
            this.Cb_items.Items.AddRange(new object[] {
            "candy",
            "chips",
            "cola"});
            this.Cb_items.Location = new System.Drawing.Point(3, 6);
            this.Cb_items.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cb_items.Name = "Cb_items";
            this.Cb_items.Size = new System.Drawing.Size(140, 24);
            this.Cb_items.TabIndex = 5;
            this.Cb_items.SelectedIndexChanged += new System.EventHandler(this.Cb_items_SelectedIndexChanged);
            // 
            // Txt_qty
            // 
            this.Txt_qty.Location = new System.Drawing.Point(315, 3);
            this.Txt_qty.Name = "Txt_qty";
            this.Txt_qty.Size = new System.Drawing.Size(73, 22);
            this.Txt_qty.TabIndex = 7;
            this.Txt_qty.TextChanged += new System.EventHandler(this.Txt_qty_TextChanged);
            // 
            // Txt_Price
            // 
            this.Txt_Price.Location = new System.Drawing.Point(198, 3);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.ReadOnly = true;
            this.Txt_Price.Size = new System.Drawing.Size(54, 22);
            this.Txt_Price.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Qty :";
            // 
            // Txt_amount
            // 
            this.Txt_amount.Location = new System.Drawing.Point(469, 3);
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.Size = new System.Drawing.Size(84, 22);
            this.Txt_amount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount :";
            // 
            // Details_Grid
            // 
            this.Details_Grid.AllowUserToAddRows = false;
            this.Details_Grid.BackgroundColor = System.Drawing.Color.White;
            this.Details_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Details_Grid.Location = new System.Drawing.Point(3, 38);
            this.Details_Grid.Name = "Details_Grid";
            this.Details_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Details_Grid.Size = new System.Drawing.Size(643, 169);
            this.Details_Grid.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amount :";
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(377, 222);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(84, 22);
            this.Txt_total.TabIndex = 14;
            // 
            // Btn_PlaceOrder
            // 
            this.Btn_PlaceOrder.Location = new System.Drawing.Point(469, 216);
            this.Btn_PlaceOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_PlaceOrder.Name = "Btn_PlaceOrder";
            this.Btn_PlaceOrder.Size = new System.Drawing.Size(94, 28);
            this.Btn_PlaceOrder.TabIndex = 16;
            this.Btn_PlaceOrder.Text = "Buy";
            this.Btn_PlaceOrder.UseVisualStyleBackColor = true;
            this.Btn_PlaceOrder.Click += new System.EventHandler(this.Btn_PlaceOrder_Click);
            // 
            // Txt_No
            // 
            this.Txt_No.Location = new System.Drawing.Point(135, 76);
            this.Txt_No.Name = "Txt_No";
            this.Txt_No.Size = new System.Drawing.Size(99, 22);
            this.Txt_No.TabIndex = 17;
            this.Txt_No.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Transaction No :";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "THANK YOU";
            this.label8.Visible = false;
            // 
            // Btn_Order
            // 
            this.Btn_Order.Location = new System.Drawing.Point(591, 29);
            this.Btn_Order.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Size = new System.Drawing.Size(87, 28);
            this.Btn_Order.TabIndex = 21;
            this.Btn_Order.Text = "Order";
            this.Btn_Order.UseVisualStyleBackColor = true;
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Details_Grid);
            this.panel1.Controls.Add(this.Txt_qty);
            this.panel1.Controls.Add(this.Txt_Price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Btn_add);
            this.panel1.Controls.Add(this.Btn_PlaceOrder);
            this.panel1.Controls.Add(this.Cb_items);
            this.panel1.Controls.Add(this.Txt_amount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_total);
            this.panel1.Location = new System.Drawing.Point(29, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 254);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Order);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_No);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Cb_AdMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_AdMoney);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Details_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AdMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_AdMoney;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.ComboBox Cb_items;
        private System.Windows.Forms.TextBox Txt_qty;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Details_Grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Button Btn_PlaceOrder;
        private System.Windows.Forms.TextBox Txt_No;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.Panel panel1;
    }
}

