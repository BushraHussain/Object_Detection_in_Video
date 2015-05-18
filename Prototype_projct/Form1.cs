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
namespace Prototype_projct
{
  public partial class Detection_of_objects : Form
    {
     static Bitmap videoFrame;
     
      
        //PitureBox.SizeMode = SizeMode.Stretch
        static string path; // File path
        int iner = 0;       // for inner loop counter
        int outer = 0;     // for outer loop counter
        string Caption1 = "Attributes of Video";
        string Caption2 = "RGB values of pixel";
        static int count = 0;
        string caption3 = "InnerLoop Count";
        string caption4= "OuterLoop Count";
        Bitmap original = new Bitmap(@"C:\Users\Bushra Hussain\Desktop\Capture1.PNG");
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

      

        private void Detect_Click(object sender, EventArgs e) // read video 
        {
                VideoFileReader reader=new VideoFileReader();
                reader.Open(path);
            // Show attributes of video into messagebox
                MessageBox.Show("width =  " + reader.Width + "\nheight =  " 
                + reader.Height + "\nFPS  =  " + reader.FrameRate 
                + "\nCodec  =  " + reader.CodecName ,Caption1);
           
            // Reading video frame by frame & Extract RGB info out of it 
              for (int i = 0; i < 580; i++)  //Total 2279 frames , read 1 frame out of it
              {
            
                 videoFrame = reader.ReadVideoFrame(); // process the frame somehow

                //Bitmap IMAGEE = new Bitmap(path);
                // create filter
                ColorFiltering filter = new ColorFiltering();
                // set color ranges to keep
                filter.Red = new IntRange(100, 255);
                filter.Green = new IntRange(0, 75);
                filter.Blue = new IntRange(0, 75);
                //apply the filter
                filter.ApplyInPlace(videoFrame);

                  //corner detector 
                MoravecCornersDetector mcd = new MoravecCornersDetector();
                // process image searching for corners
                List<IntPoint> corners = mcd.ProcessImage(videoFrame);
                // process points
                foreach (IntPoint corner in corners)
                {
                    // ... 
                }

                // create corner maker filter
                CornersMarker filter1 = new CornersMarker(mcd, Color.Blue);
                // apply the filter
                filter1.ApplyInPlace(videoFrame);
                //// Create instance of Blobcounter class 
                BlobCounter blobcounter = new BlobCounter();

                //Process input image 
                blobcounter.ProcessImage(videoFrame);
                
                //get information about detected objects
                Blob[] blob = blobcounter.GetObjectsInformation();
                foreach (Blob arr in blob)
                {
                    //MessageBox.Show("information of image" + arr.Rectangle +
                    //"\n  " + arr.CenterOfGravity + "\n   " + arr.ColorMean +
                    //"\n   " + arr.ColorStdDev);
                    count++;


                }

              
                //Read all Pixels of frame & extract RGB info out of it
                // x,y coordinates of pixel 
                //for (int x = 0; x < 1 ; x++) // original condition x < videoFrame.Width
                //{
                //    for (int y = 0; y < 5; y++) // original condition y < videoFrame.Height
                //    {
                //        MessageBox.Show("frame " + "[" + x + "][" + y + "]  = " + videoFrame.GetPixel(x, y) ,Caption2);
                //        iner++;
                //    }
                //    outer++;
                //}

                // Apply color Filter on each image frame
                  // This filter change background color of image into Black 
                //ColorFiltering filter = new ColorFiltering();
                //// set color ranges to keep
                //filter.Red = new IntRange(100, 255);
                //filter.Green = new IntRange(0, 75);
                //filter.Blue = new IntRange(0, 75);
                //// apply the filter
                //filter.ApplyInPlace(videoFrame);



                // dispose the frame when it is no longer required
                videoFrame.Dispose();

            }
            reader.Close();
            //MessageBox.Show("Inner loop count = " + iner, caption3);
            //MessageBox.Show("outer loop count = " + outer, caption4);

            MessageBox.Show("Total objects in video " + count);






        }

