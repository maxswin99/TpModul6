using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    public int playCount;

    public SayaTubeVideo(string title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Review Film - Andraes Christian Firga");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();
    }
}
