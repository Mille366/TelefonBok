namespace Telefonbok
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
            listBoxContact = new ListBox();
            textBoxName = new TextBox();
            textBoxAdress = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxPostCode = new TextBox();
            textBoxZipCode = new TextBox();
            textBoxEMail = new TextBox();
            labelName = new Label();
            labelPhoneNumber = new Label();
            labelAdress = new Label();
            labelZipCode = new Label();
            labelPostCode = new Label();
            labelEMail = new Label();
            buttonAdd = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonRemove = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // listBoxContact
            // 
            listBoxContact.FormattingEnabled = true;
            listBoxContact.ItemHeight = 15;
            listBoxContact.Location = new Point(103, 86);
            listBoxContact.Name = "listBoxContact";
            listBoxContact.Size = new Size(246, 289);
            listBoxContact.TabIndex = 0;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(429, 86);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(132, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(429, 214);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(132, 23);
            textBoxAdress.TabIndex = 2;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(596, 214);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(132, 23);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxPostCode
            // 
            textBoxPostCode.Location = new Point(429, 149);
            textBoxPostCode.Name = "textBoxPostCode";
            textBoxPostCode.Size = new Size(132, 23);
            textBoxPostCode.TabIndex = 4;
            // 
            // textBoxZipCode
            // 
            textBoxZipCode.Location = new Point(596, 149);
            textBoxZipCode.Name = "textBoxZipCode";
            textBoxZipCode.Size = new Size(132, 23);
            textBoxZipCode.TabIndex = 5;
            // 
            // textBoxEMail
            // 
            textBoxEMail.Location = new Point(596, 86);
            textBoxEMail.Name = "textBoxEMail";
            textBoxEMail.Size = new Size(132, 23);
            textBoxEMail.TabIndex = 6;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(429, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(43, 15);
            labelName.TabIndex = 7;
            labelName.Text = "Namn:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(596, 185);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(91, 15);
            labelPhoneNumber.TabIndex = 8;
            labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Location = new Point(429, 185);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(45, 15);
            labelAdress.TabIndex = 9;
            labelAdress.Text = "Adress:";
            // 
            // labelZipCode
            // 
            labelZipCode.AutoSize = true;
            labelZipCode.Location = new Point(596, 122);
            labelZipCode.Name = "labelZipCode";
            labelZipCode.Size = new Size(58, 15);
            labelZipCode.TabIndex = 10;
            labelZipCode.Text = "Zip Code:";
            // 
            // labelPostCode
            // 
            labelPostCode.AutoSize = true;
            labelPostCode.Location = new Point(429, 122);
            labelPostCode.Name = "labelPostCode";
            labelPostCode.Size = new Size(64, 15);
            labelPostCode.TabIndex = 11;
            labelPostCode.Text = "Post Code:";
            // 
            // labelEMail
            // 
            labelEMail.AutoSize = true;
            labelEMail.Location = new Point(596, 55);
            labelEMail.Name = "labelEMail";
            labelEMail.Size = new Size(33, 15);
            labelEMail.TabIndex = 12;
            labelEMail.Text = "Mail:";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(552, 269);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(181, 47);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(168, 23);
            textBoxSearch.TabIndex = 14;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(100, 46);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 15;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(248, 389);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(101, 36);
            buttonRemove.TabIndex = 17;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(103, 389);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(101, 36);
            buttonEdit.TabIndex = 18;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonRemove);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonAdd);
            Controls.Add(labelEMail);
            Controls.Add(labelPostCode);
            Controls.Add(labelZipCode);
            Controls.Add(labelAdress);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelName);
            Controls.Add(textBoxEMail);
            Controls.Add(textBoxZipCode);
            Controls.Add(textBoxPostCode);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAdress);
            Controls.Add(textBoxName);
            Controls.Add(listBoxContact);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxContact;
        private TextBox textBoxName;
        private TextBox textBoxAdress;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxPostCode;
        private TextBox textBoxZipCode;
        private TextBox textBoxEMail;
        private Label labelName;
        private Label labelPhoneNumber;
        private Label labelAdress;
        private Label labelZipCode;
        private Label labelPostCode;
        private Label labelEMail;
        private Button buttonAdd;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonRemove;
        private Button buttonEdit;
    }
}
