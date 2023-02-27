using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Post
    {

        private static int currentPostId;

        //properties

        protected int ID { get; set; }
        protected string Title { get; set; }

        protected string SendByUsername { get; set; }

        public bool IsPublic { get; set; }


        //default constructor, If a derived class does not invoke a base
        public Post()

        {
            ID = 0;
            Title = "FirstPost";
            IsPublic= true;
            SendByUsername = "Cris";

        }

        //instace constructor 3 params

        public Post(string title, string sendByUsername, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic= isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        //constructor
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }


        // makes post
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
