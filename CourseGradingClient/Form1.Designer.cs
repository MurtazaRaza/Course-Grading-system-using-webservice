namespace CourseGradingClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MultiStudentAddButton = new System.Windows.Forms.Button();
            this.MultiStudentsLabel = new System.Windows.Forms.Label();
            this.MultiStudentText = new System.Windows.Forms.TextBox();
            this.LastNameSingle = new System.Windows.Forms.Label();
            this.FirstNameSingle = new System.Windows.Forms.Label();
            this.SingleStudentLastText = new System.Windows.Forms.TextBox();
            this.SingleStudentAddButton = new System.Windows.Forms.Button();
            this.SingleStudentFirstText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AssessmentTypeText = new System.Windows.Forms.ComboBox();
            this.AssessmentAddButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AssessmentMarksText = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.StudentsAssessmentMarksButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentsAssessmentMarks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChooseAssessment = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GradeText = new System.Windows.Forms.TextBox();
            this.PrintMarks = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.FinalGrade = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(429, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 250);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Controls.Add(this.MultiStudentAddButton);
            this.tabPage1.Controls.Add(this.MultiStudentsLabel);
            this.tabPage1.Controls.Add(this.MultiStudentText);
            this.tabPage1.Controls.Add(this.LastNameSingle);
            this.tabPage1.Controls.Add(this.FirstNameSingle);
            this.tabPage1.Controls.Add(this.SingleStudentLastText);
            this.tabPage1.Controls.Add(this.SingleStudentAddButton);
            this.tabPage1.Controls.Add(this.SingleStudentFirstText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            // 
            // MultiStudentAddButton
            // 
            this.MultiStudentAddButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MultiStudentAddButton.Location = new System.Drawing.Point(283, 195);
            this.MultiStudentAddButton.Name = "MultiStudentAddButton";
            this.MultiStudentAddButton.Size = new System.Drawing.Size(88, 23);
            this.MultiStudentAddButton.TabIndex = 7;
            this.MultiStudentAddButton.Text = "Add Student(s)";
            this.MultiStudentAddButton.UseVisualStyleBackColor = false;
            this.MultiStudentAddButton.Click += new System.EventHandler(this.MultiStudentAddButton_Click);
            // 
            // MultiStudentsLabel
            // 
            this.MultiStudentsLabel.AutoSize = true;
            this.MultiStudentsLabel.Location = new System.Drawing.Point(20, 99);
            this.MultiStudentsLabel.Name = "MultiStudentsLabel";
            this.MultiStudentsLabel.Size = new System.Drawing.Size(148, 13);
            this.MultiStudentsLabel.TabIndex = 6;
            this.MultiStudentsLabel.Text = "FirstName *space* Last Name";
            // 
            // MultiStudentText
            // 
            this.MultiStudentText.Location = new System.Drawing.Point(23, 115);
            this.MultiStudentText.Multiline = true;
            this.MultiStudentText.Name = "MultiStudentText";
            this.MultiStudentText.Size = new System.Drawing.Size(237, 103);
            this.MultiStudentText.TabIndex = 5;
            // 
            // LastNameSingle
            // 
            this.LastNameSingle.AutoSize = true;
            this.LastNameSingle.Location = new System.Drawing.Point(19, 48);
            this.LastNameSingle.Name = "LastNameSingle";
            this.LastNameSingle.Size = new System.Drawing.Size(58, 13);
            this.LastNameSingle.TabIndex = 4;
            this.LastNameSingle.Text = "Last Name";
            // 
            // FirstNameSingle
            // 
            this.FirstNameSingle.AutoSize = true;
            this.FirstNameSingle.Location = new System.Drawing.Point(20, 6);
            this.FirstNameSingle.Name = "FirstNameSingle";
            this.FirstNameSingle.Size = new System.Drawing.Size(57, 13);
            this.FirstNameSingle.TabIndex = 3;
            this.FirstNameSingle.Text = "First Name";
            this.FirstNameSingle.Click += new System.EventHandler(this.label1_Click);
            // 
            // SingleStudentLastText
            // 
            this.SingleStudentLastText.Location = new System.Drawing.Point(23, 61);
            this.SingleStudentLastText.Name = "SingleStudentLastText";
            this.SingleStudentLastText.Size = new System.Drawing.Size(237, 20);
            this.SingleStudentLastText.TabIndex = 2;
            // 
            // SingleStudentAddButton
            // 
            this.SingleStudentAddButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SingleStudentAddButton.Location = new System.Drawing.Point(283, 61);
            this.SingleStudentAddButton.Name = "SingleStudentAddButton";
            this.SingleStudentAddButton.Size = new System.Drawing.Size(88, 23);
            this.SingleStudentAddButton.TabIndex = 1;
            this.SingleStudentAddButton.Text = "Add Student";
            this.SingleStudentAddButton.UseVisualStyleBackColor = false;
            this.SingleStudentAddButton.Click += new System.EventHandler(this.SingleStudentAddButton_Click);
            // 
            // SingleStudentFirstText
            // 
            this.SingleStudentFirstText.Location = new System.Drawing.Point(23, 22);
            this.SingleStudentFirstText.Name = "SingleStudentFirstText";
            this.SingleStudentFirstText.Size = new System.Drawing.Size(237, 20);
            this.SingleStudentFirstText.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.AssessmentTypeText);
            this.tabPage2.Controls.Add(this.AssessmentAddButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.AssessmentMarksText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(392, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assessments";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // AssessmentTypeText
            // 
            this.AssessmentTypeText.FormattingEnabled = true;
            this.AssessmentTypeText.Items.AddRange(new object[] {
            "Quiz",
            "Assignment",
            "Mid Term ",
            "Final"});
            this.AssessmentTypeText.Location = new System.Drawing.Point(27, 43);
            this.AssessmentTypeText.Name = "AssessmentTypeText";
            this.AssessmentTypeText.Size = new System.Drawing.Size(121, 21);
            this.AssessmentTypeText.TabIndex = 8;
            // 
            // AssessmentAddButton
            // 
            this.AssessmentAddButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AssessmentAddButton.Location = new System.Drawing.Point(275, 141);
            this.AssessmentAddButton.Name = "AssessmentAddButton";
            this.AssessmentAddButton.Size = new System.Drawing.Size(101, 23);
            this.AssessmentAddButton.TabIndex = 7;
            this.AssessmentAddButton.Text = "Add Assessment";
            this.AssessmentAddButton.UseVisualStyleBackColor = false;
            this.AssessmentAddButton.Click += new System.EventHandler(this.AssessmentAddButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Assessment Type";
            // 
            // AssessmentMarksText
            // 
            this.AssessmentMarksText.Location = new System.Drawing.Point(27, 141);
            this.AssessmentMarksText.Name = "AssessmentMarksText";
            this.AssessmentMarksText.Size = new System.Drawing.Size(100, 20);
            this.AssessmentMarksText.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.StudentsAssessmentMarksButton);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.StudentsAssessmentMarks);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.ChooseAssessment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(392, 224);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Marks";
            // 
            // StudentsAssessmentMarksButton
            // 
            this.StudentsAssessmentMarksButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StudentsAssessmentMarksButton.Location = new System.Drawing.Point(314, 185);
            this.StudentsAssessmentMarksButton.Name = "StudentsAssessmentMarksButton";
            this.StudentsAssessmentMarksButton.Size = new System.Drawing.Size(75, 23);
            this.StudentsAssessmentMarksButton.TabIndex = 4;
            this.StudentsAssessmentMarksButton.Text = "Submit";
            this.StudentsAssessmentMarksButton.UseVisualStyleBackColor = false;
            this.StudentsAssessmentMarksButton.Click += new System.EventHandler(this.StudentsAssessmentMarksButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Name *space* Last Name *space* Marks";
            // 
            // StudentsAssessmentMarks
            // 
            this.StudentsAssessmentMarks.Location = new System.Drawing.Point(29, 106);
            this.StudentsAssessmentMarks.Multiline = true;
            this.StudentsAssessmentMarks.Name = "StudentsAssessmentMarks";
            this.StudentsAssessmentMarks.Size = new System.Drawing.Size(279, 102);
            this.StudentsAssessmentMarks.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saved Assessments";
            // 
            // ChooseAssessment
            // 
            this.ChooseAssessment.FormattingEnabled = true;
            this.ChooseAssessment.Location = new System.Drawing.Point(29, 33);
            this.ChooseAssessment.Name = "ChooseAssessment";
            this.ChooseAssessment.Size = new System.Drawing.Size(279, 21);
            this.ChooseAssessment.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.GradeText);
            this.tabPage3.Controls.Add(this.PrintMarks);
            this.tabPage3.Controls.Add(this.ResultText);
            this.tabPage3.Controls.Add(this.FinalGrade);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grades";
            // 
            // GradeText
            // 
            this.GradeText.Location = new System.Drawing.Point(294, 71);
            this.GradeText.Multiline = true;
            this.GradeText.Name = "GradeText";
            this.GradeText.Size = new System.Drawing.Size(92, 147);
            this.GradeText.TabIndex = 3;
            // 
            // PrintMarks
            // 
            this.PrintMarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PrintMarks.Location = new System.Drawing.Point(6, 6);
            this.PrintMarks.Name = "PrintMarks";
            this.PrintMarks.Size = new System.Drawing.Size(282, 59);
            this.PrintMarks.TabIndex = 2;
            this.PrintMarks.Text = "Print Marks";
            this.PrintMarks.UseVisualStyleBackColor = false;
            this.PrintMarks.Click += new System.EventHandler(this.PrintMarks_Click);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(6, 71);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(282, 147);
            this.ResultText.TabIndex = 1;
            // 
            // FinalGrade
            // 
            this.FinalGrade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FinalGrade.Location = new System.Drawing.Point(294, 6);
            this.FinalGrade.Name = "FinalGrade";
            this.FinalGrade.Size = new System.Drawing.Size(92, 59);
            this.FinalGrade.TabIndex = 0;
            this.FinalGrade.Text = "Generate Final Grade";
            this.FinalGrade.UseVisualStyleBackColor = false;
            this.FinalGrade.Click += new System.EventHandler(this.FinalGrade_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 36);
            this.label7.MaximumSize = new System.Drawing.Size(55, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 130);
            this.label7.TabIndex = 5;
            this.label7.Text = "Note: Make sure you use correct names. Check Grade Tab for list\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 274);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label FirstNameSingle;
        private System.Windows.Forms.TextBox SingleStudentLastText;
        private System.Windows.Forms.Button SingleStudentAddButton;
        private System.Windows.Forms.TextBox SingleStudentFirstText;
        private System.Windows.Forms.Label LastNameSingle;
        private System.Windows.Forms.Button MultiStudentAddButton;
        private System.Windows.Forms.Label MultiStudentsLabel;
        private System.Windows.Forms.TextBox MultiStudentText;
        private System.Windows.Forms.TextBox AssessmentMarksText;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AssessmentAddButton;
        private System.Windows.Forms.ComboBox AssessmentTypeText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button StudentsAssessmentMarksButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StudentsAssessmentMarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ChooseAssessment;
        private System.Windows.Forms.Button PrintMarks;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button FinalGrade;
        private System.Windows.Forms.TextBox GradeText;
        private System.Windows.Forms.Label label7;
    }
}

