namespace Session_07
{
    partial class UniversityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversityForm));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStudent = new System.Windows.Forms.ToolStripDropDownButton();
            this.editStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProfessor = new System.Windows.Forms.ToolStripDropDownButton();
            this.editProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGrade = new System.Windows.Forms.ToolStripDropDownButton();
            this.editGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCourse = new System.Windows.Forms.ToolStripDropDownButton();
            this.editCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSchedule = new System.Windows.Forms.ToolStripDropDownButton();
            this.editSchedule = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(180, 120);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 120);
            this.Root.TextVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripStudent,
            this.toolStripProfessor,
            this.toolStripGrade,
            this.toolStripCourse,
            this.toolStripSchedule});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(38, 22);
            this.toolStripFile.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripStudent
            // 
            this.toolStripStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editStudent});
            this.toolStripStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStudent.Image")));
            this.toolStripStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStudent.Name = "toolStripStudent";
            this.toolStripStudent.Size = new System.Drawing.Size(61, 22);
            this.toolStripStudent.Text = "Student";
            // 
            // editStudent
            // 
            this.editStudent.Name = "editStudent";
            this.editStudent.Size = new System.Drawing.Size(94, 22);
            this.editStudent.Text = "Edit";
            this.editStudent.Click += new System.EventHandler(this.editStudentClick);
            // 
            // toolStripProfessor
            // 
            this.toolStripProfessor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripProfessor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfessor});
            this.toolStripProfessor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripProfessor.Image")));
            this.toolStripProfessor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripProfessor.Name = "toolStripProfessor";
            this.toolStripProfessor.Size = new System.Drawing.Size(69, 22);
            this.toolStripProfessor.Text = "Professor";
            // 
            // editProfessor
            // 
            this.editProfessor.Name = "editProfessor";
            this.editProfessor.Size = new System.Drawing.Size(94, 22);
            this.editProfessor.Text = "Edit";
            this.editProfessor.Click += new System.EventHandler(this.editProfessor_Click);
            // 
            // toolStripGrade
            // 
            this.toolStripGrade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGrade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGrade});
            this.toolStripGrade.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGrade.Image")));
            this.toolStripGrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGrade.Name = "toolStripGrade";
            this.toolStripGrade.Size = new System.Drawing.Size(51, 22);
            this.toolStripGrade.Text = "Grade";
            // 
            // editGrade
            // 
            this.editGrade.Name = "editGrade";
            this.editGrade.Size = new System.Drawing.Size(94, 22);
            this.editGrade.Text = "Edit";
            this.editGrade.Click += new System.EventHandler(this.editGrade_Click);
            // 
            // toolStripCourse
            // 
            this.toolStripCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCourse});
            this.toolStripCourse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCourse.Image")));
            this.toolStripCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCourse.Name = "toolStripCourse";
            this.toolStripCourse.Size = new System.Drawing.Size(57, 22);
            this.toolStripCourse.Text = "Course";
            // 
            // editCourse
            // 
            this.editCourse.Name = "editCourse";
            this.editCourse.Size = new System.Drawing.Size(94, 22);
            this.editCourse.Text = "Edit";
            this.editCourse.Click += new System.EventHandler(this.editCourse_Click);
            // 
            // toolStripSchedule
            // 
            this.toolStripSchedule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSchedule});
            this.toolStripSchedule.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSchedule.Image")));
            this.toolStripSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSchedule.Name = "toolStripSchedule";
            this.toolStripSchedule.Size = new System.Drawing.Size(68, 22);
            this.toolStripSchedule.Text = "Schedule";
            // 
            // editSchedule
            // 
            this.editSchedule.Name = "editSchedule";
            this.editSchedule.Size = new System.Drawing.Size(94, 22);
            this.editSchedule.Text = "Edit";
            this.editSchedule.Click += new System.EventHandler(this.editSchedule_Click);
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataLayoutControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("UniversityForm.IconOptions.LargeImage")));
            this.Name = "UniversityForm";
            this.Text = "University";
            this.Load += new System.EventHandler(this.UniversityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripStudent;
        private System.Windows.Forms.ToolStripDropDownButton toolStripProfessor;
        private System.Windows.Forms.ToolStripDropDownButton toolStripGrade;
        private System.Windows.Forms.ToolStripDropDownButton toolStripCourse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSchedule;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudent;
        private System.Windows.Forms.ToolStripMenuItem editProfessor;
        private System.Windows.Forms.ToolStripMenuItem editGrade;
        private System.Windows.Forms.ToolStripMenuItem editCourse;
        private System.Windows.Forms.ToolStripMenuItem editSchedule;
    }
}

