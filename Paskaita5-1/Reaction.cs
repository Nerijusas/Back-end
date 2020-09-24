using System;
using System.Collections.Generic;
using System.Text;

namespace Paskaita5_1
{
    class Reaction
    {
        public enum Reactions
        {
            Like,
            Love,
            Care,
            Haha,
            Wow,
            Sad,
            Angry

        }
        public Reactions Reactionas { get; set; }
        public DateTime TimeCreated { get; set; }

        public User Author { get; set; }


        public Reaction(Reactions reactionas, DateTime timeCreated, User user)
        {
            Reactionas = reactionas;
            TimeCreated = timeCreated;
            Author = user;

        }


       
    }
}
