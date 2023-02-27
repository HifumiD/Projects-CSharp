using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class ImagePost : Post
    {

        protected string ImageURL { get; set; }

        //constructor with post properties
        public ImagePost(string title, string sendByUserName, string ImageURL, bool isPublic)
        {
           this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername= sendByUserName;
            this.IsPublic = isPublic;

            this.ImageURL= ImageURL;
        }


        //prints post info
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} | {3}", this.ID, this.Title, this.SendByUsername, this.ImageURL);
        }

    }
}
