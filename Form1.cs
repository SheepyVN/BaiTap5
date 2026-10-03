using System.Drawing.Text;

namespace BaiTap7
{
    public partial class Form1 : Form
    {
        private string? currentFilePath;

        public Form1()
        {
            InitializeComponent();
            LoadFontsAndSizes();
            UpdateWordCount();
        }

        private void LoadFontsAndSizes()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
                cmbFonts.Items.Add(font.Name);

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
                cmbSizes.Items.Add(size.ToString());

            cmbFonts.Text = "Tahoma";
            cmbSizes.Text = "14";
            richText.Font = new Font("Tahoma", 14);
        }

        private void NewDocument()
        {
            richText.Clear();
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;
            cmbFonts.Text = "Tahoma";
            cmbSizes.Text = "14";
            currentFilePath = null;
            UpdateWordCount();
        }

        private void OpenDocument()
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Tập tin văn bản (*.txt;*.rtf)|*.txt;*.rtf|Tất cả tập tin (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType type = dialog.FileName.EndsWith(".rtf", StringComparison.OrdinalIgnoreCase)
                    ? RichTextBoxStreamType.RichText
                    : RichTextBoxStreamType.PlainText;
                richText.LoadFile(dialog.FileName, type);
                currentFilePath = dialog.FileName;
                UpdateWordCount();
            }
        }

        private void SaveDocument()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                dialog.DefaultExt = "rtf";
                dialog.AddExtension = true;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                currentFilePath = dialog.FileName;
            }

            RichTextBoxStreamType type = currentFilePath.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)
                ? RichTextBoxStreamType.PlainText
                : RichTextBoxStreamType.RichText;
            richText.SaveFile(currentFilePath, type);
            MessageBox.Show("Lưu nội dung văn bản thành công.");
        }

        private void ChooseFont()
        {
            using FontDialog dialog = new FontDialog
            {
                ShowColor = true,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = true,
                Font = richText.SelectionFont ?? richText.Font,
                Color = richText.SelectionColor
            };

            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                richText.SelectionColor = dialog.Color;
                richText.SelectionFont = dialog.Font;
                cmbFonts.Text = dialog.Font.Name;
                cmbSizes.Text = ((int)dialog.Font.Size).ToString();
            }
        }

        private void ToggleStyle(FontStyle style)
        {
            Font current = richText.SelectionFont ?? richText.Font;
            FontStyle newStyle = (current.Style & style) == style
                ? current.Style & ~style
                : current.Style | style;
            richText.SelectionFont = new Font(current, newStyle);
            UpdateFormatButtons();
            richText.Focus();
        }

        private void UpdateFormatButtons()
        {
            Font? font = richText.SelectionFont;
            boldButton.Checked = font != null && font.Bold;
            italicButton.Checked = font != null && font.Italic;
            underlineButton.Checked = font != null && font.Underline;
        }

        private void UpdateWordCount()
        {
            string text = richText.Text.Trim();
            int count = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            wordCountLabel.Text = "Số từ: " + count;
        }

        private void richText_TextChanged(object? sender, EventArgs e)
        {
            UpdateWordCount();
        }

        private void richText_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateFormatButtons();
        }

        private void cmbFonts_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ApplyFont();
        }

        private void cmbSizes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ApplyFont();
        }

        private void ApplyFont()
        {
            if (!float.TryParse(cmbSizes.Text, out float size) || string.IsNullOrWhiteSpace(cmbFonts.Text))
                return;

            Font current = richText.SelectionFont ?? richText.Font;
            richText.SelectionFont = new Font(cmbFonts.Text, size, current.Style);
            richText.Focus();
        }

        private void exitMenuItem_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void newMenuItem_Click(object? sender, EventArgs e)
        {
            NewDocument();
        }

        private void openMenuItem_Click(object? sender, EventArgs e)
        {
            OpenDocument();
        }

        private void saveMenuItem_Click(object? sender, EventArgs e)
        {
            SaveDocument();
        }

        private void fontMenuItem_Click(object? sender, EventArgs e)
        {
            ChooseFont();
        }

        private void boldButton_Click(object? sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Bold);
        }

        private void italicButton_Click(object? sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Italic);
        }

        private void underlineButton_Click(object? sender, EventArgs e)
        {
            ToggleStyle(FontStyle.Underline);
        }

        private void systemMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
