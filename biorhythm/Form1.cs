using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QAAclasses;

namespace biorhythm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CurrentDate = DateTime.Now;
            BirthDate = DateTime.Now;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biorhythm Calculator version " + Version + "\nCreated by Bobby D. Jones\nbdjtexas@gmail.com\nCopyright ©  2014", "About Biorhythm Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Form1.BirthDate = dateTimePicker1.Value;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Form1.CurrentDate = dateTimePicker2.Value;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void changeApplicationColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color chosenColor = colorDialog1.Color;
            this.BackColor = chosenColor;
        }

        private void CalculateBiorhythmButton_Click(object sender, EventArgs e)
        {
            CalcDaysAlive();
            TotalDaysAliveTextBox.Text = TotalDaysAlive.ToString();
            PhysicalCycleTextBox.Text = Physical.CalcPhysical().ToString();
            EmotionalCycleTextBox.Text = Emotional.CalcEmotional().ToString();
            IntellectualCycleTextBox.Text = Intellectual.CalcIntellectual().ToString();
            TotalDaysAliveTextBox.Update();
            PhysicalCycleTextBox.Update();
            EmotionalCycleTextBox.Update();
            IntellectualCycleTextBox.Update();
        }

        private void SeeGraphButton_Click(object sender, EventArgs e)
        {
            Form2 GraphWindow = new Form2();
            GraphWindow.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveBirthDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PhysicalCycleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
