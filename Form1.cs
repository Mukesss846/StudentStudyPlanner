namespace StudentStudyPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) ||
    string.IsNullOrWhiteSpace(txtAssignmentTitle.Text) ||
    string.IsNullOrWhiteSpace(cmbPriority.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            Assignment assignment = new Assignment();

            assignment.Subject = txtSubject.Text;
            assignment.Title = txtAssignmentTitle.Text;
            assignment.DueDate = dtpDueDate.Value;
            assignment.Priority = cmbPriority.Text;
            assignment.Status = "Pending";

            MessageBox.Show("Assignment created successfully!");
        }
    }
}
