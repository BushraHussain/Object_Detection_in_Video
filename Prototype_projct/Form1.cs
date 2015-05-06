using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video.FFMPEG;



namespace Prototype_projct
{
//    <startup useLegacyV2RunTimeActivationPolicy ="true">
//<supportedRuntime version="v4.0"/>
//</startup>


    public partial class Detection_of_objects : Form
    {
        static string path;
        int iner = 0;
        int outer = 0;
        string Caption1 = "Attributes of Video";
        string Caption2 = "RGB values of pixel";
        string caption3 = "InnerLoop Count";
        string caption4= "OuterLoop Count";
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
            VideoFileReader reader=new VideoFileReader();

            reader.Open(@"C:\Users\Bushra Hussain\Pictures\2013-02-05 17.47.26 (2).jpg");
           MessageBox.Show("width =  " + reader.Width + "\nheight =  " 
                + reader.Height + "\nFPS  =  " + reader.FrameRate 
                + "\nCodec  =  " + reader.CodecName ,Caption1);
           

              for (int i = 0; i < 1; i++)  //Total 2279 frames , read 1 frames out of it
              {
            
                Bitmap videoFrame = reader.ReadVideoFrame(); // process the frame somehow
                
                //Read all Pixels of frame & extract RGB info out of it
                // x,y coordinates of pixel 
                for (int x = 0; x < 1 ; x++) // original condition x < videoFrame.Width
                {
                    for (int y = 0; y < 5; y++) // original condition y < videoFrame.Height
                    {
                        MessageBox.Show("frame " + "[" + x + "][" + y + "]  = " + videoFrame.GetPixel(x, y) ,Caption2);
                        //Console.WriteLine("frame " + "[" + x + "][" + y + "]  = " + videoFrame.GetPixel(x, y));
                        Color clr = videoFrame.GetPixel(x, y); 

                        int red = clr.R;
                        int green = clr.G;
                        int blue = clr.B;
                        Console.WriteLine("RGB: " + "[" + x + "][" + y + "] =  " + red + "  "
                                           + green + " " + blue);


                        iner++;
                    }
                    outer++;
                }


                // dispose the frame when it is no longer required
                videoFrame.Dispose();

            }
            reader.Close();
            MessageBox.Show("Inner loop count = " + iner, caption3);
            MessageBox.Show("outer loop count = " + outer, caption4);


        }

        private void Output_player_Enter(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        public  void browse_Click(object sender, EventArgs e)
        {
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
            //axWindowsMediaPlayer1.settings.autoStart = false;
            Original_player.URL = path;
            //axWindowsMediaPlayer2.settings.autoStart = false;
            Binary_player.URL = path;
            //axWindowsMediaPlayer4.settings.autoStart = false;
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

       




    }
}
