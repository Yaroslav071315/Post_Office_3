namespace Post_Office_3
{
    partial class Post_Office
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post_Office));
            weightF = new TextBox();
            datesendF = new TextBox();
            datecomeF = new TextBox();
            priceF = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            send = new Button();
            read = new Button();
            AddParcelToDb = new Button();
            ReadParcelFromDb = new Button();
            WeightMoreThan10 = new Button();
            PriceMoreThan100 = new Button();
            Average = new Button();
            UpdateParcelInDbButton = new Button();
            parcelIdF = new TextBox();
            label5 = new Label();
            DeleteParcelFromDbButton = new Button();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            LastParclelF = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // weightF
            // 
            weightF.Location = new Point(144, 120);
            weightF.Name = "weightF";
            weightF.Size = new Size(125, 27);
            weightF.TabIndex = 0;
            // 
            // datesendF
            // 
            datesendF.Location = new Point(144, 175);
            datesendF.Name = "datesendF";
            datesendF.Size = new Size(125, 27);
            datesendF.TabIndex = 1;
            // 
            // datecomeF
            // 
            datecomeF.Location = new Point(144, 232);
            datecomeF.Name = "datecomeF";
            datecomeF.Size = new Size(125, 27);
            datecomeF.TabIndex = 2;
            // 
            // priceF
            // 
            priceF.Location = new Point(144, 287);
            priceF.Name = "priceF";
            priceF.Size = new Size(125, 27);
            priceF.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 127);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 182);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Date Send";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 235);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "Date Come";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 290);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // send
            // 
            send.Location = new Point(20, 51);
            send.Name = "send";
            send.Size = new Size(94, 29);
            send.TabIndex = 8;
            send.Text = "send";
            send.UseVisualStyleBackColor = true;
            send.Click += send_Click;
            // 
            // read
            // 
            read.Location = new Point(20, 112);
            read.Name = "read";
            read.Size = new Size(94, 29);
            read.TabIndex = 9;
            read.Text = "read";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // AddParcelToDb
            // 
            AddParcelToDb.Location = new Point(93, 7);
            AddParcelToDb.Name = "AddParcelToDb";
            AddParcelToDb.Size = new Size(94, 29);
            AddParcelToDb.TabIndex = 10;
            AddParcelToDb.Text = "Add parcel to DB";
            AddParcelToDb.UseVisualStyleBackColor = true;
            AddParcelToDb.Click += AddParcelToDb_Click;
            // 
            // ReadParcelFromDb
            // 
            ReadParcelFromDb.Location = new Point(93, 51);
            ReadParcelFromDb.Name = "ReadParcelFromDb";
            ReadParcelFromDb.Size = new Size(94, 29);
            ReadParcelFromDb.TabIndex = 11;
            ReadParcelFromDb.Text = "Read parcel from DB";
            ReadParcelFromDb.UseVisualStyleBackColor = true;
            ReadParcelFromDb.Click += ReadParcelFromDb_Click;
            // 
            // WeightMoreThan10
            // 
            WeightMoreThan10.Location = new Point(328, 512);
            WeightMoreThan10.Name = "WeightMoreThan10";
            WeightMoreThan10.Size = new Size(94, 29);
            WeightMoreThan10.TabIndex = 12;
            WeightMoreThan10.Text = "Weight>10";
            WeightMoreThan10.UseVisualStyleBackColor = true;
            WeightMoreThan10.Click += WeightMoreThan10_Click;
            // 
            // PriceMoreThan100
            // 
            PriceMoreThan100.Location = new Point(580, 512);
            PriceMoreThan100.Name = "PriceMoreThan100";
            PriceMoreThan100.Size = new Size(94, 29);
            PriceMoreThan100.TabIndex = 13;
            PriceMoreThan100.Text = "Price>100";
            PriceMoreThan100.UseVisualStyleBackColor = true;
            PriceMoreThan100.Click += PriceMoreThan100_Click;
            // 
            // Average
            // 
            Average.Location = new Point(862, 512);
            Average.Name = "Average";
            Average.Size = new Size(94, 29);
            Average.TabIndex = 14;
            Average.Text = "Average";
            Average.UseVisualStyleBackColor = true;
            Average.Click += Average_Click;
            // 
            // UpdateParcelInDbButton
            // 
            UpdateParcelInDbButton.Location = new Point(93, 96);
            UpdateParcelInDbButton.Name = "UpdateParcelInDbButton";
            UpdateParcelInDbButton.Size = new Size(94, 29);
            UpdateParcelInDbButton.TabIndex = 15;
            UpdateParcelInDbButton.Text = "Update";
            UpdateParcelInDbButton.UseVisualStyleBackColor = true;
            UpdateParcelInDbButton.Click += UpdateParcelInDbButton_Click;
            // 
            // parcelIdF
            // 
            parcelIdF.Location = new Point(623, 106);
            parcelIdF.Name = "parcelIdF";
            parcelIdF.Size = new Size(125, 27);
            parcelIdF.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 106);
            label5.Name = "label5";
            label5.Size = new Size(186, 20);
            label5.TabIndex = 17;
            label5.Text = "Id for updating or deleting";
            // 
            // DeleteParcelFromDbButton
            // 
            DeleteParcelFromDbButton.Location = new Point(93, 137);
            DeleteParcelFromDbButton.Name = "DeleteParcelFromDbButton";
            DeleteParcelFromDbButton.Size = new Size(94, 29);
            DeleteParcelFromDbButton.TabIndex = 18;
            DeleteParcelFromDbButton.Text = "Delete";
            DeleteParcelFromDbButton.UseVisualStyleBackColor = true;
            DeleteParcelFromDbButton.Click += DeleteParcelFromDbButton_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(370, 144);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(send);
            splitContainer1.Panel1.Controls.Add(read);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LightSlateGray;
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(ReadParcelFromDb);
            splitContainer1.Panel2.Controls.Add(DeleteParcelFromDbButton);
            splitContainer1.Panel2.Controls.Add(UpdateParcelInDbButton);
            splitContainer1.Panel2.Controls.Add(AddParcelToDb);
            splitContainer1.Size = new Size(430, 169);
            splitContainer1.SplitterDistance = 141;
            splitContainer1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 7);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 20;
            label6.Text = "Text files";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 11);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 21;
            label7.Text = "DB";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1044, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(275, 347);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.images;
            pictureBox3.Location = new Point(553, 340);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 166);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.average;
            pictureBox4.Location = new Point(815, 347);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(187, 159);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // LastParclelF
            // 
            LastParclelF.Location = new Point(75, 512);
            LastParclelF.Name = "LastParclelF";
            LastParclelF.Size = new Size(94, 29);
            LastParclelF.TabIndex = 24;
            LastParclelF.Text = "Last Parcel";
            LastParclelF.UseVisualStyleBackColor = true;
            LastParclelF.Click += LastParclelF_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(31, 347);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(209, 159);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // Post_Office
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 611);
            Controls.Add(pictureBox5);
            Controls.Add(LastParclelF);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitContainer1);
            Controls.Add(label5);
            Controls.Add(parcelIdF);
            Controls.Add(Average);
            Controls.Add(PriceMoreThan100);
            Controls.Add(WeightMoreThan10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(priceF);
            Controls.Add(datecomeF);
            Controls.Add(datesendF);
            Controls.Add(weightF);
            Name = "Post_Office";
            Text = "Post_Office";
            Load += Post_Office_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox weightF;
        private TextBox datesendF;
        private TextBox datecomeF;
        private TextBox priceF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button send;
        private Button read;
        private Button AddParcelToDb;
        private Button ReadParcelFromDb;
        private Button WeightMoreThan10;
        private Button PriceMoreThan100;
        private Button Average;
        private Button UpdateParcelInDbButton;
        private TextBox parcelIdF;
        private Label label5;
        private Button DeleteParcelFromDbButton;
        private SplitContainer splitContainer1;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button LastParclelF;
        private PictureBox pictureBox5;
    }
}