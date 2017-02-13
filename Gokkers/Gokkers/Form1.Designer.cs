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
            this.goBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.betSetTitle = new System.Windows.Forms.Label();
            this.player3 = new System.Windows.Forms.RadioButton();
            this.betListTitle = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.RadioButton();
            this.messageLbl = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.player2 = new System.Windows.Forms.RadioButton();
            this.betBtn = new System.Windows.Forms.Button();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.winningLabel = new System.Windows.Forms.Label();
            this.entity1 = new System.Windows.Forms.PictureBox();
            this.entity4 = new System.Windows.Forms.PictureBox();
            this.entity2 = new System.Windows.Forms.PictureBox();
            this.entity3 = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.betOffice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // betOffice
            // 
            this.betOffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.betOffice.Controls.Add(this.winningLabel);
            this.betOffice.Controls.Add(this.goBtn);
            this.betOffice.Controls.Add(this.textBox2);
            this.betOffice.Controls.Add(this.textBox3);
            this.betOffice.Controls.Add(this.textBox1);
            this.betOffice.Controls.Add(this.betSetTitle);
            this.betOffice.Controls.Add(this.player3);
            this.betOffice.Controls.Add(this.betListTitle);
            this.betOffice.Controls.Add(this.player1);
            this.betOffice.Controls.Add(this.messageLbl);
            this.betOffice.Controls.Add(this.numericUpDown2);
            this.betOffice.Controls.Add(this.player2);
            this.betOffice.Controls.Add(this.betBtn);
            this.betOffice.Controls.Add(this.betAmount);
            this.betOffice.Location = new System.Drawing.Point(12, 348);
            this.betOffice.Name = "betOffice";
            this.betOffice.Size = new System.Drawing.Size(886, 203);
            this.betOffice.TabIndex = 5;
            this.betOffice.TabStop = false;
            this.betOffice.Text = "Bet office";
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.Location = new System.Drawing.Point(795, 161);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(85, 36);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(546, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(281, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(546, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(281, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(546, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(281, 22);
            this.textBox1.TabIndex = 10;
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
            this.player3.TabStop = true;
            this.player3.Text = "Fer";
            this.player3.UseVisualStyleBackColor = true;
            // 
            // betListTitle
            // 
            this.betListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.betListTitle.AutoSize = true;
            this.betListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betListTitle.Location = new System.Drawing.Point(638, 18);
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
            this.player1.TabStop = true;
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(339, 174);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
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
            this.player2.TabStop = true;
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
            // entity1
            // 
            this.entity1.BackColor = System.Drawing.Color.Transparent;
            this.entity1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entity1.BackgroundImage")));
            this.entity1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity1.Location = new System.Drawing.Point(23, 12);
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
            this.entity4.Location = new System.Drawing.Point(23, 287);
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
            this.entity2.Location = new System.Drawing.Point(23, 95);
            this.entity2.Name = "entity2";
            this.entity2.Size = new System.Drawing.Size(100, 35);
            this.entity2.TabIndex = 2;
            this.entity2.TabStop = false;
            // 
            // entity3
            // 
            this.entity3.BackColor = System.Drawing.Color.Transparent;
            this.entity3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.entity3.Image = global::Gokkers.Properties.Resources.Dog;
            this.entity3.Location = new System.Drawing.Point(23, 197);
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
            this.Background.BackgroundImage = global::Gokkers.Properties.Resources.PictureBox1;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Location = new System.Drawing.Point(1, -1);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(904, 343);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 555);
            this.Controls.Add(this.betOffice);
            this.Controls.Add(this.entity1);
            this.Controls.Add(this.entity4);
            this.Controls.Add(this.entity2);
            this.Controls.Add(this.entity3);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.betOffice.ResumeLayout(false);
            this.betOffice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton player1;
        private System.Windows.Forms.RadioButton player2;
        private System.Windows.Forms.RadioButton player3;
        private System.Windows.Forms.Label betListTitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label winningLabel;
    }
}

