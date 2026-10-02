namespace StudentStudyPlanner
{
    public partial class Form1 : Form
    {
        private List<Assignment> assignments = new List<Assignment>();
        private List<StudySession> studySessions = new List<StudySession>();
        private int editingIndex = -1;
        private int nextAssignmentId = 1;
        private int nextSessionId = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;   // selects the first item, "Pending"

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
                assignment.Id = assignments[editingIndex].Id;   // ADD: keep the same Id when editing
                assignments[editingIndex] = assignment;
                

                MessageBox.Show("Assignment updated successfully!");
            }
            else
            {
                assignment.Id = nextAssignmentId++;             // ADD: give a new Id, then add 1
                assignments.Add(assignment);

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
                editingIndex = -1;   // cancel any edit in progress, since row positions have changed
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
                cmbStatus.Text = selectedAssignment.Status;
            }
            else
            {
                MessageBox.Show("Please select an assignment to edit.");
            }
        }

        

        private void btnAddStudySession_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSessionSubject.Text) ||
                string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Please enter the session subject and duration.");
                return;
            }

            if (!int.TryParse(txtDuration.Text, out int duration))
            {
                MessageBox.Show("Duration must be a number.");
                return;
            }

            StudySession session = new StudySession();

            session.Subject = txtSessionSubject.Text;
            session.Date = dtpSessionDate.Value.Date;
            session.StartTime = dtpStartTime.Value.TimeOfDay;
            session.Duration = duration;
            session.Notes = txtSessionNotes.Text;
            session.Id = nextSessionId++;
            studySessions.Add(session);

            dgvStudySessions.DataSource = null;
            dgvStudySessions.DataSource = studySessions;

            MessageBox.Show("Study session added successfully!");
        }




       

        

        }
    }

