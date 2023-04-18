namespace FurnitureCompany
{
    partial class OrdersForm
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
            listBoxOrders = new ListBox();
            textBoxStatus = new TextBox();
            textBoxProduct = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDateOrder = new TextBox();
            textBoxDateDeliv = new TextBox();
            label2 = new Label();
            yearGraduationLabel = new Label();
            nextStudyLabel = new Label();
            positionLabel = new Label();
            groupLabel = new Label();
            label1 = new Label();
            buttonWorker = new Button();
            SuspendLayout();
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 20;
            listBoxOrders.Location = new Point(12, 12);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(317, 304);
            listBoxOrders.TabIndex = 0;
            listBoxOrders.SelectedIndexChanged += listBoxOrders_SelectedIndexChanged;
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(486, 144);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(201, 27);
            textBoxStatus.TabIndex = 48;
            // 
            // textBoxProduct
            // 
            textBoxProduct.Location = new Point(486, 12);
            textBoxProduct.Name = "textBoxProduct";
            textBoxProduct.ReadOnly = true;
            textBoxProduct.Size = new Size(201, 27);
            textBoxProduct.TabIndex = 44;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(486, 45);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(201, 27);
            textBoxPrice.TabIndex = 45;
            // 
            // textBoxDateOrder
            // 
            textBoxDateOrder.Location = new Point(486, 78);
            textBoxDateOrder.Name = "textBoxDateOrder";
            textBoxDateOrder.ReadOnly = true;
            textBoxDateOrder.Size = new Size(201, 27);
            textBoxDateOrder.TabIndex = 46;
            // 
            // textBoxDateDeliv
            // 
            textBoxDateDeliv.Location = new Point(486, 111);
            textBoxDateDeliv.Name = "textBoxDateDeliv";
            textBoxDateDeliv.ReadOnly = true;
            textBoxDateDeliv.Size = new Size(201, 27);
            textBoxDateDeliv.TabIndex = 47;
            // 
            // label2
            // 
            label2.Location = new Point(339, 147);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 43;
            label2.Text = "Статус:";
            // 
            // yearGraduationLabel
            // 
            yearGraduationLabel.Location = new Point(339, 15);
            yearGraduationLabel.Name = "yearGraduationLabel";
            yearGraduationLabel.Size = new Size(129, 23);
            yearGraduationLabel.TabIndex = 39;
            yearGraduationLabel.Text = "Товар: ";
            // 
            // nextStudyLabel
            // 
            nextStudyLabel.Location = new Point(339, 48);
            nextStudyLabel.Name = "nextStudyLabel";
            nextStudyLabel.Size = new Size(100, 23);
            nextStudyLabel.TabIndex = 40;
            nextStudyLabel.Text = "Ціна:";
            // 
            // positionLabel
            // 
            positionLabel.Location = new Point(339, 81);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(141, 23);
            positionLabel.TabIndex = 41;
            positionLabel.Text = "Дата замовлення:";
            // 
            // groupLabel
            // 
            groupLabel.Location = new Point(339, 114);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(141, 23);
            groupLabel.TabIndex = 42;
            groupLabel.Text = "Дата доставки:";
            // 
            // label1
            // 
            label1.Location = new Point(339, 180);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 49;
            label1.Text = "Працівник:";
            // 
            // buttonWorker
            // 
            buttonWorker.Location = new Point(486, 177);
            buttonWorker.Name = "buttonWorker";
            buttonWorker.Size = new Size(201, 27);
            buttonWorker.TabIndex = 50;
            buttonWorker.Text = "Інформація";
            buttonWorker.UseVisualStyleBackColor = true;
            buttonWorker.Click += buttonWorker_Click;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 331);
            Controls.Add(buttonWorker);
            Controls.Add(label1);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxProduct);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDateOrder);
            Controls.Add(textBoxDateDeliv);
            Controls.Add(label2);
            Controls.Add(yearGraduationLabel);
            Controls.Add(nextStudyLabel);
            Controls.Add(positionLabel);
            Controls.Add(groupLabel);
            Controls.Add(listBoxOrders);
            Name = "OrdersForm";
            Text = "OrdersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxOrders;
        private TextBox textBoxStatus;
        private TextBox textBoxProduct;
        private TextBox textBoxPrice;
        private TextBox textBoxDateOrder;
        private TextBox textBoxDateDeliv;
        private Label label2;
        private Label yearGraduationLabel;
        private Label nextStudyLabel;
        private Label positionLabel;
        private Label groupLabel;
        private Label label1;
        private Button buttonWorker;
    }
}