using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 20 Minutes", "CodeMaster", 1200);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for making this."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Travel Destinations", "TravelWithMe", 850);
        video2.AddComment(new Comment("David", "I want to visit Japan."));
        video2.AddComment(new Comment("Emma", "Amazing video!"));
        video2.AddComment(new Comment("Frank", "Great editing."));
        videos.Add(video2);

        Video video3 = new Video("Easy Chocolate Cake Recipe", "KitchenLife", 540);
        video3.AddComment(new Comment("Grace", "Made this today!"));
        video3.AddComment(new Comment("Henry", "Delicious recipe."));
        video3.AddComment(new Comment("Isabella", "Simple and easy."));
        videos.Add(video3);

        Video video4 = new Video("Football Skills Compilation", "SportsZone", 760);
        video4.AddComment(new Comment("Jack", "Awesome skills!"));
        video4.AddComment(new Comment("Kevin", "Who's your favorite player?"));
        video4.AddComment(new Comment("Lily", "Loved every second."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}