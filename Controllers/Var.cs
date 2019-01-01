using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLibrary.Person;
using NewLibrary.Book;


namespace NewLibrary.Controllers
{
  public  static class Var
    {
       public static DataGridView DataPersons,DataBooks,DataDebtors,DataReaders;

        public static List<Form> forms = new List<Form>();



        public static List<Button> buttonslist = new List<Button>();
        public static GroupBox groupButton;
    }
}
