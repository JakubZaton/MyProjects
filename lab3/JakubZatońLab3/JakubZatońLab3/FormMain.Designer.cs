namespace JakubZatońLab3
{
    partial class FormMain
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
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.buttonViewGrades = new System.Windows.Forms.Button();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.textBoxCourse = new System.Windows.Forms.TextBox();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.buttonViewCourses = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(402, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(386, 73);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Jakub Zatoń";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(365, 85);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(423, 305);
            this.dataGridViewData.TabIndex = 1;
            // 
            // buttonViewGrades
            // 
            this.buttonViewGrades.Location = new System.Drawing.Point(225, 104);
            this.buttonViewGrades.Name = "buttonViewGrades";
            this.buttonViewGrades.Size = new System.Drawing.Size(75, 23);
            this.buttonViewGrades.TabIndex = 2;
            this.buttonViewGrades.Text = "View Grades";
            this.buttonViewGrades.UseVisualStyleBackColor = true;
            this.buttonViewGrades.Click += new System.EventHandler(this.buttonViewGrades_Click);
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Location = new System.Drawing.Point(200, 178);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTeacherName.TabIndex = 3;
            // 
            // textBoxCourse
            // 
            this.textBoxCourse.Location = new System.Drawing.Point(200, 238);
            this.textBoxCourse.Name = "textBoxCourse";
            this.textBoxCourse.Size = new System.Drawing.Size(100, 20);
            this.textBoxCourse.TabIndex = 4;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(200, 162);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(92, 13);
            this.labelTeacherName.TabIndex = 5;
            this.labelTeacherName.Text = "Imię Wykładowcy";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(200, 222);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(69, 13);
            this.labelCourseName.TabIndex = 6;
            this.labelCourseName.Text = "Nazwa kursu";
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(200, 276);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(100, 37);
            this.buttonAddCourse.TabIndex = 7;
            this.buttonAddCourse.Text = "Dodaj nowy kurs";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // buttonViewCourses
            // 
            this.buttonViewCourses.Location = new System.Drawing.Point(200, 353);
            this.buttonViewCourses.Name = "buttonViewCourses";
            this.buttonViewCourses.Size = new System.Drawing.Size(140, 23);
            this.buttonViewCourses.TabIndex = 8;
            this.buttonViewCourses.Text = "Pokazanie kursów";
            this.buttonViewCourses.UseVisualStyleBackColor = true;
            this.buttonViewCourses.Click += new System.EventHandler(this.buttonViewCourses_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonViewCourses);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.textBoxCourse);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.buttonViewGrades);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Button buttonViewGrades;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.TextBox textBoxCourse;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Button buttonViewCourses;
    }
}

