using System.Data.SQLite;
using System.Drawing;
using System.Xml.Linq;

namespace FurnitureCompany
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            catalogueTreeView = new TreeView();
            label1 = new Label();
            panel1 = new Panel();
            buttonManufacture = new Button();
            labelPrice = new Label();
            buttonBuy = new Button();
            labelDesc = new Label();
            labelName = new Label();
            pictureBox = new PictureBox();
            buttonAddCategory = new Button();
            buttonAddProduct = new Button();
            buttonOrders = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // catalogueTreeView
            // 
            catalogueTreeView.Location = new Point(15, 51);
            catalogueTreeView.Name = "catalogueTreeView";
            catalogueTreeView.Size = new Size(350, 555);
            catalogueTreeView.TabIndex = 0;
            catalogueTreeView.AfterSelect += catalogueTreeView_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 36);
            label1.TabIndex = 1;
            label1.Text = "Каталог";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonManufacture);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(buttonBuy);
            panel1.Controls.Add(labelDesc);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(368, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 555);
            panel1.TabIndex = 2;
            // 
            // buttonManufacture
            // 
            buttonManufacture.Location = new Point(3, 466);
            buttonManufacture.Name = "buttonManufacture";
            buttonManufacture.Size = new Size(94, 29);
            buttonManufacture.TabIndex = 7;
            buttonManufacture.Text = "Виробник";
            buttonManufacture.UseVisualStyleBackColor = true;
            buttonManufacture.Click += buttonManufacture_Click;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(211, 430);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(188, 68);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "300";
            labelPrice.TextAlign = ContentAlignment.BottomRight;
            // 
            // buttonBuy
            // 
            buttonBuy.BackColor = Color.PaleGreen;
            buttonBuy.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBuy.ForeColor = SystemColors.ControlText;
            buttonBuy.Location = new Point(3, 501);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(396, 44);
            buttonBuy.TabIndex = 5;
            buttonBuy.Text = "КУПИТИ";
            buttonBuy.UseVisualStyleBackColor = false;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // labelDesc
            // 
            labelDesc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesc.Location = new Point(3, 343);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(392, 120);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "Опис";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(3, 305);
            labelName.Name = "labelName";
            labelName.Size = new Size(104, 38);
            labelName.TabIndex = 1;
            labelName.Text = "Назва ";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.noimage;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(396, 299);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(140, 12);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(225, 36);
            buttonAddCategory.TabIndex = 3;
            buttonAddCategory.Text = "Додати категорію";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(30, 564);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(322, 32);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Додати товар";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.Location = new Point(651, 12);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(119, 36);
            buttonOrders.TabIndex = 5;
            buttonOrders.Text = "Корзина";
            buttonOrders.UseVisualStyleBackColor = true;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 616);
            Controls.Add(buttonOrders);
            Controls.Add(buttonAddProduct);
            Controls.Add(buttonAddCategory);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(catalogueTreeView);
            Name = "Form1";
            Text = "Меблі";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView catalogueTreeView;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox;
        private Label labelName;
        private Label labelDesc;
        private Label labelPrice;
        private Button buttonBuy;
        private Button buttonManufacture;
        private Button buttonAddCategory;
        private Button buttonAddProduct;
        private Button buttonOrders;
    }
}