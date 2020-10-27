namespace FormClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDeleteFeed = new System.Windows.Forms.Button();
            this.ButtonDeleteRecipient = new System.Windows.Forms.Button();
            this.TextBoxTags = new System.Windows.Forms.TextBox();
            this.TextBoxNewRecipient = new System.Windows.Forms.TextBox();
            this.ListBoxRecipients = new System.Windows.Forms.ListBox();
            this.LabelDays = new System.Windows.Forms.Label();
            this.LabelHours = new System.Windows.Forms.Label();
            this.LabelSeconds = new System.Windows.Forms.Label();
            this.NumericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.ButtonAddRecipient = new System.Windows.Forms.Button();
            this.ButtonBeginSending = new System.Windows.Forms.Button();
            this.ListBoxFeeds = new System.Windows.Forms.ListBox();
            this.LabelPageTitle = new System.Windows.Forms.Label();
            this.TextBoxNewLink = new System.Windows.Forms.TextBox();
            this.ListBoxFeedItems = new System.Windows.Forms.ListBox();
            this.WebBrowserMain = new System.Windows.Forms.WebBrowser();
            this.ButtonAddFeed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonDeleteFeed
            // 
            this.ButtonDeleteFeed.Location = new System.Drawing.Point(9, 141);
            this.ButtonDeleteFeed.Name = "ButtonDeleteFeed";
            this.ButtonDeleteFeed.Size = new System.Drawing.Size(137, 23);
            this.ButtonDeleteFeed.TabIndex = 44;
            this.ButtonDeleteFeed.Text = "Delete RSS feed";
            this.ButtonDeleteFeed.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteRecipient
            // 
            this.ButtonDeleteRecipient.Location = new System.Drawing.Point(1488, 144);
            this.ButtonDeleteRecipient.Name = "ButtonDeleteRecipient";
            this.ButtonDeleteRecipient.Size = new System.Drawing.Size(122, 23);
            this.ButtonDeleteRecipient.TabIndex = 43;
            this.ButtonDeleteRecipient.Text = "Delete recipient";
            this.ButtonDeleteRecipient.UseVisualStyleBackColor = true;
            // 
            // TextBoxTags
            // 
            this.TextBoxTags.Location = new System.Drawing.Point(1616, 5);
            this.TextBoxTags.Multiline = true;
            this.TextBoxTags.Name = "TextBoxTags";
            this.TextBoxTags.Size = new System.Drawing.Size(415, 161);
            this.TextBoxTags.TabIndex = 42;
            this.TextBoxTags.Text = "online development science";
            // 
            // TextBoxNewRecipient
            // 
            this.TextBoxNewRecipient.Location = new System.Drawing.Point(1209, 144);
            this.TextBoxNewRecipient.Name = "TextBoxNewRecipient";
            this.TextBoxNewRecipient.Size = new System.Drawing.Size(272, 22);
            this.TextBoxNewRecipient.TabIndex = 41;
            // 
            // ListBoxRecipients
            // 
            this.ListBoxRecipients.FormattingEnabled = true;
            this.ListBoxRecipients.ItemHeight = 16;
            this.ListBoxRecipients.Items.AddRange(new object[] {
            "rewif99224@bevsemail.com",
            "rowefa3610@iazhy.com",
            "mekiwow992@bevsemail.com"});
            this.ListBoxRecipients.Location = new System.Drawing.Point(1080, 5);
            this.ListBoxRecipients.Name = "ListBoxRecipients";
            this.ListBoxRecipients.Size = new System.Drawing.Size(530, 132);
            this.ListBoxRecipients.TabIndex = 40;
            // 
            // LabelDays
            // 
            this.LabelDays.AutoSize = true;
            this.LabelDays.Location = new System.Drawing.Point(995, 108);
            this.LabelDays.Name = "LabelDays";
            this.LabelDays.Size = new System.Drawing.Size(40, 17);
            this.LabelDays.TabIndex = 39;
            this.LabelDays.Text = "Days";
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(995, 64);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(46, 17);
            this.LabelHours.TabIndex = 38;
            this.LabelHours.Text = "Hours";
            // 
            // LabelSeconds
            // 
            this.LabelSeconds.AutoSize = true;
            this.LabelSeconds.Location = new System.Drawing.Point(995, 10);
            this.LabelSeconds.Name = "LabelSeconds";
            this.LabelSeconds.Size = new System.Drawing.Size(57, 17);
            this.LabelSeconds.TabIndex = 37;
            this.LabelSeconds.Text = "Minutes";
            // 
            // NumericUpDownMinutes
            // 
            this.NumericUpDownMinutes.Location = new System.Drawing.Point(919, 5);
            this.NumericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumericUpDownMinutes.Name = "NumericUpDownMinutes";
            this.NumericUpDownMinutes.Size = new System.Drawing.Size(60, 22);
            this.NumericUpDownMinutes.TabIndex = 36;
            this.NumericUpDownMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericUpDownDays
            // 
            this.NumericUpDownDays.Location = new System.Drawing.Point(919, 108);
            this.NumericUpDownDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericUpDownDays.Name = "NumericUpDownDays";
            this.NumericUpDownDays.Size = new System.Drawing.Size(61, 22);
            this.NumericUpDownDays.TabIndex = 35;
            // 
            // NumericUpDownHours
            // 
            this.NumericUpDownHours.Location = new System.Drawing.Point(919, 59);
            this.NumericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumericUpDownHours.Name = "NumericUpDownHours";
            this.NumericUpDownHours.Size = new System.Drawing.Size(61, 22);
            this.NumericUpDownHours.TabIndex = 34;
            // 
            // ButtonAddRecipient
            // 
            this.ButtonAddRecipient.Location = new System.Drawing.Point(1080, 143);
            this.ButtonAddRecipient.Name = "ButtonAddRecipient";
            this.ButtonAddRecipient.Size = new System.Drawing.Size(123, 23);
            this.ButtonAddRecipient.TabIndex = 33;
            this.ButtonAddRecipient.Text = "Add recipient";
            this.ButtonAddRecipient.UseVisualStyleBackColor = true;
            // 
            // ButtonBeginSending
            // 
            this.ButtonBeginSending.Location = new System.Drawing.Point(919, 143);
            this.ButtonBeginSending.Name = "ButtonBeginSending";
            this.ButtonBeginSending.Size = new System.Drawing.Size(155, 23);
            this.ButtonBeginSending.TabIndex = 32;
            this.ButtonBeginSending.Text = "Start sending news";
            this.ButtonBeginSending.UseVisualStyleBackColor = true;
            // 
            // ListBoxFeeds
            // 
            this.ListBoxFeeds.FormattingEnabled = true;
            this.ListBoxFeeds.ItemHeight = 16;
            this.ListBoxFeeds.Items.AddRange(new object[] {
            "https://www.nytimes.com/svc/collections/v1/publish/https://www.nytimes.com/sectio" +
                "n/world/rss.xml",
            "https://www.ibm.com/developerworks/views/global/rss/libraryview.jsp",
            "https://www.thecipherbrief.com/feed"});
            this.ListBoxFeeds.Location = new System.Drawing.Point(9, 5);
            this.ListBoxFeeds.Name = "ListBoxFeeds";
            this.ListBoxFeeds.Size = new System.Drawing.Size(904, 132);
            this.ListBoxFeeds.TabIndex = 31;
            // 
            // LabelPageTitle
            // 
            this.LabelPageTitle.AutoSize = true;
            this.LabelPageTitle.Location = new System.Drawing.Point(740, 170);
            this.LabelPageTitle.Name = "LabelPageTitle";
            this.LabelPageTitle.Size = new System.Drawing.Size(0, 17);
            this.LabelPageTitle.TabIndex = 30;
            // 
            // TextBoxNewLink
            // 
            this.TextBoxNewLink.Location = new System.Drawing.Point(152, 142);
            this.TextBoxNewLink.Name = "TextBoxNewLink";
            this.TextBoxNewLink.Size = new System.Drawing.Size(594, 22);
            this.TextBoxNewLink.TabIndex = 29;
            // 
            // ListBoxFeedItems
            // 
            this.ListBoxFeedItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListBoxFeedItems.FormattingEnabled = true;
            this.ListBoxFeedItems.HorizontalScrollbar = true;
            this.ListBoxFeedItems.ItemHeight = 16;
            this.ListBoxFeedItems.Location = new System.Drawing.Point(9, 170);
            this.ListBoxFeedItems.Name = "ListBoxFeedItems";
            this.ListBoxFeedItems.Size = new System.Drawing.Size(331, 500);
            this.ListBoxFeedItems.TabIndex = 28;
            // 
            // WebBrowserMain
            // 
            this.WebBrowserMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowserMain.Location = new System.Drawing.Point(346, 202);
            this.WebBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserMain.Name = "WebBrowserMain";
            this.WebBrowserMain.ScriptErrorsSuppressed = true;
            this.WebBrowserMain.Size = new System.Drawing.Size(1563, 468);
            this.WebBrowserMain.TabIndex = 27;
            // 
            // ButtonAddFeed
            // 
            this.ButtonAddFeed.Location = new System.Drawing.Point(752, 143);
            this.ButtonAddFeed.Name = "ButtonAddFeed";
            this.ButtonAddFeed.Size = new System.Drawing.Size(161, 23);
            this.ButtonAddFeed.TabIndex = 26;
            this.ButtonAddFeed.Text = "Add RSS feed";
            this.ButtonAddFeed.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 674);
            this.Controls.Add(this.ButtonDeleteFeed);
            this.Controls.Add(this.ButtonDeleteRecipient);
            this.Controls.Add(this.TextBoxTags);
            this.Controls.Add(this.TextBoxNewRecipient);
            this.Controls.Add(this.ListBoxRecipients);
            this.Controls.Add(this.LabelDays);
            this.Controls.Add(this.LabelHours);
            this.Controls.Add(this.LabelSeconds);
            this.Controls.Add(this.NumericUpDownMinutes);
            this.Controls.Add(this.NumericUpDownDays);
            this.Controls.Add(this.NumericUpDownHours);
            this.Controls.Add(this.ButtonAddRecipient);
            this.Controls.Add(this.ButtonBeginSending);
            this.Controls.Add(this.ListBoxFeeds);
            this.Controls.Add(this.LabelPageTitle);
            this.Controls.Add(this.TextBoxNewLink);
            this.Controls.Add(this.ListBoxFeedItems);
            this.Controls.Add(this.WebBrowserMain);
            this.Controls.Add(this.ButtonAddFeed);
            this.Name = "Form1";
            this.Text = "no";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDeleteFeed;
        private System.Windows.Forms.Button ButtonDeleteRecipient;
        private System.Windows.Forms.TextBox TextBoxTags;
        private System.Windows.Forms.TextBox TextBoxNewRecipient;
        private System.Windows.Forms.ListBox ListBoxRecipients;
        private System.Windows.Forms.Label LabelDays;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.NumericUpDown NumericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown NumericUpDownDays;
        private System.Windows.Forms.NumericUpDown NumericUpDownHours;
        private System.Windows.Forms.Button ButtonAddRecipient;
        private System.Windows.Forms.Button ButtonBeginSending;
        private System.Windows.Forms.ListBox ListBoxFeeds;
        private System.Windows.Forms.Label LabelPageTitle;
        private System.Windows.Forms.TextBox TextBoxNewLink;
        private System.Windows.Forms.ListBox ListBoxFeedItems;
        private System.Windows.Forms.WebBrowser WebBrowserMain;
        private System.Windows.Forms.Button ButtonAddFeed;
    }
}

