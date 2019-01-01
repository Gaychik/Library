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
using NewLibrary.POCO;
using NewLibrary.CreateObject;
namespace NewLibrary
{
    public partial class Debtors : Form
    {
        private
         Objects objects = new Objects();
        public Debtors()
        {
            InitializeComponent();
        }

        private void Debtors_Load(object sender, EventArgs e)
        {
            Var.DataPersons = objects.NewDatagridView("Person");

            this.tableLayoutPanel2.Controls.Add(Var.DataPersons, 0, 1);
            Var.DataPersons.Show();
            using (LibraryDB db = new LibraryDB())
            {
                Var.DataDebtors.DataSource = db.History.Where(s=>s.DeadLine.Value.Date < DateTime.Today).ToList();

            }
        }
    }
}
