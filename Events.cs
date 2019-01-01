using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibrary.Controllers;
using NewLibrary.CreateObject;
using NewLibrary.POCO;
using LinqToDB;
using System.Reflection;
using NewLibrary.Book;
using NewLibrary.Person;



namespace NewLibrary
{

    class Events
    {
        static Form page;

        private Objects objects = new Objects();
        public void Basebutton_ClickPersons(object sender, EventArgs e)

        {

            page = new PagePerson();
            
            BoxButtons.Hide(Var.forms.Find(f=>f.GetType()==typeof(Persons)));

            int y = 0;
          
            var rowIndex = 0;
            foreach (DataGridViewRow item in Var.DataPersons.SelectedRows)
                rowIndex = item.Index;
            var PropertyPerson = Persons.ListPerson[rowIndex].GetType().GetProperties() ;
          

            foreach (var prop in PropertyPerson)
            {
                var value = prop.GetValue(Persons.ListPerson[rowIndex]);
                if (value==null)
                    value = "";
                
                var TextBox = objects.NewTextBox(200, 30 + y,value.ToString());
                page.Controls.Add(TextBox) ;

                y += 40;
               


            }
            
            page.Show();

            (sender as Button).Click -= Basebutton_ClickPersons;
            
        }
        public void Basebutton_ClickBooks(object sender, EventArgs e)

        {


            page = new PageBook();
            BoxButtons.Hide(Var.forms.Find(f => f.GetType() == typeof(Books)));
            
            int y = 0;
         
            int rowIndex = 0; 
            foreach (DataGridViewRow item in Var.DataBooks.SelectedRows)          
                rowIndex = item.Index;

            var PropertyBook = Books.ListBook[rowIndex].GetType().GetProperties();
      

            foreach (var prop in PropertyBook)
            {
                var value = prop.GetValue(Persons.ListPerson[rowIndex]);
                if (value == null)
                    value = "";
                var TextBox = objects.NewTextBox(200, 20 + y, value.ToString());
                page.Controls.Add(TextBox);

                y += 40;
            }
            
            page.Show();
            (sender as Button).Click -= Basebutton_ClickBooks;

        }


        public void OwnButton_Click(object sender, EventArgs e)
        {
           
           
            Var.groupButton.Controls.Remove(sender as Control);
          
            var db = new LibraryDB();
            foreach (DataGridViewRow rowBook in Var.DataBooks.SelectedRows)
            {

                var history = new History

                {
                    Id = Guid.NewGuid(),
                  
                    Book = rowBook.Cells["Name_Book"].Value.ToString(),
                    DateOfIssue = DateTime.Now
                };
                var Book = db.Books.Single(b => b.Name_Book == rowBook.Cells["Name_Book"].Value.ToString());
                history.BookId = Book.BookId;
                foreach (DataGridViewRow rowPerson in Var.DataPersons.SelectedRows)
                {
                    var Person = db.Persons.Single(p => p.TelephoneNumber == rowPerson.Cells["TelephoneNumber"].Value.ToString());

                    history.PersonId = Person.NameId;
                    history.Person = rowPerson.Cells["Name"].Value.ToString();
                }
               
              
                db.Insert(history);

                Buttons.AddBook.Click -=OwnButton_Click;
                BoxButtons.Hide(Var.forms.Find(f => f.GetType() == typeof(Books)));
                Var.groupButton.Controls.Remove(Buttons.AddBook);
            }




        }





    }
}

