public class LinkqFile
{
    public static void Main(){
        string wholetext = File.ReadAllText("Sample.txt");
        string[] nameCount = wholetext.Split(' ',',');
        var indiaCount = (from country in nameCount
                        where country == "Yamuna"
                        select country  
                            ).Count();
        System.Console.WriteLine($"No of times india appear is :{indiaCount}");
    }
}

