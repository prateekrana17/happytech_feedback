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
    public partial class delete : UserControl
    {
        public delete()
        {
            InitializeComponent();

        }

        private void DeleteUI_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete selected Template", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Template template_factory = new Template();
                string temp_title = comboBox1.Text;
                bool isSucess = template_factory.delete_template(temp_title);

                if (isSucess)
                {
                    DialogResult sucesssMsg = MessageBox.Show("Template deleted sucessfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult failureMsg = MessageBox.Show("Failed to delete Template", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
           
        }

        public void RefreshItems()
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
}
