

namespace Startliste
{
    internal class Registration
    {
        private string _startNumber;
        private string _name;
        private string _club;
        private string _nationality;
        private string _group;
        private string _class;

        public Registration(string startNumber, string name, string club, string nationality, string group, string @class)
        {
            _startNumber = startNumber;
            _name = name;
            _club = club;
            _nationality = nationality;
            _group = group;
            _class = @class;
        }

        public void Show()
        {
            Console.WriteLine(
                _startNumber.PadRight(15) 
                + _name.PadRight(35)
                + _club.PadRight(35)
                + _nationality.PadRight(15) 
                + _group.PadRight(50)
                + _class.PadLeft(10)
            );
        }
    }
}
