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
using University;

namespace Session_07
{
    public partial class BasicForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "students.json";

        

       

        public string Name { get; set; }


        public BasicForm()
        {
            InitializeComponent();
          
            
            
        }





        private void BasicForm_Load(object sender, EventArgs e)
        {

        }






        public void btnClose_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
          
        }
    }
}