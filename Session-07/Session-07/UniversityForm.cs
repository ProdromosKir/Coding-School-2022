
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
using University;




namespace Session_07
{
    

    public partial class UniversityForm : DevExpress.XtraEditors.XtraForm
    {
        University.University university = new University.University();
        Student student = new Student();

        



        private const string STUDENT_FILE_NAME = "student.json";



        public UniversityForm()
        {
            InitializeComponent();
            
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Loaded OK!");


        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        private void LoadData()
        {
            string s = File.ReadAllText(STUDENT_FILE_NAME);
            student = (Student)JsonSerializer.Deserialize(s,typeof(Student));
            
        }


        private void SaveData()
        {
            string json = JsonSerializer.Serialize(student);
            File.WriteAllText(STUDENT_FILE_NAME, json);
            MessageBox.Show("File Saved!");


        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editStudentClick(object sender, EventArgs e)
        {
            //CreateForm();

            StudentForm studentForm = new StudentForm();

            if (university.Students!=null && university.Students.Count>0)
            {
                
                studentForm.Students = university.Students;
                studentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Students are not loaded", "Warning", MessageBoxButtons.OK);

                studentForm.ShowDialog();
                //university.Students.Add(student)

               // BasicForm form = new BasicForm();
               // form.ShowDialog();
            }
           
        }

       

        private void editProfessor_Click(object sender, EventArgs e)
        {
            ProfessorForm professorForm = new ProfessorForm();
            professorForm.Show();
        }


        private void editGrade_Click(object sender, EventArgs e)
        {
            GradeForm gradeForm = new GradeForm();
            gradeForm.Show();
        }


        private void editCourse_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
        }

        private void editSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm  scheduleForm = new ScheduleForm();
            scheduleForm.Show();
        }

        private void UniversityForm_Load(object sender, EventArgs e)
        {
            
        }




        
    }
}
