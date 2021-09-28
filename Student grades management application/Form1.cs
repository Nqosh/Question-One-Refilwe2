using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_grades_management_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {   
                string fileName = txtfileName.Text;
                string studeNo = txtStudentNo.Text;
                string Name = txtName.Text;
                string surName = txtSurname.Text;
                string indvAssigment = txtIndividualAssignment.Text;
                string grpAssignment = txtGrpAssignment.Text;
                string test = txtTest.Text;  

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                              fileName + " " + ".txt");

            List<string> ls = new List<string>();
            ls.Add(fileName);
            ls.Add(studeNo);
            ls.Add(Name);
            ls.Add(surName);
            ls.Add(indvAssigment);
            ls.Add(grpAssignment);
            ls.Add(test);

            StringBuilder words = new StringBuilder();
            foreach(var item in ls)
            {
                words.Append(item);
            }
            var test2 = words.ToString();


            using (StreamWriter outputFile = new StreamWriter(filePath, true)) //// true to append data to the file
            {
                await outputFile.WriteAsync(test2);
            }


            //txtfileName.Text = "";
            //txtStudentNo.Text = "";
            //txtName.Text = "";
            //txtSurname = "";
        }
    }
}
