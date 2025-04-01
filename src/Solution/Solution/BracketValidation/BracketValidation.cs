// Buat solusi dari soal ini di project Solution dalam folder BracketValidation dengan namespace Solution.BracketValidation.

// Anda diminta untuk membuat sistem validasi kurung dalam ekspresi string menggunakan konsep Stack tanpa menggunakan kelas Stack bawaan dari .NET library. Sistem ini harus dapat memvalidasi kurung buka dan tutup dalam ekspresi dan menentukan apakah ekspresi tersebut valid. Ekspresi dapat mengandung kurung (), kurawal {}, dan siku [].

// Persyaratan:
// Implementasi Stack Manual: Buat kelas publik BracketValidator sebagai stack dan implementasikan struktur data Stack manual menggunakan linked list atau array untuk menyimpan karakter kurung dalam ekspresi.

// Validasi Ekspresi: Di dalam kelas publik BracketValidator buat metode ValidasiEkspresi yang menerima parameter ekspresi (string) dan mengembalikan nilai bertipe bool. Metode ini akan mengecek apakah semua jenis kurung dalam ekspresi memiliki pasangan yang benar dan terurut.

// Logika Validasi:

// Jika karakter adalah kurung buka (, kurawal {, atau siku [, dorong ke dalam stack.
// Jika karakter adalah kurung tutup ), kurawal }, atau siku ], pop item dari stack dan cek apakah item yang di-pop cocok dengan kurung tutup tersebut.
// Jika di akhir ekspresi, stack tidak kosong atau ada kurung tutup yang tidak cocok, ekspresi dianggap tidak valid.
// Contoh Ekspresi Valid: "[{}](){}", "([]{[]})[]{{}()}".

// Contoh Ekspresi Tidak Valid: "(]", "([)]", "{[}".

// Buat kelas publik Program yang berisi metode Main. Di dalam Main, demonstrasikan penggunaan metode ValidasiEkspresi dengan beberapa ekspresi sebagai contoh.

// Contoh Implementasi:
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         string ekspresiValid = "[{}](){}";
//         string ekspresiInvalid = "(]";

//         Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {ValidasiEkspresi(ekspresiValid)}");
//         Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {ValidasiEkspresi(ekspresiInvalid)}");
//     }
// }
// Contoh Output:
// Ekspresi '[{}](){}' valid? True
// Ekspresi '(]' valid? False
using System.Data;
namespace Solution.BracketValidation
{
    public class BracketValidator
    {
        public LinkedList<char> stack = new LinkedList<char>();
        public BracketValidator() { }
        public bool ValidasiEkspresi(string str)
        {
            stack.Clear(); 
            if (string.IsNullOrEmpty(str))
            {
                return true;
            }
            bool isValid = true;
            int count = 0;
            while (isValid && count < str.Length)
            {
                char c = str[count++];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.AddLast(c);
                }
                else if (c == ')')
                {
                    if (stack.Last != null && stack.Last.Value == '(')
                    {
                        stack.RemoveLast();
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                else if (c == '}')
                {
                    if (stack.Last != null && stack.Last.Value == '{')
                    {
                        stack.RemoveLast();
                    }
                    else
                    {
                        isValid = false;
                    }
                }
                else if (c == ']')
                {
                    if (stack.Last != null && stack.Last.Value == '[')
                    {
                        stack.RemoveLast();
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }
            if (stack.Count != 0)
            {
                isValid = false;
            }
            return isValid;
        }

    }
}