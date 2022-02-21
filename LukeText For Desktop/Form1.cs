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
			saveFile.Filter = "LukeText Document (*.txt)|*.txt|All Files (*.*)|*.*";
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
	}
}
