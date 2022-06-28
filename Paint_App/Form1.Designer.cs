
namespace Paint_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_hand = new System.Windows.Forms.Button();
            this.btn_rubbish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_folder = new System.Windows.Forms.Button();
            this.btn_brown = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.btn_purple = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_orange = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_hexagon = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btn_brown);
            this.panel1.Controls.Add(this.btn_white);
            this.panel1.Controls.Add(this.btn_purple);
            this.panel1.Controls.Add(this.btn_yellow);
            this.panel1.Controls.Add(this.btn_black);
            this.panel1.Controls.Add(this.btn_orange);
            this.panel1.Controls.Add(this.btn_blue);
            this.panel1.Controls.Add(this.btn_green);
            this.panel1.Controls.Add(this.btn_red);
            this.panel1.Controls.Add(this.btn_hexagon);
            this.panel1.Controls.Add(this.btn_triangle);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(718, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.btn_fill);
            this.groupBox1.Controls.Add(this.btn_eraser);
            this.groupBox1.Controls.Add(this.btn_pencil);
            this.groupBox1.Controls.Add(this.btn_hand);
            this.groupBox1.Controls.Add(this.btn_rubbish);
            this.groupBox1.Location = new System.Drawing.Point(3, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(111, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şekil İşlemleri";
            // 
            // btn_fill
            // 
            this.btn_fill.BackgroundImage = global::Paint_App.Properties.Resources.fill;
            this.btn_fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.Location = new System.Drawing.Point(30, 99);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(52, 38);
            this.btn_fill.TabIndex = 17;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_eraser.BackgroundImage = global::Paint_App.Properties.Resources.erase;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.Location = new System.Drawing.Point(56, 16);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(52, 38);
            this.btn_eraser.TabIndex = 16;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_pencil.BackgroundImage = global::Paint_App.Properties.Resources.pencil;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.Location = new System.Drawing.Point(3, 16);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(52, 38);
            this.btn_pencil.TabIndex = 15;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_hand
            // 
            this.btn_hand.BackgroundImage = global::Paint_App.Properties.Resources.mouse_hand;
            this.btn_hand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hand.Location = new System.Drawing.Point(3, 58);
            this.btn_hand.Name = "btn_hand";
            this.btn_hand.Size = new System.Drawing.Size(52, 38);
            this.btn_hand.TabIndex = 1;
            this.btn_hand.UseVisualStyleBackColor = true;
            this.btn_hand.Click += new System.EventHandler(this.btn_hand_Click);
            // 
            // btn_rubbish
            // 
            this.btn_rubbish.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_rubbish.BackgroundImage = global::Paint_App.Properties.Resources.rubbish;
            this.btn_rubbish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_rubbish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rubbish.Location = new System.Drawing.Point(56, 58);
            this.btn_rubbish.Name = "btn_rubbish";
            this.btn_rubbish.Size = new System.Drawing.Size(52, 38);
            this.btn_rubbish.TabIndex = 0;
            this.btn_rubbish.UseVisualStyleBackColor = false;
            this.btn_rubbish.Click += new System.EventHandler(this.btn_rubbish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_folder);
            this.groupBox2.Location = new System.Drawing.Point(3, 352);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(111, 60);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya İşlemleri";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::Paint_App.Properties.Resources.save;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(56, 16);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(52, 41);
            this.btn_save.TabIndex = 2;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.BackgroundImage = global::Paint_App.Properties.Resources.folder;
            this.btn_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_folder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_folder.Location = new System.Drawing.Point(3, 16);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(52, 41);
            this.btn_folder.TabIndex = 0;
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_brown
            // 
            this.btn_brown.BackColor = System.Drawing.Color.Maroon;
            this.btn_brown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_brown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_brown.FlatAppearance.BorderSize = 2;
            this.btn_brown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_brown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_brown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brown.Location = new System.Drawing.Point(42, 172);
            this.btn_brown.Margin = new System.Windows.Forms.Padding(0);
            this.btn_brown.Name = "btn_brown";
            this.btn_brown.Size = new System.Drawing.Size(33, 27);
            this.btn_brown.TabIndex = 13;
            this.btn_brown.UseVisualStyleBackColor = false;
            this.btn_brown.Click += new System.EventHandler(this.btn_brown_Click);
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.White;
            this.btn_white.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_white.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_white.FlatAppearance.BorderSize = 2;
            this.btn_white.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_white.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_white.Location = new System.Drawing.Point(81, 172);
            this.btn_white.Margin = new System.Windows.Forms.Padding(0);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(33, 27);
            this.btn_white.TabIndex = 12;
            this.btn_white.UseVisualStyleBackColor = false;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // btn_purple
            // 
            this.btn_purple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_purple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_purple.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_purple.FlatAppearance.BorderSize = 2;
            this.btn_purple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_purple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_purple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_purple.Location = new System.Drawing.Point(3, 172);
            this.btn_purple.Margin = new System.Windows.Forms.Padding(0);
            this.btn_purple.Name = "btn_purple";
            this.btn_purple.Size = new System.Drawing.Size(33, 27);
            this.btn_purple.TabIndex = 11;
            this.btn_purple.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_purple.UseVisualStyleBackColor = false;
            this.btn_purple.Click += new System.EventHandler(this.btn_purple_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yellow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_yellow.FlatAppearance.BorderSize = 2;
            this.btn_yellow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_yellow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yellow.Location = new System.Drawing.Point(81, 139);
            this.btn_yellow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(33, 27);
            this.btn_yellow.TabIndex = 10;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_black
            // 
            this.btn_black.BackColor = System.Drawing.Color.Black;
            this.btn_black.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_black.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_black.FlatAppearance.BorderSize = 2;
            this.btn_black.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_black.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_black.Location = new System.Drawing.Point(42, 139);
            this.btn_black.Margin = new System.Windows.Forms.Padding(0);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(33, 27);
            this.btn_black.TabIndex = 9;
            this.btn_black.UseVisualStyleBackColor = false;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // btn_orange
            // 
            this.btn_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_orange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_orange.FlatAppearance.BorderSize = 2;
            this.btn_orange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_orange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orange.Location = new System.Drawing.Point(3, 139);
            this.btn_orange.Margin = new System.Windows.Forms.Padding(0);
            this.btn_orange.Name = "btn_orange";
            this.btn_orange.Size = new System.Drawing.Size(33, 27);
            this.btn_orange.TabIndex = 8;
            this.btn_orange.UseVisualStyleBackColor = false;
            this.btn_orange.Click += new System.EventHandler(this.btn_orange_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.Blue;
            this.btn_blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_blue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_blue.FlatAppearance.BorderSize = 2;
            this.btn_blue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_blue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blue.Location = new System.Drawing.Point(42, 106);
            this.btn_blue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(33, 27);
            this.btn_blue.TabIndex = 7;
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_green.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_green.FlatAppearance.BorderSize = 2;
            this.btn_green.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_green.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_green.Location = new System.Drawing.Point(81, 106);
            this.btn_green.Margin = new System.Windows.Forms.Padding(0);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(33, 27);
            this.btn_green.TabIndex = 6;
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_red.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_red.FlatAppearance.BorderSize = 2;
            this.btn_red.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_red.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_red.Location = new System.Drawing.Point(3, 106);
            this.btn_red.Margin = new System.Windows.Forms.Padding(0);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(33, 27);
            this.btn_red.TabIndex = 5;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_hexagon
            // 
            this.btn_hexagon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_hexagon.BackgroundImage = global::Paint_App.Properties.Resources.hexagon;
            this.btn_hexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hexagon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hexagon.Location = new System.Drawing.Point(57, 50);
            this.btn_hexagon.Name = "btn_hexagon";
            this.btn_hexagon.Size = new System.Drawing.Size(57, 50);
            this.btn_hexagon.TabIndex = 4;
            this.btn_hexagon.UseVisualStyleBackColor = false;
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_triangle.BackgroundImage = global::Paint_App.Properties.Resources.triangle;
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_triangle.Location = new System.Drawing.Point(3, 50);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(55, 50);
            this.btn_triangle.TabIndex = 3;
            this.btn_triangle.UseVisualStyleBackColor = false;
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ellipse.BackgroundImage = global::Paint_App.Properties.Resources.ellipse;
            this.btn_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.Location = new System.Drawing.Point(57, 3);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(57, 50);
            this.btn_ellipse.TabIndex = 2;
            this.btn_ellipse.UseVisualStyleBackColor = false;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_rect.BackgroundImage = global::Paint_App.Properties.Resources.rectangle;
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.Location = new System.Drawing.Point(3, 3);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(55, 50);
            this.btn_rect.TabIndex = 0;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(718, 450);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_hexagon;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_orange;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_brown;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.Button btn_purple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_hand;
        private System.Windows.Forms.Button btn_rubbish;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

