using DarkThemeSyntax.Resources;
using Sunny.UI;
using Sunny.UI.Win32;
using System.Xml.Serialization;

namespace DarkThemeSyntax
{
    public partial class MainForm : UIForm
    {

        public MainForm()
        {
            InitializeComponent();
            fileDropPanel.DragEnter += new DragEventHandler(FileDropPanel_DragEnter);
            fileDropPanel.DragDrop += new DragEventHandler(FileDropPanel_DragDrop);
            fileDropPanel.AllowDrop = true;
            colorPreviewPanel.FillColor = Color.FromArgb(30, 30, 30);
            exportTextBox.FillColor = Color.FromArgb(30, 30, 30);
            exportTextBox.FillReadOnlyColor = Color.FromArgb(30, 30, 30);
            exportTextBox.RectReadOnlyColor = Color.FromArgb(18, 58, 92);
            exportTextBox.ForeColor = Color.White;
            exportTextBox.ForeReadOnlyColor = Color.White;
            colorPercentageTextBox.FillColor = Color.FromArgb(30, 30, 30);
            colorPercentageTextBox.ForeColor = Color.White;
            generateColorsButton.Style = UIStyle.Orange;
            UILocalizeHelper.SetEN();

        }

        private void FileDropPanel_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private class Item
        {
            public string Name { get; set; }

            public Color OldColor { get; set; }
            public Color NewColor { get; set; }

            public override string ToString()
            {
                return Name;
            }

        }
        private List<Item> items = new List<Item>();
        private string _filePath = string.Empty;
        private void FileDropPanel_DragDrop(object? sender, DragEventArgs e)
        {
            
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string filePath = files.FirstOrDefault();
            if (filePath == null) return;
            if (Path.GetExtension(filePath) != ".langdef") return;
            var filename = Path.GetFileNameWithoutExtension(filePath);
            Text = $"ActiPro - Dark Theme Syntax Editor - {filename}";
            _filePath = filePath;
            Generate();
        }

        private void Generate()
        {
            if(string.IsNullOrEmpty(_filePath)) return;
            propertiesListBox.Items.Clear();
            exportTextBox.Clear();
            items.Clear();

            LanguageDefinition languageDefinition;
            using (var reader = new StreamReader(_filePath))
            {
                languageDefinition = (LanguageDefinition)new XmlSerializer(typeof(LanguageDefinition)).Deserialize(reader);
            }

            foreach (var langDef in languageDefinition.LanguageDefinitionClassificationTypes)
            {
                if (string.IsNullOrWhiteSpace(langDef.DefaultStyle)) continue;
                var hexColor = DefaultStyleToHex(langDef.DefaultStyle);
                if (string.IsNullOrEmpty(hexColor)) continue;
                var color = HexToColor(hexColor);
                Color lighterColor = ColorHelper.MakeColorLighter(color, Convert.ToInt32(colorPercentageTextBox.Text));
                items.Add(new Item()
                {
                    Name = langDef.Key,
                    OldColor = color,
                    NewColor = lighterColor
                }); ;
            }

            foreach (var item in items)
            {
                propertiesListBox.Items.Add(item);
            }

            generateVsSettings();
        }
        private Color HexToColor(string hexColor)
        {
            Color color = ColorTranslator.FromHtml(hexColor);
            return color;
        }
        private string ToVssSettingsHex(Color color)
        {
            //return the string in reverse order as VS expects it
            return $"0x00{color.B.ToString("X2")}{color.G.ToString("X2")}{color.R.ToString("X2")}";
        }
        private string DefaultStyleToHex(string defaulStyle)
        {
            var splitted = defaulStyle.Split(',');
            foreach (var line in splitted)
            {
                if (line.StartsWith("#"))
                {
                    return line;
                }
            }
            return "";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void generateVsSettings()
        {
            exportTextBox.Clear();

            foreach (var item in items)
            {
                var vssSettingHex = ToVssSettingsHex(item.NewColor);
                exportTextBox.Text += $"<Item Name=\"{item.Name}\" Foreground=\"{vssSettingHex}\" Background=\"0x02000000\" BoldFont=\"No\" />{Environment.NewLine}";
            }

        }

        private void propertiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (Item)propertiesListBox.SelectedItem;
            if (item == null) return;
            oldColorPicker.FillColor = item.OldColor;
            newColorPicker.Value = item.NewColor;
            previewOldLabel.ForeColor = item.OldColor;
            previewNewLabel.ForeColor = item.NewColor;
            previewOldLabel.Update();
            previewNewLabel.Update();

        }

        private void newColorPicker_ValueChanged(object sender, Color value)
        {
            var selectedItem = (Item)propertiesListBox.SelectedItem;
            if (selectedItem == null) return;
            var item = items.FirstOrDefault(m => m.Name == selectedItem.Name);
            previewNewLabel.ForeColor = newColorPicker.Value;
            previewNewLabel.Update();
            item.NewColor = newColorPicker.Value;

            generateVsSettings();

        }

        private void generateColorsButton_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("Warning!", "This will override all custom changes, are you sure?", UIStyle.DarkBlue  ))
            {
                Generate();
            }

        }
    }
}