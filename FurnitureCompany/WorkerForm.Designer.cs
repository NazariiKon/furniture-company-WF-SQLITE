namespace FurnitureCompany
{
    partial class WorkerForm
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
            textBoxSurname = new TextBox();
            passLabel = new Label();
            textBoxAdress = new TextBox();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            adressLabel = new Label();
            idLabel = new Label();
            nameLabel = new Label();
            textBoxNumber = new TextBox();
            numberLabel = new Label();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(118, 72);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.ReadOnly = true;
            textBoxSurname.Size = new Size(272, 27);
            textBoxSurname.TabIndex = 68;
            // 
            // passLabel
            // 
            passLabel.Location = new Point(12, 75);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(100, 23);
            passLabel.TabIndex = 67;
            passLabel.Text = "Призвіще:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(118, 105);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.ReadOnly = true;
            textBoxAdress.Size = new Size(272, 27);
            textBoxAdress.TabIndex = 64;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(118, 6);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(272, 27);
            textBoxId.TabIndex = 61;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(118, 39);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(272, 27);
            textBoxName.TabIndex = 62;
            // 
            // adressLabel
            // 
            adressLabel.Location = new Point(12, 108);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new Size(100, 23);
            adressLabel.TabIndex = 59;
            adressLabel.Text = "Адреса:";
            // 
            // idLabel
            // 
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(100, 23);
            idLabel.TabIndex = 57;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(12, 42);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 23);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "Ім'я:";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(119, 138);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.ReadOnly = true;
            textBoxNumber.Size = new Size(272, 27);
            textBoxNumber.TabIndex = 70;
            // 
            // numberLabel
            // 
            numberLabel.Location = new Point(13, 141);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(100, 23);
            numberLabel.TabIndex = 69;
            numberLabel.Text = "Номер: ";
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 175);
            Controls.Add(textBoxNumber);
            Controls.Add(numberLabel);
            Controls.Add(textBoxSurname);
            Controls.Add(passLabel);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxId);
            Controls.Add(textBoxName);
            Controls.Add(adressLabel);
            Controls.Add(idLabel);
            Controls.Add(nameLabel);
            Name = "WorkerForm";
            Text = "Працівник";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSurname;
        private Label passLabel;
        private TextBox textBoxAdress;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private Label adressLabel;
        private Label idLabel;
        private Label nameLabel;
        private TextBox textBoxNumber;
        private Label numberLabel;
    }
}