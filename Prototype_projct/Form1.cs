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
        public Detection_of_objects()
        {
            InitializeComponent();
        }

       

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        string str_file_name = openFileDialog1.FileName;
        //        MessageBox.Show(str_file_name);

        //    }


           
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            VideoFileReader reader=new VideoFileReader();
           
            reader.Open(@"path");
             //check some of its attributes
            //Console.WriteLine("width:  " + reader.Width);
            //Console.WriteLine("Height: " + reader.Height);
            //Console.WriteLine("Fps:    " + reader.FrameRate);
            //Console.WriteLine("Codec:  " + reader.CodecName);

            double width = reader.Width;
             double Height=reader.Height;
                double  Fps=   reader.FrameRate;
              string Codec = reader.CodecName;


             //Total 2279 frames & read 10 frames out of it
            for (int i = 0; i < 10; i++)
            {
                Bitmap videoFrame = reader.ReadVideoFrame(); // process the frame somehow
                
                //Read all Pixels of frame & extract RGB info out of it 
                for (int x = 0; x < videoFrame.Width; x++)
                {
                    for (int y = 0; y < videoFrame.Height; y++)
                    {

                        //Console.WriteLine("frame " + "[" + x+ "][" + y + "]  = " + videoFrame.GetPixel(j, k));
                        Color clr = videoFrame.GetPixel(x, y); // x,y coordinates of pixel 

                        int red = clr.R;
                        int green = clr.G;
                        int blue = clr.B;
                        //Console.WriteLine("RGB: " + "[" + x + "][" + y+ "] =  " + red + "  "
                        //                   + green + " " + blue);


                        iner++;
                    }
                    outer++;
                }


                // dispose the frame when it is no longer required
                videoFrame.Dispose();

            }
            reader.Close();
           // Console.WriteLine("Inner loop count = " + iner);
           // Console.WriteLine("outer loop count = " + outer);


        }

        private void axWindowsMediaPlayer4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void Detect_Click(object sender, EventArgs e)
        {

        }

       




    }
}
