using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTech_FeedbackApp.classes;

namespace FeedbackApp
{
    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void FeedbackUI_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                comboBox1.Items.Clear();

                Template template_factory = new Template();

                List<Template> list = new List<Template>();
                list = template_factory.get_templates();
                foreach (Template item in list)
                {
                    comboBox1.Items.Add(item.template_name);

                }
            }
        }
        private bool isFormEmpty()
        {
            if (name.Text == null || name.Text == string.Empty
                || email.Text == null || email.Text == string.Empty
                || comboBox1.Text == null || comboBox1.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            bool isEmpty = isFormEmpty();
            if (isEmpty)
            {
                DialogResult failureMsg = MessageBox.Show("1 or more Field(s) Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                string rcvrEmail = name.Text;
                string rcvrName = email.Text;
                string tempTitle = comboBox1.Text;
                HappyTech_FeedbackApp.classes.Feedback fd = new HappyTech_FeedbackApp.classes.Feedback();
                fd.applicant_email = rcvrEmail;
                fd.applicant_name = rcvrName;
                fd.template_name = tempTitle;
                bool isSucess = fd.save(fd);
                if (isSucess)
                {
                    DialogResult sucesssMsg = MessageBox.Show("Feedback added sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult failureMsg = MessageBox.Show("Failed to save Feedback", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



        }


        public void RefreshItems()
        {

            name.Text = string.Empty;
            email.Text = string.Empty;
            comboBox1.Items.Clear();
            comboBox1.Text = string.Empty;

            Template template_factory = new Template();

            List<Template> list = new List<Template>();
            list = template_factory.get_templates();
            foreach (Template item in list)
            {
                comboBox1.Items.Add(item.template_name);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
