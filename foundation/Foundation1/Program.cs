using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        videos.Add(new Video("Learning C#", "Arlette Steele", 600));
        videos.Add(new Video("Intro to Databases", "Collin Steele", 800));
        videos.Add(new Video("Web Development Basics", "Julia Grant", 720));

        videos[0].AddComment(new Comment("Petrina", "Great tutorial!"));
        videos[0].AddComment(new Comment("Carolina", "Very informative."));
        videos[0].AddComment(new Comment("David", "Loved the examples."));

        videos[1].AddComment(new Comment("Felipe", "Clear explanation, thanks!"));
        videos[1].AddComment(new Comment("Morgan", "Helped me a lot."));

        videos[2].AddComment(new Comment("Chris", "Awesome content!"));
        videos[2].AddComment(new Comment("Alanna", "Really enjoyed this."));

        foreach (var video in videos)
        {
            Console.WriteLine(video.Display());
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.Display());
            }
            Console.WriteLine();
        }
    }
}
