
namespace Startliste
{
    internal class Club
    {
        private string _name;
        private List<Registration> _registrations;

        public Club(string name, List<Registration> registrations)
        {
            _name = name;
            _registrations = registrations;
        }
    }


}
