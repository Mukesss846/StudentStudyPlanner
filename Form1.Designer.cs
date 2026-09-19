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
            lblsubject.Location = new Point(551, 202);
            lblsubject.Name = "lblsubject";
            lblsubject.Size = new Size(74, 25);
            lblsubject.TabIndex = 1;
            lblsubject.Text = "Subject:";
            lblsubject.UseWaitCursor = true;
            lblsubject.Click += label2_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(647, 199);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(508, 31);
            txtSubject.TabIndex = 2;
            txtSubject.UseWaitCursor = true;
            // 
            // lblAssignmentTitle
            // 
            lblAssignmentTitle.AutoSize = true;
            lblAssignmentTitle.Location = new Point(478, 262);
            lblAssignmentTitle.Name = "lblAssignmentTitle";
            lblAssignmentTitle.Size = new Size(147, 25);
            lblAssignmentTitle.TabIndex = 3;
            lblAssignmentTitle.Text = "Assignment Title:";
            lblAssignmentTitle.UseWaitCursor = true;
            lblAssignmentTitle.Click += label3_Click;
            // 
            // txtAssignmentTitle
            // 
            txtAssignmentTitle.Location = new Point(647, 259);
            txtAssignmentTitle.Name = "txtAssignmentTitle";
            txtAssignmentTitle.Size = new Size(665, 31);
            txtAssignmentTitle.TabIndex = 4;
            txtAssignmentTitle.UseWaitCursor = true;
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(535, 330);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(90, 25);
            lblDueDate.TabIndex = 5;
            lblDueDate.Text = "Due Date:";
            lblDueDate.UseWaitCursor = true;
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(647, 330);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(300, 31);
            dtpDueDate.TabIndex = 6;
            dtpDueDate.UseWaitCursor = true;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(551, 396);
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
            cmbPriority.Location = new Point(645, 393);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(182, 33);
            cmbPriority.TabIndex = 8;
            cmbPriority.UseWaitCursor = true;
            // 
            // btnSaveAssignment
            // 
            btnSaveAssignment.Location = new Point(773, 509);
            btnSaveAssignment.Name = "btnSaveAssignment";
            btnSaveAssignment.Size = new Size(301, 34);
            btnSaveAssignment.TabIndex = 9;
            btnSaveAssignment.Text = "Save Assignment ";
            btnSaveAssignment.UseVisualStyleBackColor = true;
            btnSaveAssignment.UseWaitCursor = true;
            btnSaveAssignment.Click += btnSaveAssignment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 808);
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
    }
}
