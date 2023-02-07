using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentScores
{
    public partial class FrmAddNewStudent : Form
    {
        public FrmAddNewStudent()
        {
            InitializeComponent();
        }

        List<int> scoreList = new List<int>(); 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(this.txtScore.Text);
            scoreList.Add(score);

            // Display sores in form
            this.DisplayScores();
        }
        private void DisplayScores()
        {
            string scores = "";
            foreach (int score in this.scoreList)
            {
                scores += score.ToString() + " ";
            }
            this.lblScores.Text = scores;
        }
    }
        
}
