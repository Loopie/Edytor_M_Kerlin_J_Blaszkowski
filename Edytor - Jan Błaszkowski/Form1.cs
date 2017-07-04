using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Edytor___Jan_Błaszkowski
{
    public partial class Form1 : Form
    {
        string FileName1 = " ";
        bool textChanged = false;
        bool varr = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (textChanged)
            {
            DialogResult result;
            result = MessageBox.Show(
              "Czy chcesz zapisać zmiany", "Edytor",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                SaveToolStripMenuItem_Click(sender, e);
                textChanged = false;
                EditorTextBox.Clear();
            }
            if (result == DialogResult.No)
            {
                EditorTextBox.Clear();
                textChanged = false;
            }  
            }
            else
                EditorTextBox.Clear();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textChanged)
            {
                DialogResult result;
                result = MessageBox.Show(
                  "Czy chcesz zapisać zmiany", "Edytor",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                    Form.ActiveForm.Close();
                }
                if (result == DialogResult.No)
                {
                    varr = false;
                    Form.ActiveForm.Close();
                }
            }
            else
                Form.ActiveForm.Close();

        }

        private void TextWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if ( EditorTextBox.WordWrap == true)
            {
                EditorTextBox.WordWrap = false;
                TextWrapToolStripMenuItem.Checked = false;
            }
            else
            {
                EditorTextBox.WordWrap = true;
                TextWrapToolStripMenuItem.Checked = true;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FontDialog1 = new FontDialog();
            FontDialog1.Font = EditorTextBox.SelectionFont;
            if (FontDialog1.ShowDialog() == DialogResult.OK)
            {
                EditorTextBox.SelectionFont = FontDialog1.Font;
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTextBox.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorTextBox.SelectAll();
        }

        public void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveAsResult = SaveFileDialog1.ShowDialog();
                if (saveAsResult == DialogResult.OK && SaveFileDialog1.FilterIndex == 2)
                {
                    EditorTextBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    FileName1 = SaveFileDialog1.FileName;
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
                else if (saveAsResult == DialogResult.OK && SaveFileDialog1.FilterIndex == 1)
                {
                    EditorTextBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    FileName1 = SaveFileDialog1.FileName;
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
            
            
        }


        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName1 == " ")
            {
                DialogResult saveResult = SaveFileDialog1.ShowDialog();
                if (saveResult == DialogResult.OK && SaveFileDialog1.FilterIndex == 2)
                {
                    EditorTextBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    textChanged = false;
                    FileName1 = SaveFileDialog1.FileName;
                    EditorTextBox.ClearUndo();
                }
                else if (saveResult == DialogResult.OK &&  SaveFileDialog1.FilterIndex == 1)
                {
                    EditorTextBox.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    textChanged = false;
                    FileName1 = SaveFileDialog1.FileName;
                    EditorTextBox.ClearUndo();
                }
            }
            else
            {
                if (FileName1 == "*.rtf")
                {
                    EditorTextBox.SaveFile(FileName1, RichTextBoxStreamType.RichText);
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
                if (FileName1 == "*.txt")
                {  
                    EditorTextBox.SaveFile(FileName1, RichTextBoxStreamType.PlainText);
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
            }

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textChanged)
            {
                DialogResult result;
                result = MessageBox.Show(
                  "Czy chcesz zapisać zmiany", "Edytor",
                  MessageBoxButtons.YesNoCancel,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    SaveToolStripMenuItem_Click(sender, e);
                    DialogResult openFileResult = OpenFileDialog1.ShowDialog();
                    if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 2)
                    {
                        EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        FileName1 = OpenFileDialog1.FileName;
                        textChanged = false;
                        EditorTextBox.ClearUndo();
                    }
                    else if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 1)
                    {
                        EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        textChanged = false;
                        FileName1 = OpenFileDialog1.FileName;
                        EditorTextBox.ClearUndo();
                    }
                }
                if (result == DialogResult.No)
                {
                    DialogResult openFileResult = OpenFileDialog1.ShowDialog();
                    if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 2)
                    {
                        EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        textChanged = false;
                        FileName1 = OpenFileDialog1.FileName;
                        EditorTextBox.ClearUndo();
                    }
                    else if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 1)
                    {
                        EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        textChanged = false;
                        FileName1 = OpenFileDialog1.FileName;
                        EditorTextBox.ClearUndo();
                    }
                }
            }

            else
            {
                DialogResult openFileResult = OpenFileDialog1.ShowDialog();
                if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 2)
                {
                    EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    FileName1 = OpenFileDialog1.FileName;
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
                else if (openFileResult == DialogResult.OK && OpenFileDialog1.FilterIndex == 1)
                {
                    EditorTextBox.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    FileName1 = OpenFileDialog1.FileName;
                    textChanged = false;
                    EditorTextBox.ClearUndo();
                }
            }


        }

        private void FontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog FontColorDialog1 = new ColorDialog();
            FontColorDialog1.AllowFullOpen = true;
            FontColorDialog1.Color = EditorTextBox.SelectionColor;
            if (FontColorDialog1.ShowDialog() == DialogResult.OK)
            {
                EditorTextBox.SelectionColor = FontColorDialog1.Color;
            }
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog BackColorDialog1 = new ColorDialog();
            BackColorDialog1.AllowFullOpen = true;
            BackColorDialog1.Color = EditorTextBox.BackColor;
            if (BackColorDialog1.ShowDialog() == DialogResult.OK)
            {
                EditorTextBox.BackColor = BackColorDialog1.Color;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (varr)
            {
                if (textChanged)
                {
                    DialogResult result;
                    result = MessageBox.Show(
                      "Czy chcesz zapisać zmiany", "Edytor",
                      MessageBoxButtons.YesNoCancel,
                      MessageBoxIcon.Exclamation,
                      MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        SaveToolStripMenuItem_Click(sender, e);
                    }

                    if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void EditorTextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
            if (EditorTextBox.Text == "")
            {
                toolBold.Checked = false;
                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Bold);
                toolItalic.Checked = false;
                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Italic);
                toolUnderline.Checked = false;
                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Underline);
                EditorTextBox.SelectionAlignment = HorizontalAlignment.Left;
                toolAlignLeft.Checked = true;
                toolAlignCenter.Checked = false;
                toolAlignRight.Checked = false;
            }
        }

        private void toolAlignLeft_Click(object sender, EventArgs e)
        {
            EditorTextBox.SelectionAlignment = HorizontalAlignment.Left;
            toolAlignLeft.Checked = true;
            toolAlignCenter.Checked = false;
            toolAlignRight.Checked = false;
        }

        private void toolAlignCenter_Click(object sender, EventArgs e)
        {
            EditorTextBox.SelectionAlignment = HorizontalAlignment.Center;
            toolAlignLeft.Checked = false;
            toolAlignCenter.Checked = true;
            toolAlignRight.Checked = false;
        }

        private void toolAlignRight_Click(object sender, EventArgs e)
        {
            EditorTextBox.SelectionAlignment = HorizontalAlignment.Right;
            toolAlignLeft.Checked = false;
            toolAlignCenter.Checked = false;
            toolAlignRight.Checked = true;
        }

        private void toolBold_Click(object sender, EventArgs e)
        {
            if (EditorTextBox.SelectionFont != null)
            {
                if (EditorTextBox.SelectionFont.Bold)
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Bold);
                    toolBold.Checked = false;
                }
                else
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Bold);
                    toolBold.Checked = true;
                }
            }
            else
            {
                int selectionStart = EditorTextBox.SelectionStart;
                int selectionLength = EditorTextBox.SelectionLength;
                int selectionEnd = selectionStart + EditorTextBox.SelectionLength;
                int j = 0;
                while (true)
                {
                    int i = 0;
                    int sectionSelectionStart = selectionStart + j;
                    if (sectionSelectionStart < selectionEnd)
                    {
                        while (true)
                        {
                            EditorTextBox.Select(sectionSelectionStart, i);
                            if (EditorTextBox.SelectionFont != null)
                            {
                                if (selectionEnd > sectionSelectionStart + i)
                                {
                                    i++;
                                }
                                else
                                {
                                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Bold);
                                    j += i;
                                    break;
                                }
                            }
                            if (EditorTextBox.SelectionFont == null)
                            {
                                i--;
                                EditorTextBox.Select(sectionSelectionStart, i);
                                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Bold);
                                j += i;
                                EditorTextBox.Select(selectionStart, selectionLength);
                                break;
                            }
                        }
                    }
                    else
                    {
                        EditorTextBox.Select(selectionStart, selectionLength);
                        break;
                    }

                }





            }

        }

        private void tooltalic_Click(object sender, EventArgs e)
        {
            if (EditorTextBox.SelectionFont != null)
            {
                if (EditorTextBox.SelectionFont.Italic)
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Italic);
                    toolItalic.Checked = false;
                }
                else
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Italic);
                    toolItalic.Checked = true;
                }
            }
            else
            {
                int selectionStart = EditorTextBox.SelectionStart;
                int selectionLength = EditorTextBox.SelectionLength;
                int selectionEnd = selectionStart + EditorTextBox.SelectionLength;
                int j = 0;
                while (true)
                {
                    int i = 0;
                    int sectionSelectionStart = selectionStart + j;
                    if (sectionSelectionStart < selectionEnd)
                    {
                        while (true)
                        {
                            EditorTextBox.Select(sectionSelectionStart, i);
                            if (EditorTextBox.SelectionFont != null)
                            {
                                if (selectionEnd > sectionSelectionStart + i)
                                {
                                    i++;
                                }
                                else
                                {
                                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Italic);
                                    j += i;
                                    break;
                                }
                            }
                            if (EditorTextBox.SelectionFont == null)
                            {
                                i--;
                                EditorTextBox.Select(sectionSelectionStart, i);
                                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Italic);
                                j += i;
                                EditorTextBox.Select(selectionStart, selectionLength);
                                break;
                            }
                        }
                    }
                    else
                    {
                        EditorTextBox.Select(selectionStart, selectionLength);
                        break;
                    }

                }
            }
        }

        private void toolUnderline_Click(object sender, EventArgs e)
        {
            if (EditorTextBox.SelectionFont != null)
            {
                if (EditorTextBox.SelectionFont.Underline)
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style & ~FontStyle.Underline);
                    toolUnderline.Checked = false;
                }
                else
                {
                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Underline);
                    toolUnderline.Checked = true;
                }
            }
            else
            {
                int selectionStart = EditorTextBox.SelectionStart;
                int selectionLength = EditorTextBox.SelectionLength;
                int selectionEnd = selectionStart + EditorTextBox.SelectionLength;
                int j = 0;
                while (true)
                {
                    int i = 0;
                    int sectionSelectionStart = selectionStart + j;
                    if (sectionSelectionStart < selectionEnd)
                    {
                        while (true)
                        {
                            EditorTextBox.Select(sectionSelectionStart, i);
                            if (EditorTextBox.SelectionFont != null)
                            {
                                if (selectionEnd > sectionSelectionStart + i)
                                {
                                    i++;
                                }
                                else
                                {
                                    EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Underline);
                                    j += i;
                                    break;
                                }
                            }
                            if (EditorTextBox.SelectionFont == null)
                            {
                                i--;
                                EditorTextBox.Select(sectionSelectionStart, i);
                                EditorTextBox.SelectionFont = new Font(EditorTextBox.SelectionFont, EditorTextBox.SelectionFont.Style | FontStyle.Underline);
                                j += i;
                                EditorTextBox.Select(selectionStart, selectionLength);
                                break;
                            }
                        }
                    }
                    else
                    {
                        EditorTextBox.Select(selectionStart, selectionLength);
                        break;
                    }

                }
            }
        }

        private void EditorTextBox_SelectionChanged(object sender, EventArgs e)
        {
            if (EditorTextBox.SelectionFont != null)
            {
                if (EditorTextBox.SelectionFont.Bold)
                {
                    toolBold.Checked = true;
                }
                else
                {
                    toolBold.Checked = false;
                }
                if (EditorTextBox.SelectionFont.Italic)
                {
                    toolItalic.Checked = true;
                }
                else
                {
                    toolItalic.Checked = false;
                }
                if (EditorTextBox.SelectionFont.Underline)
                {
                    toolUnderline.Checked = true;
                }
                else
                {
                    toolUnderline.Checked = false;
                }
            }
            else
            {
                    toolBold.Checked = false;
                    toolUnderline.Checked = false;
                    toolItalic.Checked = false;
            }

            if (EditorTextBox.SelectionAlignment == HorizontalAlignment.Left)
            {
                toolAlignLeft.Checked = true;
                toolAlignCenter.Checked = false;
                toolAlignRight.Checked = false;
            }
            else if (EditorTextBox.SelectionAlignment == HorizontalAlignment.Center)
            {
                toolAlignLeft.Checked = false;
                toolAlignCenter.Checked = true;
                toolAlignRight.Checked = false;
            }
            else if (EditorTextBox.SelectionAlignment == HorizontalAlignment.Right)
            {
                toolAlignLeft.Checked = false;
                toolAlignCenter.Checked = false;
                toolAlignRight.Checked = true;
            }
        }
    }
}
