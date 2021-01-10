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
    public partial class update2 : UserControl
    {
        public update2()
        {
            InitializeComponent();
            
            updateTemplateUI1.Hide();
        }

        private void updateUI_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Temp_title = comboBox1.Text;
            Template t1 = new Template();

            Template template_factory = new Template();
            t1 = template_factory.search_template_by_title(Temp_title);

            updateTemplateUI1.temp_sender.Text = t1.HR_id;
            updateTemplateUI1.temp_subject.Text = t1.section1_title;
            updateTemplateUI1.temp_position.Text = t1.position;
            updateTemplateUI1.temp_comment.Text = t1.section2_title;
            updateTemplateUI1.temp_title.Text = t1.template_name;
            updateTemplateUI1.temp_id.Text = t1.template_id.ToString();
            updateTemplateUI1.Show();
            

            //t1 = template_factory.;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateTemplateUI1_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {

            }

        }
        public void RefreshItems()
        {
            comboBox1.Text = string.Empty;

            Template template_factory = new Template();
            comboBox1.Items.Clear();
            List<Template> list = new List<Template>();
            list = template_factory.get_templates();
            foreach (Template item in list)
            {
                comboBox1.Items.Add(item.template_name);

            }
        }
    }
}
