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

// Основная форма,откуда я перехожу к базе с абонентами, также отсюда могу перейти к книгам и должникам
namespace NewLibrary
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Persons_Click(object sender, EventArgs e)
        {
        /*    Person.Persons person =*/ new Person.Persons().Show();
          
            //person.Show();

        }

        private void Debtors_Click(object sender, EventArgs e)
        {
            new Debtors().Show();
        }

        private void Books_Click(object sender, EventArgs e)
        {
            
       
           new Book.Books().Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            BoxButtons.CreateGroupButton(ref Var.groupButton)
           ;
        }
    }
}
