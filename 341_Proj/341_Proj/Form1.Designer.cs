namespace _341_Proj
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listMovies = new System.Windows.Forms.Button();
            this.listSeries = new System.Windows.Forms.Button();
            this.crewList = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.findAct = new System.Windows.Forms.Button();
            this.findMovie = new System.Windows.Forms.Button();
            this.findSeries = new System.Windows.Forms.Button();
            this.text4 = new System.Windows.Forms.TextBox();
            this.viewReview = new System.Windows.Forms.Button();
            this.genreList = new System.Windows.Forms.Button();
            this.text5 = new System.Windows.Forms.TextBox();
            this.findGenre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rMovie = new System.Windows.Forms.TextBox();
            this.rNick = new System.Windows.Forms.TextBox();
            this.rRate = new System.Windows.Forms.TextBox();
            this.rText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addReview = new System.Windows.Forms.Button();
            this.checkMovie = new System.Windows.Forms.CheckBox();
            this.checkSeries = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text6 = new System.Windows.Forms.TextBox();
            this.findEpisode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(830, 140);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 468);
            this.listBox1.TabIndex = 0;
            // 
            // listMovies
            // 
            this.listMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listMovies.Location = new System.Drawing.Point(25, 524);
            this.listMovies.Name = "listMovies";
            this.listMovies.Size = new System.Drawing.Size(176, 59);
            this.listMovies.TabIndex = 1;
            this.listMovies.Text = "MOVIES";
            this.listMovies.UseVisualStyleBackColor = true;
            this.listMovies.Click += new System.EventHandler(this.listMovies_Click);
            // 
            // listSeries
            // 
            this.listSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listSeries.Location = new System.Drawing.Point(220, 524);
            this.listSeries.Name = "listSeries";
            this.listSeries.Size = new System.Drawing.Size(176, 59);
            this.listSeries.TabIndex = 2;
            this.listSeries.Text = "TV SERIES";
            this.listSeries.UseVisualStyleBackColor = true;
            this.listSeries.Click += new System.EventHandler(this.listSeries_Click);
            // 
            // crewList
            // 
            this.crewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.crewList.Location = new System.Drawing.Point(421, 524);
            this.crewList.Name = "crewList";
            this.crewList.Size = new System.Drawing.Size(176, 59);
            this.crewList.TabIndex = 3;
            this.crewList.Text = "CREW";
            this.crewList.UseVisualStyleBackColor = true;
            this.crewList.Click += new System.EventHandler(this.crewList_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(25, 82);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(135, 23);
            this.text1.TabIndex = 4;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(25, 122);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(135, 23);
            this.text2.TabIndex = 5;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(25, 161);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(135, 23);
            this.text3.TabIndex = 6;
            // 
            // findAct
            // 
            this.findAct.Location = new System.Drawing.Point(193, 80);
            this.findAct.Name = "findAct";
            this.findAct.Size = new System.Drawing.Size(115, 24);
            this.findAct.TabIndex = 7;
            this.findAct.Text = "Find Actor";
            this.findAct.UseVisualStyleBackColor = true;
            this.findAct.Click += new System.EventHandler(this.findAct_Click);
            // 
            // findMovie
            // 
            this.findMovie.Location = new System.Drawing.Point(193, 122);
            this.findMovie.Name = "findMovie";
            this.findMovie.Size = new System.Drawing.Size(115, 23);
            this.findMovie.TabIndex = 8;
            this.findMovie.Text = "Find Movie";
            this.findMovie.UseVisualStyleBackColor = true;
            this.findMovie.Click += new System.EventHandler(this.findMovie_Click);
            // 
            // findSeries
            // 
            this.findSeries.Location = new System.Drawing.Point(193, 161);
            this.findSeries.Name = "findSeries";
            this.findSeries.Size = new System.Drawing.Size(115, 23);
            this.findSeries.TabIndex = 9;
            this.findSeries.Text = "Find TV Series";
            this.findSeries.UseVisualStyleBackColor = true;
            this.findSeries.Click += new System.EventHandler(this.findSeries_Click);
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(25, 203);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(135, 23);
            this.text4.TabIndex = 10;
            // 
            // viewReview
            // 
            this.viewReview.Location = new System.Drawing.Point(192, 282);
            this.viewReview.Name = "viewReview";
            this.viewReview.Size = new System.Drawing.Size(116, 23);
            this.viewReview.TabIndex = 11;
            this.viewReview.Text = "View Reviews";
            this.viewReview.UseVisualStyleBackColor = true;
            this.viewReview.Click += new System.EventHandler(this.viewReview_Click);
            // 
            // genreList
            // 
            this.genreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genreList.Location = new System.Drawing.Point(617, 524);
            this.genreList.Name = "genreList";
            this.genreList.Size = new System.Drawing.Size(176, 59);
            this.genreList.TabIndex = 12;
            this.genreList.Text = "GENRES";
            this.genreList.UseVisualStyleBackColor = true;
            this.genreList.Click += new System.EventHandler(this.genreList_Click);
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(25, 282);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(135, 23);
            this.text5.TabIndex = 13;
            // 
            // findGenre
            // 
            this.findGenre.Location = new System.Drawing.Point(193, 203);
            this.findGenre.Name = "findGenre";
            this.findGenre.Size = new System.Drawing.Size(115, 23);
            this.findGenre.TabIndex = 14;
            this.findGenre.Text = "Find Genre";
            this.findGenre.UseVisualStyleBackColor = true;
            this.findGenre.Click += new System.EventHandler(this.findGenre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(381, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add A Review:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rMovie
            // 
            this.rMovie.Location = new System.Drawing.Point(386, 97);
            this.rMovie.Name = "rMovie";
            this.rMovie.Size = new System.Drawing.Size(181, 23);
            this.rMovie.TabIndex = 16;
            // 
            // rNick
            // 
            this.rNick.Location = new System.Drawing.Point(386, 136);
            this.rNick.Name = "rNick";
            this.rNick.Size = new System.Drawing.Size(181, 23);
            this.rNick.TabIndex = 17;
            // 
            // rRate
            // 
            this.rRate.Location = new System.Drawing.Point(386, 178);
            this.rRate.Name = "rRate";
            this.rRate.Size = new System.Drawing.Size(181, 23);
            this.rRate.TabIndex = 18;
            // 
            // rText
            // 
            this.rText.Location = new System.Drawing.Point(384, 215);
            this.rText.Multiline = true;
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(396, 145);
            this.rText.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(582, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(582, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nick";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(583, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rate (0-10)";
            // 
            // addReview
            // 
            this.addReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addReview.Location = new System.Drawing.Point(709, 389);
            this.addReview.Name = "addReview";
            this.addReview.Size = new System.Drawing.Size(71, 44);
            this.addReview.TabIndex = 23;
            this.addReview.Text = "Add";
            this.addReview.UseVisualStyleBackColor = true;
            this.addReview.Click += new System.EventHandler(this.addReview_Click);
            // 
            // checkMovie
            // 
            this.checkMovie.AutoSize = true;
            this.checkMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkMovie.Location = new System.Drawing.Point(386, 62);
            this.checkMovie.Name = "checkMovie";
            this.checkMovie.Size = new System.Drawing.Size(69, 24);
            this.checkMovie.TabIndex = 24;
            this.checkMovie.Text = "Movie";
            this.checkMovie.UseVisualStyleBackColor = true;
            // 
            // checkSeries
            // 
            this.checkSeries.AutoSize = true;
            this.checkSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSeries.Location = new System.Drawing.Point(467, 63);
            this.checkSeries.Name = "checkSeries";
            this.checkSeries.Size = new System.Drawing.Size(97, 24);
            this.checkSeries.TabIndex = 25;
            this.checkSeries.Text = "TV Series";
            this.checkSeries.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(830, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 129);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lists:";
            // 
            // text6
            // 
            this.text6.Location = new System.Drawing.Point(25, 244);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(135, 23);
            this.text6.TabIndex = 30;
            // 
            // findEpisode
            // 
            this.findEpisode.Location = new System.Drawing.Point(192, 244);
            this.findEpisode.Name = "findEpisode";
            this.findEpisode.Size = new System.Drawing.Size(116, 23);
            this.findEpisode.TabIndex = 29;
            this.findEpisode.Text = "Find Episodes";
            this.findEpisode.UseVisualStyleBackColor = true;
            this.findEpisode.Click += new System.EventHandler(this.findEpisode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 638);
            this.Controls.Add(this.text6);
            this.Controls.Add(this.findEpisode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkSeries);
            this.Controls.Add(this.checkMovie);
            this.Controls.Add(this.addReview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rText);
            this.Controls.Add(this.rRate);
            this.Controls.Add(this.rNick);
            this.Controls.Add(this.rMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findGenre);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.genreList);
            this.Controls.Add(this.viewReview);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.findSeries);
            this.Controls.Add(this.findMovie);
            this.Controls.Add(this.findAct);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.crewList);
            this.Controls.Add(this.listSeries);
            this.Controls.Add(this.listMovies);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button listMovies;
        private System.Windows.Forms.Button listSeries;
        private System.Windows.Forms.Button crewList;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button findAct;
        private System.Windows.Forms.Button findMovie;
        private System.Windows.Forms.Button findSeries;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.Button viewReview;
        private System.Windows.Forms.Button genreList;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.Button findGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rMovie;
        private System.Windows.Forms.TextBox rNick;
        private System.Windows.Forms.TextBox rRate;
        private System.Windows.Forms.TextBox rText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addReview;
        private System.Windows.Forms.CheckBox checkMovie;
        private System.Windows.Forms.CheckBox checkSeries;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text6;
        private System.Windows.Forms.Button findEpisode;
    }
}

