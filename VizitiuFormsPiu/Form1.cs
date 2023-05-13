

using System.Windows.Forms;

using VizitiuFormsPiu.Agenda;

using static VizitiuFormsPiu.Agenda.Person;

namespace VizitiuFormsPiu
{
    public partial class Form1 : Form
    {
        private Agend _agendApp;

        private const int FONT_SIZE = 9;

        private const int NUME_MAX_LEN = 25;

        private List<GroupBox> groupsToHide = new List<GroupBox>();
        private string SelectedFilePath { get; set; } = "NONE";

        private HashSet<IDisposable> labels = new HashSet<IDisposable>();

        private Label labelNume;
        private TextBox textBoxNume;
        private TextBox prenumeTextBox;
        private Label labelPrenume;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNumber;
        private ComboBox comboBoxGrup;
        private Label labelGrup;
        private TextBox textBoxEmail;
        private Label emailLabel;
        private Label labelBirhtDay;
        private ComboBox comboBoxDay;
        private ComboBox comboBoxMonth;
        private ComboBox comboBoxYear;
        private Button buttonSaveContacts;
        private Button buttonClear;
        private Label labelNumeWarn;
        private Label labelWarnPrenume;
        private Label labelPhoneWarn;
        private Label labelEmailWarn;
        private Label labelBirthdayWarn;
        private Label labelContactAdded;
        private Label labelAddedExtraInfo;
        private Label labelLikeness;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private CheckBox checkBoxIncludeRating;
        private GroupBox groupBox1;
        private Button buttonSelectImage;
        private PictureBox pictureBoxAddContact;
        private Label labelProfilePictureText;


        private GroupBox GetContactBox(Person person)
        {
            GroupBox groupBoxContactInfo = new GroupBox();
            Label labelratingA = new Label();
            Label labelBirthDayA = new Label();
            Label labelEmailA = new Label();
            Label labelGroupA = new Label();
            PictureBox pictureBoxSmallPhoneIcon = new PictureBox();
            Label labelPhoneNumberA = new Label();
            PictureBox pictureBoxProfilePicture = new PictureBox();
            Label labelNumePrenume = new Label();
            panelContacts.SuspendLayout();
            groupBoxContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSmallPhoneIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).BeginInit();

