using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita5_1
{
    class Post
    {


        public Post(string text, User author, DateTime timeCreated)
        {
            Comments = new List<Comment>();
            Reactions = new List<Reaction>();
            Visibility = new List<User>();
            Text = text;
            Author = author;
            TimeCreated = timeCreated;
            Status = status.Public;

        }

        public enum status
        {
            Hidden,
            Deleted,
            Public,
            Private
        }

        private Boolean isEdited;

        public Boolean IsEdited
        {
            get
            {
                return isEdited;
            }
        }

        public string Text{ get; set; }

        public User Author { get; set; }

        public DateTime TimeCreated { get; set; }
        public DateTime TimeEdited { get; set; }

        public status Status { get; set; }

        public List<Reaction> Reactions{ get; set; }

        public int reports { get; set; }

        private List<User> visibility;

        public List<User> Visibility
        {
            get { if (Status != status.Public) return new List<User>();  return visibility; }
            set { if (canSetVisibility()) visibility = value; }
        }

        private List<Comment> comments;

        public List<Comment> Comments
        {
            get { return comments; }
            set { comments = value; }
        }


        public void edit(String text, DateTime timeEdited)
        {
            TimeEdited = timeEdited;
            isEdited = true;
            Text = text;

        }

        public void share(String Location, DateTime time)
        {
            //Tipo postina, nes nzn kaip cia padaryti ta postinima :DDD

        }

        public void report()
        {

            if (reports > 10)
                Status = status.Private;
            reports++;

        }

        public Boolean canSetVisibility()
        {
            return !(reports > 10);
        }



    }
}
