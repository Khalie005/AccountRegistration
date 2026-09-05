using System.Xml.Linq;

namespace AccountRegistration1
{
    partial class FrmRegistration
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentNo = new TextBox();
            cmbProgram = new ComboBox();
            txtMiddleName = new TextBox();
            txtFirstName = new TextBox();
            txtAddress = new TextBox();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtContactNo = new TextBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.2F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(37, 39);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.2F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(37, 184);
            label2.Name = "label2";
            label2.Size = new Size(44, 23);
            label2.TabIndex = 1;
            label2.Text = "Age:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.2F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(500, 113);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 2;
            label3.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.2F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(302, 39);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 3;
            label4.Text = "Program:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.2F);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(270, 113);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 4;
            label5.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.2F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(37, 113);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 5;
            label6.Text = "Last Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.2F);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(37, 254);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 6;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10.2F);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(270, 184);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 7;
            label8.Text = "Contact No.:";
            // 
            // txtStudentNo
            // 
            txtStudentNo.BackColor = Color.FromArgb(224, 224, 224);
            txtStudentNo.Font = new Font("Nirmala UI", 10.2F);
            txtStudentNo.ForeColor = SystemColors.ActiveCaptionText;
            txtStudentNo.Location = new Point(37, 67);
            txtStudentNo.Margin = new Padding(3, 4, 3, 4);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(258, 30);
            txtStudentNo.TabIndex = 8;
            // 
            // cmbProgram
            // 
            cmbProgram.BackColor = Color.FromArgb(224, 224, 224);
            cmbProgram.Font = new Font("Nirmala UI", 10.2F);
            cmbProgram.ForeColor = SystemColors.ActiveCaptionText;
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Items.AddRange(new object[] { "Bachelor of Science in Business Administration", "Bachelor of Science in Computer Engineering", "Bachelor of Science in Criminology", "Bachelor of Science in Hospitality Management", "Bachelor of Science in Information Technology", "Bachelor of Science in Multimedia Arts", "Bachelor of Science in Tourism Management" });
            cmbProgram.Location = new Point(302, 66);
            cmbProgram.Margin = new Padding(3, 4, 3, 4);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(375, 31);
            cmbProgram.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BackColor = Color.FromArgb(224, 224, 224);
            txtMiddleName.Font = new Font("Nirmala UI", 10.2F);
            txtMiddleName.ForeColor = SystemColors.ActiveCaptionText;
            txtMiddleName.Location = new Point(500, 140);
            txtMiddleName.Margin = new Padding(3, 4, 3, 4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(224, 30);
            txtMiddleName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(224, 224, 224);
            txtFirstName.Font = new Font("Nirmala UI", 10.2F);
            txtFirstName.ForeColor = SystemColors.ActiveCaptionText;
            txtFirstName.Location = new Point(270, 140);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(224, 30);
            txtFirstName.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.FromArgb(224, 224, 224);
            txtAddress.Font = new Font("Nirmala UI", 10.2F);
            txtAddress.ForeColor = SystemColors.ActiveCaptionText;
            txtAddress.Location = new Point(37, 281);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(687, 153);
            txtAddress.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(224, 224, 224);
            txtAge.Font = new Font("Nirmala UI", 10.2F);
            txtAge.ForeColor = SystemColors.ActiveCaptionText;
            txtAge.Location = new Point(37, 211);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(226, 30);
            txtAge.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.FromArgb(224, 224, 224);
            txtLastName.Font = new Font("Nirmala UI", 10.2F);
            txtLastName.ForeColor = SystemColors.ActiveCaptionText;
            txtLastName.Location = new Point(37, 140);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(226, 30);
            txtLastName.TabIndex = 15;
            // 
            // txtContactNo
            // 
            txtContactNo.BackColor = Color.FromArgb(224, 224, 224);
            txtContactNo.Font = new Font("Nirmala UI", 10.2F);
            txtContactNo.ForeColor = SystemColors.ActiveCaptionText;
            txtContactNo.Location = new Point(270, 211);
            txtContactNo.Margin = new Padding(3, 4, 3, 4);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(224, 30);
            txtContactNo.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(302, 452);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(112, 40);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 510);
            Controls.Add(btnNext);
            Controls.Add(txtContactNo);
            Controls.Add(txtLastName);
            Controls.Add(txtAge);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(txtMiddleName);
            Controls.Add(cmbProgram);
            Controls.Add(txtStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
            private Label label2;
            private Label label3;
            private Label label4;
            private Label label5;
            private Label label6;
            private Label label7;
            private Label label8;
            private TextBox txtStudentNo;
            private ComboBox cmbProgram;
            private TextBox txtMiddleName;
            private TextBox txtFirstName;
            private TextBox txtAddress;
            private TextBox txtAge;
            private TextBox txtLastName;
            private TextBox txtContactNo;
            private Button btnNext;
        }
    }