            // 
            // groupBoxContactInfo
            // 
            groupBoxContactInfo.BackColor = SystemColors.ActiveCaption;
            groupBoxContactInfo.Controls.Add(labelratingA);
            groupBoxContactInfo.Controls.Add(labelBirthDayA);
            groupBoxContactInfo.Controls.Add(labelEmailA);
            groupBoxContactInfo.Controls.Add(labelGroupA);
            groupBoxContactInfo.Controls.Add(pictureBoxSmallPhoneIcon);
            groupBoxContactInfo.Controls.Add(labelPhoneNumberA);
            groupBoxContactInfo.Controls.Add(pictureBoxProfilePicture);
            groupBoxContactInfo.Controls.Add(labelNumePrenume);
            groupBoxContactInfo.FlatStyle = FlatStyle.Flat;
            groupBoxContactInfo.Name = "groupBoxContactInfo";
            groupBoxContactInfo.Size = new Size(932, 186);
            groupBoxContactInfo.TabIndex = 4;
            groupBoxContactInfo.TabStop = false;
            // 
            // labelratingA
            // 
            labelratingA.AutoSize = true;
            labelratingA.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelratingA.Location = new Point(462, 111);
            labelratingA.Name = "labelratingA";
            labelratingA.Size = new Size(87, 30);
            labelratingA.TabIndex = 7;
            labelratingA.Text = "Rating: " + new string('⭐', person.Rating);
            // 
            // labelBirthDayA
            // 
            labelBirthDayA.AutoSize = true;
            labelBirthDayA.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDayA.Location = new Point(462, 81);
            labelBirthDayA.Name = "labelBirthDayA";
            labelBirthDayA.Size = new Size(109, 30);
            labelBirthDayA.TabIndex = 6;
            labelBirthDayA.Text = $"Birthday: {person.BithDate.Day:D2}/{person.BithDate.Month:D2}/{person.BithDate.Year:D4}";
            // 
            // labelEmailA
            // 
            labelEmailA.AutoSize = true;
            labelEmailA.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmailA.Location = new Point(462, 49);
            labelEmailA.Name = "labelEmailA";
            labelEmailA.Size = new Size(84, 30);
            labelEmailA.TabIndex = 5;
            labelEmailA.Text = $"E-mail: {person.Email}";
            // 
            // labelGroupA
            // 
            labelGroupA.AutoSize = true;
            labelGroupA.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelGroupA.Location = new Point(462, 19);
            labelGroupA.Name = "labelGroupA";
            labelGroupA.Size = new Size(90, 30);
            labelGroupA.TabIndex = 4;
            labelGroupA.Text = $"Group: {person.Group.ToString()}";
            // 
            // pictureBoxSmallPhoneIcon
            // 
            pictureBoxSmallPhoneIcon.Image = Properties.Resources.icons8_phone_24;
            pictureBoxSmallPhoneIcon.Location = new Point(133, 70);
            pictureBoxSmallPhoneIcon.Name = "pictureBoxSmallPhoneIcon";
            pictureBoxSmallPhoneIcon.Size = new Size(42, 40);
            pictureBoxSmallPhoneIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSmallPhoneIcon.TabIndex = 3;
            pictureBoxSmallPhoneIcon.TabStop = false;
            // 
            // labelPhoneNumberA
            // 
            labelPhoneNumberA.AutoSize = true;
            labelPhoneNumberA.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumberA.Location = new Point(171, 70);
            labelPhoneNumberA.Name = "labelPhoneNumberA";
            labelPhoneNumberA.Size = new Size(171, 41);
            labelPhoneNumberA.TabIndex = 2;
            labelPhoneNumberA.Text = person.PhoneNumber;
            // 
            // pictureBoxProfilePicture
            // 
            pictureBoxProfilePicture.Location = new Point(8, 19);
            pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            pictureBoxProfilePicture.Size = new Size(119, 105);
            pictureBoxProfilePicture.TabIndex = 1;
            pictureBoxProfilePicture.TabStop = false;

            if (File.Exists(person.ProfilePicturePath))
            {
                var picture = Image.FromFile(person.ProfilePicturePath);
                pictureBoxProfilePicture.Image = picture;
            }
            else
            {
                var picture = Image.FromFile(@"./ContactPictures/contact_pfp.png");
                pictureBoxProfilePicture.Image = picture;
            }
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // labelNumePrenume
            // 
            labelNumePrenume.AutoSize = true;
            labelNumePrenume.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumePrenume.Location = new Point(133, 19);
            labelNumePrenume.Name = "labelNumePrenume";
            labelNumePrenume.Size = new Size(236, 41);
            labelNumePrenume.TabIndex = 0;
            labelNumePrenume.Text = person.Name + " " + person.Prenume;

            groupBoxContactInfo.ResumeLayout(false);
            groupBoxContactInfo.PerformLayout();

