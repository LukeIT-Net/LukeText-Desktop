using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LukeText_For_Desktop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.Clear();
				using (StreamReader sr = new StreamReader(openFile.FileName))
				{
					richTextBox1.Text = sr.ReadToEnd();
					sr.Close();
				}
			}
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFile = new SaveFileDialog();
			saveFile.Title = "Save file as...";
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				StreamWriter txtoutput = new StreamWriter(saveFile.FileName);
				txtoutput.Write(richTextBox1.Text);
				txtoutput.Close();
			}
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
	}
}
