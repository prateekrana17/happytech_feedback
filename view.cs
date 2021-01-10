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
    public partial class view : UserControl
    {
        

        public view()
        {
            InitializeComponent();
            
        }
        public void print_template_info()
        {



            foreach (Control item in this.Controls.OfType<Control>())
            {
                this.Controls.Remove(item);
            }

            this.heading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(125, 31);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(194, 26);
            this.heading.TabIndex = 0;
            this.heading.Text = "List of Templates";


            Template template_factory = new Template();
            List<Template> list = new List<Template>();
            //list = template_factory.get_all_template_info();
            list = template_factory.get_templates();
            int width = 0;
            int height = 80;
            int count = 1;
            for (int i = 0; i < list.Count; i++)
            {
                this.label1 = new System.Windows.Forms.Label();
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.Location = new System.Drawing.Point(width, height);
                this.label1.Name = list[i].template_name;
                this.label1.Size = new System.Drawing.Size(100, 26);
                this.label1.TabIndex = 0;
                this.label1.Text = count + ".    " + list[i].template_name;
                //this.label1.Click += new System.EventHandler(this.label1_Click);


                this.label2 = new System.Windows.Forms.Label();
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.Location = new System.Drawing.Point(width + 250, height);
                this.label2.Name = list[i].section1_title;
                this.label2.Size = new System.Drawing.Size(100, 26);
                this.label2.TabIndex = 0;
                this.label2.Text = list[i].section1_title;

                this.Controls.Add(this.label1);
                this.Controls.Add(this.label2);
                count++;
                height = height + 30;
            }

        }

        private void viewUI_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                //print_template_info();
            }
        }
        public void RefreshItems()
        {
            print_template_info();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
