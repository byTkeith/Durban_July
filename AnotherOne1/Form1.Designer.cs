namespace AnotherOne1
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
            grpHorse = new GroupBox();
            lblTime3 = new Label();
            lblTime2 = new Label();
            lblTime1 = new Label();
            label4 = new Label();
            lblHeight = new Label();
            lblAge = new Label();
            lblName = new Label();
            txtTime3 = new TextBox();
            txtTime2 = new TextBox();
            txtTime1 = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtName = new TextBox();
            btnAdd = new Button();
            grpRoaster = new GroupBox();
            txtRoaster = new TextBox();
            btnPredictWinner = new Button();
            grpHorse.SuspendLayout();
            grpRoaster.SuspendLayout();
            SuspendLayout();
            // 
            // grpHorse
            // 
            grpHorse.Controls.Add(lblTime3);
            grpHorse.Controls.Add(lblTime2);
            grpHorse.Controls.Add(lblTime1);
            grpHorse.Controls.Add(label4);
            grpHorse.Controls.Add(lblHeight);
            grpHorse.Controls.Add(lblAge);
            grpHorse.Controls.Add(lblName);
            grpHorse.Controls.Add(txtTime3);
            grpHorse.Controls.Add(txtTime2);
            grpHorse.Controls.Add(txtTime1);
            grpHorse.Controls.Add(txtAge);
            grpHorse.Controls.Add(txtHeight);
            grpHorse.Controls.Add(txtName);
            grpHorse.Controls.Add(btnAdd);
            grpHorse.Location = new Point(24, 69);
            grpHorse.Name = "grpHorse";
            grpHorse.Size = new Size(286, 313);
            grpHorse.TabIndex = 0;
            grpHorse.TabStop = false;
            grpHorse.Text = "Horse";
            // 
            // lblTime3
            // 
            lblTime3.AutoSize = true;
            lblTime3.Location = new Point(19, 269);
            lblTime3.Name = "lblTime3";
            lblTime3.Size = new Size(42, 15);
            lblTime3.TabIndex = 13;
            lblTime3.Text = "Time 3";
            // 
            // lblTime2
            // 
            lblTime2.AutoSize = true;
            lblTime2.Location = new Point(19, 230);
            lblTime2.Name = "lblTime2";
            lblTime2.Size = new Size(42, 15);
            lblTime2.TabIndex = 12;
            lblTime2.Text = "Time 2";
            // 
            // lblTime1
            // 
            lblTime1.AutoSize = true;
            lblTime1.Location = new Point(19, 194);
            lblTime1.Name = "lblTime1";
            lblTime1.Size = new Size(42, 15);
            lblTime1.TabIndex = 11;
            lblTime1.Text = "Time 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 10;
            label4.Text = "Enter the last three races";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(19, 103);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 9;
            lblHeight.Text = "Height:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(19, 74);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 8;
            lblAge.Text = "Age:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Name:";
            // 
            // txtTime3
            // 
            txtTime3.Location = new Point(82, 261);
            txtTime3.Name = "txtTime3";
            txtTime3.Size = new Size(122, 23);
            txtTime3.TabIndex = 6;
            // 
            // txtTime2
            // 
            txtTime2.Location = new Point(82, 222);
            txtTime2.Name = "txtTime2";
            txtTime2.Size = new Size(122, 23);
            txtTime2.TabIndex = 5;
            // 
            // txtTime1
            // 
            txtTime1.Location = new Point(82, 186);
            txtTime1.Name = "txtTime1";
            txtTime1.Size = new Size(122, 23);
            txtTime1.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(71, 66);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(122, 23);
            txtAge.TabIndex = 3;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(71, 103);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(122, 23);
            txtHeight.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(67, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(192, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpRoaster
            // 
            grpRoaster.Controls.Add(txtRoaster);
            grpRoaster.Location = new Point(336, 69);
            grpRoaster.Name = "grpRoaster";
            grpRoaster.Size = new Size(452, 272);
            grpRoaster.TabIndex = 1;
            grpRoaster.TabStop = false;
            grpRoaster.Text = "Roaster";
            // 
            // txtRoaster
            // 
            txtRoaster.Location = new Point(18, 37);
            txtRoaster.Multiline = true;
            txtRoaster.Name = "txtRoaster";
            txtRoaster.Size = new Size(414, 208);
            txtRoaster.TabIndex = 0;
            // 
            // btnPredictWinner
            // 
            btnPredictWinner.Location = new Point(106, 399);
            btnPredictWinner.Name = "btnPredictWinner";
            btnPredictWinner.Size = new Size(108, 23);
            btnPredictWinner.TabIndex = 2;
            btnPredictWinner.Text = "Predict Winner";
            btnPredictWinner.UseVisualStyleBackColor = true;
            btnPredictWinner.Click += btnPredictWinner_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPredictWinner);
            Controls.Add(grpRoaster);
            Controls.Add(grpHorse);
            Name = "Form1";
            Text = "Form1";
            grpHorse.ResumeLayout(false);
            grpHorse.PerformLayout();
            grpRoaster.ResumeLayout(false);
            grpRoaster.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpHorse;
        private Button btnAdd;
        private GroupBox grpRoaster;
        private TextBox txtRoaster;
        private Button btnPredictWinner;
        private Label lblTime3;
        private Label lblTime2;
        private Label lblTime1;
        private Label label4;
        private Label lblHeight;
        private Label lblAge;
        private Label lblName;
        private TextBox txtTime3;
        private TextBox txtTime2;
        private TextBox txtTime1;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtName;
    }
}
