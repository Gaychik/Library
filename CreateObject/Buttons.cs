using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLibrary.CreateObject
{
  static  class Buttons
    {
      static  Objects objects = new Objects();
        public static Button MoreInformation = objects.NewButton("More Information");
        //public static Button Moreinformation { get  set { value = objects.NewButton("More Information"); } }
        public static  Button AddBook  = objects.NewButton("Add Book"); 
        
    }
}
