using System;
using System.Reflection.Metadata.Ecma335;

namespace Klasser
{
    public class Person
    {
        private string name;
        private string surname;
        private long personnumber;

        public Person() { }
        public Person(string namn, string efternamn, long personnummer)
        {
            this.name = namn;
            this.surname = efternamn;
            this.personnumber = personnummer;
        }
        public void setnamn(string _name)
        {
            this.name = _name;
        }
        public void setsurname(string _surname)
        {
            this.name = _surname;
        }
        public void setperson_nr(long _personnumber)
        {
            this.personnumber = _personnumber;
        }

        public string getnamn()
        {
            return name;
        }

        public string getsurname()
        {
            return surname;
        }
        public long getpersonnumber()
        {
            return personnumber;
        }

        public string ToString()
        {
            string minperson = "";
            minperson = "name: " + name + "\nsurname: " + surname + "\npersonnumber:" + personnumber;
            return minperson;
        }

    }
}



