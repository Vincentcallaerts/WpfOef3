using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfOef3
{
    class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public bool LoggedIn { get; set; }
        public string FullName { get; set; }
        public string ImagePath { get; set; }

        public Persoon(string voornaam, string achternaam, bool loggedIn)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            LoggedIn = loggedIn;

            FullName = Voornaam + " " + Achternaam;

            if (loggedIn)
            {
                ImagePath = "Images/emo-1.png";
            }
            else
            {
                ImagePath = "Images/emo-3.png";

            }
        }
    }
}
