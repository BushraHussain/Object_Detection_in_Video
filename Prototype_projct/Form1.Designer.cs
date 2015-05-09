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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Upload = new System.Windows.Forms.Button();
            this.browse = new System.Windows.Forms.Button();
            this.show_link = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Detect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Original_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Binary_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Output_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Binary_player)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Output_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Upload);
            this.groupBox1.Controls.Add(this.browse);
            this.groupBox1.Controls.Add(this.show_link);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(825, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.file_upload_area_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(411, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 41);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(19, 65);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(105, 31);
            this.Upload.TabIndex = 5;
            this.Upload.Text = "Upload File";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(573, 28);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(109, 31);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // show_link
            // 
            this.show_link.Location = new System.Drawing.Point(19, 37);
            this.show_link.Name = "show_link";
            this.show_link.ReadOnly = true;
            this.show_link.Size = new System.Drawing.Size(548, 22);
            this.show_link.TabIndex = 3;
            this.show_link.TextChanged += new System.EventHandler(this.showLink_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Detect);
            this.groupBox3.Location = new System.Drawing.Point(264, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.Detect_Area_Enter);
            // 
            // Detect
            // 
            this.Detect.Location = new System.Drawing.Point(55, 21);
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
            this.groupBox4.Size = new System.Drawing.Size(215, 173);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original";
            this.label1.Click += new System.EventHandler(this.original_Click);
            // 
            // Original_player
            // 
            this.Original_player.Enabled = true;
            this.Original_player.Location = new System.Drawing.Point(6, 16);
            this.Original_player.Name = "Original_player";
            this.Original_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Original_player.OcxState")));
            this.Original_player.Size = new System.Drawing.Size(188, 104);
            this.Original_player.TabIndex = 0;
            this.Original_player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.Binary_player);
            this.groupBox5.Location = new System.Drawing.Point(264, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 179);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.Area_for_Binary_player_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Binary";
            this.label2.Click += new System.EventHandler(this.Binary_Click);
            // 
            // Binary_player
            // 
            this.Binary_player.Enabled = true;
            this.Binary_player.Location = new System.Drawing.Point(0, 0);
            this.Binary_player.Name = "Binary_player";
            this.Binary_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Binary_player.OcxState")));
            this.Binary_player.Size = new System.Drawing.Size(194, 104);
            this.Binary_player.TabIndex = 1;
            this.Binary_player.Enter += new System.EventHandler(this.binary_player_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.Output_player);
            this.groupBox6.Controls.Add(this.axWindowsMediaPlayer3);
            this.groupBox6.Location = new System.Drawing.Point(492, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 184);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.Area_for_output_player_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output ";
            this.label3.Click += new System.EventHandler(this.output_Click);
            // 
            // Output_player
            // 
            this.Output_player.Enabled = true;
            this.Output_player.Location = new System.Drawing.Point(0, 0);
            this.Output_player.Name = "Output_player";
            this.Output_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Output_player.OcxState")));
            this.Output_player.Size = new System.Drawing.Size(202, 104);
            this.Output_player.TabIndex = 2;
            this.Output_player.Enter += new System.EventHandler(this.Output_player_Enter);
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(6, 0);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(194, 104);
            this.axWindowsMediaPlayer3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 191);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Detection_of_objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Detection_of_objects";
            this.Text = "Detection of Objects";
            this.Load += new System.EventHandler(this.Detection_of_objects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Binary_player)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Output_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox show_link;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Detect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private AxWMPLib.AxWindowsMediaPlayer Original_player;
        private AxWMPLib.AxWindowsMediaPlayer Binary_player;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer Output_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;

    }
}

