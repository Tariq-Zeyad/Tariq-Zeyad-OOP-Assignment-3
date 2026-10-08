using Collections;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Egyptian Phone Tests:");

            Console.WriteLine($"01012345678 -> {"01012345678".IsValidEgyptianPhone()}");
            Console.WriteLine($"+201512345678 -> {"+201512345678".IsValidEgyptianPhone()}");
            Console.WriteLine($"01312345678 -> {"01312345678".IsValidEgyptianPhone()}");
            Console.WriteLine($"0101234567 -> {"0101234567".IsValidEgyptianPhone()}");
            Console.WriteLine($"0101234567a -> {"0101234567a".IsValidEgyptianPhone()}");

            Console.WriteLine();

            Console.WriteLine("Egyptian National ID Tests:");

            Console.WriteLine($"29901011234567 -> {"29901011234567".IsValidEgyptianNationalId()}");
            Console.WriteLine($"19901011234567 -> {"19901011234567".IsValidEgyptianNationalId()}");
            Console.WriteLine($"2990101123456 -> {"2990101123456".IsValidEgyptianNationalId()}");
        }
    }
}   