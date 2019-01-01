using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibrary.Controllers;
using System.Collections;
using NewLibrary.CreateObject;

namespace NewLibrary.Controllers
{
    class ListsGridview { }



    class BoxButtons 
    {

      //public static List<string>BaseButtonNames{ get; private set; }
      //private static Events events = new Events();
        public BoxButtons()

        {
        }

        public static void PopupBox(Form form)
        {
            Var.groupButton.Location = form.PointToClient(Cursor.Position);

            Var.groupButton.Show();

            Var.groupButton.BringToFront();
        
        }

        public static void CreateGroupButton(ref GroupBox groupBox/*,object sender*/)
        {

            //BaseButtonNames = new List<string> { "More Information" };
            var objects = new Objects();
            groupBox = objects.NewGroupBox(groupBox);

            //foreach (string item in BaseButtonNames)
            //{
            //    var button = objects.NewButton(item);

            groupBox.Controls.Add( Buttons.MoreInformation);

            //    //if (sender is Person.Persons)

            //    //button.Click += events.Basebutton_ClickPersons;
            //    //if (sender is Book.Books)
            //    //    button.Click += events.Basebutton_ClickBooks;



            //}





        }
        public static void Hide(Form form) { form.Controls.Remove(Var.groupButton); }

    

    }
}
