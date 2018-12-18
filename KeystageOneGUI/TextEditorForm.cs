﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeystageOneGUI
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            openFileDialog.Title = "Open a File...";

            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(openFileDialog.FileName);
                richTextBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (.txt)|*.txt";
            saveFileDialog.Title = "Save File...";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog.FileName);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }
        }
    }
}
