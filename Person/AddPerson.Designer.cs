namespace NewLibrary.Person
{
    partial class AddPerson
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
            this.components = new System.ComponentModel.Container();
            this.PersonText = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.Home_addressText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telephone_NumberText = new System.Windows.Forms.MaskedTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // PersonText
            // 
            this.PersonText.Location = new System.Drawing.Point(211, 24);
            this.PersonText.Margin = new System.Windows.Forms.Padding(6);
            this.PersonText.Name = "PersonText";
            this.PersonText.Size = new System.Drawing.Size(180, 29);
            this.PersonText.TabIndex = 0;
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(211, 61);
            this.AgeText.Margin = new System.Windows.Forms.Padding(6);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(180, 29);
            this.AgeText.TabIndex = 1;
            // 
            // Home_addressText
            // 
            this.Home_addressText.Location = new System.Drawing.Point(211, 97);
            this.Home_addressText.Margin = new System.Windows.Forms.Padding(6);
            this.Home_addressText.Name = "Home_addressText";
            this.Home_addressText.Size = new System.Drawing.Size(180, 29);
            this.Home_addressText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Home_address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telephone_Number:";
            // 
            // telephone_NumberText
            // 
            this.telephone_NumberText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.telephone_NumberText.Location = new System.Drawing.Point(211, 135);
            this.telephone_NumberText.Mask = "+7(999) 000-0000";
            this.telephone_NumberText.Name = "telephone_NumberText";
            this.telephone_NumberText.Size = new System.Drawing.Size(180, 29);
            this.telephone_NumberText.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(404, 132);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(149, 32);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 241);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.telephone_NumberText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Home_addressText);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.PersonText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(621, 280);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PersonText;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.TextBox Home_addressText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox telephone_NumberText;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}