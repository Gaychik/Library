using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToDB.Data;
using NewLibrary.POCO;
using LinqToDB;
using NewLibrary.Controllers;

namespace NewLibrary.Person
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var db=new LibraryDB())
            {
                POCO.Person person = new POCO.Person
                {
                    NameId=Guid.NewGuid(),
                    Name = PersonText.Text,
                    Age = int.Parse(AgeText.Text),
                    HomeAddress = Home_addressText.Text,
                    TelephoneNumber = telephone_NumberText.Text

                };

                db.Insert(person);
                Operations.Update(new POCO.Person());
            }
        }
    }
}
