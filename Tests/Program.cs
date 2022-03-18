using System.Text;
using System.Text.RegularExpressions;

class Programm
{

    public struct BookChapterVerse
    {
        public int book;
        public int chapter;
        public int verse;

        public BookChapterVerse(int book, int chapter, int verse)
        {
            this.book = book;
            this.chapter = chapter;
            this.verse = verse;
        }

        public override string ToString()
        {
            return $"Book:{book + 1} Chapter:{chapter + 1} Verse:{verse + 1} Internal=[{book},{chapter},{verse}]";
        }
    }

    static string[] shortBookName = {
            "Gen", "Exo", "Lev", "Num", "Deu", "Jos", "Jdg", "Rut", "1Sa", "2Sa", "1Ki",
            "2Ki", "1Ch", "2Ch", "Ezr", "Neh", "Est", "Job", "Psa", "Pro", "Ecc", "Sng",
            "Isa", "Jer", "Lam", "Ezk", "Dan", "Hos", "Jol", "Amo", "Oba", "Jon", "Mic",
            "Nam", "Hab", "Zep", "Hag", "Zec", "Mal", "Mat", "Mrk", "Luk", "Jhn", "Act",
            "Rom", "1Co", "2Co", "Gal", "Eph", "Php", "Col", "1Th", "2Th", "1Ti", "2Ti",
            "Tit", "Phm", "Heb", "Jas", "1Pe", "2Pe", "1Jn", "2Jn", "3Jn", "Jud", "Rev"};

    public static List<BookChapterVerse> Reference;

    public static List<String> Text;

    public static void Main(string[] args)
    {
        int n = 0;
        foreach (string s in shortBookName)
        {
            Console.Write(s + " ");
            n++;
            if (n % 11 == 0) Console.WriteLine();
        }


        // Is a certain book name in the shortBookName-Array?
        string book = "Jas";
        if (isBibleBook(book))
            Console.WriteLine(book + " found");
        else
            Console.WriteLine(book + " NOT found");


        // Index of a certain book
        int idx = indexBibleBook(book);
        Console.WriteLine(idx);


        // Reading the KJB
        string path = "kingjamesbible.vpl";
        string[] readText = File.ReadAllLines(path);

        Reference = new List<BookChapterVerse>();
        Text = new List<String>();

        Regex rx = new Regex(@"^(?<book>.+)[ \t](?<chapter>\d+)[:.,](?<verse>\d+)[ \t](?<text>.+)$");

        BookChapterVerse bcv; // book, chapter, verse

        foreach (String s in readText)
        {
            // allow for empty lines in the VPL-file
            if (!rx.IsMatch(s))
                continue;

            Match m = rx.Match(s);
            GroupCollection groups = m.Groups;
            bcv.book = Array.IndexOf(shortBookName, groups["book"].Value); // book
            bcv.chapter = Convert.ToInt32(groups["chapter"].Value) - 1;    // chapter
            bcv.verse = Convert.ToInt32(groups["verse"].Value) - 1;        // verse
            Reference.Add(bcv);
            Text.Add(groups["text"].Value);
        }

        Console.WriteLine(Reference[0]);
        Console.WriteLine(Text[0]);
        Console.WriteLine();

        Console.WriteLine($"Chapters in {book}: " + numberOfChapters(indexBibleBook(book)));

        ////////////////////////////////////////////////////
        ////////////////        Regex       ////////////////
        ////////////////////////////////////////////////////

        string[] bookRegex = { "(Jo?hn?|Jn)", "(Dn|Da(n(iel)?)?)", "Am(os?)?" };

        StringBuilder sb = new StringBuilder();
        List<string> regexPerBook = new List<string>();

        string prefix = "\\b(?<book>";
        string suffix = ")(\\s?(?<chapter>\\d+))?([:.,](?<verse>\\d+))?"; // "", "3", " 3", "3:16", " 3.16", ...

        for (int i = 0; i < bookRegex.Length; i++)
        {
            sb.Clear();
            sb.Append(prefix);
            sb.Append(bookRegex[i]);
            sb.Append(suffix);
            regexPerBook.Add(sb.ToString());
        }

        //foreach (string s in regexPerBook)
        //    Console.WriteLine(s);
        //Console.WriteLine("Number of books: " + regexPerBook.Count);

        string str = "Am 3:16";
        for (int i = 0; i < regexPerBook.Count; i++)
        {
            if (new Regex(regexPerBook[i], RegexOptions.IgnoreCase).IsMatch(str))
            {
                Console.WriteLine($"FOUND (at position: {i})");
                break;
            }
        }

        Console.WriteLine(@"
        ////////////////////////////////////////////////////
        //////////////        Search        ////////////////
        ////////////////////////////////////////////////////");

        List<int> list = new List<int>();
        //string search = "Godhead"; // single word
        string search = "way truth life"; // multiple words

        // Search is case-sensitive, if there are uppercase-letters or an underscore
        bool case_sensitive = new Regex(@"[A-Z_]").IsMatch(search);
        search = search.Replace("_", "");

        string[] words = search.Split();

        for (int i = 0; i < Text.Count; i++)
        {
            if (case_sensitive)
            {
                if (words.All(w => Text[i].Contains(w)))
                    list.Add(i);
            }
            else
            {
                if (words.All(w => Text[i].ToUpper().Contains(w.ToUpper())))
                    list.Add(i);
            }
        }

        foreach (int item in list)
        {
            Console.WriteLine(Reference[item]);
            Console.WriteLine(Text[item]);

        }

    }

    static int numberOfChapters(int book)
    {
        int numberOfChapters = 0;
        foreach (var r in Reference)
            if (r.book == book && r.chapter > numberOfChapters)
                numberOfChapters = r.chapter;
        return numberOfChapters + 1;
    }

    static int numberOfVerses(int book, int chapter)
    {
        int numberOfVerses = 0;
        foreach (var r in Reference)
            if (r.book == book && r.chapter == chapter && r.verse > numberOfVerses)
                numberOfVerses = r.verse;
        return numberOfVerses + 1;
    }

    static bool isBibleBook(string bookName)
    {
        return shortBookName.Contains(bookName);
    }

    static int indexBibleBook(string bookName)
    {
        return Array.IndexOf(shortBookName, bookName);
    }
}
