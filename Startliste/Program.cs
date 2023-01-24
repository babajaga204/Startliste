using System.Text;

namespace Startliste;

internal class Program
{
    public static void Main(string[] args)
    {
        var registrationList = GetParticipants();

    }

    private static List<Registration> GetParticipants()
    {
        const string path = @"C:\Users\simen\github\Startliste\Startliste\startlist.csv";
        var startlist = File.ReadLines(path, Encoding.UTF8);

        var registrationList = startlist.Select(line => line.Split(",")).Select(participantInfo =>
            new Registration(
                participantInfo[0],
                participantInfo[1],
                participantInfo[2],
                participantInfo[3],
                participantInfo[4],
                participantInfo[5])
        ).ToList();
        return registrationList;
    }
}