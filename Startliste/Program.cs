using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Startliste;

internal class Program
{
    public static void Main(string[] args)
    {
        var registrationList = GetParticipants();
        var clubNames = new List<string>();
        registrationList.ForEach(item =>
        {
            if (clubNames.Contains(item._club) || item._club.Length < 2) return;
            clubNames.Add(item._club);
            
        });
        var clubs = clubNames
            .Select(clubName => new Club(clubName.Trim(), new List<Registration>()))
            .ToList();
        
        clubs.ForEach(club =>
        {
            club._registrations = new List<Registration>(registrationList.Where(registration => registration._club == club._name));
        });

        foreach (var club in clubs)
        {
            club.ShowStats();
        }
    }

    private static void PrintList(List<Registration> registrationList)
    {
        registrationList.ForEach(r => r.Show());
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
        registrationList.RemoveAt(0);
        return registrationList;
    }
}