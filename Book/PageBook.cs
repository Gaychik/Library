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

namespace NewLibrary.Book
{
    public partial class PageBook : Form
    {
        private Objects objects = new Objects();
        public PageBook()
        {
            InitializeComponent();
        }

        private void CountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TextBoxValue = this.Controls.Cast<Control>().First(p => p.GetType() == typeof(TextBox)).Text;

            using (var db=new LibraryDB())
            {
                Form viewbook = new ViewPersons();

                var datagridview = objects.NewDatagridView("Persons");

                viewbook.Controls.Add(datagridview);

                var viewBookTable = db.History.
                    Where(h => h.BookId == new Guid(TextBoxValue)).
                    Select(h => new
                    { h.PersonId, h.Person,h.DateOfIssue });

                viewbook.Show();
                datagridview.DataSource = viewBookTable.ToList();
            }
           

        }
    }
}
