

namespace NewLibrary.Person
{
    partial class Persons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persons));
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Filter = new System.Windows.Forms.Button();
            this.SearhText = new System.Windows.Forms.TextBox();
            this.Label_Search = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.button_Filter);
            this.flowLayoutPanel4.Controls.Add(this.SearhText);
            this.flowLayoutPanel4.Controls.Add(this.Label_Search);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(599, 52);
            this.flowLayoutPanel4.TabIndex = 15;
            // 
            // button_Filter
            // 
            this.button_Filter.BackColor = System.Drawing.Color.Transparent;
            this.button_Filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Filter.BackgroundImage")));
            this.button_Filter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Filter.Location = new System.Drawing.Point(532, 6);
            this.button_Filter.Margin = new System.Windows.Forms.Padding(6);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(61, 44);
            this.button_Filter.TabIndex = 12;
            this.button_Filter.UseVisualStyleBackColor = false;
            // 
            // SearhText
            // 
            this.SearhText.Location = new System.Drawing.Point(100, 6);
            this.SearhText.Margin = new System.Windows.Forms.Padding(6);
            this.SearhText.Name = "SearhText";
            this.SearhText.Size = new System.Drawing.Size(420, 29);
            this.SearhText.TabIndex = 11;
            this.SearhText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_Search
            // 
            this.Label_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label_Search.Location = new System.Drawing.Point(15, 9);
            this.Label_Search.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label_Search.Name = "Label_Search";
            this.Label_Search.Size = new System.Drawing.Size(73, 37);
            this.Label_Search.TabIndex = 13;
            this.Label_Search.Text = "Search:";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(6, 150);
            this.Add.Margin = new System.Windows.Forms.Padding(6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 54);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update.Location = new System.Drawing.Point(6, 81);
            this.update.Margin = new System.Windows.Forms.Padding(6);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(138, 57);
            this.update.TabIndex = 6;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(6, 6);
            this.delete.Margin = new System.Windows.Forms.Padding(6);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 63);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.delete);
            this.flowLayoutPanel1.Controls.Add(this.update);
            this.flowLayoutPanel1.Controls.Add(this.Add);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(902, 70);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 223);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.20538F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.79463F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.33141F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.66859F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1078, 519);
            this.tableLayoutPanel2.TabIndex = 17;
            this.tableLayoutPanel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseClick);
            // 
            // Persons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 519);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Persons";
            this.Text = "Persons";
            this.Load += new System.EventHandler(this.Persons_Load);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.TextBox SearhText;
        private System.Windows.Forms.Label Label_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}