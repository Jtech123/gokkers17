namespace Gokkers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.betOffice = new System.Windows.Forms.GroupBox();
            this.betLabel = new System.Windows.Forms.Label();
            this.winningLabel = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Button();
            this.centerMessage = new System.Windows.Forms.TextBox();
            this.bottomMessage = new System.Windows.Forms.TextBox();
            this.topMessage = new System.Windows.Forms.TextBox();
            this.betSetTitle = new System.Windows.Forms.Label();
            this.player3 = new System.Windows.Forms.RadioButton();
            this.betListTitle = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.RadioButton();
            this.messageLbl = new System.Windows.Forms.Label();
            this.targetNumbers = new System.Windows.Forms.NumericUpDown();
            this.player2 = new System.Windows.Forms.RadioButton();
            this.betBtn = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.entity1 = new System.Windows.Forms.PictureBox();
            this.entity4 = new System.Windows.Forms.PictureBox();
            this.entity2 = new System.Windows.Forms.PictureBox();
            this.entity3 = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.cashUpdate = new System.Windows.Forms.Timer(this.components);
            this.entity5 = new System.Windows.Forms.PictureBox();
            this.entity6 = new System.Windows.Forms.PictureBox();
            this.entity7 = new System.Windows.Forms.PictureBox();
            this.entity8 = new System.Windows.Forms.PictureBox();
            this.entity9 = new System.Windows.Forms.PictureBox();
            this.betOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity9)).BeginInit();
            this.SuspendLayout();
            // 
            // betOffice
            // 
            this.betOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betOffice.BackColor = System.Drawing.SystemColors.Control;
            this.betOffice.Controls.Add(this.betLabel);
            this.betOffice.Controls.Add(this.winningLabel);
            this.betOffice.Controls.Add(this.goBtn);
            this.betOffice.Controls.Add(this.centerMessage);
            this.betOffice.Controls.Add(this.bottomMessage);
            this.betOffice.Controls.Add(this.topMessage);
            this.betOffice.Controls.Add(this.betSetTitle);
            this.betOffice.Controls.Add(this.player3);
            this.betOffice.Controls.Add(this.betListTitle);
            this.betOffice.Controls.Add(this.player1);
            this.betOffice.Controls.Add(this.messageLbl);
            this.betOffice.Controls.Add(this.targetNumbers);
            this.betOffice.Controls.Add(this.player2);
            this.betOffice.Controls.Add(this.betBtn);
            this.betOffice.Controls.Add(this.betAmount);
            this.betOffice.Location = new System.Drawing.Point(12, 491);
            this.betOffice.Name = "betOffice";
            this.betOffice.Size = new System.Drawing.Size(1206, 203);
            this.betOffice.TabIndex = 5;
            this.betOffice.TabStop = false;
            this.betOffice.Text = "Bet office";
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(257, 46);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(68, 17);
            this.betLabel.TabIndex = 6;
            this.betLabel.Text = "TESTING";
            this.betLabel.Visible = false;
            // 
            // winningLabel
            // 
            this.winningLabel.AutoSize = true;
            this.winningLabel.Location = new System.Drawing.Point(377, 18);
            this.winningLabel.Name = "winningLabel";
            this.winningLabel.Size = new System.Drawing.Size(39, 17);
            this.winningLabel.TabIndex = 6;
            this.winningLabel.Text = "Wins";
            this.winningLabel.Visible = false;
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Location = new System.Drawing.Point(1115, 161);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(85, 36);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // centerMessage
            // 
            this.centerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.centerMessage.Location = new System.Drawing.Point(866, 74);
            this.centerMessage.Name = "centerMessage";
            this.centerMessage.ReadOnly = true;
            this.centerMessage.Size = new System.Drawing.Size(281, 22);
            this.centerMessage.TabIndex = 11;
            // 
            // bottomMessage
            // 
            this.bottomMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomMessage.Location = new System.Drawing.Point(866, 102);
            this.bottomMessage.Name = "bottomMessage";
            this.bottomMessage.ReadOnly = true;
            this.bottomMessage.Size = new System.Drawing.Size(281, 22);
            this.bottomMessage.TabIndex = 12;
            // 
            // topMessage
            // 
            this.topMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.topMessage.Location = new System.Drawing.Point(866, 46);
            this.topMessage.Name = "topMessage";
            this.topMessage.ReadOnly = true;
            this.topMessage.Size = new System.Drawing.Size(281, 22);
            this.topMessage.TabIndex = 10;
            // 
            // betSetTitle
            // 
            this.betSetTitle.AutoSize = true;
            this.betSetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betSetTitle.Location = new System.Drawing.Point(6, 18);
            this.betSetTitle.Name = "betSetTitle";
            this.betSetTitle.Size = new System.Drawing.Size(171, 25);
            this.betSetTitle.TabIndex = 0;
            this.betSetTitle.Text = "Minimal bet 5 euro";
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Location = new System.Drawing.Point(11, 101);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(50, 21);
            this.player3.TabIndex = 8;
            this.player3.Text = "Fer";
            this.player3.UseVisualStyleBackColor = true;
            // 
            // betListTitle
            // 
            this.betListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.betListTitle.AutoSize = true;
            this.betListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betListTitle.Location = new System.Drawing.Point(958, 18);
            this.betListTitle.Name = "betListTitle";
            this.betListTitle.Size = new System.Drawing.Size(51, 25);
            this.betListTitle.TabIndex = 9;
            this.betListTitle.Text = "Bets";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(11, 46);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(68, 21);
            this.player1.TabIndex = 6;
            this.player1.Text = "Sietse";
            this.player1.UseVisualStyleBackColor = true;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(196, 174);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(141, 17);
            this.messageLbl.TabIndex = 1;
            this.messageLbl.Text = "euro on dog number:";
            // 
            // targetNumbers
            // 
            this.targetNumbers.Location = new System.Drawing.Point(339, 174);
            this.targetNumbers.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.targetNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.targetNumbers.Name = "targetNumbers";
            this.targetNumbers.Size = new System.Drawing.Size(55, 22);
            this.targetNumbers.TabIndex = 5;
            this.targetNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(11, 73);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(55, 21);
            this.player2.TabIndex = 7;
            this.player2.Text = "Lydi";
            this.player2.UseVisualStyleBackColor = true;
            // 
            // betBtn
            // 
            this.betBtn.Location = new System.Drawing.Point(57, 172);
            this.betBtn.Name = "betBtn";
            this.betBtn.Size = new System.Drawing.Size(75, 23);
            this.betBtn.TabIndex = 2;
            this.betBtn.Text = "Bet";
            this.betBtn.UseVisualStyleBackColor = true;
            this.betBtn.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(138, 172);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(52, 22);
            this.betAmount.TabIndex = 4;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // entity1
            // 
            this.entity1.BackColor = System.Drawing.Color.Transparent;
            this.entity1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity1.BackgroundImage")));
            this.entity1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity1.Location = new System.Drawing.Point(23, -1);
            this.entity1.Name = "entity1";
            this.entity1.Size = new System.Drawing.Size(100, 35);
            this.entity1.TabIndex = 4;
            this.entity1.TabStop = false;
            // 
            // entity4
            // 
            this.entity4.BackColor = System.Drawing.Color.Transparent;
            this.entity4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity4.BackgroundImage")));
            this.entity4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity4.Location = new System.Drawing.Point(23, 161);
            this.entity4.Name = "entity4";
            this.entity4.Size = new System.Drawing.Size(100, 35);
            this.entity4.TabIndex = 3;
            this.entity4.TabStop = false;
            // 
            // entity2
            // 
            this.entity2.BackColor = System.Drawing.Color.Transparent;
            this.entity2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity2.BackgroundImage")));
            this.entity2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity2.Location = new System.Drawing.Point(23, 50);
            this.entity2.Name = "entity2";
            this.entity2.Size = new System.Drawing.Size(100, 35);
            this.entity2.TabIndex = 2;
            this.entity2.TabStop = false;
            // 
            // entity3
            // 
            this.entity3.BackColor = System.Drawing.Color.Transparent;
            this.entity3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity3.BackgroundImage")));
            this.entity3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity3.Location = new System.Drawing.Point(23, 111);
            this.entity3.Name = "entity3";
            this.entity3.Size = new System.Drawing.Size(100, 35);
            this.entity3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.entity3.TabIndex = 1;
            this.entity3.TabStop = false;
            // 
            // Background
            // 
            this.Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.BackgroundImage = global::Gokkers.Properties.Resources.sea_background;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Location = new System.Drawing.Point(1, -1);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1224, 486);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // cashUpdate
            // 
            this.cashUpdate.Enabled = true;
            this.cashUpdate.Tick += new System.EventHandler(this.cashUpdate_Tick);
            // 
            // entity5
            // 
            this.entity5.BackColor = System.Drawing.Color.Transparent;
            this.entity5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity5.BackgroundImage")));
            this.entity5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity5.Location = new System.Drawing.Point(23, 231);
            this.entity5.Name = "entity5";
            this.entity5.Size = new System.Drawing.Size(100, 35);
            this.entity5.TabIndex = 6;
            this.entity5.TabStop = false;
            // 
            // entity6
            // 
            this.entity6.BackColor = System.Drawing.Color.Transparent;
            this.entity6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity6.BackgroundImage")));
            this.entity6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity6.Location = new System.Drawing.Point(23, 293);
            this.entity6.Name = "entity6";
            this.entity6.Size = new System.Drawing.Size(100, 35);
            this.entity6.TabIndex = 7;
            this.entity6.TabStop = false;
            // 
            // entity7
            // 
            this.entity7.BackColor = System.Drawing.Color.Transparent;
            this.entity7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity7.BackgroundImage")));
            this.entity7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity7.Location = new System.Drawing.Point(23, 344);
            this.entity7.Name = "entity7";
            this.entity7.Size = new System.Drawing.Size(100, 35);
            this.entity7.TabIndex = 8;
            this.entity7.TabStop = false;
            // 
            // entity8
            // 
            this.entity8.BackColor = System.Drawing.Color.Transparent;
            this.entity8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity8.BackgroundImage")));
            this.entity8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity8.Location = new System.Drawing.Point(23, 402);
            this.entity8.Name = "entity8";
            this.entity8.Size = new System.Drawing.Size(100, 35);
            this.entity8.TabIndex = 9;
            this.entity8.TabStop = false;
            // 
            // entity9
            // 
            this.entity9.BackColor = System.Drawing.Color.Transparent;
            this.entity9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity9.BackgroundImage")));
            this.entity9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity9.Location = new System.Drawing.Point(23, 450);
            this.entity9.Name = "entity9";
            this.entity9.Size = new System.Drawing.Size(100, 35);
            this.entity9.TabIndex = 10;
            this.entity9.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1230, 698);
            this.Controls.Add(this.entity9);
            this.Controls.Add(this.entity8);
            this.Controls.Add(this.entity7);
            this.Controls.Add(this.entity6);
            this.Controls.Add(this.entity5);
            this.Controls.Add(this.betOffice);
            this.Controls.Add(this.entity1);
            this.Controls.Add(this.entity4);
            this.Controls.Add(this.entity2);
            this.Controls.Add(this.entity3);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.betOffice.ResumeLayout(false);
            this.betOffice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox entity3;
        private System.Windows.Forms.PictureBox entity2;
        private System.Windows.Forms.PictureBox entity4;
        private System.Windows.Forms.PictureBox entity1;
        private System.Windows.Forms.GroupBox betOffice;
        private System.Windows.Forms.Label betSetTitle;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Button betBtn;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.NumericUpDown targetNumbers;
        private System.Windows.Forms.RadioButton player1;
        private System.Windows.Forms.RadioButton player2;
        private System.Windows.Forms.RadioButton player3;
        private System.Windows.Forms.Label betListTitle;
        private System.Windows.Forms.TextBox topMessage;
        private System.Windows.Forms.TextBox centerMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label winningLabel;
        private System.Windows.Forms.TextBox bottomMessage;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Timer cashUpdate;
        private System.Windows.Forms.PictureBox entity5;
        private System.Windows.Forms.PictureBox entity6;
        private System.Windows.Forms.PictureBox entity7;
        private System.Windows.Forms.PictureBox entity8;
        private System.Windows.Forms.PictureBox entity9;
    }
}

