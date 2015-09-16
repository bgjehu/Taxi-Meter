using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Taxi_Meter
{
    public partial class mainframe : Form
    {
        public mainframe()
        {
            MessageBox.Show("Welcome Using Taxi Meter!", "Msg");
            InitializeComponent();
        }
        struct journey
        {
            public string name;
            public string phone;
            public string startpt;
            public string destination;
            public DateTime[] time;
            public double[] cost;
        }

        /*
        string[] name = new string[10];
        string[] phone = new string[10];
        string[] startpt = new string[10];
        string[] destination = new string[10];
        */
        const double price1 = 0.005 * 60;
        const double price2 = 0.0025 * 60;
        int ordernum = 0;
        int timeindex = 0;
        Regex rgx1 = new Regex(@"^\d{10}$");
        Regex rgx2 = new Regex(@"^\d{11}$");
        public string log = null;
        bool IsStarted = false;
        bool IsPaused = false;
        bool IsStopped = true;
        bool IsLoaded = false;
        journey[] jny = new journey[10];

        
        

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (IsLoaded) { }
            else 
            {
                //Select Default Country Code
                if (ComboBox_Code.SelectedIndex == -1)
                { ComboBox_Code.SelectedIndex = 0; }

                //Handle No Name
                if (String.IsNullOrEmpty(TextBox_Name.Text))
                { MessageBox.Show("Please input customer name", "Msg"); }

                //Handle No PhoneNo
                else if (String.IsNullOrEmpty(TextBox_PhoneNo.Text))
                { MessageBox.Show("Please input phone number", "Msg"); }

                //Handle Invalid Phone#
                else if ((ComboBox_Code.SelectedIndex == 0 && !rgx1.IsMatch(TextBox_PhoneNo.Text))
                   || (ComboBox_Code.SelectedIndex == 1 && !rgx2.IsMatch(TextBox_PhoneNo.Text)))
                {
                    DialogResult tmp;
                    tmp = MessageBox.Show("Clear Phone#?", "Invalid Phone", MessageBoxButtons.YesNo);
                    if (tmp == System.Windows.Forms.DialogResult.Yes)
                    { TextBox_PhoneNo.Text = null; }
                }

                //Handle No Starting Point
                else if (String.IsNullOrEmpty(TextBox_StartPt.Text))
                { MessageBox.Show("Please input starting point", "Msg"); }

                //Handle No Destination
                else if (String.IsNullOrEmpty(TextBox_Destination.Text))
                { MessageBox.Show("Please input destination", "Msg"); }

                else
                {
                    //Record Inputs
                    jny[ordernum].name = TextBox_Name.Text;
                    jny[ordernum].phone = ComboBox_Code.SelectedItem.ToString() + "-" + TextBox_PhoneNo.Text;
                    jny[ordernum].startpt = TextBox_StartPt.Text;
                    jny[ordernum].destination = TextBox_Destination.Text;

                    log = log + "Customer: " + jny[ordernum].name + "(" + jny[ordernum].phone + ")" + System.Environment.NewLine
                        + "Drive from " + jny[ordernum].startpt + " to " + jny[ordernum].destination + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    IsLoaded = true;
                }
                
            }

        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (IsLoaded)
            {
                if (IsStarted)
                {
                    MessageBox.Show("Metet has started already", "Msg");
                }
                else
                {
                    jny[ordernum].time = new DateTime[100];
                    jny[ordernum].cost = new Double[100];
                    jny[ordernum].time[timeindex] = DateTime.Now;
                    log = log + jny[ordernum].time[timeindex].ToShortDateString() + " " + jny[ordernum].time[timeindex].ToLongTimeString() + " " + "START" + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    IsStarted = true;
                    IsStopped = false;
                    timeindex++;
                }
            }
            else { MessageBox.Show("Please input and confirm customer info.", "Msg"); }
            
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            if (!IsStarted)
            {
                MessageBox.Show("Metet has not started yet", "Msg");
            }
            else if (IsStopped)
            {
                MessageBox.Show("Metet has stopped already", "Msg");
            }
            else
            {
                if (IsPaused)
                {
                    jny[ordernum].time[timeindex] = DateTime.Now;
                    double tstmp = jny[ordernum].time[timeindex].Subtract(jny[ordernum].time[timeindex - 1]).Duration().Minutes;
                    jny[ordernum].cost[timeindex - 1] = tstmp * price2;
                    log = log + jny[ordernum].time[timeindex].ToShortDateString() + " " + jny[ordernum].time[timeindex].ToLongTimeString() + " " + "RESUME" + System.Environment.NewLine
                        + tstmp + " Mins Park: $" + jny[ordernum].cost[timeindex - 1] + " = " + tstmp + " x " + price1 + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    Button_Pause.Text = "Pause";
                    IsPaused = false;
                    timeindex++;
                }
                else
                {
                    jny[ordernum].time[timeindex] = DateTime.Now;
                    double tstmp = jny[ordernum].time[timeindex].Subtract(jny[ordernum].time[timeindex - 1]).Duration().Minutes;
                    jny[ordernum].cost[timeindex - 1] = tstmp * price1;
                    log = log + jny[ordernum].time[timeindex].ToShortDateString() + " " + jny[ordernum].time[timeindex].ToLongTimeString() + " " + "PAUSE" + System.Environment.NewLine
                        + tstmp + " Mins Drive: $" + jny[ordernum].cost[timeindex - 1] + " = " + tstmp + " x " + price1 + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    Button_Pause.Text = "Resume";
                    IsPaused = true;
                    timeindex++;
                }
            }
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            if (!IsStarted)
            {
                MessageBox.Show("Metet has not started yet", "Msg");
            }
            else if (IsStopped)
            {
                MessageBox.Show("Metet has stopped already", "Msg");
            }
            else
            {
                if (IsPaused)
                {
                    log = log + jny[ordernum].time[timeindex-1].ToShortDateString() + " " + jny[ordernum].time[timeindex-1].ToLongTimeString() + " " + "STOP" + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    Button_Pause.Text = "Pause";
                    IsStopped = true;
                }
                else
                {
                    jny[ordernum].time[timeindex] = DateTime.Now;
                    double tstmp = jny[ordernum].time[timeindex].Subtract(jny[ordernum].time[timeindex - 1]).Duration().Minutes;
                    jny[ordernum].cost[timeindex - 1] = tstmp * price1;
                    log = log + jny[ordernum].time[timeindex].ToShortDateString() + " " + jny[ordernum].time[timeindex].ToLongTimeString() + " " + "STOP" + System.Environment.NewLine
                        + tstmp + " Mins Drive: $" + jny[ordernum].cost[timeindex - 1] + " = " + tstmp + " x " + price1 + System.Environment.NewLine;
                    TextBox_Log.Text = log;
                    IsPaused = true;
                    timeindex++;
                }

                double total = 0;
                for (int i = 0; i < timeindex; i++)
                {
                    total = total + jny[ordernum].cost[i];
                }
                log = log + "Total: $" + total + System.Environment.NewLine + System.Environment.NewLine;
                TextBox_Log.Text = log;
                IsStarted = false;
                IsPaused = false;
                IsLoaded = false;
                timeindex = 0;
                ordernum++;
                TextBox_Name.Clear();
                TextBox_PhoneNo.Clear();
                TextBox_StartPt.Clear();
                TextBox_Destination.Clear();

            }
        }

        private void TextBox_Log_TextChanged(object sender, EventArgs e)
        {
            TextBox_Log.ScrollBars = ScrollBars.Vertical;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
    }
}
