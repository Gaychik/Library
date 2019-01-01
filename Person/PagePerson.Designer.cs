namespace NewLibrary
{
    partial class PagePerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDebtor = new System.Windows.Forms.Label();
            this.Issue = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewBookButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "PersonId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Home Address:";
            // 
            // labelDebtor
            // 
            this.labelDebtor.AutoSize = true;
            this.labelDebtor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebtor.Location = new System.Drawing.Point(488, 9);
            this.labelDebtor.Name = "labelDebtor";
            this.labelDebtor.Size = new System.Drawing.Size(0, 31);
            this.labelDebtor.TabIndex = 11;
            // 
            // Issue
            // 
            this.Issue.Location = new System.Drawing.Point(494, 302);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(145, 37);
            this.Issue.TabIndex = 12;
            this.Issue.Text = "Issue a book";
            this.Issue.UseVisualStyleBackColor = true;
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Count Books:";
            // 
            // ViewBookButton
            // 
            this.ViewBookButton.Location = new System.Drawing.Point(21, 289);
            this.ViewBookButton.Name = "ViewBookButton";
            this.ViewBookButton.Size = new System.Drawing.Size(145, 37);
            this.ViewBookButton.TabIndex = 15;
            this.ViewBookButton.Text = "View Books";
            this.ViewBookButton.UseVisualStyleBackColor = true;
            this.ViewBookButton.Click += new System.EventHandler(this.ViewBookButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telephone Number:";
            // 
            // PagePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 351);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewBookButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.labelDebtor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(672, 390);
            this.Name = "PagePerson";
            this.Text = "PagePerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PagePerson_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDebtor;
        private System.Windows.Forms.Button Issue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ViewBookButton;
        private System.Windows.Forms.Label label5;
    }
}