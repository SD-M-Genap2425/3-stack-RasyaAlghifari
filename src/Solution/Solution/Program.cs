using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager hm = new HistoryManager();
        hm.KunjungiHalaman("google.com");
        hm.KunjungiHalaman("example.com");
        hm.LihatHalamanSaatIni();
        hm.Kembali();
        hm.TampilkanHistory();
        
        
        // Bracket validator
        BracketValidator bv = new BracketValidator();
        string expression = "{[]}[]";
        bool isValid = bv.ValidasiEkspresi(expression);
        Console.WriteLine($"Ekspresi '{expression}' valid? {isValid}");
        

        //Palindrome Checker
        string str = "Madam, I'm Adam";
        bool isPalindrome = PalindromeChecker.CekPalindrom(str);
        Console.WriteLine($"Apakah '{str}' adalah palindrom? {isPalindrome}");
        
        

    }
}
