using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SundayGrade.App
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void marksShowButton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.Physics = Convert.ToDouble(marksPhysicaTextBox.Text);
            aResult.Chemistry = Convert.ToDouble(marksChemistryTextBox.Text);
            aResult.Math = Convert.ToDouble(marksMathTextBox.Text);

            marksAverageTextBox.Text = aResult.GetAverage().ToString();
            marksGradeLetterTextBox.Text = aResult.GetGradeLetter();

        }
    }
}
