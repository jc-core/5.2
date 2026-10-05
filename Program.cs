namespace Assignment5_2 {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Select an option:");

            while (true) {

                Console.WriteLine();
                Console.WriteLine("  1 - Last Word Length");
                Console.WriteLine("  2 - Count Up");
                Console.WriteLine("  3 - Count Down");
                Console.WriteLine("  4 - Text Palindrome");
                Console.WriteLine("  x - Quit");

                var choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice) {
                    case '1':
                        LastWord();
                        break;
                    case '2':
                        CountUp();
                        break;
                    case '3':
                        CountDown();
                        break;
                    case '4':
                        TextPalindrome();
                        break;
                    case 'x':
                        return;
                    default:
                        Console.WriteLine("That is not one of the options, please select something from the list.");
                        continue;
                }

                if (EndPrompt())
                    return;

            }

        }

        static void LastWord() {

            Console.WriteLine();

            string text = ReadText("Word or sentence: ");

            Console.WriteLine($"The last word is {TextFuncs.LastWordLength(text)} letters long.");

        }

        static void CountUp() {

            Console.WriteLine();

            int count = ReadCount("Count up to: ");

            CountFuncs.CountUp(count);
            Console.WriteLine();

        }

        static void CountDown() {

            Console.WriteLine();

            int count = ReadCount("Count down from: ");

            CountFuncs.CountDown(count);
            Console.WriteLine();

        }

        static void TextPalindrome() {

            Console.WriteLine();

            string text = ReadText("Word to check: ");

            Console.WriteLine(TextFuncs.IsPalindrome(text) ? $"{text} is a palindrome!" : $"{text} is not a palindrome.");

        }

        static bool EndPrompt() {

            Console.WriteLine();
            Console.Write("Press enter to go back to the menu, or 'x' to quit: ");

            var choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            return choice == 'x';

        }

        static string ReadText(string prompt) {

            while (true) {

                Console.Write(prompt);
                string text = Console.ReadLine() ?? "";

                if (text.Trim() != "")
                    return text;

                Console.WriteLine("Need at least one character, try again.");

            }

        }

        static int ReadCount(string prompt) {

            while (true) {

                Console.Write(prompt);

                if (int.TryParse(Console.ReadLine(), out int value) && value >= 1 && value <= 1000)
                    return value;

                Console.WriteLine("Whole numbers from 1 to 1000 only, try again.");

            }

        }
    }
}
