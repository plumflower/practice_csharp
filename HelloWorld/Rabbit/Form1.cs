using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rabbit
{
    public partial class Rabbit : Form
    {
        private Form2 anotherForm;
        private string[] names;
        private string[] nums;

        public Rabbit()
        {
            InitializeComponent();
            anotherForm = new Form2();
        }

        private void Rabbit_Load(object sender, EventArgs e)
        {
            names = new string[] { "Jason", "Jack", "Jay", "Baby" };
            nums = new string[] { "12345", "21345", "32145", "42315" };
            this.checkedListBox1.Items.AddRange(names);
            this.comboBox1.SelectedIndex = 0;
        }

        private void SayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void ShowAnotherForm_Click(object sender, EventArgs e)
        {
            anotherForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Unable to open link that was visited");
            }
        }

        private void VisitLink()
        {
            this.WelcomeToMSDN.LinkVisited = true;
            System.Diagnostics.Process.Start("http://msdn.microsoft.com");
        }

        private void HideForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.ShowBalloonTip(6000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            FontFamily oldFontFamily = this.label1.Font.FontFamily;
            FontStyle oldFontStyle = this.label1.Font.Style;
            float fontSize = this.trackBar1.Value;
            Font newFont = new Font(oldFontFamily, fontSize, oldFontStyle);
            this.label1.Font = newFont;
        }

        private void OK1_Click(object sender, EventArgs e)
        {
            string radioButtonChose = null;
            string checkButtonChose = new string('\0', 0);
            if (radioButton1.Checked)
            {
                radioButtonChose = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                radioButtonChose = radioButton2.Text;
            }

            if (radioButton3.Checked)
            {
                radioButtonChose = radioButton3.Text;
            }

            if (checkBox1.Checked)
            {
                checkButtonChose += checkBox1.Text + ",";
            }

            if (checkBox2.Checked)
            {
                checkButtonChose += checkBox2.Text + ",";
            }

            if (checkBox3.Checked)
            {
                checkButtonChose += checkBox3.Text + ",";
            }

            if (checkButtonChose.Length == 0)
            {
                checkButtonChose = "没有复选框被选中";
            }
            else
            {
                checkButtonChose = "复选框" + checkButtonChose + "被选中了";
            }

            MessageBox.Show("单选框" + radioButtonChose + "被选中了"
                + Environment.NewLine + Environment.NewLine
                + checkButtonChose);
            /// this.Close();

        }

        private void CommitInfo_Click(object sender, EventArgs e)
        {
            int count = this.checkedListBox1.CheckedItems.Count;
            if (count == 0) return;
            if (this.checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("请在CheckedListBox中选择要添加的项");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                this.listBox1.Items.Add(this.checkedListBox1.CheckedItems[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            switch (cb.SelectedIndex)
            {
                case 0:
                    this.checkedListBox1.Items.Clear();
                    this.checkedListBox1.Items.AddRange(names);
                    break;
                case 1:
                    this.checkedListBox1.Items.Clear();
                    this.checkedListBox1.Items.AddRange(nums);
                    break;
            }
            this.listBox1.Items.Clear();
        }
    }
}
