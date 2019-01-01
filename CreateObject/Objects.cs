
using System.Windows.Forms;
using System.Drawing;
using NewLibrary.Controllers;
using NewLibrary.Person;

namespace NewLibrary.CreateObject
{
  public  class Objects
    { 
        public DataGridView NewDatagridView( string name)
        {
            var sender = new DataGridView
            {
                Name = name,
        
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                Dock = DockStyle.Fill,
               
                Location =new Point(20,30)


            };
            sender.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sender.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            sender.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sender.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sender.AllowUserToAddRows = false;
            sender.ReadOnly = true;

             
            return sender;

        }
        public void NewButton(ref Button button, Form form)
        {
            
            button = new Button
            {
                Text = "Add",
                Size = new Size(96, 30),
                Font = new Font("Microsoft sans Serif", 12F),
                Visible = true,
                

            };
           
            form.Controls.Add(button);
            
        }
        public Button NewButton(string Name)
        {
            var button = new Button
            {
                Text = Name,
                Size = new Size(90, 30),
                Font = new Font("Microsoft sans Serif", 12F),
                Visible = true,
                Dock = DockStyle.Top

        };
       

            return button;
            
          




         }

    

        public GroupBox NewGroupBox( GroupBox group)
        {
             group = new GroupBox
            { 
                AutoSize=true,
              
                Visible = true
            };
            return group;
        }

       
        public void NewTabPage(ref TabPage tabPage, string name, string text)
        {
            tabPage = new TabPage { Name = name, Text = text };

        }

        public void newTrackBar(ref TrackBar trackBar, int Max, int Min)
        {
            trackBar = new TrackBar { Maximum = Max, Minimum = Min, TickStyle = TickStyle.TopLeft, SmallChange = 1, TickFrequency = 1 };
        }
        public Label NewLabel(int x,int y,string value)
        {
           return new Label
            {
                Text = value,


                Location = new Point(x, y),

                AutoSize = true,

                

            };
            
            
        }

        public Control NewTextBox(int x ,int y,string value)
        {

          return  new TextBox
            {
                Text = value,
                Location = new Point(x, y),
                Size = new Size(270, 30)


            };




        }

    }
}
