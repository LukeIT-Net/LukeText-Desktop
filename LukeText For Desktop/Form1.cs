using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LukeText_For_Desktop
{
	public partial class Form1 : Form
	{
		public Form1(string filename)
		{
			InitializeComponent();
			if (filename != null )
			{
				try
				{
					richTextBox1.LoadFile(filename);
				}
				catch(Exception ex)
				{ 
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			richTextBox1.EnableAutoDragDrop = true;
		}

		public Form1()
		{
			InitializeComponent();
			richTextBox1.EnableAutoDragDrop = true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			openFile.Title = "Open Any File...";
			openFile.Filter = "Text Document (*.txt)|*.txt|LukeText Document (*.ltd)|*.ltd|LukeText Text Document (*.ltdt)|*.ltdt|All Files (*.*)|*.*";
			openFile.DefaultExt = "*.ltd";
			openFile.FilterIndex = 2;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Clear();
				string filename = openFile.FileName;
				RichTextBoxStreamType streamType;
					if (openFile.FilterIndex == 2)
						streamType = RichTextBoxStreamType.RichText;
					else
						streamType = RichTextBoxStreamType.PlainText;

				richTextBox1.LoadFile(filename, streamType);
			}
			
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			string filename = "";
			saveFile.Title = "Save file as...";
			saveFile.Filter = "Text Document (*.txt)|*.txt|LukeText Document (*.ltd)|*.ltd|LukeText Text Document(*.ltdt)|*.ltdt|All Files (*.*)|*.*";
			saveFile.DefaultExt = "*.ltd";
			saveFile.FilterIndex = 2;
			
			DialogResult retval = saveFile.ShowDialog();
			if (retval == DialogResult.OK)
				filename = saveFile.FileName;
			else
				return;

			RichTextBoxStreamType streamType;
			if (saveFile.FilterIndex == 2)
				streamType = RichTextBoxStreamType.RichText;
			else
				streamType = RichTextBoxStreamType.PlainText;
			
			richTextBox1.SaveFile(filename, streamType);
		}

		private void cutToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			newToolStripButton.PerformClick();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openToolStripButton.PerformClick();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveToolStripButton.PerformClick();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Undo();
		}

		private void redoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Redo();
		}

		private void cutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Cut();
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Copy();
		}

		private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Calibri", 11);
		}

		private void boldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Garamond", 11);
		}

		private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Garamond", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Times New Roman", 11);
		}

		private void boldToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Times New Roman", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Arial", 11);
		}

		private void boldToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Arial", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cambria", 11);
		}

		private void boldToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cambria", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Verdana", 11);
		}

		private void boldToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Rockwell", 11);
		}

		private void boldToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Rockwell", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Franklin Gothic", 11);
		}

		private void boldToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Franklin Gothic", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code PL", 11);
		}

		private void boldToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code PL", 11, FontStyle.Bold);
		}

		private void boldToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code", 11);
		}

		private void boldToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Code", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11);
		}

		private void boldToolStripMenuItem12_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11, FontStyle.Bold);
		}

		private void normalToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono", 11);
		}

		private void boldToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionFont = new Font("Cascadia Mono PL", 11, FontStyle.Bold);
		}

		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Black;
		}

		private void silverToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Silver;
		}

		private void grayToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Gray;
		}

		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.White;
		}

		private void darkRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Maroon;
		}

		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Red;
		}

		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Orange;
		}

		private void oliveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Olive;
		}

		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Yellow;
		}

		private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Lime;
		}

		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Green;
		}

		private void navyBlueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Navy;
		}

		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Blue;
		}

		private void tealToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Teal;
		}

		private void lightBlueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Aqua;
		}

		private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Purple;
		}

		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Fuchsia;
		}

		private void goldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionColor = Color.Gold;
		}

		private void moreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdlg = new FontDialog();
			fdlg.ShowDialog();
			richTextBox1.Font = fdlg.Font;
		}

		private void moreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.ForeColor = cdlg.Color;

		}

		private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton3.PerformClick();
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					Clipboard.SetImage(Image.FromFile(ofd.FileName));
					richTextBox1.Paste();
				}
			}
		}

		private void fileToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Yellow;
		}

		private void redToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Red;
		}

		private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Green;
		}

		private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionBackColor = Color.Blue;
		}

		private void moreToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.SelectionBackColor = cdlg.Color;
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			Font SelectedText_Font = richTextBox1.SelectionFont;
			if (SelectedText_Font != null)
				richTextBox1.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Strikeout);
		}

		private void aboutLukeTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton5.PerformClick();
		}

		private void italicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton6.PerformClick();
		}

		private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton4.PerformClick();
		}

		private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStripButton7.PerformClick();
		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void leftToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
		}

		private void centerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
		}

		private void rightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			richTextBox1.Select();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
		}

		private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog fdlg = new FontDialog();
			fdlg.ShowDialog();
			richTextBox1.Font = fdlg.Font;
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.ForeColor = cdlg.Color;
		}

		private void highlightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog cdlg = new ColorDialog();
			cdlg.ShowDialog();
			richTextBox1.SelectionBackColor = cdlg.Color;
		}
	}
}
