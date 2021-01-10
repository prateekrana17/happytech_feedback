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
    public partial class add : UserControl
    {
        public add()
        {
            InitializeComponent();
            
        }

        public void addUIcs_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                temp_sender.Text = string.Empty;
                temp_title.Text = string.Empty;
                temp_subject.Text = string.Empty;
                
                temp_position.Text = string.Empty;
            }
        }
        private bool isFormEmpty()
        {
            if (temp_sender.Text == null || temp_sender.Text == string.Empty
                || temp_title.Text == null || temp_title.Text == string.Empty
                || temp_subject.Text == null || temp_subject.Text == string.Empty
                
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
        private void Create_template_on_click(object sender, EventArgs e)
        {
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
                
                t1.position = temp_position.Text;

                bool isSucess = template_factory.Create_template(t1);

                if (isSucess)
                {
                    DialogResult sucesssMsg = MessageBox.Show("Template added sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult failureMsg = MessageBox.Show("Failed to create New Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        public void RefreshItems()
        {
            temp_sender.Text = string.Empty;
            temp_title.Text = string.Empty;
            temp_subject.Text = string.Empty;
            temp_position.Text = string.Empty;
        }

        private void Sender_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
