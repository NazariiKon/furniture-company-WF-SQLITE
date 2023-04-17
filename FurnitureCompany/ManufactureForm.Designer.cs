namespace FurnitureCompany
{
    partial class ManufactureForm
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
            labelName = new Label();
            label2 = new Label();
            labelAddress = new Label();
            label1 = new Label();
            labelPhone = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(151, 38);
            labelName.TabIndex = 0;
            labelName.Text = "Виробник";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 50);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 1;
            label2.Text = "Адреса: ";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddress.Location = new Point(109, 55);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(116, 23);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "вул. Барана 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 82);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 3;
            label1.Text = "Телефон: ";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(109, 86);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(71, 20);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "3091-121";
            // 
            // ManufactureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 120);
            Controls.Add(labelPhone);
            Controls.Add(label1);
            Controls.Add(labelAddress);
            Controls.Add(label2);
            Controls.Add(labelName);
            Name = "ManufactureForm";
            Text = "ManufactureForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label2;
        private Label labelAddress;
        private Label label1;
        private Label labelPhone;
    }
}