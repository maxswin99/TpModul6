using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 100, "Judul tidak boleh null dan maksimal 100 karakter!");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count > 0 && count <= 10000000, "Input play count maksimal 10 juta per panggilan!");
        checked
        {
            playCount += count;
        }
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
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Andreas Christian Firga");
        video.IncreasePlayCount(100);
        video.PrintVideoDetails();

        Console.ReadKey(); // Agar output tidak langsung tertutup
    }
}
