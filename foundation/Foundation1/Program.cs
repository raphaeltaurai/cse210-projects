using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Naruto","Anime_Writer", 108000);
        Video video2 = new Video("Coco melon", "Coco Melon", 300);

        video1.AddComment(new Comment("Tino", "Zvozodii paya"));
        video1.AddComment(new Comment("Pana", "This episode was great!!!"));

        video2.AddComment(new Comment("Tindo", "Goo goo gaga was the birth of Nerd iQ"));
        video2.AddComment(new Comment("Shiana", "Da doli Shonononai"));

        List<Video> videos = new List<Video> { video1, video2};

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
