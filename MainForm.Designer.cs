namespace DarkThemeSyntax
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            fileDropPanel = new Sunny.UI.UITitlePanel();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            exportTextBox = new Sunny.UI.UITextBox();
            colorPreviewPanel = new Sunny.UI.UITitlePanel();
            previewNewLabel = new Sunny.UI.UILabel();
            previewOldLabel = new Sunny.UI.UILabel();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            propertiesListBox = new Sunny.UI.UIListBox();
            uiTitlePanel4 = new Sunny.UI.UITitlePanel();
            oldColorPicker = new Sunny.UI.UIPanel();
            newColorPicker = new Sunny.UI.UIColorPicker();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            colorPercentageTextBox = new Sunny.UI.UINumPadTextBox();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            generateColorsButton = new Sunny.UI.UIButton();
            uiLabel3 = new Sunny.UI.UILabel();
            fileDropPanel.SuspendLayout();
            uiTitlePanel1.SuspendLayout();
            colorPreviewPanel.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            uiTitlePanel4.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 129);
            label1.Name = "label1";
            label1.Size = new Size(299, 29);
            label1.TabIndex = 0;
            label1.Text = "Drag && Drop  .langdef here";
            // 
            // fileDropPanel
            // 
            fileDropPanel.Controls.Add(label1);
            fileDropPanel.FillColor = Color.FromArgb(24, 24, 24);
            fileDropPanel.FillColor2 = Color.FromArgb(24, 24, 24);
            fileDropPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fileDropPanel.ForeColor = Color.White;
            fileDropPanel.Location = new Point(24, 56);
            fileDropPanel.Margin = new Padding(4, 5, 4, 5);
            fileDropPanel.MinimumSize = new Size(1, 1);
            fileDropPanel.Name = "fileDropPanel";
            fileDropPanel.RectColor = Color.FromArgb(18, 58, 92);
            fileDropPanel.ShowText = false;
            fileDropPanel.Size = new Size(574, 270);
            fileDropPanel.Style = Sunny.UI.UIStyle.Black;
            fileDropPanel.TabIndex = 1;
            fileDropPanel.Text = "Langdef file";
            fileDropPanel.TextAlignment = ContentAlignment.MiddleCenter;
            fileDropPanel.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(exportTextBox);
            uiTitlePanel1.FillColor = Color.FromArgb(24, 24, 24);
            uiTitlePanel1.FillColor2 = Color.FromArgb(24, 24, 24);
            uiTitlePanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.ForeColor = Color.White;
            uiTitlePanel1.Location = new Point(24, 781);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.RectColor = Color.FromArgb(18, 58, 92);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(987, 369);
            uiTitlePanel1.Style = Sunny.UI.UIStyle.Black;
            uiTitlePanel1.TabIndex = 3;
            uiTitlePanel1.Text = "VS Settings Result";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // exportTextBox
            // 
            exportTextBox.ButtonRectColor = Color.FromArgb(18, 58, 92);
            exportTextBox.ButtonSymbolOffset = new Point(0, 0);
            exportTextBox.Dock = DockStyle.Bottom;
            exportTextBox.FillColor2 = Color.FromArgb(24, 24, 24);
            exportTextBox.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            exportTextBox.Location = new Point(0, 36);
            exportTextBox.Margin = new Padding(4, 5, 4, 5);
            exportTextBox.MinimumSize = new Size(1, 16);
            exportTextBox.Multiline = true;
            exportTextBox.Name = "exportTextBox";
            exportTextBox.Padding = new Padding(5);
            exportTextBox.ReadOnly = true;
            exportTextBox.RectColor = Color.FromArgb(18, 58, 92);
            exportTextBox.ScrollBarColor = Color.FromArgb(24, 24, 24);
            exportTextBox.ShowScrollBar = true;
            exportTextBox.ShowText = false;
            exportTextBox.Size = new Size(987, 333);
            exportTextBox.Style = Sunny.UI.UIStyle.Black;
            exportTextBox.TabIndex = 4;
            exportTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            exportTextBox.Watermark = "";
            // 
            // colorPreviewPanel
            // 
            colorPreviewPanel.Controls.Add(previewNewLabel);
            colorPreviewPanel.Controls.Add(previewOldLabel);
            colorPreviewPanel.FillColor = Color.FromArgb(24, 24, 24);
            colorPreviewPanel.FillColor2 = Color.FromArgb(24, 24, 24);
            colorPreviewPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorPreviewPanel.ForeColor = Color.White;
            colorPreviewPanel.Location = new Point(606, 56);
            colorPreviewPanel.Margin = new Padding(4, 5, 4, 5);
            colorPreviewPanel.MinimumSize = new Size(1, 1);
            colorPreviewPanel.Name = "colorPreviewPanel";
            colorPreviewPanel.RectColor = Color.FromArgb(18, 58, 92);
            colorPreviewPanel.ShowText = false;
            colorPreviewPanel.Size = new Size(405, 270);
            colorPreviewPanel.Style = Sunny.UI.UIStyle.Black;
            colorPreviewPanel.TabIndex = 5;
            colorPreviewPanel.Text = "Color Preview";
            colorPreviewPanel.TextAlignment = ContentAlignment.MiddleCenter;
            colorPreviewPanel.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // previewNewLabel
            // 
            previewNewLabel.BackColor = Color.Transparent;
            previewNewLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            previewNewLabel.ForeColor = Color.White;
            previewNewLabel.Location = new Point(3, 158);
            previewNewLabel.Name = "previewNewLabel";
            previewNewLabel.Size = new Size(399, 34);
            previewNewLabel.Style = Sunny.UI.UIStyle.Black;
            previewNewLabel.TabIndex = 1;
            previewNewLabel.Text = "Hello world color new!";
            previewNewLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // previewOldLabel
            // 
            previewOldLabel.BackColor = Color.Transparent;
            previewOldLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            previewOldLabel.ForeColor = Color.White;
            previewOldLabel.Location = new Point(3, 91);
            previewOldLabel.Name = "previewOldLabel";
            previewOldLabel.Size = new Size(399, 34);
            previewOldLabel.Style = Sunny.UI.UIStyle.Black;
            previewOldLabel.TabIndex = 0;
            previewOldLabel.Text = "Hello world old color!";
            previewOldLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(propertiesListBox);
            uiTitlePanel3.FillColor = Color.FromArgb(24, 24, 24);
            uiTitlePanel3.FillColor2 = Color.FromArgb(24, 24, 24);
            uiTitlePanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.ForeColor = Color.White;
            uiTitlePanel3.Location = new Point(24, 345);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.RectColor = Color.FromArgb(18, 58, 92);
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(574, 416);
            uiTitlePanel3.Style = Sunny.UI.UIStyle.Black;
            uiTitlePanel3.TabIndex = 7;
            uiTitlePanel3.Text = "Properties";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel3.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // propertiesListBox
            // 
            propertiesListBox.Dock = DockStyle.Bottom;
            propertiesListBox.FillColor = Color.FromArgb(24, 24, 24);
            propertiesListBox.FillColor2 = Color.FromArgb(24, 24, 24);
            propertiesListBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            propertiesListBox.ForeColor = Color.White;
            propertiesListBox.HoverColor = Color.FromArgb(55, 55, 55);
            propertiesListBox.ItemSelectForeColor = Color.White;
            propertiesListBox.Location = new Point(0, 35);
            propertiesListBox.Margin = new Padding(4, 5, 4, 5);
            propertiesListBox.MinimumSize = new Size(1, 1);
            propertiesListBox.Name = "propertiesListBox";
            propertiesListBox.Padding = new Padding(2);
            propertiesListBox.RectColor = Color.FromArgb(18, 58, 92);
            propertiesListBox.ScrollBarBackColor = Color.FromArgb(24, 24, 24);
            propertiesListBox.ScrollBarColor = Color.White;
            propertiesListBox.ShowText = false;
            propertiesListBox.Size = new Size(574, 381);
            propertiesListBox.Style = Sunny.UI.UIStyle.Black;
            propertiesListBox.TabIndex = 7;
            propertiesListBox.Text = "uiListBox1";
            propertiesListBox.SelectedIndexChanged += propertiesListBox_SelectedIndexChanged;
            // 
            // uiTitlePanel4
            // 
            uiTitlePanel4.Controls.Add(oldColorPicker);
            uiTitlePanel4.Controls.Add(newColorPicker);
            uiTitlePanel4.Controls.Add(uiLabel2);
            uiTitlePanel4.Controls.Add(uiLabel1);
            uiTitlePanel4.FillColor = Color.FromArgb(24, 24, 24);
            uiTitlePanel4.FillColor2 = Color.FromArgb(24, 24, 24);
            uiTitlePanel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel4.ForeColor = Color.White;
            uiTitlePanel4.Location = new Point(606, 345);
            uiTitlePanel4.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel4.MinimumSize = new Size(1, 1);
            uiTitlePanel4.Name = "uiTitlePanel4";
            uiTitlePanel4.RectColor = Color.FromArgb(18, 58, 92);
            uiTitlePanel4.ShowText = false;
            uiTitlePanel4.Size = new Size(405, 175);
            uiTitlePanel4.Style = Sunny.UI.UIStyle.Black;
            uiTitlePanel4.TabIndex = 10;
            uiTitlePanel4.Text = "Color Options";
            uiTitlePanel4.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel4.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // oldColorPicker
            // 
            oldColorPicker.FillColor = Color.FromArgb(24, 24, 24);
            oldColorPicker.FillColor2 = Color.FromArgb(24, 24, 24);
            oldColorPicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oldColorPicker.ForeColor = Color.White;
            oldColorPicker.Location = new Point(160, 54);
            oldColorPicker.Margin = new Padding(4, 5, 4, 5);
            oldColorPicker.MinimumSize = new Size(1, 1);
            oldColorPicker.Name = "oldColorPicker";
            oldColorPicker.RectColor = Color.FromArgb(18, 58, 92);
            oldColorPicker.Size = new Size(236, 42);
            oldColorPicker.Style = Sunny.UI.UIStyle.Black;
            oldColorPicker.TabIndex = 4;
            oldColorPicker.Text = null;
            oldColorPicker.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // newColorPicker
            // 
            newColorPicker.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            newColorPicker.FillColor = Color.White;
            newColorPicker.FillColor2 = Color.FromArgb(24, 24, 24);
            newColorPicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newColorPicker.Location = new Point(160, 113);
            newColorPicker.Margin = new Padding(4, 5, 4, 5);
            newColorPicker.MinimumSize = new Size(63, 0);
            newColorPicker.Name = "newColorPicker";
            newColorPicker.Padding = new Padding(0, 0, 30, 2);
            newColorPicker.RectColor = Color.FromArgb(18, 58, 92);
            newColorPicker.Size = new Size(236, 44);
            newColorPicker.Style = Sunny.UI.UIStyle.Black;
            newColorPicker.TabIndex = 3;
            newColorPicker.TextAlignment = ContentAlignment.MiddleLeft;
            newColorPicker.Watermark = "";
            newColorPicker.ValueChanged += newColorPicker_ValueChanged;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(13, 116);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(135, 34);
            uiLabel2.Style = Sunny.UI.UIStyle.Black;
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "New Color:";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(14, 57);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(135, 34);
            uiLabel1.Style = Sunny.UI.UIStyle.Black;
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "Old Color:";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // colorPercentageTextBox
            // 
            colorPercentageTextBox.DecimalPlaces = 0;
            colorPercentageTextBox.FillColor = Color.White;
            colorPercentageTextBox.FillColor2 = Color.FromArgb(24, 24, 24);
            colorPercentageTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorPercentageTextBox.Location = new Point(290, 54);
            colorPercentageTextBox.Margin = new Padding(4, 5, 4, 5);
            colorPercentageTextBox.Maximum = 100D;
            colorPercentageTextBox.Minimum = 0D;
            colorPercentageTextBox.MinimumSize = new Size(63, 0);
            colorPercentageTextBox.Name = "colorPercentageTextBox";
            colorPercentageTextBox.NumPadType = Sunny.UI.NumPadType.Integer;
            colorPercentageTextBox.Padding = new Padding(0, 0, 30, 2);
            colorPercentageTextBox.RectColor = Color.FromArgb(18, 58, 92);
            colorPercentageTextBox.Size = new Size(92, 44);
            colorPercentageTextBox.Style = Sunny.UI.UIStyle.Black;
            colorPercentageTextBox.TabIndex = 11;
            colorPercentageTextBox.Text = "50";
            colorPercentageTextBox.TextAlignment = ContentAlignment.MiddleLeft;
            colorPercentageTextBox.Watermark = "";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(generateColorsButton);
            uiTitlePanel2.Controls.Add(uiLabel3);
            uiTitlePanel2.Controls.Add(colorPercentageTextBox);
            uiTitlePanel2.FillColor = Color.FromArgb(24, 24, 24);
            uiTitlePanel2.FillColor2 = Color.FromArgb(24, 24, 24);
            uiTitlePanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.ForeColor = Color.White;
            uiTitlePanel2.Location = new Point(606, 537);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.RectColor = Color.FromArgb(18, 58, 92);
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(405, 224);
            uiTitlePanel2.Style = Sunny.UI.UIStyle.Black;
            uiTitlePanel2.TabIndex = 12;
            uiTitlePanel2.Text = "Auto Generate colors";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel2.TitleColor = Color.FromArgb(21, 21, 21);
            // 
            // generateColorsButton
            // 
            generateColorsButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generateColorsButton.Location = new Point(183, 115);
            generateColorsButton.MinimumSize = new Size(1, 1);
            generateColorsButton.Name = "generateColorsButton";
            generateColorsButton.Size = new Size(199, 32);
            generateColorsButton.Style = Sunny.UI.UIStyle.Black;
            generateColorsButton.TabIndex = 13;
            generateColorsButton.Text = "Generate colors";
            generateColorsButton.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            generateColorsButton.Click += generateColorsButton_Click;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.White;
            uiLabel3.Location = new Point(13, 57);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(253, 34);
            uiLabel3.Style = Sunny.UI.UIStyle.Black;
            uiLabel3.TabIndex = 12;
            uiLabel3.Text = "Lighter shade percentage:";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1032, 1177);
            ControlBoxFillHoverColor = Color.FromArgb(70, 70, 70);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel4);
            Controls.Add(uiTitlePanel3);
            Controls.Add(colorPreviewPanel);
            Controls.Add(uiTitlePanel1);
            Controls.Add(fileDropPanel);
            ForeColor = Color.White;
            MaximizeBox = false;
            Name = "MainForm";
            RectColor = Color.FromArgb(18, 58, 92);
            Style = Sunny.UI.UIStyle.Black;
            Text = "ActiPro - Dark Theme Syntax Editor";
            TitleColor = Color.FromArgb(21, 21, 21);
            ZoomScaleRect = new Rectangle(22, 22, 1892, 1041);
            Load += MainForm_Load;
            fileDropPanel.ResumeLayout(false);
            fileDropPanel.PerformLayout();
            uiTitlePanel1.ResumeLayout(false);
            colorPreviewPanel.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            uiTitlePanel4.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Sunny.UI.UITitlePanel fileDropPanel;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UITextBox exportTextBox;
        private Sunny.UI.UITitlePanel colorPreviewPanel;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UIListBox propertiesListBox;
        private Sunny.UI.UITitlePanel uiTitlePanel4;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIColorPicker newColorPicker;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel previewNewLabel;
        private Sunny.UI.UILabel previewOldLabel;
        private Sunny.UI.UIPanel oldColorPicker;
        private Sunny.UI.UINumPadTextBox colorPercentageTextBox;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UIButton generateColorsButton;
        private Sunny.UI.UILabel uiLabel3;
    }
}