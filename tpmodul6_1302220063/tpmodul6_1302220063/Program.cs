using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999); // Generate random 5-digit ID
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
        Console.WriteLine($"Judul: {title}");
        Console.WriteLine($"Jumlah Tayangan: {playCount}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        string namaPraktikan = "Irham Baehaqi";
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - " + namaPraktikan);
        video.IncreasePlayCount(10);
        video.PrintVideoDetails();
    }
}
