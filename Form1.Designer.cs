namespace Maxwell_2
{
    partial class CourseOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.termInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.selectTermYearLabel = new System.Windows.Forms.Label();
            this.selectATermLabel = new System.Windows.Forms.Label();
            this.termYearComboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.residencyLabel = new System.Windows.Forms.Label();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.studentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.courseOrderInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.beginningRussianCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningSpanishCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningItalianCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningGermanCheckBox = new System.Windows.Forms.CheckBox();
            this.outOfStateChargeLabel = new System.Windows.Forms.Label();
            this.inStateChargeLabel = new System.Windows.Forms.Label();
            this.chargePerCourseLabel = new System.Windows.Forms.Label();
            this.inStateLabel = new System.Windows.Forms.Label();
            this.beginningFrenchCheckBox = new System.Windows.Forms.CheckBox();
            this.outOfStateLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.paymentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.numberOfCoursesSelectedLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.totalCoursesLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.expirationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.exitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.termInformationGroupBox.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.courseOrderInformationGroupBox.SuspendLayout();
            this.paymentInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // termInformationGroupBox
            // 
            this.termInformationGroupBox.Controls.Add(this.fallRadioButton);
            this.termInformationGroupBox.Controls.Add(this.selectTermYearLabel);
            this.termInformationGroupBox.Controls.Add(this.selectATermLabel);
            this.termInformationGroupBox.Controls.Add(this.termYearComboBox);
            this.termInformationGroupBox.Controls.Add(this.springRadioButton);
            this.termInformationGroupBox.Location = new System.Drawing.Point(4, 129);
            this.termInformationGroupBox.Name = "termInformationGroupBox";
            this.termInformationGroupBox.Size = new System.Drawing.Size(276, 96);
            this.termInformationGroupBox.TabIndex = 0;
            this.termInformationGroupBox.TabStop = false;
            this.termInformationGroupBox.Text = "Term Information";
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoCheck = false;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(104, 16);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(61, 24);
            this.fallRadioButton.TabIndex = 5;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            this.fallRadioButton.CheckedChanged += new System.EventHandler(this.fallRadioButton_CheckedChanged);
            // 
            // selectTermYearLabel
            // 
            this.selectTermYearLabel.Location = new System.Drawing.Point(3, 54);
            this.selectTermYearLabel.Name = "selectTermYearLabel";
            this.selectTermYearLabel.Size = new System.Drawing.Size(100, 23);
            this.selectTermYearLabel.TabIndex = 4;
            this.selectTermYearLabel.Text = "Select Term Year:";
            // 
            // selectATermLabel
            // 
            this.selectATermLabel.Location = new System.Drawing.Point(5, 22);
            this.selectATermLabel.Name = "selectATermLabel";
            this.selectATermLabel.Size = new System.Drawing.Size(87, 21);
            this.selectATermLabel.TabIndex = 3;
            this.selectATermLabel.Text = "Select A Term:";
            // 
            // termYearComboBox
            // 
            this.termYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.termYearComboBox.FormattingEnabled = true;
            this.termYearComboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.termYearComboBox.Location = new System.Drawing.Point(111, 54);
            this.termYearComboBox.Name = "termYearComboBox";
            this.termYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.termYearComboBox.TabIndex = 2;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoCheck = false;
            this.springRadioButton.Location = new System.Drawing.Point(171, 16);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(61, 24);
            this.springRadioButton.TabIndex = 1;
            this.springRadioButton.TabStop = true;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.residencyLabel);
            this.studentInformationGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentInformationGroupBox.Controls.Add(this.studentIDMaskedTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.emailLabel);
            this.studentInformationGroupBox.Controls.Add(this.lastNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.firstNameLabel);
            this.studentInformationGroupBox.Controls.Add(this.studentIDLabel);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(4, 231);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(276, 205);
            this.studentInformationGroupBox.TabIndex = 1;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // residencyLabel
            // 
            this.residencyLabel.Location = new System.Drawing.Point(3, 149);
            this.residencyLabel.Name = "residencyLabel";
            this.residencyLabel.Size = new System.Drawing.Size(124, 23);
            this.residencyLabel.TabIndex = 9;
            this.residencyLabel.Text = "Choose Your Residency:";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.Location = new System.Drawing.Point(136, 177);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(129, 22);
            this.outOfStateRadioButton.TabIndex = 8;
            this.outOfStateRadioButton.Text = "Out-Of-State Resident";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(136, 148);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(107, 24);
            this.inStateRadioButton.TabIndex = 7;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State Resident";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentIDMaskedTextBox
            // 
            this.studentIDMaskedTextBox.Location = new System.Drawing.Point(111, 25);
            this.studentIDMaskedTextBox.Mask = "000-00-0000";
            this.studentIDMaskedTextBox.Name = "studentIDMaskedTextBox";
            this.studentIDMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentIDMaskedTextBox.TabIndex = 3;
            this.studentIDMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(111, 94);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(111, 71);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(111, 48);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(5, 94);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "E-mail address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(5, 71);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 23);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(5, 48);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(100, 23);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.Location = new System.Drawing.Point(5, 25);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(100, 23);
            this.studentIDLabel.TabIndex = 1;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // courseOrderInformationGroupBox
            // 
            this.courseOrderInformationGroupBox.Controls.Add(this.beginningRussianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.beginningSpanishCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.beginningItalianCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.beginningGermanCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.outOfStateChargeLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.inStateChargeLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.chargePerCourseLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.inStateLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.beginningFrenchCheckBox);
            this.courseOrderInformationGroupBox.Controls.Add(this.outOfStateLabel);
            this.courseOrderInformationGroupBox.Controls.Add(this.courseLabel);
            this.courseOrderInformationGroupBox.Location = new System.Drawing.Point(286, 129);
            this.courseOrderInformationGroupBox.Name = "courseOrderInformationGroupBox";
            this.courseOrderInformationGroupBox.Size = new System.Drawing.Size(324, 150);
            this.courseOrderInformationGroupBox.TabIndex = 2;
            this.courseOrderInformationGroupBox.TabStop = false;
            this.courseOrderInformationGroupBox.Text = "Course Order Information";
            // 
            // beginningRussianCheckBox
            // 
            this.beginningRussianCheckBox.Location = new System.Drawing.Point(153, 49);
            this.beginningRussianCheckBox.Name = "beginningRussianCheckBox";
            this.beginningRussianCheckBox.Size = new System.Drawing.Size(78, 36);
            this.beginningRussianCheckBox.TabIndex = 23;
            this.beginningRussianCheckBox.Text = "Beginning Russian";
            this.beginningRussianCheckBox.UseVisualStyleBackColor = true;
            this.beginningRussianCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // beginningSpanishCheckBox
            // 
            this.beginningSpanishCheckBox.Location = new System.Drawing.Point(67, 50);
            this.beginningSpanishCheckBox.Name = "beginningSpanishCheckBox";
            this.beginningSpanishCheckBox.Size = new System.Drawing.Size(79, 35);
            this.beginningSpanishCheckBox.TabIndex = 24;
            this.beginningSpanishCheckBox.Text = "Beginning Spanish";
            this.beginningSpanishCheckBox.UseVisualStyleBackColor = true;
            this.beginningSpanishCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // beginningItalianCheckBox
            // 
            this.beginningItalianCheckBox.Location = new System.Drawing.Point(237, 17);
            this.beginningItalianCheckBox.Name = "beginningItalianCheckBox";
            this.beginningItalianCheckBox.Size = new System.Drawing.Size(83, 31);
            this.beginningItalianCheckBox.TabIndex = 25;
            this.beginningItalianCheckBox.Text = "Beginning Italian";
            this.beginningItalianCheckBox.UseVisualStyleBackColor = true;
            this.beginningItalianCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // beginningGermanCheckBox
            // 
            this.beginningGermanCheckBox.Location = new System.Drawing.Point(152, 16);
            this.beginningGermanCheckBox.Name = "beginningGermanCheckBox";
            this.beginningGermanCheckBox.Size = new System.Drawing.Size(79, 31);
            this.beginningGermanCheckBox.TabIndex = 26;
            this.beginningGermanCheckBox.Text = "Beginning German";
            this.beginningGermanCheckBox.UseVisualStyleBackColor = true;
            this.beginningGermanCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // outOfStateChargeLabel
            // 
            this.outOfStateChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outOfStateChargeLabel.Location = new System.Drawing.Point(204, 127);
            this.outOfStateChargeLabel.Name = "outOfStateChargeLabel";
            this.outOfStateChargeLabel.Size = new System.Drawing.Size(75, 20);
            this.outOfStateChargeLabel.TabIndex = 18;
            this.outOfStateChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inStateChargeLabel
            // 
            this.inStateChargeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inStateChargeLabel.Location = new System.Drawing.Point(204, 99);
            this.inStateChargeLabel.Name = "inStateChargeLabel";
            this.inStateChargeLabel.Size = new System.Drawing.Size(75, 23);
            this.inStateChargeLabel.TabIndex = 17;
            this.inStateChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chargePerCourseLabel
            // 
            this.chargePerCourseLabel.Location = new System.Drawing.Point(6, 102);
            this.chargePerCourseLabel.Name = "chargePerCourseLabel";
            this.chargePerCourseLabel.Size = new System.Drawing.Size(71, 38);
            this.chargePerCourseLabel.TabIndex = 16;
            this.chargePerCourseLabel.Text = "Charges Per Course :";
            // 
            // inStateLabel
            // 
            this.inStateLabel.Location = new System.Drawing.Point(83, 100);
            this.inStateLabel.Name = "inStateLabel";
            this.inStateLabel.Size = new System.Drawing.Size(95, 23);
            this.inStateLabel.TabIndex = 14;
            this.inStateLabel.Text = "In State Resident:";
            // 
            // beginningFrenchCheckBox
            // 
            this.beginningFrenchCheckBox.Location = new System.Drawing.Point(67, 17);
            this.beginningFrenchCheckBox.Name = "beginningFrenchCheckBox";
            this.beginningFrenchCheckBox.Size = new System.Drawing.Size(79, 31);
            this.beginningFrenchCheckBox.TabIndex = 19;
            this.beginningFrenchCheckBox.Text = "Beginning French";
            this.beginningFrenchCheckBox.UseVisualStyleBackColor = true;
            this.beginningFrenchCheckBox.CheckedChanged += new System.EventHandler(this.beginningFrenchCheckBox_CheckedChanged);
            // 
            // outOfStateLabel
            // 
            this.outOfStateLabel.Location = new System.Drawing.Point(76, 124);
            this.outOfStateLabel.Name = "outOfStateLabel";
            this.outOfStateLabel.Size = new System.Drawing.Size(115, 23);
            this.outOfStateLabel.TabIndex = 15;
            this.outOfStateLabel.Text = "Out Of State Resident:";
            // 
            // courseLabel
            // 
            this.courseLabel.Location = new System.Drawing.Point(6, 22);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(60, 20);
            this.courseLabel.TabIndex = 0;
            this.courseLabel.Text = "Courses:";
            // 
            // paymentInformationGroupBox
            // 
            this.paymentInformationGroupBox.Controls.Add(this.totalLabel);
            this.paymentInformationGroupBox.Controls.Add(this.numberOfCoursesSelectedLabel);
            this.paymentInformationGroupBox.Controls.Add(this.orderTotalLabel);
            this.paymentInformationGroupBox.Controls.Add(this.totalCoursesLabel);
            this.paymentInformationGroupBox.Controls.Add(this.paymentTypeLabel);
            this.paymentInformationGroupBox.Controls.Add(this.expirationMaskedTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberTextBox);
            this.paymentInformationGroupBox.Controls.Add(this.expirationLabel);
            this.paymentInformationGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentInformationGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInformationGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInformationGroupBox.Location = new System.Drawing.Point(286, 279);
            this.paymentInformationGroupBox.Name = "paymentInformationGroupBox";
            this.paymentInformationGroupBox.Size = new System.Drawing.Size(324, 157);
            this.paymentInformationGroupBox.TabIndex = 3;
            this.paymentInformationGroupBox.TabStop = false;
            this.paymentInformationGroupBox.Text = "Payment Information";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(132, 131);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(75, 23);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberOfCoursesSelectedLabel
            // 
            this.numberOfCoursesSelectedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfCoursesSelectedLabel.Location = new System.Drawing.Point(132, 104);
            this.numberOfCoursesSelectedLabel.Name = "numberOfCoursesSelectedLabel";
            this.numberOfCoursesSelectedLabel.Size = new System.Drawing.Size(75, 23);
            this.numberOfCoursesSelectedLabel.TabIndex = 21;
            this.numberOfCoursesSelectedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.Location = new System.Drawing.Point(6, 131);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.orderTotalLabel.TabIndex = 20;
            this.orderTotalLabel.Text = "Order Total:";
            // 
            // totalCoursesLabel
            // 
            this.totalCoursesLabel.Location = new System.Drawing.Point(0, 104);
            this.totalCoursesLabel.Name = "totalCoursesLabel";
            this.totalCoursesLabel.Size = new System.Drawing.Size(126, 23);
            this.totalCoursesLabel.TabIndex = 19;
            this.totalCoursesLabel.Text = "Total Courses Selected:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.Location = new System.Drawing.Point(6, 23);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(85, 23);
            this.paymentTypeLabel.TabIndex = 18;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // expirationMaskedTextBox
            // 
            this.expirationMaskedTextBox.Location = new System.Drawing.Point(107, 69);
            this.expirationMaskedTextBox.Mask = "00/00/0000";
            this.expirationMaskedTextBox.Name = "expirationMaskedTextBox";
            this.expirationMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.expirationMaskedTextBox.TabIndex = 17;
            this.expirationMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expirationMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(107, 46);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardNumberTextBox.TabIndex = 16;
            this.cardNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // expirationLabel
            // 
            this.expirationLabel.Location = new System.Drawing.Point(6, 66);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(100, 23);
            this.expirationLabel.TabIndex = 3;
            this.expirationLabel.Text = "Expiration Date:";
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.Location = new System.Drawing.Point(6, 46);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(85, 20);
            this.cardNumberLabel.TabIndex = 2;
            this.cardNumberLabel.Text = "Card Number:";
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.Location = new System.Drawing.Point(197, 19);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(61, 24);
            this.visaRadioButton.TabIndex = 15;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(107, 19);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(84, 24);
            this.masterCardRadioButton.TabIndex = 14;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Maxwell_2.Properties.Resources.hello_in_eight_different_languages_185250085_5941fb8c3df78c537b32ecac;
            this.pictureBox1.Location = new System.Drawing.Point(-36, -59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 182);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(4, 442);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 36);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Sa&ve";
            this.saveToolTip.SetToolTip(this.saveButton, "Click Here To Save For Later and See The Order Summary");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(255, 442);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 36);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "&Clear";
            this.clearToolTip.SetToolTip(this.clearButton, "Click Here To Clear The Form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(473, 442);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 36);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "E&xit";
            this.exitToolTip.SetToolTip(this.exitButton, "Click Here To Close The Program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CourseOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 490);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.paymentInformationGroupBox);
            this.Controls.Add(this.courseOrderInformationGroupBox);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.termInformationGroupBox);
            this.Name = "CourseOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Language Course Order Form";
            this.Load += new System.EventHandler(this.CourseOrderForm_Load);
            this.termInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.courseOrderInformationGroupBox.ResumeLayout(false);
            this.paymentInformationGroupBox.ResumeLayout(false);
            this.paymentInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox termInformationGroupBox;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.GroupBox courseOrderInformationGroupBox;
        private System.Windows.Forms.GroupBox paymentInformationGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.ComboBox termYearComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.MaskedTextBox studentIDMaskedTextBox;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.MaskedTextBox expirationMaskedTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.Label expirationLabel;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip saveToolTip;
        private System.Windows.Forms.ToolTip clearToolTip;
        private System.Windows.Forms.ToolTip exitToolTip;
        private System.Windows.Forms.Label selectTermYearLabel;
        private System.Windows.Forms.Label selectATermLabel;
        private System.Windows.Forms.Label residencyLabel;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label numberOfCoursesSelectedLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label totalCoursesLabel;
        private System.Windows.Forms.Label inStateLabel;
        private System.Windows.Forms.Label outOfStateLabel;
        private System.Windows.Forms.Label outOfStateChargeLabel;
        private System.Windows.Forms.Label inStateChargeLabel;
        private System.Windows.Forms.Label chargePerCourseLabel;
        private System.Windows.Forms.CheckBox beginningRussianCheckBox;
        private System.Windows.Forms.CheckBox beginningSpanishCheckBox;
        private System.Windows.Forms.CheckBox beginningItalianCheckBox;
        private System.Windows.Forms.CheckBox beginningGermanCheckBox;
        private System.Windows.Forms.CheckBox beginningFrenchCheckBox;
        private System.Windows.Forms.RadioButton fallRadioButton;
    }
}

