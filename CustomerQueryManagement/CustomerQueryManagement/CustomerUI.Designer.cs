namespace CustomerQueryManagement
{
    partial class CustomerUI
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dequeueButton = new System.Windows.Forms.Button();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.complainDequeueTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameDequeueTextBox = new System.Windows.Forms.TextBox();
            this.serialDequeueTextBox = new System.Windows.Forms.TextBox();
            this.complainEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.remainingLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.servedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Complain";
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "serial";
            // 
            // customerListView
            // 
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.Location = new System.Drawing.Point(47, 267);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(529, 168);
            this.customerListView.TabIndex = 31;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(516, 86);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 30;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(206, 91);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 29;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // complainDequeueTextBox
            // 
            this.complainDequeueTextBox.Location = new System.Drawing.Point(377, 184);
            this.complainDequeueTextBox.Name = "complainDequeueTextBox";
            this.complainDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainDequeueTextBox.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Complain";
            // 
            // nameDequeueTextBox
            // 
            this.nameDequeueTextBox.Location = new System.Drawing.Point(377, 135);
            this.nameDequeueTextBox.Name = "nameDequeueTextBox";
            this.nameDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDequeueTextBox.TabIndex = 26;
            // 
            // serialDequeueTextBox
            // 
            this.serialDequeueTextBox.Location = new System.Drawing.Point(377, 86);
            this.serialDequeueTextBox.Name = "serialDequeueTextBox";
            this.serialDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialDequeueTextBox.TabIndex = 25;
            // 
            // complainEnqueueTextBox
            // 
            this.complainEnqueueTextBox.Location = new System.Drawing.Point(100, 149);
            this.complainEnqueueTextBox.Name = "complainEnqueueTextBox";
            this.complainEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.complainEnqueueTextBox.TabIndex = 24;
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(100, 93);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEnqueueTextBox.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Waiting Queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Serial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Customer Dequeue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Complain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer Enqueue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Remaining";
            // 
            // remainingLabel
            // 
            this.remainingLabel.AutoSize = true;
            this.remainingLabel.Location = new System.Drawing.Point(99, 468);
            this.remainingLabel.Name = "remainingLabel";
            this.remainingLabel.Size = new System.Drawing.Size(17, 13);
            this.remainingLabel.TabIndex = 33;
            this.remainingLabel.Text = "\"\"";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(315, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Served";
            // 
            // servedLabel
            // 
            this.servedLabel.AutoSize = true;
            this.servedLabel.Location = new System.Drawing.Point(435, 467);
            this.servedLabel.Name = "servedLabel";
            this.servedLabel.Size = new System.Drawing.Size(17, 13);
            this.servedLabel.TabIndex = 35;
            this.servedLabel.Text = "\"\"";
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 513);
            this.Controls.Add(this.servedLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.remainingLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.complainDequeueTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameDequeueTextBox);
            this.Controls.Add(this.serialDequeueTextBox);
            this.Controls.Add(this.complainEnqueueTextBox);
            this.Controls.Add(this.nameEnqueueTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerUI";
            this.Text = "Customer Query management";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox complainDequeueTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameDequeueTextBox;
        private System.Windows.Forms.TextBox serialDequeueTextBox;
        private System.Windows.Forms.TextBox complainEnqueueTextBox;
        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label remainingLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label servedLabel;
    }
}

