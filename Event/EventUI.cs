using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itc.Event
{
    public partial class EventUI : UserControl
    {
        public EventUI(string name)
        {
            Event Event_it = new Event(name);
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Event_it.Path_Desing);
            // label1.Text = Event_it.Name;
            Text_desc.Text = Event_it.Description;
            //    LB_Des.Text = Event_it.Description;
            Event_Name.Text = Event_it.Name;
            DTP.Value = Event_it.Date;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // false
        }

        private void EventUI_Load(object sender, EventArgs e)
        {
            // false
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // apel TeamShow and Function
        }

        private void Event_Name_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}