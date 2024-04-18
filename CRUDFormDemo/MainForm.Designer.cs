namespace CRUDFormDemo
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            insertButton = new Button();
            studentRecordGridView = new DataGridView();
            updateButton = new Button();
            deleteButton = new Button();
            resetButton = new Button();
            studentNameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            rollNumberText = new TextBox();
            label3 = new Label();
            addressText = new TextBox();
            label4 = new Label();
            fatherNameText = new TextBox();
            label5 = new Label();
            phoneNumberText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)studentRecordGridView).BeginInit();
            SuspendLayout();
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.Chartreuse;
            insertButton.FlatAppearance.BorderSize = 0;
            insertButton.FlatStyle = FlatStyle.Flat;
            insertButton.Font = new Font("Verdana", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertButton.Location = new Point(12, 282);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(117, 37);
            insertButton.TabIndex = 6;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += insertButton_Click;
            // 
            // studentRecordGridView
            // 
            studentRecordGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentRecordGridView.Location = new Point(12, 325);
            studentRecordGridView.Name = "studentRecordGridView";
            studentRecordGridView.RowHeadersWidth = 47;
            studentRecordGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentRecordGridView.Size = new Size(783, 223);
            studentRecordGridView.TabIndex = 50;
            studentRecordGridView.CellClick += studentRecordGridView_CellClick;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Yellow;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Verdana", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(135, 282);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(117, 37);
            updateButton.TabIndex = 7;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Red;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Verdana", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(258, 282);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(117, 37);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.DeepSkyBlue;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Verdana", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(381, 282);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(117, 37);
            resetButton.TabIndex = 9;
            resetButton.Text = "Clear";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // studentNameText
            // 
            studentNameText.Font = new Font("Verdana", 11.7818184F);
            studentNameText.Location = new Point(50, 55);
            studentNameText.Name = "studentNameText";
            studentNameText.Size = new Size(337, 29);
            studentNameText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.7818184F);
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(139, 22);
            label1.TabIndex = 8;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.7818184F);
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 10;
            label2.Text = "Roll Number";
            // 
            // rollNumberText
            // 
            rollNumberText.Font = new Font("Verdana", 11.7818184F);
            rollNumberText.Location = new Point(50, 121);
            rollNumberText.Name = "rollNumberText";
            rollNumberText.Size = new Size(337, 29);
            rollNumberText.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.7818184F);
            label3.Location = new Point(50, 163);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 12;
            label3.Text = "Address";
            // 
            // addressText
            // 
            addressText.Font = new Font("Verdana", 11.7818184F);
            addressText.Location = new Point(50, 188);
            addressText.Name = "addressText";
            addressText.Size = new Size(337, 29);
            addressText.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.7818184F);
            label4.Location = new Point(419, 30);
            label4.Name = "label4";
            label4.Size = new Size(126, 22);
            label4.TabIndex = 14;
            label4.Text = "Father Name";
            // 
            // fatherNameText
            // 
            fatherNameText.Font = new Font("Verdana", 11.7818184F);
            fatherNameText.Location = new Point(419, 55);
            fatherNameText.Name = "fatherNameText";
            fatherNameText.Size = new Size(337, 29);
            fatherNameText.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.7818184F);
            label5.Location = new Point(419, 96);
            label5.Name = "label5";
            label5.Size = new Size(143, 22);
            label5.TabIndex = 16;
            label5.Text = "Phone Number";
            // 
            // phoneNumberText
            // 
            phoneNumberText.Font = new Font("Verdana", 11.7818184F);
            phoneNumberText.Location = new Point(419, 121);
            phoneNumberText.Name = "phoneNumberText";
            phoneNumberText.Size = new Size(337, 29);
            phoneNumberText.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(807, 560);
            Controls.Add(label5);
            Controls.Add(phoneNumberText);
            Controls.Add(label4);
            Controls.Add(fatherNameText);
            Controls.Add(label3);
            Controls.Add(addressText);
            Controls.Add(label2);
            Controls.Add(rollNumberText);
            Controls.Add(label1);
            Controls.Add(studentNameText);
            Controls.Add(resetButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(studentRecordGridView);
            Controls.Add(insertButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentRecordGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button insertButton;
        private DataGridView studentRecordGridView;
        private Button updateButton;
        private Button deleteButton;
        private Button resetButton;
        private TextBox studentNameText;
        private Label label1;
        private Label label2;
        private TextBox rollNumberText;
        private Label label3;
        private TextBox addressText;
        private Label label4;
        private TextBox fatherNameText;
        private Label label5;
        private TextBox phoneNumberText;
    }
}
