namespace GloceryShopDemo
{
    partial class ShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvMenu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gvShopping = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbShoppingCardSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefreshShopping = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCashBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvShopping)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 233);
            this.panel1.TabIndex = 0;
            // 
            // gvMenu
            // 
            this.gvMenu.AllowUserToAddRows = false;
            this.gvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMenu.Location = new System.Drawing.Point(0, 62);
            this.gvMenu.Name = "gvMenu";
            this.gvMenu.RowHeadersWidth = 62;
            this.gvMenu.RowTemplate.Height = 28;
            this.gvMenu.Size = new System.Drawing.Size(800, 171);
            this.gvMenu.TabIndex = 0;
            this.gvMenu.DoubleClick += new System.EventHandler(this.gvMenu_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gvShopping);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 179);
            this.panel3.TabIndex = 1;
            // 
            // gvShopping
            // 
            this.gvShopping.AllowUserToAddRows = false;
            this.gvShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShopping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvShopping.Location = new System.Drawing.Point(0, 71);
            this.gvShopping.Name = "gvShopping";
            this.gvShopping.RowHeadersWidth = 62;
            this.gvShopping.RowTemplate.Height = 28;
            this.gvShopping.Size = new System.Drawing.Size(800, 108);
            this.gvShopping.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnComplete);
            this.panel4.Controls.Add(this.btnRefreshShopping);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.tbShoppingCardSum);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 71);
            this.panel4.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "complete sum";
            // 
            // tbShoppingCardSum
            // 
            this.tbShoppingCardSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShoppingCardSum.Location = new System.Drawing.Point(439, 13);
            this.tbShoppingCardSum.Name = "tbShoppingCardSum";
            this.tbShoppingCardSum.Size = new System.Drawing.Size(100, 35);
            this.tbShoppingCardSum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "basket";
            // 
            // btnRefreshShopping
            // 
            this.btnRefreshShopping.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshShopping.BackgroundImage")));
            this.btnRefreshShopping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshShopping.Location = new System.Drawing.Point(560, 6);
            this.btnRefreshShopping.Name = "btnRefreshShopping";
            this.btnRefreshShopping.Size = new System.Drawing.Size(61, 59);
            this.btnRefreshShopping.TabIndex = 4;
            this.btnRefreshShopping.UseVisualStyleBackColor = true;
            this.btnRefreshShopping.Click += new System.EventHandler(this.btnRefreshShopping_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComplete.BackgroundImage")));
            this.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComplete.Location = new System.Drawing.Point(697, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(65, 59);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(627, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 59);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "cash register";
            // 
            // tbCashBox
            // 
            this.tbCashBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashBox.Location = new System.Drawing.Point(491, 421);
            this.tbCashBox.Name = "tbCashBox";
            this.tbCashBox.Size = new System.Drawing.Size(100, 35);
            this.tbCashBox.TabIndex = 4;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCashBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvShopping)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gvShopping;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbShoppingCardSum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCashBox;
        private System.Windows.Forms.Button btnRefreshShopping;
    }
}

