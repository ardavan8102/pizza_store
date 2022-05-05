namespace Project2
{
    partial class Form1
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
            this.pizzaGroup = new System.Windows.Forms.GroupBox();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.pizzaSmall = new System.Windows.Forms.TextBox();
            this.pizzaMedium = new System.Windows.Forms.TextBox();
            this.pizzaLarge = new System.Windows.Forms.TextBox();
            this.itemBox = new System.Windows.Forms.CheckedListBox();
            this.extraGroup = new System.Windows.Forms.GroupBox();
            this.beforeGroup = new System.Windows.Forms.GroupBox();
            this.fries = new System.Windows.Forms.Label();
            this.sld = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.friesNum = new System.Windows.Forms.TextBox();
            this.saladNum = new System.Windows.Forms.TextBox();
            this.friesMon = new System.Windows.Forms.TextBox();
            this.SaladMon = new System.Windows.Forms.TextBox();
            this.friesTotal = new System.Windows.Forms.TextBox();
            this.saladTotal = new System.Windows.Forms.TextBox();
            this.drinkGroup = new System.Windows.Forms.GroupBox();
            this.water = new System.Windows.Forms.Label();
            this.coca = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.waterNum = new System.Windows.Forms.TextBox();
            this.cocaNum = new System.Windows.Forms.TextBox();
            this.waterMon = new System.Windows.Forms.TextBox();
            this.cocaMon = new System.Windows.Forms.TextBox();
            this.waterTotal = new System.Windows.Forms.TextBox();
            this.cocaTotal = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.totalPriceBtn = new System.Windows.Forms.Button();
            this.sendHome = new System.Windows.Forms.CheckBox();
            this.extraLabel = new System.Windows.Forms.Label();
            this.extraMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pizzaGroup.SuspendLayout();
            this.extraGroup.SuspendLayout();
            this.beforeGroup.SuspendLayout();
            this.drinkGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaGroup
            // 
            this.pizzaGroup.Controls.Add(this.pizzaLarge);
            this.pizzaGroup.Controls.Add(this.pizzaMedium);
            this.pizzaGroup.Controls.Add(this.pizzaSmall);
            this.pizzaGroup.Controls.Add(this.radioMedium);
            this.pizzaGroup.Controls.Add(this.radioLarge);
            this.pizzaGroup.Controls.Add(this.radioSmall);
            this.pizzaGroup.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.pizzaGroup.Location = new System.Drawing.Point(27, 23);
            this.pizzaGroup.Name = "pizzaGroup";
            this.pizzaGroup.Size = new System.Drawing.Size(200, 112);
            this.pizzaGroup.TabIndex = 0;
            this.pizzaGroup.TabStop = false;
            this.pizzaGroup.Text = "Pizza Size";
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSmall.Location = new System.Drawing.Point(7, 23);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(65, 26);
            this.radioSmall.TabIndex = 0;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(7, 76);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(74, 30);
            this.radioLarge.TabIndex = 1;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMedium.Location = new System.Drawing.Point(7, 50);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(85, 26);
            this.radioMedium.TabIndex = 2;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // pizzaSmall
            // 
            this.pizzaSmall.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaSmall.Location = new System.Drawing.Point(94, 18);
            this.pizzaSmall.Name = "pizzaSmall";
            this.pizzaSmall.ReadOnly = true;
            this.pizzaSmall.Size = new System.Drawing.Size(100, 25);
            this.pizzaSmall.TabIndex = 3;
            this.pizzaSmall.Text = "25000";
            // 
            // pizzaMedium
            // 
            this.pizzaMedium.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaMedium.Location = new System.Drawing.Point(94, 49);
            this.pizzaMedium.Name = "pizzaMedium";
            this.pizzaMedium.ReadOnly = true;
            this.pizzaMedium.Size = new System.Drawing.Size(100, 25);
            this.pizzaMedium.TabIndex = 4;
            this.pizzaMedium.Text = "50000";
            // 
            // pizzaLarge
            // 
            this.pizzaLarge.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaLarge.Location = new System.Drawing.Point(94, 81);
            this.pizzaLarge.Name = "pizzaLarge";
            this.pizzaLarge.ReadOnly = true;
            this.pizzaLarge.Size = new System.Drawing.Size(100, 25);
            this.pizzaLarge.TabIndex = 1;
            this.pizzaLarge.Text = "75000";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Items.AddRange(new object[] {
            "+ Extra Peperoni",
            "+ Extra Drink",
            "+ Extra Fries"});
            this.itemBox.Location = new System.Drawing.Point(7, 29);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(187, 79);
            this.itemBox.TabIndex = 1;
            // 
            // extraGroup
            // 
            this.extraGroup.Controls.Add(this.itemBox);
            this.extraGroup.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.extraGroup.Location = new System.Drawing.Point(27, 184);
            this.extraGroup.Name = "extraGroup";
            this.extraGroup.Size = new System.Drawing.Size(200, 115);
            this.extraGroup.TabIndex = 2;
            this.extraGroup.TabStop = false;
            this.extraGroup.Text = "Extra Items";
            // 
            // beforeGroup
            // 
            this.beforeGroup.Controls.Add(this.saladTotal);
            this.beforeGroup.Controls.Add(this.SaladMon);
            this.beforeGroup.Controls.Add(this.friesTotal);
            this.beforeGroup.Controls.Add(this.friesMon);
            this.beforeGroup.Controls.Add(this.saladNum);
            this.beforeGroup.Controls.Add(this.friesNum);
            this.beforeGroup.Controls.Add(this.label5);
            this.beforeGroup.Controls.Add(this.label4);
            this.beforeGroup.Controls.Add(this.label3);
            this.beforeGroup.Controls.Add(this.sld);
            this.beforeGroup.Controls.Add(this.fries);
            this.beforeGroup.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.beforeGroup.Location = new System.Drawing.Point(337, 23);
            this.beforeGroup.Name = "beforeGroup";
            this.beforeGroup.Size = new System.Drawing.Size(438, 140);
            this.beforeGroup.TabIndex = 3;
            this.beforeGroup.TabStop = false;
            this.beforeGroup.Text = "Salad And Fries";
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Font = new System.Drawing.Font("Minion Pro", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fries.Location = new System.Drawing.Point(19, 60);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(109, 24);
            this.fries.TabIndex = 0;
            this.fries.Text = "Fries + Cheese";
            // 
            // sld
            // 
            this.sld.AutoSize = true;
            this.sld.Font = new System.Drawing.Font("Minion Pro", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sld.Location = new System.Drawing.Point(19, 100);
            this.sld.Name = "sld";
            this.sld.Size = new System.Drawing.Size(110, 24);
            this.sld.TabIndex = 1;
            this.sld.Text = "Chicken Salad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // friesNum
            // 
            this.friesNum.Location = new System.Drawing.Point(153, 50);
            this.friesNum.Name = "friesNum";
            this.friesNum.Size = new System.Drawing.Size(27, 30);
            this.friesNum.TabIndex = 5;
            this.friesNum.Text = "0";
            // 
            // saladNum
            // 
            this.saladNum.Location = new System.Drawing.Point(153, 94);
            this.saladNum.Name = "saladNum";
            this.saladNum.Size = new System.Drawing.Size(27, 30);
            this.saladNum.TabIndex = 6;
            this.saladNum.Text = "0";
            // 
            // friesMon
            // 
            this.friesMon.Location = new System.Drawing.Point(196, 49);
            this.friesMon.Name = "friesMon";
            this.friesMon.ReadOnly = true;
            this.friesMon.Size = new System.Drawing.Size(86, 30);
            this.friesMon.TabIndex = 7;
            this.friesMon.Text = "25000";
            // 
            // SaladMon
            // 
            this.SaladMon.Location = new System.Drawing.Point(196, 94);
            this.SaladMon.Name = "SaladMon";
            this.SaladMon.ReadOnly = true;
            this.SaladMon.Size = new System.Drawing.Size(86, 30);
            this.SaladMon.TabIndex = 8;
            this.SaladMon.Text = "15000";
            // 
            // friesTotal
            // 
            this.friesTotal.Location = new System.Drawing.Point(305, 49);
            this.friesTotal.Name = "friesTotal";
            this.friesTotal.Size = new System.Drawing.Size(100, 30);
            this.friesTotal.TabIndex = 4;
            // 
            // saladTotal
            // 
            this.saladTotal.Location = new System.Drawing.Point(305, 94);
            this.saladTotal.Name = "saladTotal";
            this.saladTotal.Size = new System.Drawing.Size(100, 30);
            this.saladTotal.TabIndex = 5;
            // 
            // drinkGroup
            // 
            this.drinkGroup.Controls.Add(this.cocaTotal);
            this.drinkGroup.Controls.Add(this.waterTotal);
            this.drinkGroup.Controls.Add(this.cocaMon);
            this.drinkGroup.Controls.Add(this.waterMon);
            this.drinkGroup.Controls.Add(this.cocaNum);
            this.drinkGroup.Controls.Add(this.waterNum);
            this.drinkGroup.Controls.Add(this.label10);
            this.drinkGroup.Controls.Add(this.label9);
            this.drinkGroup.Controls.Add(this.label8);
            this.drinkGroup.Controls.Add(this.coca);
            this.drinkGroup.Controls.Add(this.water);
            this.drinkGroup.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.drinkGroup.Location = new System.Drawing.Point(337, 184);
            this.drinkGroup.Name = "drinkGroup";
            this.drinkGroup.Size = new System.Drawing.Size(438, 142);
            this.drinkGroup.TabIndex = 4;
            this.drinkGroup.TabStop = false;
            this.drinkGroup.Text = "Cold Drinks";
            // 
            // water
            // 
            this.water.AutoSize = true;
            this.water.Font = new System.Drawing.Font("Minion Pro", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.water.Location = new System.Drawing.Point(18, 64);
            this.water.Name = "water";
            this.water.Size = new System.Drawing.Size(97, 24);
            this.water.TabIndex = 0;
            this.water.Text = "Water Bottle";
            // 
            // coca
            // 
            this.coca.AutoSize = true;
            this.coca.Font = new System.Drawing.Font("Minion Pro", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coca.Location = new System.Drawing.Point(19, 104);
            this.coca.Name = "coca";
            this.coca.Size = new System.Drawing.Size(82, 24);
            this.coca.TabIndex = 1;
            this.coca.Text = "Coca Cola";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Num";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 21);
            this.label9.TabIndex = 3;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Minion Pro", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(333, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total";
            // 
            // waterNum
            // 
            this.waterNum.Location = new System.Drawing.Point(151, 58);
            this.waterNum.Name = "waterNum";
            this.waterNum.Size = new System.Drawing.Size(29, 30);
            this.waterNum.TabIndex = 5;
            this.waterNum.Text = "0";
            // 
            // cocaNum
            // 
            this.cocaNum.Location = new System.Drawing.Point(151, 98);
            this.cocaNum.Name = "cocaNum";
            this.cocaNum.Size = new System.Drawing.Size(29, 30);
            this.cocaNum.TabIndex = 6;
            this.cocaNum.Text = "0";
            // 
            // waterMon
            // 
            this.waterMon.Location = new System.Drawing.Point(196, 58);
            this.waterMon.Name = "waterMon";
            this.waterMon.ReadOnly = true;
            this.waterMon.Size = new System.Drawing.Size(86, 30);
            this.waterMon.TabIndex = 7;
            this.waterMon.Text = "6000";
            // 
            // cocaMon
            // 
            this.cocaMon.Location = new System.Drawing.Point(196, 98);
            this.cocaMon.Name = "cocaMon";
            this.cocaMon.ReadOnly = true;
            this.cocaMon.Size = new System.Drawing.Size(86, 30);
            this.cocaMon.TabIndex = 8;
            this.cocaMon.Text = "8000";
            // 
            // waterTotal
            // 
            this.waterTotal.Location = new System.Drawing.Point(305, 58);
            this.waterTotal.Name = "waterTotal";
            this.waterTotal.Size = new System.Drawing.Size(100, 30);
            this.waterTotal.TabIndex = 9;
            // 
            // cocaTotal
            // 
            this.cocaTotal.Location = new System.Drawing.Point(305, 98);
            this.cocaTotal.Name = "cocaTotal";
            this.cocaTotal.Size = new System.Drawing.Size(100, 30);
            this.cocaTotal.TabIndex = 10;
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.submitBtn.Location = new System.Drawing.Point(621, 378);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(154, 40);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit Order !";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // totalPriceBtn
            // 
            this.totalPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalPriceBtn.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.totalPriceBtn.Location = new System.Drawing.Point(449, 378);
            this.totalPriceBtn.Name = "totalPriceBtn";
            this.totalPriceBtn.Size = new System.Drawing.Size(154, 40);
            this.totalPriceBtn.TabIndex = 6;
            this.totalPriceBtn.Text = "Total Price ?!";
            this.totalPriceBtn.UseVisualStyleBackColor = true;
            this.totalPriceBtn.Click += new System.EventHandler(this.totalPriceBtn_Click);
            // 
            // sendHome
            // 
            this.sendHome.AutoSize = true;
            this.sendHome.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.sendHome.Location = new System.Drawing.Point(34, 354);
            this.sendHome.Name = "sendHome";
            this.sendHome.Size = new System.Drawing.Size(157, 30);
            this.sendHome.TabIndex = 7;
            this.sendHome.Text = "Send To Home ?!";
            this.sendHome.UseVisualStyleBackColor = true;
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.extraLabel.Location = new System.Drawing.Point(34, 319);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(133, 26);
            this.extraLabel.TabIndex = 8;
            this.extraLabel.Text = "Price Per Each :";
            // 
            // extraMon
            // 
            this.extraMon.Font = new System.Drawing.Font("Minion Pro", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraMon.Location = new System.Drawing.Point(173, 318);
            this.extraMon.Name = "extraMon";
            this.extraMon.Size = new System.Drawing.Size(73, 27);
            this.extraMon.TabIndex = 9;
            this.extraMon.Text = "10000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(29, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Price Is :";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minion Pro", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 401);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 33);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extraMon);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.sendHome);
            this.Controls.Add(this.totalPriceBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.drinkGroup);
            this.Controls.Add(this.beforeGroup);
            this.Controls.Add(this.extraGroup);
            this.Controls.Add(this.pizzaGroup);
            this.Name = "Form1";
            this.Text = "Fancy Restaurant";
            this.pizzaGroup.ResumeLayout(false);
            this.pizzaGroup.PerformLayout();
            this.extraGroup.ResumeLayout(false);
            this.beforeGroup.ResumeLayout(false);
            this.beforeGroup.PerformLayout();
            this.drinkGroup.ResumeLayout(false);
            this.drinkGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pizzaGroup;
        private System.Windows.Forms.TextBox pizzaLarge;
        private System.Windows.Forms.TextBox pizzaMedium;
        private System.Windows.Forms.TextBox pizzaSmall;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.CheckedListBox itemBox;
        private System.Windows.Forms.GroupBox extraGroup;
        private System.Windows.Forms.GroupBox beforeGroup;
        private System.Windows.Forms.TextBox saladTotal;
        private System.Windows.Forms.TextBox SaladMon;
        private System.Windows.Forms.TextBox friesTotal;
        private System.Windows.Forms.TextBox friesMon;
        private System.Windows.Forms.TextBox saladNum;
        private System.Windows.Forms.TextBox friesNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sld;
        private System.Windows.Forms.Label fries;
        private System.Windows.Forms.GroupBox drinkGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label coca;
        private System.Windows.Forms.Label water;
        private System.Windows.Forms.TextBox cocaTotal;
        private System.Windows.Forms.TextBox waterTotal;
        private System.Windows.Forms.TextBox cocaMon;
        private System.Windows.Forms.TextBox waterMon;
        private System.Windows.Forms.TextBox cocaNum;
        private System.Windows.Forms.TextBox waterNum;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button totalPriceBtn;
        private System.Windows.Forms.CheckBox sendHome;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.TextBox extraMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

