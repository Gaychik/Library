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
using NewLibrary.Controllers;
using System.Reflection;
using NewLibrary.POCO;



namespace NewLibrary.Person
{
    public partial class Persons : Form
    {
        public static List<POCO.Person> ListPerson = new List<POCO.Person>();
        private 
        Objects objects = new Objects();
       

        public Persons()
        {
            InitializeComponent();
          
        }

        private void Persons_Load(object sender, EventArgs e)
        {

            Var.forms.Add(this);

           

            Var.DataPersons = objects.NewDatagridView("Person");

            this.tableLayoutPanel2.Controls.Add(Var.DataPersons, 0, 1);
            Var.DataPersons.MouseClick += tableLayoutPanel2_MouseClick;
            Var.DataPersons.Show();
            using (LibraryDB db = new LibraryDB())
            {


                ListPerson = db.Persons.ToList();
                Var.DataPersons.DataSource = ListPerson.Select(p => new  { p.Name, p.Age, p.CountBooks, p.HomeAddress, p.TelephoneNumber }).ToList();
     
            }
     

          
          
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new AddPerson().Show();
        }

        private void tableLayoutPanel2_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (e.Button==MouseButtons.Right)
            {
                this.Controls.Add(Var.groupButton);
                BoxButtons.PopupBox(this);        
                 Buttons.MoreInformation.Click += new Events().Basebutton_ClickPersons;
            
            }
           else if (e.Button==MouseButtons.Left)
            {
              BoxButtons.Hide(this);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter.Data_Filter(SearhText, Var.DataPersons);
        }

       

       
       

    }
}
