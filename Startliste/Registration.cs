

namespace Startliste
{
    internal class Registration
    {
        public string _startNumber;
        public string _name;
        public string _club;
        public string _nationality;
        public string _group;
        public string _class;

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
                + _club.PadRight(50)
                + _nationality.PadRight(15) 
                + _group.PadRight(50)
                + _class
            );
        }
    }
}
