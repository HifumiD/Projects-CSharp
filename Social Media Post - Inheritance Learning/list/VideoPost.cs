using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace list
{
    internal class VideoPost : Post
    {
        protected bool isPlaying = false;
        public int currDuration = 0;
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        Timer timer;
        public VideoPost() 
        {
           
        }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
          this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername= sendByUsername;
            this.IsPublic= isPublic;

            this.VideoURL = videoURL;
            this.Length = length;
        }

        //post information
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} | {3} of length {4}", this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Length);
        }


        //plays the video
        public virtual void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
                
            }
        }


        //plays video until Seconds lower than Video Length
        private void TimerCallback(object state)
        {
            if(currDuration < Length)
            {
                
                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        //stops video and displays current duration
        public void Stop()
        {
            if (isPlaying) {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
            
        }

        

        
    }
}
