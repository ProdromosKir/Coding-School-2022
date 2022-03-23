using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace Session_07
{
    public partial class StudentForm : Form
    //DevExpress.XtraEditors.XtraForm
    {


        //public List<Student> Students { get; set; } 

        //private Student _selectedStudent;
        //private Student _originalStudent;

        private const string STUDENT_FILE_NAME = "student.json";

        private University.University _university;

        


        
        public StudentForm()
        {
            InitializeComponent();
           

           
          


        }

        

        private void StudentForm_Load(object sender, EventArgs e)
        {
            _university = new University.University();
            _university.Students = new List<Student>();

            bsStudents.DataSource = _university;
            bsStudents.DataMember = "Students";

            
            grdStudents.DataSource=bsStudents;
           




           

            //ctrlName.DataBindings.Add(new Binding("EditValue", bsStudents, "Name", true));
           // ctrlAge.DataBindings.Add(new Binding("EditValue", bsStudents, "Age", true));





            //ShowList();

            //Button button = new Button()
            //{
            //    Location = new System.Drawing.Point(447, 172),
            //    Name = "button1",
            //    Size = new System.Drawing.Size(75, 23),
            //    TabIndex = 0,
            //    Text = "button1",
            //    UseVisualStyleBackColor = true
            //};

            //this.Controls.Add(button);



        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string json = JsonSerializer.Serialize(_university);
            File.WriteAllText(STUDENT_FILE_NAME, json);
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //private void lstStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    SelectStudent();

        //    DisplayStudent();
        //}




        //private void DisplayStudent()
        //{
        //    if (_selectedStudent != null)
        //    {
        //        txtName.Text = _selectedStudent.Name;
        //        txtAge.Text = _selectedStudent.Age.ToString();

        //    }
        //    else
        //    {
        //        txtName.Text = string.Empty;
        //        txtAge.Text = "0";
        //    }

        //}

        //private void SelectStudent()
        //{
        //    //prepei na mhn einai null
        //    if(_selectedStudent!=null)
        //    {
        //        _selectedStudent = Students[lstStudents.SelectedIndex];
        //    }


        //}






        //private void UpdateStud()
        //{
        //    if(_selectedStudent!=null)
        //    {
        //        _originalStudent = _selectedStudent.ShallowCopy();

        //        _selectedStudent.Name = txtName.Text;
        //        _selectedStudent.Age = Convert.ToInt32(txtAge.Text);
        //    }



        //}

        //private void ShowList()
        //{
        //    lstStudents.Items.Clear();



        //        //foreach (Student item in Students)
        //        //{
        //        //    if (item != null)
        //        //        lstStudents.Items.Add(string.Format("{0}", item.Name));

        //        //    //ama einai null i lista tha prepei na ftiaxnei enan student kai na 
        //        //    //ton bazei stin lista
        //        //}



        //}











        //private void DeleteStudent()
        //{
        //    if(_selectedStudent != null)
        //    {
        //        Students.Remove(_selectedStudent);
        //        _selectedStudent = null;
        //        ShowList();
        //    }
        //    DisplayStudent();


        //}


        //private void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DeleteStudent();
        //}



        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.OK;
        //}


        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    UpdateStud();
        //    ShowList();

        //}

        //private void btnNew_Click(object sender, EventArgs e)
        //{
        //    // Student student = CreateStudent();
        //    Student student = new Student();

        //    student.Name = txtName.Text;
        //    student.Age = Convert.ToInt32(txtAge.Text);
        //    Students.Add(student);

        //    ShowList();

        //    //piganei sto index to kainoyrgio
        //    lstStudents.SelectedIndex = Students.IndexOf(student);


        //}

        //private Student CreateStudent()
        //{
        //    StudentManager manager = new StudentManager();
        //    manager.Students = Students;

        //    Student student = manager.AddStudent();
        //    return student;

        //}









    }
}