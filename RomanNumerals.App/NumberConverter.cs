namespace RomanNumerals.App
{
    public class NumberConverter
    {
        public string Parse(int number)
        {
            var result = "";
            var numerals = new Numerals();
            var _number = number.ToString();

            while (number > 0)
            {
                if (number >= 1000)
                {
                    var numThousies = number.ToString();
                    var daIndex = int.Parse(numThousies[0].ToString());

                    result += numerals.RomanThousands[daIndex];
                    number -= daIndex * 1000;
                    continue;
                }
                if (number >= 100)
                {
                    var numHundies = number.ToString();
                    var daIndex = int.Parse(numHundies[0].ToString());

                    result += numerals.RomanHundreds[daIndex];
                    number -= daIndex * 100;
                    continue;
                }
                if (number > 10)
                {
                    var numTensies = number.ToString();
                    var daIndex = int.Parse(numTensies[0].ToString());
                    result += numerals.RomanTens[daIndex];
                    number -= daIndex * 10;
                    continue;
                }
                if (number <= 10)
                {
                    result += numerals.RomanOnes[number];
                    number = 0;
                    continue;
                }
            }
            return result;
        }
    }
}
