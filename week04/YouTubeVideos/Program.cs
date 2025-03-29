using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Best way to build a garden,", "Tobias Eaton", 425);
        video1.AddComment("Maxon,", "Great video.");
        video1.AddComment("Kaz,", "Cool.");
        video1.AddComment("Jesper,", "Great editing!");

        Video video2 = new Video("Greek Mythology in its finest,", "Gleeson Hedge", 892);
        video2.AddComment("Atlas,", "Greek buildings are awesome!");
        video2.AddComment("Percy,", "Great pictures.");
        video2.AddComment("Annabeth,", "The architecture in the video is jaw droping.");

        Video video3 = new Video("Tips for swordplay,", "Mason Ballenger", 376);
        video3.AddComment("Jace,", "Great tips!");
        video3.AddComment("Kazi,", "This helped a lot.");
        video3.AddComment("Nathan,", "Those are some cool moves!");
        

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());  
            video.GetComments();
        }
    }
}
