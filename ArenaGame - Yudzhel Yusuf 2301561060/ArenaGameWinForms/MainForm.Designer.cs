namespace ArenaGameWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bNewGame = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ListBoxKnight = new ListBox();
            ListBoxRogue = new ListBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ListBoxSultan = new ListBox();
            ListBoxBrigand = new ListBox();
            bSecondGame = new Button();
            MainFight = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // bNewGame
            // 
            bNewGame.Location = new Point(295, 12);
            bNewGame.Name = "bNewGame";
            bNewGame.Size = new Size(172, 29);
            bNewGame.TabIndex = 0;
            bNewGame.Text = "New Game";
            bNewGame.UseVisualStyleBackColor = true;
            bNewGame.Click += bNewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(109, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(520, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // ListBoxKnight
            // 
            ListBoxKnight.FormattingEnabled = true;
            ListBoxKnight.Location = new Point(29, 245);
            ListBoxKnight.Name = "ListBoxKnight";
            ListBoxKnight.Size = new Size(313, 324);
            ListBoxKnight.TabIndex = 3;
            // 
            // ListBoxRogue
            // 
            ListBoxRogue.FormattingEnabled = true;
            ListBoxRogue.Location = new Point(422, 245);
            ListBoxRogue.Name = "ListBoxRogue";
            ListBoxRogue.Size = new Size(313, 324);
            ListBoxRogue.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(979, 92);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1328, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(142, 128);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // ListBoxSultan
            // 
            ListBoxSultan.FormattingEnabled = true;
            ListBoxSultan.Location = new Point(883, 245);
            ListBoxSultan.Name = "ListBoxSultan";
            ListBoxSultan.Size = new Size(313, 324);
            ListBoxSultan.TabIndex = 7;
            // 
            // ListBoxBrigand
            // 
            ListBoxBrigand.FormattingEnabled = true;
            ListBoxBrigand.Location = new Point(1241, 245);
            ListBoxBrigand.Name = "ListBoxBrigand";
            ListBoxBrigand.Size = new Size(313, 324);
            ListBoxBrigand.TabIndex = 8;
            // 
            // bSecondGame
            // 
            bSecondGame.Location = new Point(1140, 12);
            bSecondGame.Name = "bSecondGame";
            bSecondGame.Size = new Size(172, 29);
            bSecondGame.TabIndex = 9;
            bSecondGame.Text = "New Game";
            bSecondGame.UseVisualStyleBackColor = true;
            bSecondGame.Click += bSecondGame_Click;
            // 
            // MainFight
            // 
            MainFight.BackColor = Color.LemonChiffon;
            MainFight.Cursor = Cursors.Hand;
            MainFight.FlatAppearance.BorderColor = Color.Black;
            MainFight.FlatAppearance.BorderSize = 3;
            MainFight.FlatAppearance.MouseOverBackColor = Color.White;
            MainFight.FlatStyle = FlatStyle.Flat;
            MainFight.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainFight.Location = new Point(708, 12);
            MainFight.Name = "MainFight";
            MainFight.Size = new Size(212, 65);
            MainFight.TabIndex = 10;
            MainFight.Text = "New Game";
            MainFight.UseVisualStyleBackColor = false;
            MainFight.Click += MainFight_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1576, 601);
            Controls.Add(MainFight);
            Controls.Add(bSecondGame);
            Controls.Add(ListBoxBrigand);
            Controls.Add(ListBoxSultan);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(ListBoxRogue);
            Controls.Add(ListBoxKnight);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bNewGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox ListBoxKnight;
        private ListBox ListBoxRogue;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private ListBox ListBoxSultan;
        private ListBox ListBoxBrigand;
        private Button bSecondGame;
        private Button MainFight;
    }
}
