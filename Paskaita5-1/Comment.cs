using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita5_1
{
    class Comment
    {

        public string Text { get; set; }
        public DateTime TimeCreated { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Reaction> Reactions { get; set; }

        public DateTime TimeEdited { get; set; }

        public Boolean IsEdited{ get; set; }

        public User Author { get; set; }


        public Comment(string text, User user, DateTime timeCreated)
        {

            Comments = new List<Comment>();
            Reactions = new List<Reaction>();

            Text = text;
            TimeCreated = timeCreated;
            Author = user;

        }


        public void EditComment(string text, DateTime editTime) {
            IsEdited = true;
            Text = text;
            TimeEdited = editTime;
        }

    }
}
