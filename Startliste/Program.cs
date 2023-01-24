using System.Text;

namespace Startliste;

internal class Program
{
    public static void Main(string[] args)
    {
        var registrationList = GetParticipants();
    }

    private static void PrintList(List<Registration> registrationList)
    {
        registrationList.ForEach(r =>
        {
            if (r == registrationList[0])
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                r.Show();
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                r.Show();
            }
        });
    }

    private static List<Registration> GetParticipants()
    {
        const string path = @"C:\Users\simen\github\Startliste\Startliste\startlist.csv";
        var startlist = File.ReadLines(path, Encoding.UTF8);

        var registrationList = startlist
            .Select(line => line.Split(","))
            .Select(participantInfo =>
            new Registration(
                participantInfo[0].Trim('"'),
                participantInfo[1].Trim('"'),
                participantInfo[2].Trim('"'),
                participantInfo[3].Trim('"'),
                participantInfo[4].Trim('"'),
                participantInfo[5].Trim('"')
                )
        ).ToList();
        return registrationList;
    }
}