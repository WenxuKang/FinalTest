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
    }
}
