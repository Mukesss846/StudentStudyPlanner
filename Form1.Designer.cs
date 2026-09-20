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
            lblStudySessions = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(487, 36);
            label1.Name = "label1";
            label1.Size = new Size(722, 45);
            label1.TabIndex = 0;
            label1.Text = "Student Study Planner and Assignment Tracker";
            label1.UseWaitCursor = true;
            // 
            // lblsubject
            // 
            lblsubject.AutoSize = true;
            lblsubject.Location = new Point(519, 121);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(74, 25);
            lblsubject.TabIndex = 1;
            lblsubject.Text = "Subject:";
            lblsubject.UseWaitCursor = true;
            lblsubject.Click += label2_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(599, 121);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(508, 31);
            txtSubject.TabIndex = 2;
            txtSubject.UseWaitCursor = true;
            txtSubject.TextChanged += txtSubject_TextChanged;
            // 
            // lblAssignmentTitle
            // 
            lblAssignmentTitle.AutoSize = true;
            lblAssignmentTitle.Location = new Point(446, 167);
            lblAssignmentTitle.Name = "lblAssignmentTitle";
            lblAssignmentTitle.Size = new Size(147, 25);
            lblAssignmentTitle.TabIndex = 3;
            lblAssignmentTitle.Text = "Assignment Title:";
            lblAssignmentTitle.UseWaitCursor = true;
            lblAssignmentTitle.Click += label3_Click;
            // 
            // txtAssignmentTitle
            // 
            txtAssignmentTitle.Location = new Point(599, 167);
            txtAssignmentTitle.Name = "txtAssignmentTitle";
            txtAssignmentTitle.Size = new Size(665, 31);
            txtAssignmentTitle.TabIndex = 4;
            txtAssignmentTitle.UseWaitCursor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(503, 213);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(90, 25);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date:";
            lblDueDate.UseWaitCursor = true;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(599, 213);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(300, 31);
            dtpDueDate.TabIndex = 6;
            dtpDueDate.UseWaitCursor = true;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(521, 259);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(72, 25);
            lblPriority.TabIndex = 7;
            lblPriority.Text = "Priority:";
            lblPriority.UseWaitCursor = true;
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low ", "Medium ", "High" });
            cmbPriority.Location = new Point(599, 259);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(182, 33);
            cmbPriority.TabIndex = 8;
            cmbPriority.UseWaitCursor = true;
            // 
            // btnSaveAssignment
            // 
            btnSaveAssignment.Location = new Point(503, 368);
            btnSaveAssignment.Name = "btnSaveAssignment";
            btnSaveAssignment.Size = new Size(196, 34);
            btnSaveAssignment.TabIndex = 9;
            btnSaveAssignment.Text = "Save Assignment ";
            btnSaveAssignment.UseVisualStyleBackColor = true;
            btnSaveAssignment.UseWaitCursor = true;
            btnSaveAssignment.Click += btnSaveAssignment_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Location = new Point(413, 417);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.RowHeadersWidth = 62;
            dgvAssignments.Size = new Size(935, 151);
            dgvAssignments.TabIndex = 10;
            dgvAssignments.UseWaitCursor = true;
            // 
            // btnDeleteAssignment
            // 
            btnDeleteAssignment.Location = new Point(956, 368);
            btnDeleteAssignment.Name = "btnDeleteAssignment";
            btnDeleteAssignment.Size = new Size(199, 34);
            btnDeleteAssignment.TabIndex = 11;
            btnDeleteAssignment.Text = "Delete Assignment";
            btnDeleteAssignment.UseVisualStyleBackColor = true;
            btnDeleteAssignment.UseWaitCursor = true;
            btnDeleteAssignment.Click += btnDeleteAssignment_Click;
            // 
            // btnEditAssignment
            // 
            btnEditAssignment.Location = new Point(729, 368);
            btnEditAssignment.Name = "btnEditAssignment";
            btnEditAssignment.Size = new Size(198, 34);
            btnEditAssignment.TabIndex = 12;
            btnEditAssignment.Text = "Edit Assignment";
            btnEditAssignment.UseVisualStyleBackColor = true;
            btnEditAssignment.UseWaitCursor = true;
            btnEditAssignment.Click += btnEditAssignment_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(529, 315);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            lblStatus.UseWaitCursor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending ", "In Progress ", "Completed " });
            cmbStatus.Location = new Point(599, 315);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(182, 33);
            cmbStatus.TabIndex = 14;
            cmbStatus.UseWaitCursor = true;
            // 
            // lblStudySessions
            // 
            lblStudySessions.AutoSize = true;
            lblStudySessions.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudySessions.Location = new Point(413, 622);
            lblStudySessions.Name = "lblStudySessions";
            lblStudySessions.Size = new Size(209, 38);
            lblStudySessions.TabIndex = 15;
            lblStudySessions.Text = "Study Sessions";
            lblStudySessions.UseWaitCursor = true;
            lblStudySessions.Click += lblStudySessions_Click;
            // 
            // lblSessionSubject
            // 
            lblSessionSubject.AutoSize = true;
            lblSessionSubject.Location = new Point(413, 678);
            lblSessionSubject.Name = "lblSessionSubject";
            lblSessionSubject.Size = new Size(139, 25);
            lblSessionSubject.TabIndex = 16;
            lblSessionSubject.Text = "Session Subject:";
            lblSessionSubject.UseWaitCursor = true;
            lblSessionSubject.Click += label2_Click_1;
            // 
            // txtSessionSubject
            // 
            txtSessionSubject.Location = new Point(558, 678);
            txtSessionSubject.Name = "txtSessionSubject";
            txtSessionSubject.Size = new Size(301, 31);
            txtSessionSubject.TabIndex = 17;
            txtSessionSubject.UseWaitCursor = true;
            txtSessionSubject.TextChanged += txtSessionSubject_TextChanged;
            // 
            // lblSessionDate
            // 
            lblSessionDate.AutoSize = true;
            lblSessionDate.Location = new Point(434, 726);
            lblSessionDate.Name = "lblSessionDate";
            lblSessionDate.Size = new Size(118, 25);
            lblSessionDate.TabIndex = 18;
            lblSessionDate.Text = "Session Date:";
            lblSessionDate.UseWaitCursor = true;
            // 
            // dtpSessionDate
            // 
            dtpSessionDate.Location = new Point(558, 726);
            dtpSessionDate.Name = "dtpSessionDate";
            dtpSessionDate.Size = new Size(300, 31);
            dtpSessionDate.TabIndex = 19;
            dtpSessionDate.UseWaitCursor = true;
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(457, 768);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(95, 25);
            lblStartTime.TabIndex = 20;
            lblStartTime.Text = "Start Time:";
            lblStartTime.UseWaitCursor = true;
            lblStartTime.Click += lblStartTime_Click;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(559, 768);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(300, 31);
            dtpStartTime.TabIndex = 21;
            dtpStartTime.UseWaitCursor = true;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(389, 808);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(163, 25);
            lblDuration.TabIndex = 22;
            lblDuration.Text = "Duration (minutes):";
            lblDuration.UseWaitCursor = true;
            lblDuration.Click += lblDuration_Click;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(558, 808);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(270, 31);
            txtDuration.TabIndex = 23;
            txtDuration.UseWaitCursor = true;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(489, 848);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 25);
            lblNotes.TabIndex = 24;
            lblNotes.Text = "Notes:";
            lblNotes.UseWaitCursor = true;
            // 
            // txtSessionNotes
            // 
            txtSessionNotes.Location = new Point(559, 858);
            txtSessionNotes.Name = "txtSessionNotes";
            txtSessionNotes.Size = new Size(296, 31);
            txtSessionNotes.TabIndex = 25;
            txtSessionNotes.UseWaitCursor = true;
            // 
            // btnAddStudySession
            // 
            btnAddStudySession.Location = new Point(830, 910);
            btnAddStudySession.Name = "btnAddStudySession";
            btnAddStudySession.Size = new Size(205, 34);
            btnAddStudySession.TabIndex = 26;
            btnAddStudySession.Text = "Add Study Session";
            btnAddStudySession.UseVisualStyleBackColor = true;
            btnAddStudySession.UseWaitCursor = true;
            btnAddStudySession.Click += btnAddStudySession_Click;
            // 
            // dgvStudySessions
            // 
            dgvStudySessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudySessions.Location = new Point(434, 962);
            dgvStudySessions.Name = "dgvStudySessions";
            dgvStudySessions.RowHeadersWidth = 62;
            dgvStudySessions.Size = new Size(935, 153);
            dgvStudySessions.TabIndex = 27;
            dgvStudySessions.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 1170);
            Controls.Add(dgvStudySessions);
            Controls.Add(btnAddStudySession);
            Controls.Add(txtSessionNotes);
            Controls.Add(lblNotes);
            Controls.Add(txtDuration);
            Controls.Add(lblDuration);
            Controls.Add(dtpStartTime);
            Controls.Add(lblStartTime);
            Controls.Add(dtpSessionDate);
            Controls.Add(lblSessionDate);
            Controls.Add(txtSessionSubject);
            Controls.Add(lblSessionSubject);
            Controls.Add(lblStudySessions);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnEditAssignment);
            Controls.Add(btnDeleteAssignment);
            Controls.Add(dgvAssignments);
            Controls.Add(btnSaveAssignment);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(dtpDueDate);
            Controls.Add(lblDueDate);
            Controls.Add(txtAssignmentTitle);
            Controls.Add(lblAssignmentTitle);
            Controls.Add(txtSubject);
            Controls.Add(lblsubject);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Study Planner and Assignment Tracker ";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudySessions).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblStudySessions;
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
    }
}
