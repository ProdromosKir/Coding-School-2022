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
using System.Text.Json;
using System.IO;

namespace Session_07
{
    public partial class BasicForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "students.json";

        private University.University university = new University.University();

        //public BasicForm Form { get; set; }

        public string Name { get; set; }


        public BasicForm()
        {
            InitializeComponent();
           // this.ShowDialog();
            
            
        }

        //public void CreateForm()
        //{
        //    Form = new BasicForm();
        //    Form.Show();
        //}

        public void btnClose_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BasicForm_Load(object sender, EventArgs e)
        {
            var pro = new Student()
            {
                Name = "Pro",
                Age = 21

            };

            university.Students.Add(pro);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(university);

            File.WriteAllText(FILE_NAME, json);

            MessageBox.Show("Saved");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string s  = File.ReadAllText(FILE_NAME);
            university = (University.University)JsonSerializer.Deserialize(s, typeof(University.University)); ;
        }
    }
}