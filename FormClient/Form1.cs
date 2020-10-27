using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FormClient.ControlServiceReferenceCon;
using CommonLibrary;

namespace FormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Links = new List<string>();
        List<string> Summaries = new List<string>();



        public List<string> tags = new List<string>();
        public System.Timers.Timer MainTimer = new System.Timers.Timer();
        private void ButtonAddFeed_Click(object sender, EventArgs e)
        {
            ListBoxFeeds.Items.Add(TextBoxNewLink.Text);
            TextBoxNewLink.Text = "";
        }

        private void ListBoxFeedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowserMain.Navigate(Links[ListBoxFeedItems.SelectedIndex]);
            LabelPageTitle.Text = ListBoxFeedItems.Items[ListBoxFeedItems.SelectedIndex].ToString();
        }

        private void ButtonBeginSending_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(state => ReadFilterSendThreadMain());
        }
        private void ReadFilterSendThreadMain()
        {
            if (ListBoxFeeds.Items.Count > 0)
            {
                tags.Clear();
                tags = TextBoxTags.Text.Split(' ').ToList();
                Links.Clear();
                ControlClient client = new ControlClient();
                SynItems items = client.ProcessFeeds(ListBoxFeeds.Items.Cast<string>().ToArray(), tags.ToArray(), ListBoxRecipients.Items.Cast<string>().ToArray());
                client.Close();
                ListBoxFeedItems.Invoke(new Action(() => ListBoxFeedItems.Items.Clear()));
                ListBoxFeedItems.Invoke(new Action(() => ListBoxFeedItems.Items.AddRange(items.Titles.ToArray())));
                Links.AddRange(items.Links);
                MainTimer.Stop();
                MainTimer.Interval = (double)(1000 * 60 * (NumericUpDownMinutes.Value + NumericUpDownHours.Value * 60 + NumericUpDownDays.Value * 60 * 24));
                MainTimer.Start();
                ActiveForm?.Invoke(new Action(() => ActiveForm.Text = "Mail sent at " + DateTime.Now));
            }
        }

        private void ButtonAddRecipient_Click(object sender, EventArgs e)
        {
            ListBoxRecipients.Items.Add(TextBoxNewRecipient.Text);
            TextBoxNewRecipient.Text = "";
        }

        private void ButtonDeleteFeed_Click(object sender, EventArgs e)
        {
            if (ListBoxFeeds.Items.Count > 0 && ListBoxFeeds.SelectedIndex != -1)
            {
                ListBoxFeeds.Items.RemoveAt(ListBoxFeeds.SelectedIndex);
            }
        }

        private void ButtonDeleteRecipient_Click(object sender, EventArgs e)
        {
            if (ListBoxRecipients.Items.Count > 0 && ListBoxRecipients.SelectedIndex != -1)
            {
                ListBoxRecipients.Items.RemoveAt(ListBoxRecipients.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainTimer.Elapsed += (o, args) => ReadFilterSendThreadMain();
        }

        private void NumericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            if (NumericUpDownMinutes.Value == 0 && NumericUpDownHours.Value == 0 && NumericUpDownDays.Value == 0)
            {
                NumericUpDownMinutes.Value = 1;
            }
        }
    }
}
