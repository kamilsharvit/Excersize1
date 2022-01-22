using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KamilSharvit
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> CountNames;
        Dictionary<string, string> names;
        List<int> counts;
        public Form1()
        {
            InitializeComponent();
            counts = new List<int>();
            CountNames = new Dictionary<string, int>();
            //CountNames.Add("Jacob", 0);
            //CountNames.Add("Yaakov", 1);
            //CountNames.Add("Yaacov", 2);
            //CountNames.Add("Tomer",3);
            //CountNames.Add("Tommer", 4);
            //CountNames.Add("Sara", 5);
            names = new Dictionary<string, string>();
            //names.Add("Jacob", "Yaakov");
            //names.Add("Yaakov", "Yaacov");
            //names.Add("Tomer", "Tommer");
            //counts.Add(15);
            //counts.Add(12);
            //counts.Add(1);
            //counts.Add(13);
            //counts.Add(4);
            //counts.Add(19);
        }
        //הפונקציה מוסיפה לרשימה הראשונה את השם והאינדקס שלו ובתוך הרשימה של התדירות שמה את מספר הפעמים
        private void addList1_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text != "" && countOfName.Value != 0)
            {
                CountNames.Add(nameTxt.Text, CountNames.Count);
                counts.Add(Convert.ToInt32(countOfName.Value));
            }
            else
                MessageBox.Show("enter value");
            nameTxt.Text = "";
            countOfName.Value = 0;
        }
        //הפונקציה מוסיפה לרשימה השנייה את שתי השמות
        private void addList2_Click(object sender, EventArgs e)
        {
            if (name1.Text != "" && name2.Text != "")
            {
                names.Add(name1.Text, name2.Text);
            }
            else
                MessageBox.Show("enter value");
            name1.Text = "";
            name2.Text = "";
        }
//הפונקציה ממזגת את שתי הרשימות על ידי שמציגה את זה במסך
        private void mizug_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            KeyValuePair<string, int> q1, q2;
            int index1, index2;
            foreach (var item in names)
            {
                q1 = CountNames.FirstOrDefault(x => x.Key == item.Key);
                q2 = CountNames.FirstOrDefault(x => x.Key == item.Value);
                if (q1.Value != q2.Value)
                {
                    index1 = q1.Value;
                    index2 = q2.Value;
                    counts[index1] += counts[index2];
                    counts[index2] = -1;
                    CountNames.Remove(q2.Key);
                    CountNames.Add(q2.Key, index1);
                }

                //q2.Value = index;
                //int index = CountNames.FirstOrDefault(x => x.Key == item.Key).Value;
                //int index2 = CountNames.FirstOrDefault(x => x.Key == item.Value).Value;
            }
            
            foreach (var item in CountNames)
            {
                if(counts[item.Value]!=-1)
                {
                    listBox1.Items.Add(item.Key + " " + counts[item.Value]);
                    counts[item.Value] = -1;
                }
            }
        }
    }
}
