using System;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("1st Vid");
        string title1 = "Black Myth Wukong first thoughts";
        string author1 = "TheRadBrad";
        int lenght1 = 60;

        string comments1 = "#Ace - looks great! , #luffy - can't wait to play , #kaido - overated , #garp - looks decent ";


        Video video1 = new Video(title1, author1, lenght1, comments1);
        Console.WriteLine(video1.DisplayAll());


        Console.WriteLine();

        Console.WriteLine("2nd Vid");

        Console.WriteLine();

        string title2 = "Boruto TBV ch16(manga) ";
        string author2 = "NCHammer";
        int lenght2 = 120;

        string comments2 = "#Sasuke - Flyin raijin let's go!!! , #Minato - Boruto still sucks , #Itachi - I hope they keep this pace  ";

        Video video2 = new Video(title2, author2, lenght2, comments2);
        Console.WriteLine(video2.DisplayAll());

        
        Console.WriteLine();

        Console.WriteLine("3rd vid");

        Console.WriteLine();



        string title3 = "Chainsaw man trailor";
        string author3 = "Crunchyroll";
        int lenght3 = 180;

        string comments3 = "#Ichigo - best anime ever , #Rukia - The animation is insane , #Aizen - mhmm, yeah no...";

        Video video3 = new Video(title3, author3, lenght3, comments3);
        Console.WriteLine(video3.DisplayAll());


    }
}