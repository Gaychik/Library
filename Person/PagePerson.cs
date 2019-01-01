using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibrary.Controllers;
using NewLibrary.Person;
using NewLibrary.CreateObject;
using NewLibrary.POCO;

namespace NewLibrary
{
    public partial class PagePerson : Form
    {
        private Events events = new Events();
        private Objects objects = new Objects();
        public PagePerson()
        {
            InitializeComponent();
        
        }
         
        private void Issue_Click(object sender, EventArgs e)
        {
           
            if (Var.forms.Find(f => f.GetType() == typeof(Book.Books))==null)
               new Book.Books().Show();

            else Var.forms.Find(f => f.GetType() == typeof(Book.Books)).BringToFront();
            Buttons.AddBook.Click += events.OwnButton_Click;
            Var.groupButton.Controls.Add(Buttons.AddBook);
            
          
         }

        private void PagePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ViewBookButton_Click(object sender, EventArgs e)
        {
            using (var db=new LibraryDB())
            {
                string TextBoxValue = this.Controls.Cast<Control>().First(p => p.GetType() == typeof(TextBox)).Text;

               
                Form viewbook = new ViewBooks();
                var datagridview = objects.NewDatagridView("Books of Subscriber");
                viewbook.Controls.Add(datagridview);
                var viewBookTable = db.History.
                    Where(h => h.PersonId == new Guid(TextBoxValue)).
                    Select(h => new 
                    {  h.Book,h.DateOfIssue });
                viewbook.Show();
              datagridview.DataSource  = viewBookTable.ToList();


            }
        }
       
    }
    
    
}
