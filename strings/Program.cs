namespace strings
{
    internal class Program
    {
        public static string CreatePhoneNumber(int[] digits) 
        {
            string result = "Failed to create a phone number";

            if (digits.Length != 10)
            {
                return result;
            }

            result = $"+7 ({string.Concat(digits[0..3])}) {string.Concat(digits[3..6])}" +
                    $"-{string.Concat(digits[6..8])}-{string.Concat(digits[8..])}";
            return result;
        }

        public static string TrimString(string phrase, int len)
        {
            if (phrase.Length == len)
                return phrase;

            if (len <= 3)
                return phrase.Substring(0, len) + "...";

            return phrase.Substring(0, len - 3) + "...";
        }

        public static string SquareDigits(long number)
        {
            string result = "";

            while (number != 0)
            {
                int digit = (int)(number % 10);

                result = (digit * digit).ToString() + result;

                number /= 10;
            }

            return result;
        }

        public static string ShowTooltip(string[] names)
        {
            switch (names.Length) 
            {
                case 0:
                    return "No one likes this";
                case 1:
                    return $"{names[0]} likes this";
                case 2:
                    return $"{names[0]} and {names[1]} like this";
                case 3:
                    return $"{names[0]}, {names[1]} and {names[2]} like this";
                default:
                    return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
                
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]));

            Console.WriteLine(TrimString("\nWriting code is fun", 14));
            Console.WriteLine(TrimString("He", 1));

            Console.WriteLine($"\n{SquareDigits(108928301923)}");

            Console.WriteLine($"\n{ShowTooltip([])}");
            Console.WriteLine(ShowTooltip(["Peter"]));
            Console.WriteLine(ShowTooltip(["Jacob", "Alex"]));
            Console.WriteLine(ShowTooltip(["Max", "John", "Mark"]));
            Console.WriteLine(ShowTooltip(["Alex", "Jacob", "Mark", "Max"]));
        }
    }
}
