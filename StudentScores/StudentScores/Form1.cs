using System.Windows.Forms.VisualStyles;

namespace StudentScores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> studentScores = new List<string>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentScores.Add("Joel Murach|97|91|83");
            this.studentScores.Add("Doug Lowe|99|93|97");
            this.studentScores.Add("Anne Boehm|100|100|100");
            LoadStudentListBox();
        }

        private void LoadStudentListBox(int selectedIndex = 0)
        {
            this.listStudents.Items.Clear();

            foreach (string str in this.studentScores)
            {
                this.listStudents.Items.Add(str);
            }
        }

        private void ClearLabel() {
            this.lblScoreCount.Text = "0";
            this.lblAverage.Text = "0";
            this.lblScoreTotal.Text = "0";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form addForm = new FrmAddNewStudent();
            DialogResult result = addForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}