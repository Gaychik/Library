using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLibrary.Controllers
{
    class Filter
    {
        public static void Data_Filter(TextBox textbox, DataGridView datagridView)
        {

            for (int i = 0; i < datagridView.RowCount; i++)
            {
                datagridView.CurrentCell = null;
                datagridView.Rows[i].Visible = false;

            }
            for (int i = 0; i < datagridView.ColumnCount; i++)
            {

                for (int j = 0; j < datagridView.RowCount; j++)
                {
                    if (datagridView[i, j].Value == null) continue;
                    
                    else if (datagridView[i, j].Value.ToString().ToLower().IndexOf(textbox.Text.Trim().ToLower()) != -1)
                    {
                        datagridView.Rows[j].Visible = true;
                    }

                }
            }

        }

    }
}
