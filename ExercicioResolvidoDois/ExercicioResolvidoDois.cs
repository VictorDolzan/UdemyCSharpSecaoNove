using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoNove.ExercicioResolvidoDois.EntitiesDois;

namespace CSharpSecaoNove.ExercicioResolvidoDois
{
    class ExercicioResolvidoDois
    {
        public static void ExecutarExercicioResolvidoDois()
        {
            Comment c1 = new Comment("Have a Nice Trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("06/21/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );
            p1.AddComments(c1);
            p1.AddComments(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("07/28/2018 23:14:19"),
                "Good Night Guys",
                "See you Tomorrow",
                5
            );
            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}