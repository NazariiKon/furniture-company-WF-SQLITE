namespace FurnitureCompany
{
    partial class AddProductForm
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
            comboBoxCategory = new ComboBox();
            comboBoxManuf = new ComboBox();
            surnameLabel = new Label();
            phoneLabel = new Label();
            numericUpDownPrice = new NumericUpDown();
            textBoxDesc = new TextBox();
            textBoxName = new TextBox();
            yearLabel = new Label();
            colorLabel = new Label();
            carLabel = new Label();
            numberLabel = new Label();
            numericUpDownCount = new NumericUpDown();
            textBoxImage = new TextBox();
            pictureBox = new PictureBox();
            btnUpload = new Button();
            addButton = new Button();
            buttonAddManuf = new Button();
            buttonAddCategory = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(118, 172);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(233, 28);
            comboBoxCategory.TabIndex = 62;
            // 
            // comboBoxManuf
            // 
            comboBoxManuf.FormattingEnabled = true;
            comboBoxManuf.Location = new Point(118, 138);
            comboBoxManuf.Name = "comboBoxManuf";
            comboBoxManuf.Size = new Size(233, 28);
            comboBoxManuf.TabIndex = 61;
            // 
            // surnameLabel
            // 
            surnameLabel.Location = new Point(12, 141);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(100, 23);
            surnameLabel.TabIndex = 59;
            surnameLabel.Text = "Виробник:";
            // 
            // phoneLabel
            // 
            phoneLabel.Location = new Point(12, 175);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(100, 23);
            phoneLabel.TabIndex = 60;
            phoneLabel.Text = "Категорія:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(118, 73);
            numericUpDownPrice.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(272, 27);
            numericUpDownPrice.TabIndex = 70;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(118, 105);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(272, 27);
            textBoxDesc.TabIndex = 69;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(118, 6);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(272, 27);
            textBoxName.TabIndex = 67;
            // 
            // yearLabel
            // 
            yearLabel.Location = new Point(12, 73);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(100, 23);
            yearLabel.TabIndex = 66;
            yearLabel.Text = "Ціна:";
            // 
            // colorLabel
            // 
            colorLabel.Location = new Point(12, 108);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(100, 23);
            colorLabel.TabIndex = 65;
            colorLabel.Text = "Опис:";
            // 
            // carLabel
            // 
            carLabel.Location = new Point(12, 9);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(100, 23);
            carLabel.TabIndex = 63;
            carLabel.Text = "Назва:";
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(12, 42);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(100, 23);
            numberLabel.TabIndex = 64;
            numberLabel.Text = "Кількість:";
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(118, 40);
            numericUpDownCount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(272, 27);
            numericUpDownCount.TabIndex = 71;
            numericUpDownCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // textBoxImage
            // 
            textBoxImage.Location = new Point(396, 253);
            textBoxImage.Name = "textBoxImage";
            textBoxImage.ReadOnly = true;
            textBoxImage.Size = new Size(432, 27);
            textBoxImage.TabIndex = 75;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(396, 6);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(432, 236);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 74;
            pictureBox.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(12, 206);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(378, 36);
            btnUpload.TabIndex = 73;
            btnUpload.Text = "Загрузити фото";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 248);
            addButton.Name = "addButton";
            addButton.Size = new Size(378, 36);
            addButton.TabIndex = 72;
            addButton.Text = "Додати";
            addButton.Click += addButton_Click;
            // 
            // buttonAddManuf
            // 
            buttonAddManuf.Location = new Point(357, 138);
            buttonAddManuf.Name = "buttonAddManuf";
            buttonAddManuf.Size = new Size(33, 28);
            buttonAddManuf.TabIndex = 76;
            buttonAddManuf.Text = "+";
            buttonAddManuf.UseVisualStyleBackColor = true;
            buttonAddManuf.Click += buttonAddManuf_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Location = new Point(357, 172);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(33, 28);
            buttonAddCategory.TabIndex = 77;
            buttonAddCategory.Text = "+";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 293);
            Controls.Add(buttonAddCategory);
            Controls.Add(buttonAddManuf);
            Controls.Add(textBoxImage);
            Controls.Add(pictureBox);
            Controls.Add(btnUpload);
            Controls.Add(addButton);
            Controls.Add(numericUpDownCount);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxName);
            Controls.Add(yearLabel);
            Controls.Add(colorLabel);
            Controls.Add(carLabel);
            Controls.Add(numberLabel);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxManuf);
            Controls.Add(surnameLabel);
            Controls.Add(phoneLabel);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCategory;
        private ComboBox comboBoxManuf;
        private Label surnameLabel;
        private Label phoneLabel;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxDesc;
        private TextBox textBoxName;
        private Label yearLabel;
        private Label colorLabel;
        private Label carLabel;
        private Label numberLabel;
        private NumericUpDown numericUpDownCount;
        private TextBox textBoxImage;
        private PictureBox pictureBox;
        private Button btnUpload;
        private Button addButton;
        private Button buttonAddManuf;
        private Button buttonAddCategory;
    }
}