namespace Cafe_Pos
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
            this.Top_panel = new System.Windows.Forms.Panel();
            this.ChooseTable_but = new System.Windows.Forms.Button();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.Nav_panel = new System.Windows.Forms.Panel();
            this.Materials_but = new System.Windows.Forms.Button();
            this.KitchenStok_but = new System.Windows.Forms.Button();
            this.stock1 = new Cafe_Pos.Stock();
            this.kitchen_Stock1 = new Cafe_Pos.Kitchen_Stock();
            this.KitchenStock_but = new Cafe_Pos.Stock();
            this.suppier1 = new Cafe_Pos.Suppier();
            this.material1 = new Cafe_Pos.Material();
            this.Stock_but = new System.Windows.Forms.Button();
            this.Reports_but = new System.Windows.Forms.Button();
            this.Order_but = new System.Windows.Forms.Button();
            this.Cashier_but = new System.Windows.Forms.Button();
            this.Tables_but = new System.Windows.Forms.Button();
            this.Customer_but = new System.Windows.Forms.Button();
            this.Sup_but = new System.Windows.Forms.Button();
            this.Home_but = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            this.Top_panel.SuspendLayout();
            this.Nav_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Top_panel.Controls.Add(this.ChooseTable_but);
            this.Top_panel.Controls.Add(this.button5);
            this.Top_panel.Controls.Add(this.search_but);
            this.Top_panel.Controls.Add(this.search_txtbox);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1902, 100);
            this.Top_panel.TabIndex = 1;
            // 
            // ChooseTable_but
            // 
            this.ChooseTable_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.ChooseTable_but.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChooseTable_but.FlatAppearance.BorderSize = 0;
            this.ChooseTable_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.ChooseTable_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.ChooseTable_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTable_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTable_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChooseTable_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChooseTable_but.Location = new System.Drawing.Point(1420, 45);
            this.ChooseTable_but.Name = "ChooseTable_but";
            this.ChooseTable_but.Size = new System.Drawing.Size(252, 49);
            this.ChooseTable_but.TabIndex = 18;
            this.ChooseTable_but.Text = "Select Table";
            this.ChooseTable_but.UseVisualStyleBackColor = false;
            // 
            // search_txtbox
            // 
            this.search_txtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.search_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txtbox.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txtbox.Location = new System.Drawing.Point(200, 45);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(406, 49);
            this.search_txtbox.TabIndex = 0;
            // 
            // Nav_panel
            // 
            this.Nav_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nav_panel.Controls.Add(this.Materials_but);
            this.Nav_panel.Controls.Add(this.KitchenStok_but);
            this.Nav_panel.Controls.Add(this.Stock_but);
            this.Nav_panel.Controls.Add(this.Reports_but);
            this.Nav_panel.Controls.Add(this.Order_but);
            this.Nav_panel.Controls.Add(this.Cashier_but);
            this.Nav_panel.Controls.Add(this.Tables_but);
            this.Nav_panel.Controls.Add(this.Customer_but);
            this.Nav_panel.Controls.Add(this.Sup_but);
            this.Nav_panel.Controls.Add(this.Home_but);
            this.Nav_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav_panel.Location = new System.Drawing.Point(0, 100);
            this.Nav_panel.Name = "Nav_panel";
            this.Nav_panel.Size = new System.Drawing.Size(200, 933);
            this.Nav_panel.TabIndex = 2;
            // 
            // Materials_but
            // 
            this.Materials_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Materials_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Materials_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Materials_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materials_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Materials_but.Location = new System.Drawing.Point(28, 554);
            this.Materials_but.Name = "Materials_but";
            this.Materials_but.Size = new System.Drawing.Size(136, 86);
            this.Materials_but.TabIndex = 11;
            this.Materials_but.Text = "Materials";
            this.Materials_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Materials_but.UseVisualStyleBackColor = false;
            // 
            // KitchenStok_but
            // 
            this.KitchenStok_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KitchenStok_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.KitchenStok_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KitchenStok_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KitchenStok_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.KitchenStok_but.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KitchenStok_but.Location = new System.Drawing.Point(96, 452);
            this.KitchenStok_but.Name = "KitchenStok_but";
            this.KitchenStok_but.Size = new System.Drawing.Size(95, 96);
            this.KitchenStok_but.TabIndex = 10;
            this.KitchenStok_but.Text = "Kithcen Stock";
            this.KitchenStok_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KitchenStok_but.UseVisualStyleBackColor = false;
            this.KitchenStok_but.Click += new System.EventHandler(this.KitchenStok_but_Click);
            // 
            // stock1
            // 
            this.stock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.stock1.Location = new System.Drawing.Point(197, 101);
            this.stock1.Name = "stock1";
            this.stock1.Size = new System.Drawing.Size(1702, 933);
            this.stock1.TabIndex = 21;
            // 
            // kitchen_Stock1
            // 
            this.kitchen_Stock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.kitchen_Stock1.Location = new System.Drawing.Point(197, 100);
            this.kitchen_Stock1.Name = "kitchen_Stock1";
            this.kitchen_Stock1.Size = new System.Drawing.Size(1702, 933);
            this.kitchen_Stock1.TabIndex = 20;
            // 
            // KitchenStock_but
            // 
            this.KitchenStock_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.KitchenStock_but.Location = new System.Drawing.Point(197, 100);
            this.KitchenStock_but.Name = "KitchenStock_but";
            this.KitchenStock_but.Size = new System.Drawing.Size(1705, 933);
            this.KitchenStock_but.TabIndex = 19;
            // 
            // suppier1
            // 
            this.suppier1.BackColor = System.Drawing.Color.White;
            this.suppier1.Location = new System.Drawing.Point(200, 100);
            this.suppier1.Name = "suppier1";
            this.suppier1.Size = new System.Drawing.Size(1702, 933);
            this.suppier1.TabIndex = 3;
            // 
            // material1
            // 
            this.material1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.material1.Location = new System.Drawing.Point(197, 101);
            this.material1.Name = "material1";
            this.material1.Size = new System.Drawing.Size(1702, 933);
            this.material1.TabIndex = 22;
            // 
            // Stock_but
            // 
            this.Stock_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Stock_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Stock_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stock_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Stock_but.Image = global::Cafe_Pos.Properties.Resources.warehouse__3_;
            this.Stock_but.Location = new System.Drawing.Point(12, 435);
            this.Stock_but.Name = "Stock_but";
            this.Stock_but.Size = new System.Drawing.Size(78, 113);
            this.Stock_but.TabIndex = 8;
            this.Stock_but.Text = "Stock";
            this.Stock_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Stock_but.UseVisualStyleBackColor = false;
            this.Stock_but.Click += new System.EventHandler(this.Stock_but_Click);
            // 
            // Reports_but
            // 
            this.Reports_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Reports_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Reports_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Reports_but.Image = global::Cafe_Pos.Properties.Resources.pie_chart_2_;
            this.Reports_but.Location = new System.Drawing.Point(28, 813);
            this.Reports_but.Name = "Reports_but";
            this.Reports_but.Size = new System.Drawing.Size(136, 108);
            this.Reports_but.TabIndex = 7;
            this.Reports_but.Text = "Reports";
            this.Reports_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reports_but.UseVisualStyleBackColor = false;
            // 
            // Order_but
            // 
            this.Order_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Order_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Order_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Order_but.Image = global::Cafe_Pos.Properties.Resources.shopping_bag__2_;
            this.Order_but.Location = new System.Drawing.Point(28, 703);
            this.Order_but.Name = "Order_but";
            this.Order_but.Size = new System.Drawing.Size(136, 108);
            this.Order_but.TabIndex = 5;
            this.Order_but.Text = "Order";
            this.Order_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Order_but.UseVisualStyleBackColor = false;
            // 
            // Cashier_but
            // 
            this.Cashier_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cashier_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Cashier_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cashier_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cashier_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Cashier_but.Image = global::Cafe_Pos.Properties.Resources.dollar;
            this.Cashier_but.Location = new System.Drawing.Point(28, 646);
            this.Cashier_but.Name = "Cashier_but";
            this.Cashier_but.Size = new System.Drawing.Size(136, 108);
            this.Cashier_but.TabIndex = 4;
            this.Cashier_but.Text = "Casheir";
            this.Cashier_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cashier_but.UseVisualStyleBackColor = false;
            // 
            // Tables_but
            // 
            this.Tables_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Tables_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Tables_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tables_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Tables_but.Image = global::Cafe_Pos.Properties.Resources.table__1_;
            this.Tables_but.Location = new System.Drawing.Point(28, 311);
            this.Tables_but.Name = "Tables_but";
            this.Tables_but.Size = new System.Drawing.Size(136, 108);
            this.Tables_but.TabIndex = 3;
            this.Tables_but.Text = "Tables";
            this.Tables_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Tables_but.UseVisualStyleBackColor = false;
            // 
            // Customer_but
            // 
            this.Customer_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Customer_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Customer_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Customer_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Customer_but.Image = global::Cafe_Pos.Properties.Resources.user;
            this.Customer_but.Location = new System.Drawing.Point(28, 207);
            this.Customer_but.Name = "Customer_but";
            this.Customer_but.Size = new System.Drawing.Size(136, 86);
            this.Customer_but.TabIndex = 2;
            this.Customer_but.Text = "Customer";
            this.Customer_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customer_but.UseVisualStyleBackColor = false;
            // 
            // Sup_but
            // 
            this.Sup_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sup_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Sup_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sup_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Sup_but.Image = global::Cafe_Pos.Properties.Resources.supplier;
            this.Sup_but.Location = new System.Drawing.Point(9, 97);
            this.Sup_but.Name = "Sup_but";
            this.Sup_but.Size = new System.Drawing.Size(182, 87);
            this.Sup_but.TabIndex = 1;
            this.Sup_but.Text = "Supplier";
            this.Sup_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sup_but.UseVisualStyleBackColor = false;
            this.Sup_but.Click += new System.EventHandler(this.Sup_but_Click_1);
            // 
            // Home_but
            // 
            this.Home_but.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Home_but.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Home_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_but.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Home_but.Image = global::Cafe_Pos.Properties.Resources.home__1_;
            this.Home_but.Location = new System.Drawing.Point(28, 6);
            this.Home_but.Name = "Home_but";
            this.Home_but.Size = new System.Drawing.Size(136, 85);
            this.Home_but.TabIndex = 0;
            this.Home_but.Text = "Home";
            this.Home_but.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Home_but.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.button5.Image = global::Cafe_Pos.Properties.Resources.setting;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(1786, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 94);
            this.button5.TabIndex = 6;
            this.button5.Text = "Settings";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // search_but
            // 
            this.search_but.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search_but.FlatAppearance.BorderSize = 0;
            this.search_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.search_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.search_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_but.Image = global::Cafe_Pos.Properties.Resources.search;
            this.search_but.Location = new System.Drawing.Point(612, 56);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(37, 38);
            this.search_but.TabIndex = 1;
            this.search_but.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.material1);
            this.Controls.Add(this.stock1);
            this.Controls.Add(this.kitchen_Stock1);
            this.Controls.Add(this.KitchenStock_but);
            this.Controls.Add(this.suppier1);
            this.Controls.Add(this.Nav_panel);
            this.Controls.Add(this.Top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.Nav_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button search_but;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Panel Nav_panel;
        private System.Windows.Forms.Button Home_but;
        private Suppier suppier1;
        private System.Windows.Forms.Button Tables_but;
        private System.Windows.Forms.Button Customer_but;
        private System.Windows.Forms.Button Sup_but;
        private System.Windows.Forms.Button Reports_but;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Order_but;
        private System.Windows.Forms.Button Cashier_but;
        private System.Windows.Forms.Button ChooseTable_but;
        private System.Windows.Forms.Button Stock_but;
        private Stock KitchenStock_but;
        private Kitchen_Stock kitchen_Stock1;
        private System.Windows.Forms.Button KitchenStok_but;
        private Stock stock1;
        private System.Windows.Forms.Button Materials_but;
        private Material material1;
    }
}

