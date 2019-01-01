using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibrary.CreateObject;
using NewLibrary.POCO;
using NewLibrary.Controllers;

namespace NewLibrary.Book
{
    public partial class Books : Form
    {
        public static List<POCO.Book> ListBook= new List<POCO.Book>();
   
        private
          Objects objects = new Objects();
        
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            Var.forms.Add(this);
        
        
          
            Var.DataBooks = objects.NewDatagridView("Books");

            this.tableLayoutPanel1.Controls.Add(Var.DataBooks, 0, 1);

            Var.DataBooks.MouseClick += tableLayoutPanel1_MouseClick;

            using (LibraryDB db = new LibraryDB())
            {


                ListBook = db.Books.ToList();
                Var.DataBooks.DataSource = ListBook.Select(b => new { b.Name_Book,b.Author,b. CountCopies,b.Date_Register}).ToList();

            }
        }

      

       

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Controls.Add(Var.groupButton);
                BoxButtons.PopupBox(this);
                Buttons.MoreInformation.Click += new Events().Basebutton_ClickBooks;
            }
            if (e.Button == MouseButtons.Left)
            {
                BoxButtons.Hide(this);
            }
        }
    }
}
