using System.Collections.Generic;

namespace RomanNumerals.App
{
    public class Numerals
    {
        public List<string> RomanOnes = new List<string> { " ","I","II","III","IV","V","VI","VII","VIII","IX"};

        public List<string> RomanTens = new List<string> {" ","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"};

        public List<string> RomanHundreds = new List<string> {" ","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};

        public List<string> RomanThousands = new List<string> {" ","M","MM","MMM"};
    }
}
