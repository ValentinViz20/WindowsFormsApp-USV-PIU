namespace VizitiuFormsPiu
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
            viewContactsButton = new Button();
            closeContactsBtn = new Button();
            buttonAddContact = new Button();
            buttonSave = new Button();
            buttonLoadContacts = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // viewContactsButton
            // 
            viewContactsButton.Location = new Point(12, 12);
            viewContactsButton.Name = "viewContactsButton";
            viewContactsButton.Size = new Size(143, 29);
            viewContactsButton.TabIndex = 0;
            viewContactsButton.Text = "View contacts";
            viewContactsButton.UseVisualStyleBackColor = true;
            viewContactsButton.Click += viewContactsButton_Click;
            // 
            // closeContactsBtn
            // 
            closeContactsBtn.Location = new Point(12, 187);
            closeContactsBtn.Name = "closeContactsBtn";
            closeContactsBtn.Size = new Size(143, 29);
            closeContactsBtn.TabIndex = 1;
            closeContactsBtn.Text = "Close contacts";
            closeContactsBtn.UseVisualStyleBackColor = true;
            closeContactsBtn.Click += closeContactsBtn_Click;
            // 
            // buttonAddContact
            // 
            buttonAddContact.Location = new Point(12, 47);
            buttonAddContact.Name = "buttonAddContact";
            buttonAddContact.Size = new Size(143, 29);
            buttonAddContact.TabIndex = 2;
            buttonAddContact.Text = "Add contact";
            buttonAddContact.UseVisualStyleBackColor = true;
            buttonAddContact.Click += button1_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 82);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(143, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save contacts";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoadContacts
            // 
            buttonLoadContacts.Location = new Point(12, 117);
            buttonLoadContacts.Name = "buttonLoadContacts";
            buttonLoadContacts.Size = new Size(143, 29);
            buttonLoadContacts.TabIndex = 4;
            buttonLoadContacts.Text = "Load contacts";
            buttonLoadContacts.UseVisualStyleBackColor = true;
            buttonLoadContacts.Click += buttonLoadContacts_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 152);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 5;
            button1.Text = "Load Random";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 713);
            Controls.Add(button1);
            Controls.Add(buttonLoadContacts);
            Controls.Add(buttonSave);
            Controls.Add(buttonAddContact);
            Controls.Add(closeContactsBtn);
            Controls.Add(viewContactsButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button viewContactsButton;
        private Button closeContactsBtn;
        public Button buttonAddContact;
        public Button buttonSave;
        public Button buttonLoadContacts;
        private Panel panelContacts;
        private Button button1;
        private TextBox textBoxSearchContacts;
        private Label labelSearchTip;
    }
}