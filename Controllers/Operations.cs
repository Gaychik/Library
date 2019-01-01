using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLibrary.POCO;
using NewLibrary.Controllers;
using System.Windows.Forms;
using NewLibrary.CreateObject;
using System.Collections;

namespace NewLibrary.Controllers
{
    class Operations
    {
         
        //public static void Back(LibraryDB db, int indicator, Database database)
        //{
        //    object query;
        //    int pageNumber = 0;
        //    int pageSize = 10;
        //    int count = 0;
        //    pageNumber--;
        //    if (pageNumber < 0)
        //    {
        //        MessageBox.Show("You are on the initial a page ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        pageNumber += 1;
        //    }
        //    else
        //    {
        //        count = db.Persons.Count();
        //        if (count > pageNumber * pageSize)
        //        {
        //            switch (indicator)
        //            {
        //                case 1:
        //                    {
        //                        query = database.Connection_Debtors();
        //                        Var.bindingSourceDebtors.DataSource = query;
        //                        Main.dataDebtors.DataSource = Var.bindingSourceDebtors;
        //                        break;
        //                    }
        //                case 2:
        //                    {
        //                        query = database.Connection_Book();
        //                        Var.bindingSourcebooks.DataSource = query;
        //                        Main.dataGridBooks.DataSource = Var.bindingSourcebooks;
        //                        break;
        //                    }
        //                case 3:
        //                    {
        //                        query = database.Connection_Person();
        //                        Var.bindingSourceReader.DataSource = query;
        //                        Main.dataReaders.DataSource = Var.bindingSourceReader;
        //                        break;
        //                    }
        //                case 4:
        //                    {
        //                        query = database.Connection_Issuance();
        //                        Var.bindingSourceIssuance.DataSource = query;
        //                        Main.dataIssuance.DataSource = Var.bindingSourceIssuance;
        //                        break;
        //                    }

        //                default:
        //                    break;
        //            }



        //        }

        //    }
        //}
        //public static void Next(LibraryDB db, int indicator, Database database)
        //{
        //    object query;
        //    int pageNumber = 0;
        //    int pageSize = 10;
        //    int count = 0;
        //    pageNumber++;

        //    if (pageNumber < 0)
        //    {
        //        MessageBox.Show("Вы находите на начальной странице", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        //        pageNumber -= 1;
        //    }
        //    else
        //    {


        //        count = db.Persons.Count();
        //        if (count > pageNumber * pageSize)
        //        {
        //            switch (indicator)
        //            {
        //                case 1:
        //                    {
        //                        query = database.Connection_Debtors();
        //                        Var.bindingSourceDebtors.DataSource = query;
        //                        Main.dataDebtors.DataSource = Var.bindingSourceDebtors;
        //                        break;
        //                    }
        //                case 2:
        //                    {
        //                        query = database.Connection_Book();
        //                        Var.bindingSourcebooks.DataSource = query;
        //                        Main.dataGridBooks.DataSource = Var.bindingSourcebooks;
        //                        break;
        //                    }
        //                case 3:
        //                    {
        //                        query = database.Connection_Person();
        //                        Var.bindingSourceReader.DataSource = query;
        //                        Main.dataReaders.DataSource = Var.bindingSourceReader;
        //                        break;
        //                    }
        //                case 4:
        //                    {
        //                        query = database.Connection_Issuance();
        //                        Var.bindingSourceIssuance.DataSource = query;
        //                        Main.dataIssuance.DataSource = Var.bindingSourceIssuance;
        //                        break;
        //                    }

        //                default:
        //                    break;
        //            }


        //        }

        //    }
        //}
        public static void Update<T>(T database)
        {
            using (var db=new LibraryDB())
            {
                
                if (database is POCO.Person) Var.DataPersons.DataSource = db.Persons.ToList();
               
            }
           

        }
        //public static void Delete()
        //{
        //    using (db = new LibraryDB())
        //    {

        //        if (indicator == 2)
        //        {
        //            foreach (DataGridViewRow r in Main.dataGridBooks.SelectedRows)
        //            {
        //                db.Books.Where(p => p.BookId == new Guid(r.Cells["BookId"].Value.ToString())).Delete();
        //                foreach (Book item in Var.Books)
        //                {
        //                    if (item.BookId == new Guid(r.Cells["BookId"].Value.ToString()))
        //                    {

        //                        Var.Books.Remove(item);
        //                        break;
        //                    }
        //                }

        //            }
        //            Var.bindingSourcebooks.DataSource = Var.Books.GetRange(0, Var.Books.Count);
        //            Main.dataGridBooks.DataSource = Var.bindingSourcebooks;

        //        }

        //            Var.bindingSourceReader.DataSource = Var.People.GetRange(0, Var.People.Count);
        //            Main.dataReaders.DataSource = Var.bindingSourceReader;
        //        }



        //    }





        //public static void dataBindingClear()
        //{
        //    Var.textBoxPerson.Clear();
        //    Var.textBoxPerson.Clear();


        //}



        //public static void Clear_Controls(params Control[] controls)
        //{



        //    foreach (Control item in controls)
        //    {
        //        if (item is ComboBox)
        //        {
        //            (item as ComboBox).DataSource = null;
        //        }

        //        if (item is TextBox)
        //        {
        //            (item as TextBox).Clear();
        //        }


        //    }
        //}
        //public static void DataGridViewRowsVisible(DataGridView dataGridView, bool state)
        //{
        //    foreach (DataGridViewRow item in dataGridView.Rows)
        //    {
        //        if (int.Parse(item.Cells["CountCopies"].Value.ToString()) <= 0)
        //        {
        //            item.Visible = state;

        //        }
        //    }
        //}
        //public static IEnumerable<object> Enumerator(int index)
        //{
           

        //    foreach (object item in Person.Persons.ListPerson[index])
        //    {
        //        yield return item;
        //    }

        //}

        

    }
}
