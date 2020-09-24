using System;
using System.Collections.Generic;

namespace Paskaita5_1
{
    class Program
    {


    
        static void Main(string[] args)
        {

            User me = new User("Nerijus Viluckas");

            User draugas = new User("Markas Garuolis");

            Post postas = new Post("Sveiki cia mano pirmas postas", me, DateTime.Now);

            Comment komentaras = new Comment("Cia mano pirmas komentaras", draugas, DateTime.Now);

            komentaras.Reactions.Add(new Reaction(Reaction.Reactions.Care, DateTime.Now, me));

            postas.Reactions.Add(new Reaction(Reaction.Reactions.Like,DateTime.Now,draugas));

            postas.Comments.Add(komentaras);

            //postas.Status = Post.status.Private;

            List<Post> postai = new List<Post>();
            postai.Add(postas);

            

            foreach (var postas1 in postai)
            {

                if (postas1.Status != Post.status.Public) continue;
                Console.WriteLine("Posto tekstas: " + postas1.Text);
                Console.WriteLine("Posto autorius: " + postas1.Author.Vardas_Pavarde);
                Console.WriteLine("Posto data: " + postas1.TimeCreated);
                Console.WriteLine("Reacationu skacius: " + postas1.Reactions.Count);

                foreach (var item in postas1.Reactions)
                {

                    Console.WriteLine("     Reaction tipas: " + item.Reactionas + "\n     Reaction autorius: " + item.Author.Vardas_Pavarde);
                }

                Console.WriteLine("Komentaru skaicius: " + postas1.Comments.Count);

                foreach (var item in postas1.Comments)
                {

                    Console.WriteLine("     Komentaras: " + item.Text + "\n     Komentaro autorius: " + item.Author.Vardas_Pavarde);
                    Console.WriteLine("     Reacationu skacius: " + postas1.Reactions.Count);
                    foreach (var reaction in item.Reactions)
                    {

                        Console.WriteLine("          Reaction tipas: " + reaction.Reactionas + "\n          Reaction autorius: " + reaction.Author.Vardas_Pavarde);
                    }

                }
            }

        }
    }
}
