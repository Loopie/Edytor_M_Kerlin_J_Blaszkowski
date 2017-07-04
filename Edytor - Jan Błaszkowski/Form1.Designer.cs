namespace Edytor___Jan_Błaszkowski
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackColorCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUndo = new System.Windows.Forms.ToolStripButton();
            this.toolCut = new System.Windows.Forms.ToolStripButton();
            this.toolCopy = new System.Windows.Forms.ToolStripButton();
            this.toolPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFont = new System.Windows.Forms.ToolStripButton();
            this.toolFontColor = new System.Windows.Forms.ToolStripButton();
            this.toolColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.toolAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.toolAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBold = new System.Windows.Forms.ToolStripButton();
            this.toolItalic = new System.Windows.Forms.ToolStripButton();
            this.toolUnderline = new System.Windows.Forms.ToolStripButton();
            this.EditorTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.CloseToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.New_file;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.NewToolStripMenuItem.Text = "Nowy";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Open;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.OpenToolStripMenuItem.Text = "Otwórz";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Save;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SaveToolStripMenuItem.Text = "Zapisz";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Save_as;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.SaveAsToolStripMenuItem.Text = "Zapisz jako...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.CloseToolStripMenuItem.Text = "Zakończ";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.toolStripSeparator2,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.SelectAllToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Undo;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.UndoToolStripMenuItem.Text = "Cofnij";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Cut;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.CutToolStripMenuItem.Text = "Wytnij";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Copy;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.CopyToolStripMenuItem.Text = "Kopiuj";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Paste;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.PasteToolStripMenuItem.Text = "Wklej";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.SelectAllToolStripMenuItem.Text = "Zaznacz wszystko";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextWrapToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.FontColorToolStripMenuItem,
            this.BackColorCzcionkiToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // TextWrapToolStripMenuItem
            // 
            this.TextWrapToolStripMenuItem.Checked = true;
            this.TextWrapToolStripMenuItem.CheckOnClick = true;
            this.TextWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TextWrapToolStripMenuItem.Name = "TextWrapToolStripMenuItem";
            this.TextWrapToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.TextWrapToolStripMenuItem.Text = "Zawijanie tekstu";
            this.TextWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.TextWrapToolStripMenuItem_CheckedChanged);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.FontToolStripMenuItem.Text = "Czcionka...";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // FontColorToolStripMenuItem
            // 
            this.FontColorToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Text_color;
            this.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem";
            this.FontColorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.FontColorToolStripMenuItem.Text = "Kolor czcionki...";
            this.FontColorToolStripMenuItem.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // BackColorCzcionkiToolStripMenuItem
            // 
            this.BackColorCzcionkiToolStripMenuItem.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Color;
            this.BackColorCzcionkiToolStripMenuItem.Name = "BackColorCzcionkiToolStripMenuItem";
            this.BackColorCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.BackColorCzcionkiToolStripMenuItem.Text = "Kolor tła...";
            this.BackColorCzcionkiToolStripMenuItem.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.Filter = "Pliki tekstowe|*.txt|Pliki RTF|*.rtf|Wszystko|*.*";
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "Pliki tekstowe|*.txt|Pliki RTF|*.rtf|Wszystko|*.*";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewFile,
            this.toolOpen,
            this.toolSave,
            this.toolStripSeparator4,
            this.toolUndo,
            this.toolCut,
            this.toolCopy,
            this.toolPaste,
            this.toolStripSeparator5,
            this.toolFont,
            this.toolFontColor,
            this.toolColor,
            this.toolStripSeparator6,
            this.toolAlignLeft,
            this.toolAlignCenter,
            this.toolAlignRight,
            this.toolStripSeparator7,
            this.toolBold,
            this.toolItalic,
            this.toolUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(741, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolNewFile
            // 
            this.toolNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNewFile.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.New_file;
            this.toolNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewFile.Name = "toolNewFile";
            this.toolNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolNewFile.Text = "Nowy";
            this.toolNewFile.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Open;
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(23, 22);
            this.toolOpen.Text = "Otwórz";
            this.toolOpen.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Save;
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Zapisz";
            this.toolSave.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolUndo
            // 
            this.toolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUndo.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Undo;
            this.toolUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUndo.Name = "toolUndo";
            this.toolUndo.Size = new System.Drawing.Size(23, 22);
            this.toolUndo.Text = "Cofnij";
            this.toolUndo.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolCut
            // 
            this.toolCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCut.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Cut;
            this.toolCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCut.Name = "toolCut";
            this.toolCut.Size = new System.Drawing.Size(23, 22);
            this.toolCut.Text = "Wytnij";
            this.toolCut.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // toolCopy
            // 
            this.toolCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCopy.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Copy;
            this.toolCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCopy.Name = "toolCopy";
            this.toolCopy.Size = new System.Drawing.Size(23, 22);
            this.toolCopy.Text = "Kopiuj";
            this.toolCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // toolPaste
            // 
            this.toolPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPaste.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Paste;
            this.toolPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPaste.Name = "toolPaste";
            this.toolPaste.Size = new System.Drawing.Size(23, 22);
            this.toolPaste.Text = "Wklej";
            this.toolPaste.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolFont
            // 
            this.toolFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFont.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Pen;
            this.toolFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFont.Name = "toolFont";
            this.toolFont.Size = new System.Drawing.Size(23, 22);
            this.toolFont.Text = "Czcionka";
            this.toolFont.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // toolFontColor
            // 
            this.toolFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFontColor.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Text_color;
            this.toolFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFontColor.Name = "toolFontColor";
            this.toolFontColor.Size = new System.Drawing.Size(23, 22);
            this.toolFontColor.Text = "Kolor czcionki";
            this.toolFontColor.Click += new System.EventHandler(this.FontColorToolStripMenuItem_Click);
            // 
            // toolColor
            // 
            this.toolColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolColor.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Color;
            this.toolColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolColor.Name = "toolColor";
            this.toolColor.Size = new System.Drawing.Size(23, 22);
            this.toolColor.Text = "Kolor tła";
            this.toolColor.Click += new System.EventHandler(this.BackColorToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAlignLeft
            // 
            this.toolAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignLeft.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.align_text_left;
            this.toolAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignLeft.Name = "toolAlignLeft";
            this.toolAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.toolAlignLeft.Text = "Wyrównaj do lewej";
            this.toolAlignLeft.Click += new System.EventHandler(this.toolAlignLeft_Click);
            // 
            // toolAlignCenter
            // 
            this.toolAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignCenter.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.align_text_center;
            this.toolAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignCenter.Name = "toolAlignCenter";
            this.toolAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.toolAlignCenter.Text = "Wyrównaj środek";
            this.toolAlignCenter.Click += new System.EventHandler(this.toolAlignCenter_Click);
            // 
            // toolAlignRight
            // 
            this.toolAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAlignRight.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.align_text_right;
            this.toolAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAlignRight.Name = "toolAlignRight";
            this.toolAlignRight.Size = new System.Drawing.Size(23, 22);
            this.toolAlignRight.Text = "Wyrównaj prawo";
            this.toolAlignRight.Click += new System.EventHandler(this.toolAlignRight_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBold
            // 
            this.toolBold.CheckOnClick = true;
            this.toolBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBold.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.format_bold;
            this.toolBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBold.Name = "toolBold";
            this.toolBold.Size = new System.Drawing.Size(23, 22);
            this.toolBold.Text = "Pogrubienie czcionki";
            this.toolBold.Click += new System.EventHandler(this.toolBold_Click);
            // 
            // toolItalic
            // 
            this.toolItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolItalic.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.format_italic;
            this.toolItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolItalic.Name = "toolItalic";
            this.toolItalic.Size = new System.Drawing.Size(23, 22);
            this.toolItalic.Text = "Pochyła czcionka";
            this.toolItalic.Click += new System.EventHandler(this.tooltalic_Click);
            // 
            // toolUnderline
            // 
            this.toolUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolUnderline.Image = global::Edytor___Jan_Błaszkowski.Properties.Resources.Underline;
            this.toolUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnderline.Name = "toolUnderline";
            this.toolUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolUnderline.Text = "Podkreślenie";
            this.toolUnderline.Click += new System.EventHandler(this.toolUnderline_Click);
            // 
            // EditorTextBox
            // 
            this.EditorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTextBox.Location = new System.Drawing.Point(0, 49);
            this.EditorTextBox.Name = "EditorTextBox";
            this.EditorTextBox.Size = new System.Drawing.Size(741, 345);
            this.EditorTextBox.TabIndex = 3;
            this.EditorTextBox.Text = "";
            this.EditorTextBox.SelectionChanged += new System.EventHandler(this.EditorTextBox_SelectionChanged);
            this.EditorTextBox.TextChanged += new System.EventHandler(this.EditorTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 394);
            this.Controls.Add(this.EditorTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Edytor tekstu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TextWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackColorCzcionkiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolNewFile;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolUndo;
        private System.Windows.Forms.ToolStripButton toolCut;
        private System.Windows.Forms.ToolStripButton toolCopy;
        private System.Windows.Forms.ToolStripButton toolPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolFont;
        private System.Windows.Forms.ToolStripButton toolFontColor;
        private System.Windows.Forms.ToolStripButton toolColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolAlignLeft;
        private System.Windows.Forms.ToolStripButton toolAlignCenter;
        private System.Windows.Forms.ToolStripButton toolAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolBold;
        private System.Windows.Forms.ToolStripButton toolItalic;
        private System.Windows.Forms.ToolStripButton toolUnderline;
        private System.Windows.Forms.RichTextBox EditorTextBox;
    }
}