            panelContacts.ResumeLayout(false);
            panelContacts.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)pictureBoxSmallPhoneIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).EndInit();

            return groupBoxContactInfo;
        }

        public Form1(Agend agendApp)
        {
            _agendApp = agendApp;

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CleanItems()
        {
            SelectedFilePath = "NONE";
            foreach (var label in labels)
            {
                label.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Aplicatie Agenda - Vizitiu Valentin";

        }

        private void Clear_AddContact_Values(object sender, EventArgs e)
        {
            textBoxNume.Text = "";
            prenumeTextBox.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxEmail.Text = "";
            comboBoxGrup.SelectedIndex = 0;
            comboBoxDay.SelectedIndex = -1;
            comboBoxMonth.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;

            SelectedFilePath = "NONE";
            labelBirthdayWarn.Dispose();
            labelEmailWarn.Dispose();
            labelNumeWarn.Dispose();
            labelPhoneWarn.Dispose();
            labelWarnPrenume.Dispose();

        }

        private void viewContactsButton_Click(object sender, EventArgs e)
        {
            CleanItems();

            // 
            // panelContacts
            // 
            panelContacts = new Panel();
            panelContacts.AutoScroll = true;
            panelContacts.Location = new Point(171, 27 + 32 + 10);
            panelContacts.Name = "panelContacts";
            panelContacts.Size = new Size(973, 574);
            panelContacts.TabIndex = 5;
            panelContacts.Scroll += vScrollBar1_ValueChanged;

            panelContacts.SuspendLayout();
            textBoxSearchContacts = new TextBox();
            labelSearchTip = new Label();

            // 
            // textBoxSearchContacts
            // 
            textBoxSearchContacts.Location = new Point(171, 32);
            textBoxSearchContacts.Name = "textBoxSearchContacts";
            textBoxSearchContacts.PlaceholderText = "Type the name, phone number, email, etc";
            textBoxSearchContacts.Size = new Size(932, 27);
            textBoxSearchContacts.TabIndex = 6;
            textBoxSearchContacts.TextChanged += SearchBox_TextChanged;

            // 
            // labelSearchTip
            // 
            labelSearchTip.AutoSize = true;
            labelSearchTip.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchTip.Location = new Point(171, 9);
            labelSearchTip.Name = "labelSearchTip";
            labelSearchTip.Size = new Size(237, 20);
            labelSearchTip.TabIndex = 7;
            labelSearchTip.Text = "Type here to search for contacts:";

            Controls.Add(labelSearchTip);
            Controls.Add(textBoxSearchContacts);
            labels.Add(labelSearchTip);
            labels.Add(textBoxSearchContacts);

            Controls.Add(panelContacts);
            var offestY = 0;

            foreach (var person in _agendApp.peopleInAgend)
            {
                var personInfoBox = GetContactBox(person);
                personInfoBox.Location = new Point(0, offestY);

                panelContacts.Controls.Add(personInfoBox);

                offestY += personInfoBox.Height + 10;
            }
            labels.Add(panelContacts);
            panelContacts.ResumeLayout();
        }

        private void closeContactsBtn_Click(object sender, EventArgs e)
        {
            CleanItems();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanItems();

            buttonSaveContacts = new Button();
            buttonClear = new Button();



            labelNume = new Label();
            textBoxNume = new TextBox();
            prenumeTextBox = new TextBox();
            labelPrenume = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNumber = new Label();
            comboBoxGrup = new ComboBox();
            labelGrup = new Label();
            textBoxEmail = new TextBox();
            emailLabel = new Label();
            labelBirhtDay = new Label();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            comboBoxYear = new ComboBox();
            labelLikeness = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            checkBoxIncludeRating = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();

            buttonSelectImage = new Button();
            pictureBoxAddContact = new PictureBox();
            labelProfilePictureText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddContact).BeginInit();


            // buttonSelectImage
            // 
            buttonSelectImage.Location = new Point(640, 396);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(136, 29);
            buttonSelectImage.TabIndex = 6;
            buttonSelectImage.Text = "Select Image";
            buttonSelectImage.UseVisualStyleBackColor = true;
            buttonSelectImage.Click += SelectPicture_Button;

            // 
            // pictureBoxAddContact
            // 
            pictureBoxAddContact.Location = new Point(640, 277);
            pictureBoxAddContact.Name = "pictureBoxAddContact";
            pictureBoxAddContact.Size = new Size(136, 113);
            pictureBoxAddContact.TabIndex = 7;
            pictureBoxAddContact.TabStop = false;
            var image = Image.FromFile("./ContactPictures/contact_pfp.png");

            pictureBoxAddContact.Image = image;
            pictureBoxAddContact.SizeMode = PictureBoxSizeMode.StretchImage;

            // 
            // labelProfilePictureText
            // 
            labelProfilePictureText.AutoSize = true;
            labelProfilePictureText.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelProfilePictureText.Location = new Point(640, 254);
            labelProfilePictureText.Name = "labelProfilePictureText";
            labelProfilePictureText.Size = new Size(112, 20);
            labelProfilePictureText.TabIndex = 8;
            labelProfilePictureText.Text = "Profile Picture:";



            // 
            // buttonSaveContacts
            // 
            buttonSaveContacts.Location = new Point(188, 396);
            buttonSaveContacts.Name = "buttonSaveContacts";
            buttonSaveContacts.Size = new Size(115, 29);
            buttonSaveContacts.TabIndex = 3;
            buttonSaveContacts.Text = "Save contact";
            buttonSaveContacts.UseVisualStyleBackColor = true;
            buttonSaveContacts.Click += buttonSaveContacts_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(309, 396);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(115, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += Clear_AddContact_Values;



            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.BackColor = SystemColors.Control;
            labelNume.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNume.Location = new Point(192, 9);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(86, 20);
            labelNume.TabIndex = 3;
            labelNume.Text = "First Name";
            labelNume.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNume
            // 
            textBoxNume.ForeColor = SystemColors.WindowText;
            textBoxNume.Location = new Point(192, 32);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.PlaceholderText = "Input Name";
            textBoxNume.Size = new Size(164, 27);
            textBoxNume.TabIndex = 4;
            // 
            // prenumeTextBox
            // 
            prenumeTextBox.ForeColor = SystemColors.WindowText;
            prenumeTextBox.Location = new Point(192, 96);
            prenumeTextBox.Name = "prenumeTextBox";
            prenumeTextBox.PlaceholderText = "Input Name";
            prenumeTextBox.Size = new Size(164, 27);
            prenumeTextBox.TabIndex = 6;
            // 
            // labelPrenume
            // 
            labelPrenume.AutoSize = true;
            labelPrenume.BackColor = SystemColors.Control;
            labelPrenume.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrenume.Location = new Point(192, 73);
            labelPrenume.Name = "labelPrenume";
            labelPrenume.Size = new Size(84, 20);
            labelPrenume.TabIndex = 5;
            labelPrenume.Text = "Last Name";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.ForeColor = SystemColors.WindowText;
            textBoxPhoneNumber.Location = new Point(192, 156);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.PlaceholderText = "Input Number";
            textBoxPhoneNumber.Size = new Size(164, 27);
            textBoxPhoneNumber.TabIndex = 8;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.BackColor = SystemColors.Control;
            labelPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhoneNumber.Location = new Point(192, 133);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(115, 20);
            labelPhoneNumber.TabIndex = 7;
            labelPhoneNumber.Text = "Phone Number";
            labelPhoneNumber.Click += label1_Click;
            // 
            // comboBoxGrup
            // 
            comboBoxGrup.DisplayMember = "a";
            comboBoxGrup.ForeColor = SystemColors.WindowText;
            comboBoxGrup.FormattingEnabled = true;
            comboBoxGrup.Items.AddRange(Enum.GetNames(typeof(ContactGroup)));
            comboBoxGrup.Location = new Point(192, 218);
            comboBoxGrup.Name = "comboBoxGrup";
            comboBoxGrup.Size = new Size(164, 28);
            comboBoxGrup.TabIndex = 9;
            comboBoxGrup.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrup.SelectedIndex = 0;

            // 
            // labelGrup
            // 
            labelGrup.AutoSize = true;
            labelGrup.BackColor = SystemColors.Control;
            labelGrup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrup.Location = new Point(192, 195);
            labelGrup.Name = "labelGrup";
            labelGrup.Size = new Size(44, 20);
            labelGrup.TabIndex = 10;
            labelGrup.Text = "Grup";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(192, 284);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Input Email";
            textBoxEmail.Size = new Size(164, 27);
            textBoxEmail.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = SystemColors.Control;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailLabel.Location = new Point(192, 261);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(53, 20);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "E-mail";
            // 
            // labelBirhtDay
            // 
            labelBirhtDay.AutoSize = true;
            labelBirhtDay.BackColor = SystemColors.Control;
            labelBirhtDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirhtDay.Location = new Point(192, 322);
            labelBirhtDay.Name = "labelBirhtDay";
            labelBirhtDay.Size = new Size(69, 20);
            labelBirhtDay.TabIndex = 14;
            labelBirhtDay.Text = "Birthday";
            // 
            // comboBoxDay
            // 
            comboBoxDay.FormattingEnabled = true;
            for (int i = 1; i <= 31; i++)
            {
                comboBoxDay.Items.Add(i);
            }
            comboBoxDay.Location = new Point(192, 345);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(44, 28);
            comboBoxDay.TabIndex = 13;
            comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.FormattingEnabled = true;
            for (int i = 1; i <= 12; i++)
            {
                comboBoxMonth.Items.Add(i);
            }
            comboBoxMonth.Location = new Point(242, 345);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(44, 28);
            comboBoxMonth.TabIndex = 15;
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            // 
            // comboBoxYear
            // 
            comboBoxYear.FormattingEnabled = true;
            for (int i = 1900; i <= 2023; i++)
            {
                comboBoxYear.Items.Add(i);
            }
            comboBoxYear.Location = new Point(292, 345);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(64, 28);
            comboBoxYear.TabIndex = 16;
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // labelLikeness
            // 
            labelLikeness.AutoSize = true;
            labelLikeness.Enabled = false;
            labelLikeness.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelLikeness.Location = new Point(813, 43);
            labelLikeness.Name = "labelLikeness";
            labelLikeness.Size = new Size(253, 20);
            labelLikeness.TabIndex = 5;
            labelLikeness.Text = "How much do you like this person?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(38, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(50, 19);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(38, 24);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(94, 19);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(38, 24);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(178, 19);
            radioButton5.Name = "radioButton4";
            radioButton5.Size = new Size(38, 24);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(134, 19);
            radioButton4.Name = "radioButton5";
            radioButton4.Size = new Size(38, 24);
            radioButton4.TabIndex = 9;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeRating
            // 
            checkBoxIncludeRating.AutoSize = true;
            checkBoxIncludeRating.Location = new Point(813, 12);
            checkBoxIncludeRating.Name = "checkBoxIncludeRating";
            checkBoxIncludeRating.Size = new Size(235, 24);
            checkBoxIncludeRating.TabIndex = 11;
            checkBoxIncludeRating.Text = "Include a rating for the contact";
            checkBoxIncludeRating.UseVisualStyleBackColor = true;
            checkBoxIncludeRating.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(813, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 48);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;

            Controls.Add(comboBoxYear);
            Controls.Add(comboBoxMonth);
            Controls.Add(labelBirhtDay);
            Controls.Add(comboBoxDay);
            Controls.Add(textBoxEmail);
            Controls.Add(emailLabel);
            Controls.Add(labelGrup);
            Controls.Add(comboBoxGrup);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelPhoneNumber);
            Controls.Add(prenumeTextBox);
            Controls.Add(labelPrenume);
            Controls.Add(textBoxNume);
            Controls.Add(labelNume);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxIncludeRating);
            Controls.Add(labelLikeness);
            Controls.Add(buttonClear);
            Controls.Add(buttonSaveContacts);
            Controls.Add(labelProfilePictureText);
            Controls.Add(pictureBoxAddContact);
            Controls.Add(buttonSelectImage);

            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)pictureBoxAddContact).EndInit();

            labels.Add(comboBoxYear);
            labels.Add(comboBoxMonth);
            labels.Add(labelBirhtDay);
            labels.Add(comboBoxDay);
            labels.Add(textBoxEmail);
            labels.Add(emailLabel);
            labels.Add(labelGrup);
            labels.Add(comboBoxGrup);
            labels.Add(textBoxPhoneNumber);
            labels.Add(labelPhoneNumber);
            labels.Add(prenumeTextBox);
            labels.Add(labelPrenume);
            labels.Add(textBoxNume);
            labels.Add(labelNume);
            labels.Add(buttonSaveContacts);
            labels.Add(buttonClear);
            labels.Add(groupBox1);
            labels.Add(checkBoxIncludeRating);
            labels.Add(labelLikeness);
            labels.Add(buttonClear);
            labels.Add(buttonSaveContacts);
            labels.Add(labelProfilePictureText);
            labels.Add(pictureBoxAddContact);
            labels.Add(buttonSelectImage);
        }

        private void buttonSaveContacts_Click(object sender, EventArgs e)
        {
            var errors = false;

            if (string.IsNullOrEmpty(textBoxNume.Text) || textBoxNume.Text.Length > NUME_MAX_LEN)
            {
                labelNumeWarn = new Label();

                // 
                // labelNumeWarn
                // 
                labelNumeWarn.AutoSize = true;
                labelNumeWarn.ForeColor = Color.Red;
                labelNumeWarn.Location = new Point(359, 35);
                labelNumeWarn.Name = "labelNumeWarn";
                labelNumeWarn.Size = new Size(420, 20);
                labelNumeWarn.TabIndex = 5;
                labelNumeWarn.Text = "The first name is required and must be max 25 characters long";

                Controls.Add(labelNumeWarn);

                labels.Add(labelNumeWarn);
                errors = true;
            }

            if (string.IsNullOrEmpty(prenumeTextBox.Text) || prenumeTextBox.Text.Length > NUME_MAX_LEN)
            {
                labelWarnPrenume = new Label();

                // 
                // labelWarnPrenume
                // 
                labelWarnPrenume.AutoSize = true;
                labelWarnPrenume.ForeColor = Color.Red;
                labelWarnPrenume.Location = new Point(359, 100);
                labelWarnPrenume.Name = "labelWarnPrenume";
                labelWarnPrenume.Size = new Size(406, 20);
                labelWarnPrenume.TabIndex = 6;
                labelWarnPrenume.Text = "The first last is required and must be max 25 characters long";

                Controls.Add(labelWarnPrenume);

                errors = true;
                labels.Add(labelWarnPrenume);
            }

            int phoneNumber = 0;

            if (!int.TryParse(textBoxPhoneNumber.Text, out phoneNumber) || textBoxPhoneNumber.Text.Length >= NUME_MAX_LEN)
            {
                labelPhoneWarn = new Label();

                // 
                // labelPhoneWarn
                // 
                labelPhoneWarn.AutoSize = true;
                labelPhoneWarn.ForeColor = Color.Red;
                labelPhoneWarn.Location = new Point(360, 159);
                labelPhoneWarn.Name = "labelPhoneWarn";
                labelPhoneWarn.Size = new Size(418, 20);
                labelPhoneWarn.TabIndex = 7;
                labelPhoneWarn.Text = "The phone number is required and must include only numbers\r\n";

                errors = true;
                Controls.Add(labelPhoneWarn);
                labels.Add(labelPhoneWarn);
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text) || !textBoxEmail.Text.Contains('@') || !textBoxEmail.Text.Contains('.'))
            {
                labelEmailWarn = new Label();
                // 
                // labelEmailWarn
                // 
                labelEmailWarn.AutoSize = true;
                labelEmailWarn.ForeColor = Color.Red;
                labelEmailWarn.Location = new Point(360, 288);
                labelEmailWarn.Name = "labelEmailWarn";
                labelEmailWarn.Size = new Size(178, 20);
                labelEmailWarn.TabIndex = 18;
                labelEmailWarn.Text = "Please input a valid email\r\n";

                labels.Add(labelEmailWarn);
                errors = true;
                Controls.Add(labelEmailWarn);
            }

            if (string.IsNullOrEmpty(comboBoxDay.Text)
                || string.IsNullOrEmpty(comboBoxMonth.Text)
                || string.IsNullOrEmpty(comboBoxYear.Text))
            {
                labelBirthdayWarn = new Label();

                // 
                // labelBirthdayWarn
                // 
                labelBirthdayWarn.AutoSize = true;
                labelBirthdayWarn.ForeColor = Color.Red;
                labelBirthdayWarn.Location = new Point(360, 350);
                labelBirthdayWarn.Name = "labelBirthdayWarn";
                labelBirthdayWarn.Size = new Size(183, 20);
                labelBirthdayWarn.TabIndex = 19;
                labelBirthdayWarn.Text = "Please select the birthdate\r\n";

                errors = true;
                labels.Add(labelBirthdayWarn);
                Controls.Add(labelBirthdayWarn);
            }

            if (!errors)
            {
                var newPerson = new Person(
                    textBoxNume.Text,
                    prenumeTextBox.Text,
                    textBoxPhoneNumber.Text,
                    (ContactGroup)Enum.Parse(typeof(ContactGroup), (string)comboBoxGrup.SelectedItem),
                    textBoxEmail.Text,
                    new DateTime((int)comboBoxYear.SelectedItem, (int)comboBoxMonth.SelectedItem, (int)comboBoxDay.SelectedItem)
                    );

                if (checkBoxIncludeRating.Checked)
                {
                    if (radioButton1.Checked)
                        newPerson.Rating = 1;
                    else if (radioButton2.Checked)
                        newPerson.Rating = 2;
                    else if (radioButton3.Checked)
                        newPerson.Rating = 3;
                    else if (radioButton4.Checked)
                        newPerson.Rating = 4;
                    else
                        newPerson.Rating = 5;
                }

                newPerson.ProfilePicturePath = SelectedFilePath;

                _agendApp.AddPersonToAgend(newPerson);

                CleanItems();

                labelContactAdded = new Label();
                labelAddedExtraInfo = new Label();

                // 
                // labelContactAdded
                // 
                labelContactAdded.AutoSize = true;
                labelContactAdded.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
                labelContactAdded.ForeColor = Color.Red;
                labelContactAdded.Location = new Point(214, 117);
                labelContactAdded.Name = "labelContactAdded";
                labelContactAdded.Size = new Size(662, 112);
                labelContactAdded.TabIndex = 3;
                labelContactAdded.Text = "Contact Added!";
                // 
                // labelAddedExtraInfo
                // 
                labelAddedExtraInfo.AutoSize = true;
                labelAddedExtraInfo.ForeColor = Color.OrangeRed;
                labelAddedExtraInfo.Location = new Point(369, 229);
                labelAddedExtraInfo.Name = "labelAddedExtraInfo";
                labelAddedExtraInfo.Size = new Size(346, 20);
                labelAddedExtraInfo.TabIndex = 4;
                labelAddedExtraInfo.Text = "Click on \"View contacts\" to see all of your contacts!";

                Controls.Add(labelAddedExtraInfo);
                Controls.Add(labelContactAdded);

                labels.Add(labelContactAdded);
                labels.Add(labelAddedExtraInfo);
            }

            else
            {
                // Play error sound
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _agendApp.SavePeopleToFile("contacts.txt");

            CleanItems();

            labelContactAdded = new Label();
            labelAddedExtraInfo = new Label();

            // 
            // labelContactAdded
            // 
            labelContactAdded.AutoSize = true;
            labelContactAdded.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactAdded.ForeColor = Color.Red;
            labelContactAdded.Location = new Point(214, 117);
            labelContactAdded.Name = "labelContactAdded";
            labelContactAdded.Size = new Size(662, 112);
            labelContactAdded.TabIndex = 3;
            labelContactAdded.Text = "Contacts saved!";
            // 
            // labelAddedExtraInfo
            // 
            labelAddedExtraInfo.AutoSize = true;
            labelAddedExtraInfo.ForeColor = Color.OrangeRed;
            labelAddedExtraInfo.Location = new Point(369, 229);
            labelAddedExtraInfo.Name = "labelAddedExtraInfo";
            labelAddedExtraInfo.Size = new Size(346, 20);
            labelAddedExtraInfo.TabIndex = 4;
            labelAddedExtraInfo.Text = "Click on \"Load Contacts\" to load your contacts on restart!";

            Controls.Add(labelAddedExtraInfo);
            Controls.Add(labelContactAdded);

            labels.Add(labelContactAdded);
            labels.Add(labelAddedExtraInfo);

        }

        private void buttonLoadContacts_Click(object sender, EventArgs e)
        {
            var contactsLoaded = _agendApp.LoadPeopleFromFile("contacts.txt");

            CleanItems();

            labelContactAdded = new Label();
            labelAddedExtraInfo = new Label();

            // 
            // labelContactAdded
            // 
            labelContactAdded.AutoSize = true;
            labelContactAdded.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactAdded.ForeColor = Color.Red;
            labelContactAdded.Location = new Point(214, 117);
            labelContactAdded.Name = "labelContactAdded";
            labelContactAdded.Size = new Size(662, 112);
            labelContactAdded.TabIndex = 3;
            labelContactAdded.Text = $"{contactsLoaded} contacts loaded!";
            // 
            // labelAddedExtraInfo
            // 
            labelAddedExtraInfo.AutoSize = true;
            labelAddedExtraInfo.ForeColor = Color.OrangeRed;
            labelAddedExtraInfo.Location = new Point(369, 229);
            labelAddedExtraInfo.Name = "labelAddedExtraInfo";
            labelAddedExtraInfo.Size = new Size(346, 20);
            labelAddedExtraInfo.TabIndex = 4;
            labelAddedExtraInfo.Text = "Click on \"View contacts\" to see all of your contacts!";

            Controls.Add(labelAddedExtraInfo);
            Controls.Add(labelContactAdded);

            labels.Add(labelContactAdded);
            labels.Add(labelAddedExtraInfo);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIncludeRating.Checked)
            {
                groupBox1.Enabled = true;
                labelLikeness.Enabled = true;
                radioButton1.Checked = true;
            }
            else
            {
                groupBox1.Enabled = false;
                labelLikeness.Enabled = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var values = System.Enum.GetValues(typeof(ContactGroup)).Cast<ContactGroup>();

            for (int i = 0; i < 100; i++)
            {
                var randomGroup = (ContactGroup)values.ElementAt(new Random().Next(values.Count()));

                _agendApp.AddPersonToAgend(new Person(
                    Faker.Name.First(),
                    Faker.Name.Last(),
                    "0" + new Random().Next(1000000, 2222222).ToString(),
                    randomGroup,
                    Faker.Internet.Email(),
                    new DateTime(
                        new Random().Next(1900, 2010),
                        new Random().Next(1, 12),
                        new Random().Next(1, 25)
                        )
                    )
                {

                    Rating = new Random().Next(1, 5)
                }
                 );

            }

            CleanItems();

            labelContactAdded = new Label();
            labelAddedExtraInfo = new Label();

            // 
            // labelContactAdded
            // 
            labelContactAdded.AutoSize = true;
            labelContactAdded.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactAdded.ForeColor = Color.Red;
            labelContactAdded.Location = new Point(214, 117);
            labelContactAdded.Name = "labelContactAdded";
            labelContactAdded.Size = new Size(662, 112);
            labelContactAdded.TabIndex = 3;
            labelContactAdded.Text = $"{100} random contacts loaded!";
            // 
            // labelAddedExtraInfo
            // 
            labelAddedExtraInfo.AutoSize = true;
            labelAddedExtraInfo.ForeColor = Color.OrangeRed;
            labelAddedExtraInfo.Location = new Point(369, 229);
            labelAddedExtraInfo.Name = "labelAddedExtraInfo";
            labelAddedExtraInfo.Size = new Size(346, 20);
            labelAddedExtraInfo.TabIndex = 4;
            labelAddedExtraInfo.Text = "Click on \"View contacts\" to see all of your contacts!";

            Controls.Add(labelAddedExtraInfo);
            Controls.Add(labelContactAdded);

            labels.Add(labelContactAdded);
            labels.Add(labelAddedExtraInfo);

        }

        private void vScrollBar1_ValueChanged(object sender, ScrollEventArgs e)
        {
            panelContacts.VerticalScroll.Value = e.NewValue;
        }

        private void SelectPicture_Button(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Title = "Select an image file";

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // The user selected a file, so do something with it
                string fileName = openFileDialog.FileName;

                string[] files = Directory.GetFiles("./ContactPictures");
                int fileCount = files.Length;

                // Define the new file path where you want to save the file
                string newFilePath = @"ContactPictures\" + fileCount.ToString() + Path.GetExtension(fileName);

                // Copy the selected file to the new file path
                File.Copy(fileName, newFilePath);

                SelectedFilePath = newFilePath;

                Image image = Image.FromFile(newFilePath);
                pictureBoxAddContact.Image = image;
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            var offestY = 0;
            panelContacts.SuspendLayout();
            panelContacts.Controls.Clear();
            var lowercaseText = textBoxSearchContacts.Text.ToLower();

            foreach (var person in _agendApp.peopleInAgend)
            {
                if (person.Name.ToLower().Contains(lowercaseText)
                    || person.Prenume.ToLower().Contains(lowercaseText)
                    || person.PhoneNumber.Contains(lowercaseText)
                    || person.BithDate.ToString().Contains(lowercaseText)
                    || person.Email.ToLower().Contains(lowercaseText)
                    || person.Group.ToString().ToLower().Contains(lowercaseText))
                {
                    var personInfoBox = GetContactBox(person);
                    personInfoBox.Location = new Point(0, offestY);

                    panelContacts.Controls.Add(personInfoBox);

                    offestY += personInfoBox.Height + 10;
                }
            }
            panelContacts.ResumeLayout();
        }


    }
}