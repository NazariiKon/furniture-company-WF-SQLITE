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
            labelPrice = new Label();
            buttonBuy = new Button();
            labelDesc = new Label();
            labelName = new Label();
            pictureBox = new PictureBox();
            buttonManufacture = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // catalogueTreeView
            // 
            catalogueTreeView.Location = new Point(12, 48);
            catalogueTreeView.Name = "catalogueTreeView";
            catalogueTreeView.Size = new Size(350, 494);
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
            panel1.Location = new Point(368, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 529);
            panel1.TabIndex = 2;
            // 
            // labelPrice
            // 
            labelPrice.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(207, 411);
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
            buttonBuy.Location = new Point(3, 482);
            buttonBuy.Name = "buttonBuy";
            buttonBuy.Size = new Size(392, 44);
            buttonBuy.TabIndex = 5;
            buttonBuy.Text = "КУПИТИ";
            buttonBuy.UseVisualStyleBackColor = false;
            buttonBuy.Click += buttonBuy_Click;
            // 
            // labelDesc
            // 
            labelDesc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesc.Location = new Point(7, 327);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(392, 120);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "Опис";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(3, 289);
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
            pictureBox.Size = new Size(396, 283);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // buttonManufacture
            // 
            buttonManufacture.Location = new Point(7, 450);
            buttonManufacture.Name = "buttonManufacture";
            buttonManufacture.Size = new Size(94, 29);
            buttonManufacture.TabIndex = 7;
            buttonManufacture.Text = "Виробник";
            buttonManufacture.UseVisualStyleBackColor = true;
            buttonManufacture.Click += buttonManufacture_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
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
    }
}