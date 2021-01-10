using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyTech_FeedbackApp.classes;

namespace FeedbackApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Feedback f = new Feedback();
           // f.HR_Email = "pkr114@student.aru.ac.uk";
            //f.applicant_name = "1824882";
            //f.template_name = "Template1";
           // f.save(f);
           // FeedbackGenerator FeedbackGenerator = new FeedbackGenerator();
          //  List<string> l = new List<string>();
           // List<string> list = FeedbackGenerator.get_Feedback_file_names();
            //FeedbackGenerator.send_emails(list);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_form());
        }
    }
}
