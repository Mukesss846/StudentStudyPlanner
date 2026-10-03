using System.Text.Json;
namespace StudentStudyPlanner
{
    public partial class Form1 : Form
    {
        private List<Assignment> assignments = new List<Assignment>();
        private List<StudySession> studySessions = new List<StudySession>();
        private int editingIndex = -1;
        private int nextAssignmentId = 1;
        private int nextSessionId = 1;
        private DataStorage storage = new DataStorage();
        private const string AssignmentsFile = "assignments.json";
        private const string SessionsFile = "sessions.json";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            lblToday.Text = DateTime.Today.ToString("dddd, d MMM yyyy");
            try
            {
                assignments = storage.Load<Assignment>(AssignmentsFile);
                studySessions = storage.Load<StudySession>(SessionsFile);
            }
            catch (JsonException)
            {
                MessageBox.Show("Saved data is corrupted. Starting with empty lists.", "Load error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not read saved data: " + ex.Message, "Load error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (assignments.Count > 0) nextAssignmentId = assignments.Max(a => a.Id) + 1;
            if (studySessions.Count > 0) nextSessionId = studySessions.Max(s => s.Id) + 1;

            dgvAssignments.DataSource = assignments;
            FormatAssignmentGrid();
            dgvStudySessions.DataSource = studySessions;
            FormatSessionGrid();
            RefreshUpcoming();
        }







        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) ||
    string.IsNullOrWhiteSpace(cmbPriority.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            Assignment assignment = new Assignment();

            try
            {
                assignment.Subject = txtSubject.Text;
                assignment.Title = txtAssignmentTitle.Text;
                assignment.DueDate = dtpDueDate.Value;
                assignment.Priority = cmbPriority.Text.Trim();
                assignment.Status = cmbStatus.Text.Trim();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (editingIndex >= 0)
            {
                assignment.Id = assignments[editingIndex].Id;
                assignments[editingIndex] = assignment;
                editingIndex = -1;


                MessageBox.Show("Assignment updated successfully!");
            }
            else
            {
                assignment.Id = nextAssignmentId++;
                assignments.Add(assignment);

            }

            dgvAssignments.DataSource = null;
            dgvAssignments.DataSource = assignments;
            FormatAssignmentGrid();
            RefreshUpcoming();
            SaveData();
        }
        private void btnDeleteAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int index = dgvAssignments.SelectedRows[0].Index;

                dgvAssignments.DataSource = null;            // 1. disconnect first
                assignments.RemoveAt(index);                 // 2. then remove
                editingIndex = -1;
                dgvAssignments.DataSource = assignments;     // 3. reconnect
                FormatAssignmentGrid();
                RefreshUpcoming();
                SaveData();

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

            try
            {
                session.Subject = txtSessionSubject.Text;
                session.Date = dtpSessionDate.Value.Date;
                session.StartTime = dtpStartTime.Value.TimeOfDay;
                session.Duration = duration;
                session.Notes = txtSessionNotes.Text;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            session.Id = nextSessionId++;
            studySessions.Add(session);

            dgvStudySessions.DataSource = null;
            dgvStudySessions.DataSource = studySessions;
            FormatSessionGrid();

            MessageBox.Show("Study session added successfully!");
            MessageBox.Show("Study session added successfully!");
            RefreshUpcoming();
            SaveData();
        }

        private void RefreshUpcoming()
        {
            List<PlannerItem> allItems = new List<PlannerItem>();
            allItems.AddRange(assignments);
            allItems.AddRange(studySessions);

            lstUpcoming.Items.Clear();
            foreach (PlannerItem item in allItems)
            {
                lstUpcoming.Items.Add(item.GetSummary());
                int total = assignments.Count;
                int completed = assignments.Count(a => a.Status == "Completed");
                int percent = total == 0 ? 0 : completed * 100 / total;

                lblProgress.Text = $"Completed: {completed} of {total} assignments ({percent}%)";
                prgCompleted.Value = percent;
            }
        }
        private void FormatAssignmentGrid()
        {
            dgvAssignments.Columns["Id"]!.DisplayIndex = 0;
            dgvAssignments.Columns["Subject"]!.DisplayIndex = 1;
            dgvAssignments.Columns["DueDate"]!.DefaultCellStyle.Format = "dd MMM yyyy";
        }
        private void FormatSessionGrid()
        {
            dgvStudySessions.Columns["Id"]!.DisplayIndex = 0;
            dgvStudySessions.Columns["Subject"]!.DisplayIndex = 1;
            dgvStudySessions.Columns["Date"]!.DefaultCellStyle.Format = "dd MMM yyyy";
            dgvStudySessions.Columns["StartTime"]!.DefaultCellStyle.Format = @"hh\:mm";
        }

        private void SaveData()
        {
            try
            {
                storage.Save(assignments, AssignmentsFile);
                storage.Save(studySessions, SessionsFile);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Could not save data: " + ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudySession_Click(object sender, EventArgs e)
        {
            if (dgvStudySessions.SelectedRows.Count > 0)
            {
                int index = dgvStudySessions.SelectedRows[0].Index;

                dgvStudySessions.DataSource = null;          // 1. disconnect first
                studySessions.RemoveAt(index);               // 2. then remove
                dgvStudySessions.DataSource = studySessions; // 3. reconnect
                FormatSessionGrid();
                RefreshUpcoming();
                SaveData();

                MessageBox.Show("Study session deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a study session to delete.");
            }
        }
    }
}









