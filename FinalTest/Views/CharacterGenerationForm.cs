using FinalTest.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTest
{
    public partial class CharacterGenerationForm : Form
    {
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            List<LoadNames> loadNames;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;

            }
        }
    }
}
