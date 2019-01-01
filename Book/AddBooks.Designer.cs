namespace NewLibrary.Book
{
    partial class AddBooks
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
            this.Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorText = new System.Windows.Forms.TextBox();
            this.BookText = new System.Windows.Forms.TextBox();
            this.BookIdText = new System.Windows.Forms.TextBox();
            this.Date_RegisterText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(500, 103);
            this.Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(137, 40);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date_Register:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Book:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "BookId:";
            // 
            // AuthorText
            // 
            this.AuthorText.Location = new System.Drawing.Point(156, 78);
            this.AuthorText.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.AuthorText.Name = "AuthorText";
            this.AuthorText.Size = new System.Drawing.Size(327, 29);
            this.AuthorText.TabIndex = 14;
            // 
            // BookText
            // 
            this.BookText.Location = new System.Drawing.Point(156, 46);
            this.BookText.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.BookText.Name = "BookText";
            this.BookText.Size = new System.Drawing.Size(327, 29);
            this.BookText.TabIndex = 13;
            // 
            // BookIdText
            // 
            this.BookIdText.Location = new System.Drawing.Point(156, 13);
            this.BookIdText.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.BookIdText.Name = "BookIdText";
            this.BookIdText.Size = new System.Drawing.Size(327, 29);
            this.BookIdText.TabIndex = 12;
            // 
            // Date_RegisterText
            // 
            this.Date_RegisterText.Location = new System.Drawing.Point(156, 114);
            this.Date_RegisterText.Name = "Date_RegisterText";
            this.Date_RegisterText.Size = new System.Drawing.Size(327, 29);
            this.Date_RegisterText.TabIndex = 21;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 164);
            this.Controls.Add(this.Date_RegisterText);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthorText);
            this.Controls.Add(this.BookText);
            this.Controls.Add(this.BookIdText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(669, 203);
            this.Name = "AddBooks";
            this.Text = "AddBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorText;
        private System.Windows.Forms.TextBox BookText;
        private System.Windows.Forms.TextBox BookIdText;
        private System.Windows.Forms.TextBox Date_RegisterText;
    }
}