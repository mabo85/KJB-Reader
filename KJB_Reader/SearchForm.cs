using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KJB_Reader
{
    public partial class SearchForm : Form
    {
        private ToolStripTextBox txtSearch;
        private List<int> verseIndexes;

        public SearchForm(ToolStripTextBox txtSearch)
        {
            InitializeComponent();
            this.txtSearch = txtSearch;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.Text = $"Search: \"{txtSearch.Text.Replace("_", "").Trim()}\" "
                + (txtSearch.Text.Contains("_") || txtSearch.Text.Any(char.IsUpper) ? "(case-sensitive)" : "");

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.RowHeadersVisible = false;
            dgv.ShowCellToolTips = false;
            dgv.ColumnCount = 2;
            dgv.Font = new Font("Segoe UI", 11);
            dgv.Columns[0].Name = "Verse";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[0].DefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.Columns[1].Name = "Text";
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewColumn column in dgv.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            dgv.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            verseIndexes = Bible.findAllVerseIndexes(txtSearch.Text);
            this.Text += verseIndexes.Count == 0 ? " – no verse found"
                       : verseIndexes.Count == 1 ? " – 1 verse found"
                       : $" – {verseIndexes.Count} verses found";

            string book;
            int chapter, verse;
            string[] row;
            foreach (var i in verseIndexes)
            {
                book = Bible.shortBookName[Bible.Reference[i].book];
                chapter = Bible.Reference[i].chapter + 1; // zero-index
                verse = Bible.Reference[i].verse + 1; // zero-index

                row = new string[2] { $"{book} {chapter}:{verse}", Bible.Text[i] };

                dgv.Rows.Add(row);
            }
            dgv.ClearSelection();
        }


        // highlighting the search words in a DGV does not work with wrapped text (SO answer below worked neither).
        // https://stackoverflow.com/questions/66762116/texthighlight-in-datagridview-on-textcell-with-wrapmode
    }
}
