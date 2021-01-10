using System;
using System.Windows.Forms;
using HappyTech_FeedbackApp.classes;

namespace FeedbackApp
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            addUIcs1.Hide();
            viewUI1.Hide();
            updateUI1.Hide();
            deleteUI1.Hide();
            feedbackUI1.Hide();
            logoUI1.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addUIcs1.RefreshItems();
            addUIcs1.Show();
            viewUI1.Hide();
            updateUI1.Hide();
            deleteUI1.Hide();
            feedbackUI1.Hide();
            logoUI1.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click_viewButton(object sender, EventArgs e)
        {
            viewUI1.RefreshItems();
            addUIcs1.Hide();
            viewUI1.Show();
            updateUI1.Hide();
            deleteUI1.Hide();
            feedbackUI1.Hide();
            logoUI1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateUI1.RefreshItems();
            addUIcs1.Hide();
            viewUI1.Hide();
            updateUI1.Show();
            deleteUI1.Hide();
            feedbackUI1.Hide();
            logoUI1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteUI1.RefreshItems();

            addUIcs1.Hide();
            viewUI1.Hide();
            updateUI1.Hide();
            deleteUI1.Show();
            feedbackUI1.Hide();
            logoUI1.Hide();

        }

        private void feedbackUI1_Load(object sender, EventArgs e)
        {
            feedbackUI1.Refresh();
            logoUI1.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            feedbackUI1.RefreshItems();

            addUIcs1.Hide();
            viewUI1.Hide();
            updateUI1.Hide();
            deleteUI1.Hide();
            feedbackUI1.Show();
            logoUI1.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Email all applicants?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
            if (res == DialogResult.OK)
            {
                FeedbackGenerator FeedbackGenerator = new FeedbackGenerator();

                FeedbackGenerator.send_emails();
            }
            
        }

        private void viewUI1_Load(object sender, EventArgs e)
        {

        }

        private void deleteUI1_Load(object sender, EventArgs e)
        {

        }

        private void updateUI1_Load(object sender, EventArgs e)
        {

        }
    }
}
