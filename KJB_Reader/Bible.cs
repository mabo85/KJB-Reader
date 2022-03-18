using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KJB_Reader
{
    public class Bible
    {
        public static List<BookChapterVerse> Reference = new List<BookChapterVerse>();
        public static List<String> Text = new List<String>();

        public struct BookChapterVerse
        {
            public int book;
            public int chapter;
            public int verse;

            public override string ToString()
            {
                return $"Book:{book + 1} Chapter:{chapter + 1} Verse:{verse + 1} Internal=[{book},{chapter},{verse}]";
            }
        }

        public static readonly string[] shortBookName = {
            "Gen", "Exo", "Lev", "Num", "Deu", "Jos", "Jdg", "Rut", "1Sa", "2Sa", "1Ki",
            "2Ki", "1Ch", "2Ch", "Ezr", "Neh", "Est", "Job", "Psa", "Pro", "Ecc", "Sng",
            "Isa", "Jer", "Lam", "Ezk", "Dan", "Hos", "Jol", "Amo", "Oba", "Jon", "Mic",
            "Nam", "Hab", "Zep", "Hag", "Zec", "Mal", "Mat", "Mrk", "Luk", "Jhn", "Act",
            "Rom", "1Co", "2Co", "Gal", "Eph", "Php", "Col", "1Th", "2Th", "1Ti", "2Ti",
            "Tit", "Phm", "Heb", "Jas", "1Pe", "2Pe", "1Jn", "2Jn", "3Jn", "Jud", "Rev"};

        public static readonly string[] bookName = {"Genesis",
                                                    "Exodus",
                                                    "Leviticus",
                                                    "Numbers",
                                                    "Deuteronomy",
                                                    "Joshua",
                                                    "Judges",
                                                    "Ruth",
                                                    "1 Samuel",
                                                    "2 Samuel",
                                                    "1 Kings",
                                                    "2 Kings",
                                                    "1 Chronicles",
                                                    "2 Chronicles",
                                                    "Ezra",
                                                    "Nehemiah",
                                                    "Esther",
                                                    "Job",
                                                    "Psalms",
                                                    "Proverbs",
                                                    "Ecclesiastes",
                                                    "Song of Solomon",
                                                    "Isaiah",
                                                    "Jeremiah",
                                                    "Lamentations",
                                                    "Ezekiel",
                                                    "Daniel",
                                                    "Hosea",
                                                    "Joel",
                                                    "Amos",
                                                    "Obadiah",
                                                    "Jonah",
                                                    "Micah",
                                                    "Nahum",
                                                    "Habakkuk",
                                                    "Zephaniah",
                                                    "Haggai",
                                                    "Zechariah",
                                                    "Malachi",
                                                    "Matthew",
                                                    "Mark",
                                                    "Luke",
                                                    "John",
                                                    "Acts",
                                                    "Romans",
                                                    "1 Corinthians",
                                                    "2 Corinthians",
                                                    "Galatians",
                                                    "Ephesians",
                                                    "Philippians",
                                                    "Colossians",
                                                    "1 Thessalonians",
                                                    "2 Thessalonians",
                                                    "1 Timothy",
                                                    "2 Timothy",
                                                    "Titus",
                                                    "Philemon",
                                                    "Hebrews",
                                                    "James",
                                                    "1 Peter",
                                                    "2 Peter",
                                                    "1 John",
                                                    "2 John",
                                                    "3 John",
                                                    "Jude",
                                                    "Revelation"};

        public static readonly int[] chaptersPerBook = {
            50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31,
            12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21,
            28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };


        //static int numberOfChapters(int book)
        //{
        //    int numberOfChapters = 0;
        //    foreach (var r in bRef)
        //        if (r.book == book && r.chapter > numberOfChapters)
        //            numberOfChapters = r.chapter;
        //    return numberOfChapters + 1;
        //}

        public static int numberOfChapters(int book) => chaptersPerBook[book] - 1;

        public static bool isFirstChapter(int chapter) => chapter == 0;

        public static bool isLastChapter(int book, int chapter) => chapter == chaptersPerBook[book] - 1;

        public static bool isFirstBook(int book) => book == 0;

        public static bool isLastBook(int book) => book == 65;


        //public static int numberOfVerses(int book, int chapter)
        //{
        //    int numberOfVerses = 0;
        //    foreach (var r in bRef)
        //        if (r.book == book && r.chapter == chapter && r.verse > numberOfVerses)
        //            numberOfVerses = r.verse;
        //    return numberOfVerses + 1;
        //}

        public static bool isBibleBook(string bookName)
        {
            return shortBookName.Contains(bookName);
        }

        public static int indexBibleBook(string bookName)
        {
            return Array.IndexOf(shortBookName, bookName);
        }

        public static List<int> verseIndexes(int book, int chapter)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Bible.Reference.Count; i++)
                if (Bible.Reference[i].book == book && Bible.Reference[i].chapter == chapter)
                    list.Add(i);
            return list;
        }

        public static void readVplFile(string path)
        {
            string[] readText = File.ReadAllLines(path);

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
        }

        public static string[] bookRegex = {
                "(Ge(n(esis)?)?|Gn)",                       // Genesis, Gen, Ge, Gn
                "Ex(o(dus)?)?",                             // Exodus, Exo, Ex
                "(Le(v(iticus)?)?|Lv)",                     // Leviticus, Lev, Le, Lv
                "(Nu(m(bers)?)?|Nm|Nb)",                    // Numbers, Num, Nu, Nm, Nb
                "De(u(teronomy)?)?",                        // Deuteronomy, Deu, De
                "(Jos(hua)?|Jsh)",                          // Joshua, Jos, Jsh
                "(Judges|Jd?g)",                            // Judges, Jdg, Jg
                "(Ru(th?)?|Rth)",                           // Ruth, Rut, Rth, Ru
                "(1(st\\s)?|I)\\s?Sa(m(uel)?)?",            // 1Samuel, 1Sa, 1Sam, ISam, ...
                "(2(nd\\s)?|II)\\s?Sa(m(uel)?)?",           // 2Samuel, 2Sa, 2Sam, IISam, ...
                "(1(st\\s)?|I)\\s?Ki(n(gs)?)?",             // 1Kings, 1Ki, 1 Ki, I Ki, ...
                "(2(nd\\s)?|II)\\s?Ki(n(gs)?)?",            // 2Kings, 2Ki, 2 Ki, II Ki, ...
                "(1(st\\s)?|I)\\s?Ch(r(onicles)?)?",        // 1Chronicles, 1Ch, 1 Chr, ...
                "(2(nd\\s)?|II)\\s?Ch(r(onicles)?)?",       // 2Chronicles, 2Ch, 2 Chr, ...
                "Ezra?",                                    // Ezra, Ezr
                "Ne(h(emiah)?)?",                           // Nehemiah, Neh, Ne
                "Es(t(her)?)?",                             // Esther, Est, Es
                "Jo?b",                                     // Job, Jb
                "Ps(a(lms?)?)?",                            // Psalms, Psa, Ps, Psalm
                "Pr(o(verbs)?)?",                           // Proverbs, Pro, Pr
                "(Ec(c(lesiastes)?)?|Qoh(eleth)?)",         // Ecclesiastes, Ecc, Ec, Qoh(eleth)
                "(Song of Solomon|So?ng|SoS|Can(ticles)?)", // Song of Solomon, Sng, Song, SoS, Can(ticles)
                "Is(a(iah)?)?",                             // Isaiah, Isa, Is
                "(Je(r(emiah)?)?|Jr)",                      // Jeremiah, Jer, Je, Jr
                "La(m(entations)?)?",                       // Lamentations, Lam, La
                "(Ezk|Eze(k(iel)?)?)",                      // Ezekiel, Ezk, Ezek, Eze
                "(Dn|Da(n(iel)?)?)",                        // Daniel, Dan, Da, Dn
                "Ho(s(ea)?)?",                              // Hosea, Hos, Ho
                "(Joe?l|Joe|Jl)",                           // Joel, Jol, Joe, Jl
                "Am(os?)?",                                 // Amos, Amo, Am
                "Ob(a(d(iah)?)?)?",                         // Obadiah, Oba, Obad, Ob
                "Jon(ah)?",                                 // Jonah, Jon
                "Mic(ah)?",                                 // Micah, Mic
                "(Nam|Na(h(um)?)?)",                        // Nahum, Nam, Nah, Na
                "Hab(akkuk)?",                              // Habakkuk, Hab
                "(Zep(h(aniah)?)?|Zp)",                     // Zephania, Zep, Zeph, Zp
                "(Hag(gai)?|Hg)",                           // Haggai, Hag, Hg
                "(Zec(h(ariah)?)?|Zc)",                     // Zechariah, Zec, Zech, Zc
                "(Mal(achi)?|Ml)",                          // Malachi, Mal, Ml
                "(Mat(t(hew)?)?|Mt)",                       // Matthew, Mat, Matt, Mt
                "(Ma?rk|Mk|Mr)",                            // Mark, Mrk, Mk, Mr
                "(Lu(ke?)?|Lk)",                            // Luke, Luk, Lu, Lk
                "(Jo?hn?|Jn)",                              // John, Jhn, Joh, Jn, Jh
                "Ac(ts?)?",                                 // Acts, Act, Ac
                "Ro(m(ans)?)?",                             // Romans, Rom, Ro
                "(1(st\\s)?|I)\\s?Co(r(inthians)?)?",       // 1Corinthians, 1Co, 1Cor, 1 Co, I Cor, ...
                "(2(nd\\s)?|II)\\s?Co(r(inthians)?)?",      // 2Corinthians, 2Co, 2Cor, 2 Co, II Cor, ...
                "Ga(l(atians)?)?",                          // Galatians, Gal, Ga
                "Eph(esians)?",                             // Ephesians, Eph
                "(Philippians|Php)",                        // Philippians, Php
                "Col(ossians)?",                            // Colossians, Col
                "(1(st\\s)?|I)\\s?Th(es(s(alonians)?)?)?",  // 1Thessalonians, 1Th, I Thess, 1st Thes, ...
                "(2(nd\\s)?|II)\\s?Th(es(s(alonians)?)?)?", // 2Thessalonians, 2Th, II Thess, 2nd Thes, ...
                "(1(st\\s)?|I)\\s?Ti(m(othy)?)?",           // 1Timothy, 1Ti, I Tim, 1st Ti, ...
                "(2(nd\\s)?|II)\\s?Ti(m(othy)?)?",          // 2Timothy, 2Ti, II Tim, 2nd Ti, ...
                "Tit(us)?",                                 // Titus, Tit
                "Ph(ilemon|m)",                             // Philemon, Phm
                "Heb(rews)?",                               // Hebrews, Heb
                "(Ja(me)?s|Jm)",                            // James, Jas, Jm
                "(1(st\\s)?|I)\\s?Pe(t(er)?)?",             // 1Peter, 1Pe, 1 Pet, I Pe, 1st Peter, ...
                "(2(nd\\s)?|II)\\s?Pe(t(er)?)?",            // 2Peter, 2Pe, 2 Pet, II Pe, 2nd Peter, ...
                "(1(st\\s)?|I)\\s?(Jo(hn?)?|Jhn|Jn)",       // 1John, 1Jn, 1Jo, 1st Jn, I John, ...
                "(2(nd\\s)?|II)\\s?(Jo(hn?)?|Jhn|Jn)",      // 2John, 2Jn, 2Jo, 2nd Jn, II John, ...
                "(3(rd\\s)?|III)\\s?(Jo(hn?)?|Jhn|Jn)",     // 3John, 3Jn, 3Jo, 3rd Jn, III John, ...
                "Jude?",                                    // Jude, Jud
                "Re(v(elation)?)?"                          // Revelation, Rev, Re
        };

        public static bool getVerseReference(string str, out BookChapterVerse bcv)
        {
            // initialize return value
            bool returnValue = false;

            bcv.book = 0;
            bcv.chapter = 0;
            bcv.verse = 0;

            List<string> regexPerBook = makeRegexPerBook();

            Match match;
            for (int i = 0; i < regexPerBook.Count; i++)
            {
                match = Regex.Match(str, regexPerBook[i], RegexOptions.IgnoreCase);

                if (match.Success) // when match found read book, chapter and verse
                {
                    bcv.book = i; // zero-indexed

                    try
                    {
                        bcv.chapter = Convert.ToInt32(match.Groups["chapter"].Value) - 1;  // zero-indexed
                    }
                    catch (FormatException) { }

                    try
                    {
                        bcv.verse = Convert.ToInt32(match.Groups["verse"].Value) - 1; // zero-indexed
                    }
                    catch (FormatException) { }

                    if (isValidReference(bcv))
                        returnValue = true;
                }
            }
            return returnValue;
        }

        private static List<string> makeRegexPerBook()
        {
            StringBuilder sb = new StringBuilder();
            List<string> regexPerBook = new List<string>();

            string prefix = "^\\b(?<book>";
            string suffix = ")(\\s?(?<chapter>\\d+))?([:.,](?<verse>\\d+))?$"; // "", "3", " 3", "3:16", " 3.16", ...

            for (int i = 0; i < bookRegex.Length; i++)
            {
                sb.Clear();
                sb.Append(prefix);
                sb.Append(bookRegex[i]);
                sb.Append(suffix);
                regexPerBook.Add(sb.ToString());
            }
            return regexPerBook;
        }

        public static bool isValidReference(BookChapterVerse bcv)
        {
            foreach (var r in Reference)
                if (r.book == bcv.book && r.chapter == bcv.chapter && r.verse == bcv.verse)
                    return true;
            return false;
        }

        public static List<int> findAllVerseIndexes(string text)
        {
            List<int> indexes = new List<int>();

            // Search is case-sensitive, if there are uppercase-letters or an underscore
            bool case_sensitive = new Regex(@"[A-Z_]").IsMatch(text);
            string search = text.Replace("_", "");

            string[] words = search.Split();

            for (int i = 0; i < Bible.Text.Count; i++)
            {
                if (case_sensitive)
                {
                    if (words.All(w => Bible.Text[i].Contains(w)))
                        indexes.Add(i);
                }
                else
                {
                    if (words.All(w => Bible.Text[i].ToUpper().Contains(w.ToUpper())))
                        indexes.Add(i);
                }
            }
            return indexes;
        }
    }
}
