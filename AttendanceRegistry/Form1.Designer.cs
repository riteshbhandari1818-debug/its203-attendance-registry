namespace AttendanceRegistry
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
            txtStudentId = new TextBox();
            txtName = new TextBox();
            btnAddStudent = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(43, 35);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(181, 27);
            txtStudentId.TabIndex = 0;
            txtStudentId.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(43, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 27);
            txtName.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(43, 188);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(181, 29);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(43, 273);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(202, 104);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStudents);
            Controls.Add(btnAddStudent);
            Controls.Add(txtName);
            Controls.Add(txtStudentId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentId;
        private TextBox txtName;
        private Button btnAddStudent;
        private ListBox lstStudents;
    }
}
