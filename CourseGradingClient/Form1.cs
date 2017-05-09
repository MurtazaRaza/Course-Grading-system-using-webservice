using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseGradingClient
{
    public partial class Form1 : Form
    {
        //static int student_id = 1;
        static int assessment_id = 1;

        private static readonly string FOLDER_PATH_LOG = @"D:\mlog.txt";

        public Form1()
        {
            InitializeComponent();
            RefreshContent();
        }

        private void RefreshContent()
        {
            this.ChooseAssessment.Items.Clear();
            var client = new ServiceReference1.Service1Client();
            string[] assessmentType = client.ExecuteQueryReturningMultiple("select [Assessment Type] from Assessment;");
            string[] dates = client.ExecuteQueryReturningMultiple("select [Date] from Assessment;");
            int[] marks = client.ExecuteQueryReturningMultipleInt("select [Maximum Marks] from Assessment;");


            for (int i = 0; i < assessmentType.Length; i++)
            {
                this.ChooseAssessment.Items.Add(assessmentType[i] + "||" + dates[i] + "||" + marks[i]);
            }

        }

        private void AddStudent(String frstName, String lstName)
        {
            var client = new ServiceReference1.Service1Client();

            //Student_ID here is auto increment
            //If not auto incremented uncomment student_id parts and comment query below
            client.ExecuteQuery("insert into student([First Name], [Last Name]) values ('" + frstName + "', '" + lstName + "');");
            
            //client.ExecuteQuery("insert into student  values ("+ student_id +", '" + frstName + "', '" + lstName + "');");

            //student_id++;
        }

        private void AddAssessment(String type, String date, String marks)
        {
            //Assessment id here is auto increment
            //If not auto incremented uncomment assessment_id parts and comment query below
            var client = new ServiceReference1.Service1Client();

            client.ExecuteQuery("insert into assessment ([Assessment type], [Date], [Maximum Marks]) values ('" + type + "', '" + date + "', " + marks + ");");
            //client.ExecuteQuery("insert into assessment values (" + assessment_id + ",'" + type + "', '" +date + "', " + marks + ");" );
            assessment_id++;
        }

        private void AddAssessmentMarks(string FirstName, string LastName, string Marks)
        {
            char[] separatingChars = { '|' };
            string[] AssessmentDetails = this.ChooseAssessment.Text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);
            //AssessmentDetails[0] = Type, AssessmentDetails[1] = Date, AssessmentDetails[2] = Max marks

            var client = new ServiceReference1.Service1Client();

            client.ExecuteQuery("insert into [Student_Assessment] ([Student ID], [Assessment ID], [Marks]) values((select[Student ID] from[Student] where[First Name] = '"+ FirstName +"' And[Last Name] = '"+ LastName +"'),(select[Assessment_Id] from[Assessment] where[Assessment Type] = '" +AssessmentDetails[0] +"'AND[Date] = '"+AssessmentDetails[1]+"' And[Maximum Marks] = "+AssessmentDetails[2] +"), "+ Marks +"  ); ");




            MessageBox.Show("Marks Updated! ");
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SingleStudentAddButton_Click(object sender, EventArgs e)
        {
            if (this.SingleStudentFirstText.Text.Equals("") || this.SingleStudentLastText.Text.Equals(""))
            {
                MessageBox.Show("Input Missing");
            }
            else
            {
                AddStudent(this.SingleStudentFirstText.Text, this.SingleStudentLastText.Text);
                this.SingleStudentFirstText.Text = "";
                this.SingleStudentLastText.Text = "";

                MessageBox.Show("Student Added!");
            }
        }

        private void MultiStudentAddButton_Click(object sender, EventArgs e)
        {
            if (this.MultiStudentText.Text.Equals(""))
            {
                MessageBox.Show("Input Missing");
            }
            else
            {
                char[] separatingChars = { ' ', ',', '.', ':', '\t', '\n', '\r' };
                string[] StudentNames = this.MultiStudentText.Text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

                int i = 0;
                while (i < StudentNames.Length)
                {
                    AddStudent(StudentNames[i++], StudentNames[i++]);
                }
                this.MultiStudentText.Text = "";
                MessageBox.Show("Student(s) Added!");
            }
        }

        private void AssessmentAddButton_Click(object sender, EventArgs e)
        {
            if (this.AssessmentTypeText.Text.Equals("") || this.dateTimePicker1.Text.Equals("") || this.AssessmentMarksText.Text.Equals(""))
            {
                MessageBox.Show("Input Missing");
            }
            else
            {
                var client = new ServiceReference1.Service1Client();
                String queryReply = client.ExecuteScalerQuery("select sum([Maximum Marks]) from assessment;");
                //LogService(queryReply);


                //If sum of marks plus current assessment marks are greater than 100 do'nt insert and let user know

                int MarksInTable = 0;
                if (Int32.TryParse(queryReply, out MarksInTable))
                {
                    MarksInTable = Int32.Parse(queryReply);
                }

                if (MarksInTable + Int32.Parse(this.AssessmentMarksText.Text) <= 100)
                {
                    AddAssessment(this.AssessmentTypeText.Text, this.dateTimePicker1.Text, this.AssessmentMarksText.Text);
                    MessageBox.Show("Assessment Added");
                }
                else
                {
                    MessageBox.Show("Only " + (100 - Int32.Parse(queryReply)) + " marks left in the course");
                }

                RefreshContent();
            }
        }

        private void StudentsAssessmentMarksButton_Click(object sender, EventArgs e)
        {
            if (this.StudentsAssessmentMarks.Text.Equals(""))
            {
                MessageBox.Show("Input Missing");
            }
            else
            {
                char[] separatingChars = { ' ', ',', '.', ':', '\t', '\n', '\r' };
                string[] nameAndMarks = this.StudentsAssessmentMarks.Text.Split(separatingChars, System.StringSplitOptions.RemoveEmptyEntries);

                int i = 0;
                while (i < nameAndMarks.Length)
                {
                    AddAssessmentMarks(nameAndMarks[i++], nameAndMarks[i++], nameAndMarks[i++]);
                    //LogService(nameAndMarks[i++] +" " +nameAndMarks[i++] + " " +nameAndMarks[i++]);
                }
                this.StudentsAssessmentMarks.Text = "";
            }
        }

        private void PrintMarks_Click(object sender, EventArgs e)
        {
            this.ResultText.Text = "";
            var client = new ServiceReference1.Service1Client();
            int[] studentIds = client.ExecuteQueryReturningMultipleInt("select [Student ID] from Student;");

            String totalMarks = client.ExecuteScalerQuery("select sum([Maximum Marks]) from Assessment;");
            foreach (int id in studentIds)
            {
                this.ResultText.Text += client.ExecuteScalerQuery("select [First Name] from Student where [Student ID] = " + id + ";");
                this.ResultText.Text += " \t\t";
                this.ResultText.Text += client.ExecuteScalerQuery("select [Last Name] from Student where [Student ID] = " + id + ";");
                this.ResultText.Text += " \t\t";
                this.ResultText.Text += client.ExecuteScalerQuery("select sum(Marks) from [Student_Assessment] where [Student ID] =" + id + ";")?? "0";
                this.ResultText.Text += "/";
                this.ResultText.Text += totalMarks + "\t";
                this.ResultText.Text += client.ExecuteScalerQuery("select sum(Marks)*100/(select sum([Maximum Marks]) from Assessment) from [Student_Assessment] where [Student ID] =" + id + ";") +"%"+ System.Environment.NewLine;
            }
        }


        private void FinalGrade_Click(object sender, EventArgs e)
        {
            var client = new ServiceReference1.Service1Client();
            String queryReply = client.ExecuteScalerQuery("select sum([Maximum Marks]) from assessment;");
            


            //If sum of marks equals a 100 proceed else not

            int MarksInTable = 0;
            if (Int32.TryParse(queryReply, out MarksInTable))
            {
                MarksInTable = Int32.Parse(queryReply);
            }
            

            if (MarksInTable <100)
            {
               
                MessageBox.Show("Assessments don't total to 100");
            }
            else
            {
                GenerateGrades();
            }
        }

        private void GenerateGrades()
        {
            var client = new ServiceReference1.Service1Client();
            int[] studentIds = client.ExecuteQueryReturningMultipleInt("select [Student ID] from Student;");
            String queryReply = client.ExecuteScalerQuery("select count([Assessment_Id]) from assessment where [Maximum Marks] <> 0;");
            this.GradeText.Text = "";

            //if (count(assessment Id in assessment == count student Id in student_assessment)
            int AssessmentCount = 0;
            if (Int32.TryParse(queryReply, out AssessmentCount))
            {
                AssessmentCount = Int32.Parse(queryReply);
            }
            
            foreach (int id in studentIds)
            {
                queryReply = client.ExecuteScalerQuery("select count([Student ID]) from Student_Assessment where [Student ID] = "+id +";");

                int StudentCount = 0;
                if (Int32.TryParse(queryReply, out StudentCount))
                {
                    StudentCount = Int32.Parse(queryReply);
                }
                
                if (AssessmentCount == StudentCount)
                {
                    queryReply = client.ExecuteScalerQuery("select sum([Marks]) from Student_Assessment where [Student ID] = " + id + ";");
                    int SumMarks = 0;
                    if (Int32.TryParse(queryReply, out SumMarks))
                    {
                        SumMarks = Int32.Parse(queryReply);
                    }
                    
                    
                    if(SumMarks >= 86)
                    {
                        this.GradeText.Text += "A" + System.Environment.NewLine;
                    }
                    else if (SumMarks >75)
                    {
                        this.GradeText.Text += "B" + System.Environment.NewLine;
                    }
                    else if (SumMarks > 62)
                    {
                        this.GradeText.Text += "C" + System.Environment.NewLine;
                    }
                    else if (SumMarks > 50)
                    {
                        this.GradeText.Text += "D" + System.Environment.NewLine;
                    }
                    else
                    {
                        this.GradeText.Text += "F" + System.Environment.NewLine;
                    }

                }
                else
                {
                    this.GradeText.Text += "-" + System.Environment.NewLine;
                }

            }


        }

        private static void LogService(string content)
        {
            try
            {


                FileStream fs = new FileStream(FOLDER_PATH_LOG, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.WriteLine(content);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {

            }
        }

        
    }
}
