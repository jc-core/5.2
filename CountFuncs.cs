namespace Assignment5_2 {
    internal class CountFuncs {

        public static void CountUp(int number) {

            if (number < 1)
                return;

            CountUp(number - 1);
            Console.Write($"{number} ");

        }

        public static void CountDown(int number) {

            if (number < 1)
                return;

            Console.Write($"{number} ");
            CountDown(number - 1);

        }
    }
}
