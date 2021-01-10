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
    public partial class update1 : UserControl
    {
        public update1()
        {
            InitializeComponent();
        }
        private bool isFormEmpty()
        {
            if (temp_sender.Text == null || temp_sender.Text == string.Empty
                || temp_title.Text == null || temp_title.Text == string.Empty
                || temp_subject.Text == null || temp_subject.Text == string.Empty
                || temp_comment.Text == null || temp_comment.Text == string.Empty
                || temp_position.Text == null || temp_position.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //
            Template template_factory = new Template();
            bool isEmpty = isFormEmpty();
            if (isEmpty)
            {
                DialogResult failureMsg = MessageBox.Show("1 or more Field(s) Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Template t1 = new Template();
                t1.template_name = temp_title.Text;
                t1.HR_id = temp_sender.Text;
                t1.section1_title = temp_subject.Text;
                t1.section2_title = temp_comment.Text;
                t1.position = temp_position.Text;
                t1.template_id = Int32.Parse(temp_id.Text);
                bool isSucess = template_factory.update_template(t1);

                if (isSucess)
                {
                    DialogResult sucesssMsg = MessageBox.Show("Template updated sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
                else
                {
                    DialogResult failureMsg = MessageBox.Show("Failed to create New Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
            }

        }

        private void updateTemplateUI_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
