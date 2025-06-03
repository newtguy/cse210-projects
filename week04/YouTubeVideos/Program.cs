using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video shuffleVid = new Video("Shuffle Party Outside", "Shuffle Gang", 500);
        Video danceVid = new Video("Dance Party Outside", "Dancers", 1000);
        Video poolVid = new Video("Pool Party Outside", "Noodle Nation", 44);

        Comment shuffleComm1 = new Comment("Wow!", "Jake");
        Comment shuffleComm2 = new Comment("I want to shuffle too :(", "WannaBeShuffler");
        Comment shuffleComm3 = new Comment("I love the way you shuffle", "Shuffle Lover");
        shuffleVid.AddThreeComments(shuffleComm1, shuffleComm2, shuffleComm3);

        Comment danceComm1 = new Comment("Wow!", "Bob");
        Comment danceComm2 = new Comment("I want to dance too :(", "WannaBeDancer");
        Comment danceComm3 = new Comment("I love the way you dance", "Dance Lover");
        danceVid.AddThreeComments(danceComm1, danceComm2, danceComm3);

        Comment poolComm1 = new Comment("Wow!", "User144325");
        Comment poolComm2 = new Comment("I want to have a pool party!", "WannaBeSwimmer");
        Comment poolComm3 = new Comment("Keep that water away from me!", "Flaming Flamingo");
        poolVid.AddThreeComments(poolComm1, poolComm2, poolComm3);

        List<Video> videos = new List<Video>();
        videos.Add(shuffleVid);
        videos.Add(danceVid);
        videos.Add(poolVid);

        foreach (Video video in videos)
        {
            video.DisplayAll();
            Console.WriteLine();
        }
    }
}