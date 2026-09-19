namespace StudentStudyPlanner
{
    public partial class Form1 : Form
    {
        private List<Assignment> assignments = new List<Assignment>();
        private int editingIndex = -1;
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
            assignment.Status = cmbStatus.Text;
            if (editingIndex >= 0)
            {
                assignments[editingIndex] = assignment;
                editingIndex = -1;

                MessageBox.Show("Assignment updated successfully!");
            }
            else
            {
                assignments.Add(assignment);

                MessageBox.Show("Assignment created successfully!");
            }

            dgvAssignments.DataSource = null;
            dgvAssignments.DataSource = assignments;
        }
        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int index = dgvAssignments.SelectedRows[0].Index;

                assignments.RemoveAt(index);

                dgvAssignments.DataSource = null;
                dgvAssignments.DataSource = assignments;

                MessageBox.Show("Assignment deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select an assignment to delete.");
            }
        }

        private void btnEditAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int index = dgvAssignments.SelectedRows[0].Index;
                editingIndex = index; 

                Assignment selectedAssignment = assignments[index];

                txtSubject.Text = selectedAssignment.Subject;
                txtAssignmentTitle.Text = selectedAssignment.Title;
                dtpDueDate.Value = selectedAssignment.DueDate;
                cmbPriority.Text = selectedAssignment.Priority;
            }
            else
            {
                MessageBox.Show("Please select an assignment to edit.");
            }
        }
    }
}
