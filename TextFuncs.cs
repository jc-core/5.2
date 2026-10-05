namespace Assignment5_2 {
    internal class TextFuncs {

        public static int LastWordLength(string text) {

            int charPlace = text.Length - 1;

            while (charPlace >= 0 && text[charPlace] == ' ')
                charPlace--;

            int length = 0;

            while (charPlace >= 0 && text[charPlace] != ' ') {
                if (char.IsLetter(text[charPlace]))
                    length++;

                charPlace--;
            }

            return length;

        }

        public static bool IsPalindrome(string text) {

            return IsPalindrome(text, 0, text.Length - 1);

        }

        public static bool IsPalindrome(string text, int front, int back) {

            if (front >= back)
                return true;

            if (char.ToLower(text[front]) != char.ToLower(text[back]))
                return false;

            return IsPalindrome(text, front + 1, back - 1);

        }
    }
}
