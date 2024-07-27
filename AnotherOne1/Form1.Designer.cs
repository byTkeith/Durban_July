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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            grpHorse.Controls.Add(label7);
            grpHorse.Controls.Add(label6);
            grpHorse.Controls.Add(label5);
            grpHorse.Controls.Add(label4);
            grpHorse.Controls.Add(label3);
            grpHorse.Controls.Add(label2);
            grpHorse.Controls.Add(label1);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 269);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 13;
            label7.Text = "Time 3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 230);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 12;
            label6.Text = "Time 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 194);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Time 1";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 103);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Height:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 74);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Name:";
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
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTime3;
        private TextBox txtTime2;
        private TextBox txtTime1;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtName;
    }
}
