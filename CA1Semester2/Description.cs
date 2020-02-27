using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Semester2
{
    public class Description
    {
        public string BirthCountry { get; set; }
        public int Appearances { get; set; }
        public int GoalsScored { get; set; }
        public double Valuation { get; set; }

        public override string ToString()
        {
            return $"BirthCountry : {BirthCountry}\nAppearances : {Appearances}\nGoalsScored : {GoalsScored} \nValuation : {Valuation}";
        }
    }
}
