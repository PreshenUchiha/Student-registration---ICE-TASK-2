
namespace Student_registration
{
    partial class frmDesign
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.txbStudentName = new System.Windows.Forms.TextBox();
            this.txbStudentNumber = new System.Windows.Forms.TextBox();
            this.rbHIS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.rbBCAD2 = new System.Windows.Forms.RadioButton();
            this.rbBCAD1 = new System.Windows.Forms.RadioButton();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(32, 75);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(111, 15);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Full Name :";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(32, 132);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(95, 15);
            this.lblStudentNumber.TabIndex = 1;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // txbStudentName
            // 
            this.txbStudentName.Location = new System.Drawing.Point(244, 75);
            this.txbStudentName.Name = "txbStudentName";
            this.txbStudentName.Size = new System.Drawing.Size(227, 23);
            this.txbStudentName.TabIndex = 2;
            // 
            // txbStudentNumber
            // 
            this.txbStudentNumber.Location = new System.Drawing.Point(244, 129);
            this.txbStudentNumber.Name = "txbStudentNumber";
            this.txbStudentNumber.Size = new System.Drawing.Size(227, 23);
            this.txbStudentNumber.TabIndex = 3;
            // 
            // rbHIS
            // 
            this.rbHIS.AutoSize = true;
            this.rbHIS.Location = new System.Drawing.Point(6, 22);
            this.rbHIS.Name = "rbHIS";
            this.rbHIS.Size = new System.Drawing.Size(43, 19);
            this.rbHIS.TabIndex = 4;
            this.rbHIS.TabStop = true;
            this.rbHIS.Text = "HIS";
            this.rbHIS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please Enter the following information regarding tutor workshops :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Course that you are studying : ";
            // 
            // gbCourse
            // 
            this.gbCourse.Controls.Add(this.rbBCAD2);
            this.gbCourse.Controls.Add(this.rbBCAD1);
            this.gbCourse.Controls.Add(this.rbHIS);
            this.gbCourse.Location = new System.Drawing.Point(244, 186);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(227, 126);
            this.gbCourse.TabIndex = 7;
            this.gbCourse.TabStop = false;
            this.gbCourse.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbBCAD2
            // 
            this.rbBCAD2.AutoSize = true;
            this.rbBCAD2.Location = new System.Drawing.Point(6, 72);
            this.rbBCAD2.Name = "rbBCAD2";
            this.rbBCAD2.Size = new System.Drawing.Size(62, 19);
            this.rbBCAD2.TabIndex = 6;
            this.rbBCAD2.TabStop = true;
            this.rbBCAD2.Text = "BCAD2";
            this.rbBCAD2.UseVisualStyleBackColor = true;
            // 
            // rbBCAD1
            // 
            this.rbBCAD1.AutoSize = true;
            this.rbBCAD1.Location = new System.Drawing.Point(6, 47);
            this.rbBCAD1.Name = "rbBCAD1";
            this.rbBCAD1.Size = new System.Drawing.Size(62, 19);
            this.rbBCAD1.TabIndex = 5;
            this.rbBCAD1.TabStop = true;
            this.rbBCAD1.Text = "BCAD1";
            this.rbBCAD1.UseVisualStyleBackColor = true;
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 15;
            this.lstReport.Location = new System.Drawing.Point(553, 68);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(259, 244);
            this.lstReport.TabIndex = 8;
            this.lstReport.SelectedIndexChanged += new System.EventHandler(this.lstReport_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(250, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(196, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 371);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.gbCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbStudentNumber);
            this.Controls.Add(this.txbStudentName);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.lblStudentName);
            this.Name = "frmDesign";
            this.Text = "Tutor Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.TextBox txbStudentName;
        private System.Windows.Forms.TextBox txbStudentNumber;
        private System.Windows.Forms.RadioButton rbHIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCourse;
        private System.Windows.Forms.RadioButton rbBCAD2;
        private System.Windows.Forms.RadioButton rbBCAD1;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button btnSubmit;
    }
}