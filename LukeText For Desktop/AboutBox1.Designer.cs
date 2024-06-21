﻿namespace LukeText_For_Desktop
{
	partial class AboutBox1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			logoPictureBox = new System.Windows.Forms.PictureBox();
			labelProductName = new System.Windows.Forms.Label();
			labelVersion = new System.Windows.Forms.Label();
			labelCopyright = new System.Windows.Forms.Label();
			labelCompanyName = new System.Windows.Forms.Label();
			okButton = new System.Windows.Forms.Button();
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
			tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Controls.Add(richTextBox1, 1, 4);
			tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
			tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			tableLayoutPanel.Size = new System.Drawing.Size(487, 307);
			tableLayoutPanel.TabIndex = 0;
			tableLayoutPanel.Paint += tableLayoutPanel_Paint;
			// 
			// logoPictureBox
			// 
			logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			logoPictureBox.Image = Properties.Resources.LukeTextAboutImage;
			logoPictureBox.Location = new System.Drawing.Point(4, 3);
			logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new System.Drawing.Size(152, 301);
			logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			labelProductName.Location = new System.Drawing.Point(167, 0);
			labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new System.Drawing.Size(316, 20);
			labelProductName.TabIndex = 19;
			labelProductName.Text = "LukeText";
			labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			labelProductName.Click += labelProductName_Click;
			// 
			// labelVersion
			// 
			labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			labelVersion.Location = new System.Drawing.Point(167, 30);
			labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new System.Drawing.Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new System.Drawing.Size(316, 20);
			labelVersion.TabIndex = 0;
			labelVersion.Text = "Version 2.3.0";
			labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			labelVersion.Click += labelVersion_Click;
			// 
			// labelCopyright
			// 
			labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			labelCopyright.Location = new System.Drawing.Point(167, 60);
			labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new System.Drawing.Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new System.Drawing.Size(316, 20);
			labelCopyright.TabIndex = 21;
			labelCopyright.Text = "LukeIT";
			labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelCompanyName
			// 
			labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			labelCompanyName.Location = new System.Drawing.Point(167, 90);
			labelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new System.Drawing.Size(316, 20);
			labelCompanyName.TabIndex = 22;
			labelCompanyName.Text = "LukeText is licensed under the GNU GPL v3 License";
			labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// okButton
			// 
			okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			okButton.Location = new System.Drawing.Point(395, 277);
			okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new System.Drawing.Size(88, 27);
			okButton.TabIndex = 24;
			okButton.Text = "&OK";
			okButton.Click += okButton_Click;
			// 
			// richTextBox1
			// 
			richTextBox1.Location = new System.Drawing.Point(163, 123);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.Size = new System.Drawing.Size(321, 147);
			richTextBox1.TabIndex = 25;
			richTextBox1.Text = "";
			// 
			// AboutBox1
			// 
			AcceptButton = okButton;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(507, 327);
			Controls.Add(tableLayoutPanel);
			FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBox1";
			Padding = new System.Windows.Forms.Padding(10);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			Text = "About LukeText";
			Load += AboutBox1_Load;
			tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelCompanyName;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
