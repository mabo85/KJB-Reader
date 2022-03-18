using System.Text;
using System.Text.RegularExpressions;
using static KJB_Reader.Bible;

namespace KJB_Reader
{
    public partial class MainForm : Form
    {
        // ToolStripTextBox does not have a 'placeholder' property
        private const string txtSearchPlaceholder = "Search ...";

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richText.Cursor = Cursors.Arrow;
            txtSearch.Text = txtSearchPlaceholder;

            string path = @"kingjamesbible.vpl"; // file needs to be in "bin/Debug/net6.0-windows/" folder
            Bible.readVplFile(path);
            fillBooksComboBox(42); // zero-indexed (!), i.e. 0=Genesis ... 65=Revelation
            cbChapter.SelectedIndex = 0;
            displayChapterText();
        }

        /// <summary>
        /// Filling the ComboBox for the Bible books.
        /// <para>Accepts an optional <b>zero-indexed</b> parameter.
        /// Selects first book ("Genesis"), if no parameter is given.</para>
        /// </summary>
        /// <param name="index">optional <b>zero-indexed</b> book selection (default: 0)</param>
        private void fillBooksComboBox(int index = 0)
        {
            foreach (string s in Bible.bookName)
                cbBook.Items.Add(s);
            cbBook.SelectedIndex = index;
        }

        private void displayChapterText()
        {
            richText.Hide(); // avoids flickering when updating the RichTextBox
            richText.Clear();

            List<int> verses = Bible.verseIndexes(cbBook.SelectedIndex, cbChapter.SelectedIndex);

            for (int i = 0; i < verses.Count; i++)
            {
                richText.Text += (i + 1) + " " + Bible.Text[verses[i]];
                richText.Text += ((i != verses.Count - 1) ? Environment.NewLine : "");
            }

            // change the style of the verse numbers
            MatchCollection matches =
                new Regex(@"^\d+", RegexOptions.Multiline).Matches(richText.Text);

            foreach (Match match in matches)
            {
                richText.Select(match.Index, match.Length);
                richText.SelectionColor = Color.Blue;
                richText.SelectionFont = new Font(richText.Font.FontFamily,
                                                  richText.Font.Size - 3,
                                                  FontStyle.Bold);
            }
            richText.DeselectAll();
            richText.SelectionStart = 0;    // move caret to beginning of text ...
            richText.ScrollToCaret();       // ... which is the top of the richTextBox
            richText.Show();
        }
        
        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChapterComboBox();
            cbChapter.SelectedIndex = 0;
            displayChapterText();
        }

        private void updateChapterComboBox()
        {
            cbChapter.Items.Clear();
            for (int i = 0; i < Bible.chaptersPerBook[cbBook.SelectedIndex]; i++)
                cbChapter.Items.Add(i + 1);
        }

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayChapterText();
        }

        private void cmdNextChapter_Click(object sender, EventArgs e)
        {
            bool isLastBook = Bible.isLastBook(cbBook.SelectedIndex);
            bool isLastChapter = Bible.isLastChapter(cbBook.SelectedIndex, cbChapter.SelectedIndex);

            if (isLastBook && isLastChapter)
                return;

            if (isLastChapter)
            {
                cbBook.SelectedIndex += 1;
                updateChapterComboBox();
                cbChapter.SelectedIndex = 0;
            }
            else
                cbChapter.SelectedIndex += 1;

            displayChapterText();
        }

        private void cmdPreviousChapter_Click(object sender, EventArgs e)
        {
            bool isFirstBook = Bible.isFirstBook(cbBook.SelectedIndex);
            bool isFirstChapter = Bible.isFirstChapter(cbChapter.SelectedIndex);

            if (isFirstBook && isFirstChapter)
                return;

            if (isFirstChapter)
            {
                cbBook.SelectedIndex -= 1;
                updateChapterComboBox();
                cbChapter.SelectedIndex = Bible.numberOfChapters(cbBook.SelectedIndex);
            }
            else
                cbChapter.SelectedIndex -= 1;

            displayChapterText();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == txtSearchPlaceholder)
                txtSearch.Clear();
            else
                txtSearch.SelectAll();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = txtSearchPlaceholder;
        }

        private void cbChapter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                int chapter;
                if (!int.TryParse(cbChapter.Text, out chapter) || chapter < 1)
                    cbChapter.SelectedIndex = 0;

                if (cbChapter.Items.Contains(chapter))
                    cbChapter.SelectedIndex = chapter - 1;

                if (chapter > cbChapter.Items.Count)
                    cbChapter.SelectedIndex = cbChapter.Items.Count - 1;

                displayChapterText();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                int verse;

                // note: the King James Bible does not contain literal numbers,
                // but they are always in a written as words, like 'ten' for '10'.
                // --> a single number in the textbox cannot be a normal search
                if (int.TryParse(txtSearch.Text, out verse))
                {
                    scrollToVerseNumber(verse);
                    return;
                }

                BookChapterVerse bcv;
                // if text matches a bible-reference, then goto scripture ...
                if (Bible.getVerseReference(txtSearch.Text, out bcv))
                {
                    cbBook.SelectedIndex = bcv.book;
                    cbChapter.SelectedIndex = bcv.chapter;
                    displayChapterText();
                    scrollToVerseNumber(bcv.verse + 1); // +1, because zero-indexed
                    txtSearch.Clear();
                    txtSearch_Leave(sender, e);
                }
                // ... else perform a search for the words given
                else
                {
                    Form search = new SearchForm(txtSearch);
                    search.Show();
                }
            }
        }

        /// <summary>
        /// Scrolling the view of the RichTextBox of the current book and chapter to the given verse number.
        /// <para>If verse number is greater than the actual number of verses, it jumps to the last verse.
        /// If it is negative, scroll to the top, which is the first verse.</para>
        /// </summary>
        /// <param name="verse">Scroll caret of the RichTextBox to verse number</param>
        private void scrollToVerseNumber(int verse)
        {
            // (!) the space is important, to tell appart a i.e. a "1" and a "11"
            int line = richText.Text.IndexOf(verse.ToString() + " ");
            richText.SelectionStart = (line == -1 && verse > 0) ? richText.Text.Length
                                    : line < 1 ? 1
                                    : line;
            richText.ScrollToCaret();
            txtSearch.Clear();
            richText.Focus();
        }

        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void richText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
                cmdNextChapter_Click(sender, e);
            else if (e.KeyCode == Keys.P)
                cmdPreviousChapter_Click(sender, e);
            //else if (e.Control && e.KeyCode == Keys.F)
            //    MessageBox.Show("Ctrl-F: Search in current text");
        }

        private void richText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}