        private void Output_player_Enter(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

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

            path = fdlg.FileName;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            // Assign video file path to window media players 
            //axWindowsMediaPlayer4.settings.autoStart = false;
            Original_player.URL = path;
            Binary_player.URL = path;
          //  Binary_player.HasPropertyPages = filter.ApplyInPlace(videoFrame);
            //Output_player.URL = videoFrame.ToString();
        
            Output_player.URL = path;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
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

        private void binary_player_Enter(object sender, EventArgs e)
        {

        }

       

        private void Binary_Click(object sender, EventArgs e)
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
      // This is only rough Event only to check
      // whether code of filter is working or not. 
        private void show_picture_Click(object sender, EventArgs e)
        {

//            System.Drawing.Image image = System.Drawing.Image.FromFile(path);
//            // Show original image into picture box.
//            pictureBox1.Image = image;
//            pictureBox1.Height = image.Height;
//            pictureBox1.Width = image.Width;
//            //PictureBox1.SizeMode = SizeMode.Stretch;
//            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

//          //  Bitmap IMAGE = new Bitmap(path);
           
//            // Show image After Applying Color Filter 
//            Bitmap IMAGEE = new Bitmap(path);
//            // create filter
//            ColorFiltering filter = new ColorFiltering();
//            // set color ranges to keep
//            filter.Red = new IntRange(100, 255);
//            filter.Green = new IntRange(0, 75);
//            filter.Blue = new IntRange(0, 75);
//             //apply the filter
//            filter.ApplyInPlace(IMAGEE);
//            //pictureBox2.Image = IMAGEE;
//            //pictureBox2.Height = IMAGEE.Height;
//            //pictureBox2.Width = IMAGEE.Width;
//            // create corner detector's instance
//            //Susan Corners Detector
////The routine implements Susan corners detector.
//// create corners detector's instance
////SusanCornersDetector scd = new SusanCornersDetector( );
////// process image searching for corners
////List<IntPoint> corners = scd.ProcessImage( IMAGEE );
////// process points
////foreach ( IntPoint corner in corners )
////{
////      //  MessageBox.Show(corner.X.ToString());

////       // MessageBox.Show(corner.Y.ToString());
////    // ... 
////}
//            // create corner detector's instance
//            MoravecCornersDetector mcd = new MoravecCornersDetector();
//            // process image searching for corners
//            List<IntPoint> corners = mcd.ProcessImage(IMAGEE);
//            // process points
//            foreach (IntPoint corner in corners)
//            {
//                // ... 
//            }





//// create corner detector's instance
////SusanCornersDetector scd1 = new SusanCornersDetector();
////// create corner maker filter
//CornersMarker filter1 = new CornersMarker(mcd, Color.Blue);
//// apply the filter
//filter1.ApplyInPlace(IMAGEE);
//pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
//pictureBox2.Image = IMAGEE;
//pictureBox2.Height = IMAGEE.Height;
//pictureBox2.Width = IMAGEE.Width;
//pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;




            

//            //// Create instance of Blobcounter class 
//BlobCounter blobcounter = new BlobCounter();

////Process input image 
//blobcounter.ProcessImage(original);
//int count = 0;
////get information about detected objects
//Blob[] blob = blobcounter.GetObjectsInformation();
//foreach (Blob arr in blob)
//{
//    //MessageBox.Show("information of image" + arr.Rectangle +
//    //"\n  " + arr.CenterOfGravity + "\n   " + arr.ColorMean +
//    //"\n   " + arr.ColorStdDev);
//    count++;


//}
           


//            //MessageBox.Show("information of image" + blobcounter.GetObjectsInformation());
//MessageBox.Show("Total objects in picture = " + count);

//double offset = 31.2;
//Bitmap bitmap = AsfImage.FromFile(path, offset);

           



         


           






        }

        private void button1_Click(object sender, EventArgs e)
        {
            //// Path of the video and frame storing path
            //string _videopath = path;
            //string _imagepath = @"C:\Users\Bushra Hussain\Desktop\Amina_dll";
            //// Getting Frame From Video only not storing.
            //Bitmap bmp = FrameGrabber.GetFrameFromVideo(_videopath, 0.2d);
            ////Storing return bmp from FrameGrabber Class.
            //bmp.Save(_imagepath, System.Drawing.Imaging.ImageFormat.Gif);
        }

       


    }

    }
