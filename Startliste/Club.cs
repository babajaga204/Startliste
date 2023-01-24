
namespace Startliste
{
    internal class Club
    {
        public string _name;
        public List<Registration> _registrations;

        public Club(string name, List<Registration> registrations)
        {
            _name = name;
            _registrations = registrations;
        }

        public void ShowStats()
        {
            Console.WriteLine("Club: " + _name.PadLeft(50));
            Console.WriteLine("Members: " + Convert.ToString(_registrations.Count).PadLeft(47));
            Console.WriteLine();
        }
    }
}
