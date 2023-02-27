using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Threading;
using list;


// the beginning
namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {

            //creates a new basic post
            Post post1 = new Post("Thanks for the birthday wishes", "Mike", true);

            Console.WriteLine(post1.ToString());


            //creates an image post
            ImagePost imagePost1 = new ImagePost("Check my new shoes", "Melisa", "https://images.com/shose", true);
            Console.WriteLine(imagePost1.ToString());


            
            //creates a videopost with a timer
            VideoPost videoPostvideo2 = new VideoPost("My second video", "Sarah", "https://abigai.vid/video", true, 40);
            Console.WriteLine(videoPostvideo2.ToString());


            //plays video seconds until any key is entered
            videoPostvideo2.Play();
            Console.ReadLine();
            videoPostvideo2.Stop();
            

        }




    }


}