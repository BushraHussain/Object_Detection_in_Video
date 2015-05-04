using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
//using System.Drawing.Imaging;
using AForge.Video.FFMPEG;
namespace read_video
{

    class Program
    {
        static void Main(string[] args)
        {

            

            // create instance of video reader
            VideoFileReader reader = new VideoFileReader();
            
            
            reader.Open(@"C:\Video.avi");
            
           // check some of its attributes
            Console.WriteLine("width:  " + reader.Width);
            Console.WriteLine("Height: " + reader.Height);
            Console.WriteLine("Fps:    " + reader.FrameRate);
            Console.WriteLine("Codec:  " + reader.CodecName);
            Console.WriteLine("Codec:  " + reader.Length);

            // read 100 video frames out of it
            for (int i = 0; i < 100; i++)
            {
                Bitmap videoFrame = reader.ReadVideoFrame();
                // process the frame somehow
                

                // dispose the frame when it is no longer required
                videoFrame.Dispose();
                
            }
            reader.Close();

        }
    }
}














   
