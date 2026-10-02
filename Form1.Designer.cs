namespace StudentStudyPlanner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblsubject = new Label();
            txtSubject = new TextBox();
            lblAssignmentTitle = new Label();
            txtAssignmentTitle = new TextBox();
            lblDueDate = new Label();
            dtpDueDate = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            btnSaveAssignment = new Button();
            dgvAssignments = new DataGridView();
            btnDeleteAssignment = new Button();
            btnEditAssignment = new Button();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblSessionSubject = new Label();
            txtSessionSubject = new TextBox();
            lblSessionDate = new Label();
            dtpSessionDate = new DateTimePicker();
            lblStartTime = new Label();
            dtpStartTime = new DateTimePicker();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblNotes = new Label();
            txtSessionNotes = new TextBox();
            btnAddStudySession = new Button();
            dgvStudySessions = new DataGridView();
            panel1 = new Panel();
            lblToday = new Label();
            tabControl1 = new TabControl();
            tabAssignments = new TabPage();
            grpAssignmentDetails = new GroupBox();
            tabStudySessions = new TabPage();
            grpSessionDetails = new GroupBox();
            tabDashboard = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabAssignments.SuspendLayout();
            grpAssignmentDetails.SuspendLayout();
            tabStudySessions.SuspendLayout();
            grpSessionDetails.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 0);
            label1.Name = "label1";
            label1.Size = new Size(722, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Study Planner and Assignment Tracker";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(124, 36);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(81, 28);
            lblsubject.TabIndex = 1;
            lblsubject.Text = "Subject:";
            lblsubject.UseWaitCursor = true;
            lblsubject.Click += lblsubject_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(241, 33);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(345, 34);
            txtSubject.TabIndex = 2;
            txtSubject.UseWaitCursor = true;
            txtSubject.TextChanged += txtSubject_TextChanged;
            // 
            // lblAssignmentTitle
            // 
            lblAssignmentTitle.AutoSize = true;
            lblAssignmentTitle.Location = new Point(80, 91);
            lblAssignmentTitle.Name = "lblAssignmentTitle";
            lblAssignmentTitle.Size = new Size(160, 28);
            lblAssignmentTitle.TabIndex = 3;
            lblAssignmentTitle.Text = "Assignment Title:";
            lblAssignmentTitle.UseWaitCursor = true;
            // 
            // txtAssignmentTitle
            // 
            txtAssignmentTitle.Location = new Point(241, 84);
            txtAssignmentTitle.Name = "txtAssignmentTitle";
            txtAssignmentTitle.Size = new Size(731, 34);
            txtAssignmentTitle.TabIndex = 4;
            txtAssignmentTitle.UseWaitCursor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(142, 143);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(97, 28);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date:";
            lblDueDate.UseWaitCursor = true;
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "ddd, dd MMM yyyy";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(241, 136);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(227, 34);
            dtpDueDate.TabIndex = 6;
            dtpDueDate.UseWaitCursor = true;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(162, 194);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(80, 28);
            lblPriority.TabIndex = 7;
            lblPriority.Text = "Priority:";
            lblPriority.UseWaitCursor = true;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low ", "Medium ", "High" });
            cmbPriority.Location = new Point(241, 187);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 36);
            cmbPriority.TabIndex = 8;
            cmbPriority.UseWaitCursor = true;
            // 
            // btnSaveAssignment
            // 
            btnSaveAssignment.Location = new Point(135, 309);
            btnSaveAssignment.Name = "btnSaveAssignment";
            btnSaveAssignment.Size = new Size(216, 38);
            btnSaveAssignment.TabIndex = 9;
            btnSaveAssignment.Text = "Save Assignment ";
            btnSaveAssignment.UseVisualStyleBackColor = true;
            btnSaveAssignment.UseWaitCursor = true;
            btnSaveAssignment.Click += btnSaveAssignment_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.BackgroundColor = Color.White;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Location = new Point(37, 381);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.RowHeadersWidth = 62;
            dgvAssignments.Size = new Size(966, 158);
            dgvAssignments.TabIndex = 10;
            dgvAssignments.UseWaitCursor = true;
            dgvAssignments.CellContentClick += dgvAssignments_CellContentClick;
            // 
            // btnDeleteAssignment
            // 
            btnDeleteAssignment.Location = new Point(634, 309);
            btnDeleteAssignment.Name = "btnDeleteAssignment";
            btnDeleteAssignment.Size = new Size(219, 38);
            btnDeleteAssignment.TabIndex = 11;
            btnDeleteAssignment.Text = "Delete Assignment";
            btnDeleteAssignment.UseVisualStyleBackColor = true;
            btnDeleteAssignment.UseWaitCursor = true;
            btnDeleteAssignment.Click += btnDeleteAssignment_Click;
            // 
            // btnEditAssignment
            // 
            btnEditAssignment.Location = new Point(384, 309);
            btnEditAssignment.Name = "btnEditAssignment";
            btnEditAssignment.Size = new Size(218, 38);
            btnEditAssignment.TabIndex = 12;
            btnEditAssignment.Text = "Edit Assignment";
            btnEditAssignment.UseVisualStyleBackColor = true;
            btnEditAssignment.UseWaitCursor = true;
            btnEditAssignment.Click += btnEditAssignment_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(171, 257);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 28);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            lblStatus.UseWaitCursor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending ", "In Progress ", "Completed " });
            cmbStatus.Location = new Point(241, 250);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 36);
            cmbStatus.TabIndex = 14;
            cmbStatus.UseWaitCursor = true;
            // 
            // lblSessionSubject
            // 
            lblSessionSubject.AutoSize = true;
            lblSessionSubject.Location = new Point(32, 59);
            lblSessionSubject.Name = "lblSessionSubject";
            lblSessionSubject.Size = new Size(151, 28);
            lblSessionSubject.TabIndex = 16;
            lblSessionSubject.Text = "Session Subject:";
            lblSessionSubject.UseWaitCursor = true;
            // 
            // txtSessionSubject
            // 
            txtSessionSubject.Location = new Point(192, 59);
            txtSessionSubject.Name = "txtSessionSubject";
            txtSessionSubject.Size = new Size(644, 34);
            txtSessionSubject.TabIndex = 17;
            txtSessionSubject.UseWaitCursor = true;
            // 
            // lblSessionDate
            // 
            lblSessionDate.AutoSize = true;
            lblSessionDate.Location = new Point(55, 113);
            lblSessionDate.Name = "lblSessionDate";
            lblSessionDate.Size = new Size(127, 28);
            lblSessionDate.TabIndex = 18;
            lblSessionDate.Text = "Session Date:";
            lblSessionDate.UseWaitCursor = true;
            // 
            // dtpSessionDate
            // 
            dtpSessionDate.CustomFormat = "ddd, dd MMM yyyy";
            dtpSessionDate.Format = DateTimePickerFormat.Custom;
            dtpSessionDate.Location = new Point(192, 113);
            dtpSessionDate.Name = "dtpSessionDate";
            dtpSessionDate.Size = new Size(222, 34);
            dtpSessionDate.TabIndex = 19;
            dtpSessionDate.UseWaitCursor = true;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(81, 160);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(104, 28);
            lblStartTime.TabIndex = 20;
            lblStartTime.Text = "Start Time:";
            lblStartTime.UseWaitCursor = true;
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.Location = new Point(193, 160);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(122, 34);
            dtpStartTime.TabIndex = 21;
            dtpStartTime.UseWaitCursor = true;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(6, 205);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(179, 28);
            lblDuration.TabIndex = 22;
            lblDuration.Text = "Duration (minutes):";
            lblDuration.UseWaitCursor = true;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(192, 205);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(297, 34);
            txtDuration.TabIndex = 23;
            txtDuration.UseWaitCursor = true;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(116, 250);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(68, 28);
            lblNotes.TabIndex = 24;
            lblNotes.Text = "Notes:";
            lblNotes.UseWaitCursor = true;
            // 
            // txtSessionNotes
            // 
            txtSessionNotes.Location = new Point(193, 261);
            txtSessionNotes.Multiline = true;
            txtSessionNotes.Name = "txtSessionNotes";
            txtSessionNotes.Size = new Size(325, 34);
            txtSessionNotes.TabIndex = 25;
            txtSessionNotes.UseWaitCursor = true;
            // 
            // btnAddStudySession
            // 
            btnAddStudySession.Location = new Point(501, 316);
            btnAddStudySession.Name = "btnAddStudySession";
            btnAddStudySession.Size = new Size(226, 38);
            btnAddStudySession.TabIndex = 26;
            btnAddStudySession.Text = "Add Study Session";
            btnAddStudySession.UseVisualStyleBackColor = true;
            btnAddStudySession.UseWaitCursor = true;
            btnAddStudySession.Click += btnAddStudySession_Click;
            // 
            // dgvStudySessions
            // 
            dgvStudySessions.BackgroundColor = Color.White;
            dgvStudySessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudySessions.Location = new Point(6, 377);
            dgvStudySessions.Name = "dgvStudySessions";
            dgvStudySessions.RowHeadersWidth = 62;
            dgvStudySessions.Size = new Size(1028, 105);
            dgvStudySessions.TabIndex = 27;
            dgvStudySessions.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 58, 95);
            panel1.Controls.Add(lblToday);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 52);
            panel1.TabIndex = 28;
            panel1.UseWaitCursor = true;
            // 
            // lblToday
            // 
            lblToday.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblToday.AutoSize = true;
            lblToday.BackColor = Color.Transparent;
            lblToday.Font = new Font("Segoe UI", 11F);
            lblToday.Location = new Point(975, 20);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(58, 30);
            lblToday.TabIndex = 29;
            lblToday.Text = "Date";
            lblToday.UseWaitCursor = true;
            lblToday.Click += label2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAssignments);
            tabControl1.Controls.Add(tabStudySessions);
            tabControl1.Controls.Add(tabDashboard);
            tabControl1.Location = new Point(3, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(12, 6);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1803, 674);
            tabControl1.TabIndex = 29;
            tabControl1.UseWaitCursor = true;
            // 
            // tabAssignments
            // 
            tabAssignments.BackColor = Color.FromArgb(245, 247, 250);
            tabAssignments.Controls.Add(grpAssignmentDetails);
            tabAssignments.Location = new Point(4, 43);
            tabAssignments.Name = "tabAssignments";
            tabAssignments.Padding = new Padding(10);
            tabAssignments.Size = new Size(1795, 627);
            tabAssignments.TabIndex = 0;
            tabAssignments.Text = "Assignments";
            tabAssignments.UseWaitCursor = true;
            tabAssignments.Click += tabAssignments_Click;
            // 
            // grpAssignmentDetails
            // 
            grpAssignmentDetails.Controls.Add(dgvAssignments);
            grpAssignmentDetails.Controls.Add(txtSubject);
            grpAssignmentDetails.Controls.Add(cmbStatus);
            grpAssignmentDetails.Controls.Add(lblsubject);
            grpAssignmentDetails.Controls.Add(lblStatus);
            grpAssignmentDetails.Controls.Add(lblAssignmentTitle);
            grpAssignmentDetails.Controls.Add(btnEditAssignment);
            grpAssignmentDetails.Controls.Add(txtAssignmentTitle);
            grpAssignmentDetails.Controls.Add(btnDeleteAssignment);
            grpAssignmentDetails.Controls.Add(lblDueDate);
            grpAssignmentDetails.Controls.Add(dtpDueDate);
            grpAssignmentDetails.Controls.Add(btnSaveAssignment);
            grpAssignmentDetails.Controls.Add(lblPriority);
            grpAssignmentDetails.Controls.Add(cmbPriority);
            grpAssignmentDetails.Dock = DockStyle.Left;
            grpAssignmentDetails.Location = new Point(10, 10);
            grpAssignmentDetails.Name = "grpAssignmentDetails";
            grpAssignmentDetails.Size = new Size(1127, 607);
            grpAssignmentDetails.TabIndex = 15;
            grpAssignmentDetails.TabStop = false;
            grpAssignmentDetails.Text = "Assignment details";
            grpAssignmentDetails.UseWaitCursor = true;
            grpAssignmentDetails.Enter += grpAssignmentDetails_Enter_1;
            // 
            // tabStudySessions
            // 
            tabStudySessions.Controls.Add(grpSessionDetails);
            tabStudySessions.Location = new Point(4, 43);
            tabStudySessions.Name = "tabStudySessions";
            tabStudySessions.Padding = new Padding(3);
            tabStudySessions.Size = new Size(1795, 627);
            tabStudySessions.TabIndex = 1;
            tabStudySessions.Text = "Study Sessions";
            tabStudySessions.UseVisualStyleBackColor = true;
            tabStudySessions.UseWaitCursor = true;
            // 
            // grpSessionDetails
            // 
            grpSessionDetails.Controls.Add(dgvStudySessions);
            grpSessionDetails.Controls.Add(lblDuration);
            grpSessionDetails.Controls.Add(lblSessionSubject);
            grpSessionDetails.Controls.Add(dtpStartTime);
            grpSessionDetails.Controls.Add(txtSessionSubject);
            grpSessionDetails.Controls.Add(txtDuration);
            grpSessionDetails.Controls.Add(btnAddStudySession);
            grpSessionDetails.Controls.Add(lblStartTime);
            grpSessionDetails.Controls.Add(lblSessionDate);
            grpSessionDetails.Controls.Add(lblNotes);
            grpSessionDetails.Controls.Add(txtSessionNotes);
            grpSessionDetails.Controls.Add(dtpSessionDate);
            grpSessionDetails.Dock = DockStyle.Left;
            grpSessionDetails.Location = new Point(3, 3);
            grpSessionDetails.Name = "grpSessionDetails";
            grpSessionDetails.Size = new Size(1156, 621);
            grpSessionDetails.TabIndex = 27;
            grpSessionDetails.TabStop = false;
            grpSessionDetails.Text = "Study session details";
            grpSessionDetails.UseWaitCursor = true;
            grpSessionDetails.Enter += groupBox1_Enter;
            // 
            // tabDashboard
            // 
            tabDashboard.Location = new Point(4, 40);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1795, 630);
            tabDashboard.TabIndex = 2;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            tabDashboard.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1178, 694);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Study Planner and Assignment Tracker ";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabAssignments.ResumeLayout(false);
            grpAssignmentDetails.ResumeLayout(false);
            grpAssignmentDetails.PerformLayout();
            tabStudySessions.ResumeLayout(false);
            grpSessionDetails.ResumeLayout(false);
            grpSessionDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblsubject;
        private TextBox txtSubject;
        private Label lblAssignmentTitle;
        private TextBox txtAssignmentTitle;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private Button btnSaveAssignment;
        private DataGridView dgvAssignments;
        private Button btnDeleteAssignment;
        private Button btnEditAssignment;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblSessionSubject;
        private TextBox txtSessionSubject;
        private Label lblSessionDate;
        private DateTimePicker dtpSessionDate;
        private Label lblStartTime;
        private DateTimePicker dtpStartTime;
        private Label lblDuration;
        private TextBox txtDuration;
        private Label lblNotes;
        private TextBox txtSessionNotes;
        private Button btnAddStudySession;
        private DataGridView dgvStudySessions;
        private Panel panel1;
        private Label lblToday;
        private TabControl tabControl1;
        private TabPage tabAssignments;
        private TabPage tabStudySessions;
        private TabPage tabDashboard;
        private TabPage tabPage2;
        private GroupBox grpAssignmentDetails;
        private GroupBox grpSessionDetails;
    }
}
