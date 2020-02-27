using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Semester2
{
   
    public abstract class Player 
    {
        
        #region Properties

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Description> Descriptions { get; set; }

        private int age;

        public int Age
        {
            get
            {
                //Determine age and account for birthday that has not yet occured
                age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateOfBirth.DayOfYear >= DateTime.Now.DayOfYear)
                    age--;
                return age;
            }

        }


        #endregion Properties

        public Player(string firstname, string surname, string position, DateTime dateofbirth )
        {
            FirstName = firstname;
            Surname = surname;
            Position = position;
            DateOfBirth = dateofbirth;
            Descriptions = new List<Description>();
        }
        /*
        public override string ToString()
        {
            return $"{FirstName} {Surname} ({Age}) {Position.ToString().ToUpper()} ";
        } */
        public Player()
        {
            Descriptions = new List<Description>();
        }

        public class Goalkeeper : Player
        {
            public override string ToString()
            {
                return (this.FirstName + this.Surname + " - Goalkeeper");
            }
        }
        public class Defender : Player
        {

            public override string ToString()
            {
                return (this.FirstName + this.Surname + " - Defender");
            }
        }
        public class Midfielder : Player
        {

            public override string ToString()
            {
                return (this.FirstName + this.Surname + " - Midfielder");
            }
        }
        public class Forward : Player
        {

            public override string ToString()
            {
                return (this.FirstName + this.Surname + " - Forward");
            }
        }

        /*public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }*/
        public override string ToString()
        {
            return $"{FirstName + Surname}";
        }

        public string GetDetails1()
        {
            return $"{DateOfBirth.ToShortDateString()}";
        }

        public string GetDetails2()
        {
            return $"{Position}";
        }
        public string GetDescriptions()
        {
            return $"{Descriptions}";
        }


    }
}
    
