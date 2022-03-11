using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace Session_07
{
    public partial class StudentForm : DevExpress.XtraEditors.XtraForm
    {

        private University.University _university = new University.University();

        public List<Student> Students { get; set; }

        private Student _selectedStudent;
        private Student _originalStudent;


        BasicForm basicForm;
        public StudentForm()
        {
            //new BasicForm();

            //this.basicForm = new BasicForm();
            //basicForm.ShowDialog();



            InitializeComponent();
            basicForm = new BasicForm();
            this.Text = "Student";





        }

        

        private void StudentForm_Load(object sender, EventArgs e)
        {

            ShowList();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateStud();
            ShowList();

        }

        private void ShowList()
        {
            lstStudents.Items.Clear();  
            
            foreach(Student item in _university.Students)
            {
                if(item!=null)
                {
                    lstStudents.Items.Add(string.Format("{0}", item.Name));
                }
            }
        }

        private void UpdateStud()
        {

            _originalStudent = _selectedStudent.ShallowCopy();

            _selectedStudent.Name = txtName.Text;
            _selectedStudent.Age = Convert.ToInt32(txtAge.Text);
        }



        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudent();

            DisplayStudent();
        }

        private void SelectStudent()
        {
            if (_selectedStudent != null)
                _selectedStudent = Students[lstStudents.SelectedIndex];
        }




        private void DisplayStudent()
        {
            if(_selectedStudent!=null)
            {
                txtName.Text = _selectedStudent.Name;
                txtAge.Text = _selectedStudent.Age.ToString();
            }
            else
            {
                txtName.Text = String.Empty;
                txtAge.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void DeleteStudent()
        {
            if(_selectedStudent != null)
            {
                Students.Remove(_selectedStudent);
                _selectedStudent = null;
                ShowList();
            }

            DisplayStudent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Student student = CreateStudent();
            ShowList();
            lstStudents.SelectedIndex = Students.IndexOf(student);
        }

        internal Student CreateStudent()
        {
            University.StudentManager manager = new University.StudentManager();
            manager.Students = Students;

            Student student = manager.AddStudent();
            return student;
        }
    }
}