using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.FFMPEG;
using AForge.Imaging;
using AForge;
using AForge.Imaging.Filters;
using AsfMojo;
using AsfMojoUI;
using AsfMojo.Media;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using DexterLib;
using stdole;
using User.DirectShow;
using System.Drawing.Imaging;
namespace Prototype_projct
{
  public partial class Detection_of_objects : Form
    {

      public static string file_path;
      
      public Detection_of_objects()
        {
            InitializeComponent();
        }
      
       

        private void Detect_Area_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showLink_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Detection_of_objects_Load(object sender, EventArgs e)
        {

        }

        private void file_upload_area_Enter(object sender, EventArgs e)
        {

        }





        private void Detect_Click(object sender, EventArgs e)
        {

            //Form x = new Detect_form();
            //Detect_form xx = new Detect_form();
            ////this.Hide();
            //x.Show();
            Detect_object D_obj = new Detect_object();
            D_obj.detct_object(file_path);
            D_obj.GetFramesURL();
           
        }
            
            
            
            
            

        
















         


        public  void browse_Click(object sender, EventArgs e)
        {
            // open file directory 
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                show_link.Text = fdlg.FileName;
            }

             file_path= fdlg.FileName;
        }

        private void upload_Click(object sender, EventArgs e)
        {
      
            //axWindowsMediaPlayer4.settings.autoStart = false;
            Original_player.URL = file_path;
            Outputt_player.URL = @"F:\snap_video\imageVideo.avi";
          
            
        }
 
            
        
        

        private void original_Enter(object sender, EventArgs e)
        {
    
        }

        private void Area_for_binary_Enter(object sender, EventArgs e)
        {

        }

        private void Area_for_original_Enter(object sender, EventArgs e)
        {

        }

        private void original_Click(object sender, EventArgs e)
        {

        }

       

       

        

        private void Area_for_output_Enter(object sender, EventArgs e)
        {

        }

        private void Area_for_output_player_Enter(object sender, EventArgs e)
        {

        }

        private void Area_for_Binary_player_Enter(object sender, EventArgs e)
        {
 
        }

        private void show_picture_Click(object sender, EventArgs e)
        {
        }   
        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void Show_picc_Click(object sender, EventArgs e)
        //{

        //    System.Drawing.Image image = System.Drawing.Image.FromFile(file_path);
        //    // Show original image into picture box.
        //    pictureBox2.Image = image;
        //    pictureBox2.Height = image.Height;
        //    pictureBox2.Width = image.Width;
        //    //PictureBox1.SizeMode = SizeMode.Stretch;
        //    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;


        //    // apply filter on image 

        //    Bitmap IMAGE = new Bitmap(file_path);
        //    // create filter
        //    ColorFiltering filter = new ColorFiltering();
        //    // set color ranges to keep
        //    filter.Red = new IntRange(100, 255);
        //    filter.Green = new IntRange(0, 75);
        //    filter.Blue = new IntRange(0, 75);
        //    //apply the filter
        //    filter.ApplyInPlace(IMAGE);


        //    // image to grayscale

        //  //  IMAGE = Detect_object.MakeGrayscale3(IMAGE);

        //    // Rectangle (only big image)

        //    BlobCounter blobCounter = new BlobCounter();

        //    blobCounter.MinWidth = 5;
        //    blobCounter.MinHeight = 5;
        //    blobCounter.FilterBlobs = true;
        //    blobCounter.ObjectsOrder = ObjectsOrder.Size;
        //    blobCounter.ProcessImage(IMAGE);

        //    Rectangle[] rec = blobCounter.GetObjectsRectangles();
        //    foreach (Rectangle recs in rec)
        //        if (rec.Length > 0)
        //        {
        //            Rectangle objectRect = rec[0];
        //            Graphics g = Graphics.FromImage(image);
        //            using (Pen pen = new Pen(Color.FromArgb(160, 255, 160), 5))
        //            {
        //                g.DrawRectangle(pen, objectRect);
        //            }
        //            g.Dispose();
        //        }

        //    // highlighted image 

        //    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        //    pictureBox3.Image = IMAGE;
        //    pictureBox3.Height = IMAGE.Height;
        //    pictureBox3.Width = IMAGE.Width;
        //    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        //}
     




        




    }

}

      
   
       






        
       


   