using PetShopLib.Impl;
using Session15.EF.Repositories;

namespace Session_15
{
    public partial class Main : Form
    {
        private readonly IEntityRepo<Employee> _employeeRepo;

        private List<Employee> _employees = new List<Employee>();

        public Main(IEntityRepo<Employee> employeeRepo)
        {
            InitializeComponent();
            _employeeRepo = employeeRepo;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshEmployees();
        }

        private void RefreshEmployees()
        {
            _employees = _employeeRepo.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _employees;
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var employeeName = txtName.Text;
            var employeeSurname = txtSurname.Text;
            var employeeSalaryString = txtSalaryPerMonth.Text;

            decimal employeeSalary = Convert.ToDecimal(employeeSalaryString);

            if (string.IsNullOrEmpty(employeeName)||string.IsNullOrEmpty(employeeSurname))
                return;
            var employee = new Employee(employeeName, employeeSurname, employeeSalary);
            _employeeRepo.Create(employee);
            txtName.Text = String.Empty; txtSurname.Text = String.Empty;
            RefreshEmployees();


           
        }
    }
}