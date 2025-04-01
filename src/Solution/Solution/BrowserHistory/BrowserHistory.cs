namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL;
        public Halaman? next;
        public Halaman? prev;
        public Halaman(string url)
        {
            URL = url;
            next = null;
            prev = null;
        }
    }
    // implement a stack to store the history
    public class HistoryManager
    {
        private Halaman? head;
        private Halaman? tail;
        private Halaman? current;
        public HistoryManager()
        {
            head = null;
            tail = null;
            current = null;
        }
        public void KunjungiHalaman(string url)
        {
            Halaman newPage = new Halaman(url);
            if (head == null)
            {
                head = newPage;
                tail = newPage;
                current = newPage;
                Console.WriteLine($"Mengunjungi halaman: {current.URL}");

            }
            else
            {
                current!.next = newPage;
                newPage.prev = current;
                current = newPage;
                tail = newPage;
                Console.WriteLine($"Mengunjungi halaman: {current.URL}");
            }
        }
        public string Kembali()
        {
            if (current == null || current.prev == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }
            else
            {
                current = current.prev;
                Console.WriteLine("Kembali ke halaman sebelumnya...");
                return current.URL;
            }
        }
        public string LihatHalamanSaatIni()
        {
            if (current == null)
            {
                return "Tidak ada halaman saat ini.";
            }
            else
            {
                Console.WriteLine($"Halaman saat ini: {current.URL}");
                return current.URL;
            }
        }
        public void TampilkanHistory()
        {
            Halaman? temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.URL);
                temp = temp.next;
            }
        }

    }
}