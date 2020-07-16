using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (Control c in Controls)
            {
                //判断控件是否为复选框控件
                if (c is CheckBox)
                {
                    if (((CheckBox) c).Checked)
                    {
                        msg = msg + " " + ((CheckBox) c).Text;
                        ((CheckBox) c).Checked = false;
                    }
                }
            }

            if (msg != "")
            {
                MessageBox.Show(msg, "提示");
            }
            else
            {
                MessageBox.Show(@"Nope!", "提示");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show(@"radioButton1.Checked");
                radioButton1.Checked = false;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = "";
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                msg = msg + " " + checkedListBox1.CheckedItems[i].ToString();
                // checkedListBox1.SetItemChecked(i,false);
            }
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                // msg = msg + " " + checkedListBox1.CheckedItems[i].ToString();
                checkedListBox1.SetItemChecked(i,false);
            }
            if (msg != "")
            {
                MessageBox.Show(msg, "提示");
            }
            else
            {
                MessageBox.Show("Nope!", "提示");
            }
        }
    }
}