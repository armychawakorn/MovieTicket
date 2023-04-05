namespace MovieTicket
{
    partial class Add
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            addbutton = new Button();
            studentid = new TextBox();
            studentname = new TextBox();
            selectnotebook = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "ลงทะเบียน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 73);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "รหัสนักศึกษา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 107);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ นามสกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(85, 141);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "โน๊ตบุ๊ค";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 176);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 4;
            label5.Text = "ระยะเวลา";
            // 
            // addbutton
            // 
            addbutton.Location = new Point(180, 227);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 23);
            addbutton.TabIndex = 5;
            addbutton.Text = "เพิ่ม";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // studentid
            // 
            studentid.Location = new Point(164, 73);
            studentid.Name = "studentid";
            studentid.Size = new Size(195, 23);
            studentid.TabIndex = 6;
            // 
            // studentname
            // 
            studentname.Location = new Point(164, 109);
            studentname.Name = "studentname";
            studentname.Size = new Size(195, 23);
            studentname.TabIndex = 7;
            // 
            // selectnotebook
            // 
            selectnotebook.FormattingEnabled = true;
            selectnotebook.Location = new Point(164, 143);
            selectnotebook.Name = "selectnotebook";
            selectnotebook.Size = new Size(195, 23);
            selectnotebook.TabIndex = 8;
            selectnotebook.Text = "เลือกรุ่นโน๊ตบุ๊ค";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(164, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 271);
            Controls.Add(dateTimePicker1);
            Controls.Add(selectnotebook);
            Controls.Add(studentname);
            Controls.Add(studentid);
            Controls.Add(addbutton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button addbutton;
        private TextBox studentid;
        private TextBox studentname;
        private ComboBox selectnotebook;
        private DateTimePicker dateTimePicker1;
    }
}