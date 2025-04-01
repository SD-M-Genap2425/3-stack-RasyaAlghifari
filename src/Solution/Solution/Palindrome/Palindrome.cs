namespace Solution.Palindrome
{
    public class PalindromeChecker
    {
        // use stack to check palindrome
        public static bool CekPalindrom(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            char[] IllegalChars = { ',', '.', ':', ';', '!', '?', '-', '_', '=', '+', '*', '/', '\'' };
            string cleanedInput = input.ToLower();
            foreach (char c in IllegalChars)
            {
                cleanedInput = cleanedInput.Replace(c, ' ');
            }
            cleanedInput = cleanedInput.Replace(" ", "");

            Stack<char> stack = new Stack<char>();
            int mid = cleanedInput.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                stack.Push(cleanedInput[i]);
            }
            int startIndex = (cleanedInput.Length % 2 == 0) ? mid : mid + 1;
            for (int i = startIndex; i < cleanedInput.Length; i++)
            {
                if (stack.Pop() != cleanedInput[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}