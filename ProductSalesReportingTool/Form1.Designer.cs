namespace ProductSalesReportingTool
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnGenerate = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.CustomFormat = "yyyyMMMMdddd dd";
            dtpStartDate.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(236, 108);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(314, 36);
            dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarFont = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.CustomFormat = "yyyyMMMMdddd dd";
            dtpEndDate.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(236, 189);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(314, 36);
            dtpEndDate.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.ButtonHighlight;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(294, 293);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(182, 55);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 82);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 4;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 163);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 5;
            label2.Text = "End Date:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(813, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "Form1";
            Text = "Sales Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerate;
        private Label label1;
        private Label label2;
    }
}
