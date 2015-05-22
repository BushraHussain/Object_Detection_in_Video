namespace Prototype_projct
{
    partial class Detection_of_objects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detection_of_objects));
            this.Detect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Original_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Show_picture = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MAKE_Video = new System.Windows.Forms.Button();
            this.show_link = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Output_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_player)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Detect
            // 
            this.Detect.Location = new System.Drawing.Point(301, 118);
            this.Detect.Name = "Detect";
            this.Detect.Size = new System.Drawing.Size(139, 28);
            this.Detect.TabIndex = 2;
            this.Detect.Text = "Detect";
            this.Detect.UseVisualStyleBackColor = true;
            this.Detect.Click += new System.EventHandler(this.Detect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Original_player);
            this.groupBox4.Location = new System.Drawing.Point(31, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 173);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.original_Click);
            // 
            // Original_player
            // 
            this.Original_player.Enabled = true;
            this.Original_player.Location = new System.Drawing.Point(0, 0);
            this.Original_player.Name = "Original_player";
            this.Original_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Original_player.OcxState")));
            this.Original_player.Size = new System.Drawing.Size(206, 173);
            this.Original_player.TabIndex = 0;
            this.Original_player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Show_picture
            // 
            this.Show_picture.Location = new System.Drawing.Point(31, 683);
            this.Show_picture.Name = "Show_picture";
            this.Show_picture.Size = new System.Drawing.Size(146, 38);
            this.Show_picture.TabIndex = 6;
            this.Show_picture.Text = "Show picture";
            this.Show_picture.UseVisualStyleBackColor = true;
            this.Show_picture.Click += new System.EventHandler(this.show_picture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(280, 483);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // MAKE_Video
            // 
            this.MAKE_Video.Location = new System.Drawing.Point(856, 41);
            this.MAKE_Video.Name = "MAKE_Video";
            this.MAKE_Video.Size = new System.Drawing.Size(129, 23);
            this.MAKE_Video.TabIndex = 8;
            this.MAKE_Video.Text = "MAKE Video";
            this.MAKE_Video.UseVisualStyleBackColor = true;
            this.MAKE_Video.Click += new System.EventHandler(this.Make_video_Click_2);
            // 
            // show_link
            // 
            this.show_link.Location = new System.Drawing.Point(92, 50);
            this.show_link.Name = "show_link";
            this.show_link.ReadOnly = true;
            this.show_link.Size = new System.Drawing.Size(548, 22);
            this.show_link.TabIndex = 3;
            this.show_link.TextChanged += new System.EventHandler(this.showLink_TextChanged);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(695, 41);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(109, 31);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(92, 102);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(105, 31);
            this.Upload.TabIndex = 5;
            this.Upload.Text = "Upload File";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(0, 42);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(377, 152);
            this.axWindowsMediaPlayer3.TabIndex = 1;
            // 
            // Output_player
            // 
            this.Output_player.Enabled = true;
            this.Output_player.Location = new System.Drawing.Point(319, 190);
            this.Output_player.Name = "Output_player";
            this.Output_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Output_player.OcxState")));
            this.Output_player.Size = new System.Drawing.Size(213, 212);
            this.Output_player.TabIndex = 2;
            this.Output_player.Enter += new System.EventHandler(this.Output_player_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.axWindowsMediaPlayer3);
            this.groupBox6.Location = new System.Drawing.Point(495, 187);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(411, 194);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.Area_for_output_player_Enter);
            // 
            // Detection_of_objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1056, 733);
            this.Controls.Add(this.Detect);
            this.Controls.Add(this.Output_player);
            this.Controls.Add(this.MAKE_Video);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.show_link);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Show_picture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.Name = "Detection_of_objects";
            this.Text = "Detection of Objects";
            this.Load += new System.EventHandler(this.Detection_of_objects_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output_player)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Detect;
        private System.Windows.Forms.GroupBox groupBox4;
        private AxWMPLib.AxWindowsMediaPlayer Original_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Show_picture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button MAKE_Video;
        private System.Windows.Forms.TextBox show_link;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button Upload;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private AxWMPLib.AxWindowsMediaPlayer Output_player;
        private System.Windows.Forms.GroupBox groupBox6;

    }
}

