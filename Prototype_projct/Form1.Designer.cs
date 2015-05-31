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
            this.show_link = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Outputt_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.Original_player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Outputt_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).BeginInit();
            this.SuspendLayout();
            // 
            // Detect
            // 
            this.Detect.BackColor = System.Drawing.Color.Teal;
            this.Detect.ForeColor = System.Drawing.Color.White;
            this.Detect.Location = new System.Drawing.Point(103, 100);
            this.Detect.Name = "Detect";
            this.Detect.Size = new System.Drawing.Size(105, 36);
            this.Detect.TabIndex = 2;
            this.Detect.Text = "Detect";
            this.Detect.UseVisualStyleBackColor = false;
            this.Detect.Click += new System.EventHandler(this.Detect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Original_player);
            this.groupBox4.Location = new System.Drawing.Point(103, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 256);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            // show_link
            // 
            this.show_link.BackColor = System.Drawing.Color.AliceBlue;
            this.show_link.ForeColor = System.Drawing.SystemColors.Desktop;
            this.show_link.Location = new System.Drawing.Point(103, 55);
            this.show_link.Name = "show_link";
            this.show_link.ReadOnly = true;
            this.show_link.Size = new System.Drawing.Size(684, 22);
            this.show_link.TabIndex = 3;
            this.show_link.TextChanged += new System.EventHandler(this.showLink_TextChanged);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Teal;
            this.browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browse.Location = new System.Drawing.Point(841, 42);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(109, 35);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Teal;
            this.Upload.ForeColor = System.Drawing.SystemColors.Control;
            this.Upload.Location = new System.Drawing.Point(103, 464);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(105, 39);
            this.Upload.TabIndex = 5;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // Outputt_player
            // 
            this.Outputt_player.Enabled = true;
            this.Outputt_player.Location = new System.Drawing.Point(557, 156);
            this.Outputt_player.Name = "Outputt_player";
            this.Outputt_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Outputt_player.OcxState")));
            this.Outputt_player.Size = new System.Drawing.Size(376, 256);
            this.Outputt_player.TabIndex = 6;
            // 
            // Original_player
            // 
            this.Original_player.Enabled = true;
            this.Original_player.Location = new System.Drawing.Point(0, 0);
            this.Original_player.Name = "Original_player";
            this.Original_player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Original_player.OcxState")));
            this.Original_player.Size = new System.Drawing.Size(403, 256);
            this.Original_player.TabIndex = 0;
            this.Original_player.Enter += new System.EventHandler(this.original_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(100, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(571, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // Detection_of_objects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1077, 531);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Outputt_player);
            this.Controls.Add(this.Detect);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.show_link);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeBox = false;
            this.Name = "Detection_of_objects";
            this.Text = "Detection of Objects";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Detection_of_objects_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Outputt_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Original_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Detect;
        private System.Windows.Forms.GroupBox groupBox4;
        private AxWMPLib.AxWindowsMediaPlayer Original_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox show_link;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button Upload;
        private AxWMPLib.AxWindowsMediaPlayer Outputt_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}

