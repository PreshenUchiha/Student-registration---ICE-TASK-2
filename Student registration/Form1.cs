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

namespace Student_registration
{
    public partial class frmDesign : Form
    {
        List<Details> details = new List<Details>();
        public frmDesign()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            details.Clear();
            string line;

            try
            {
                StreamReader file = new StreamReader("Contacts.txt");
                while ((line = file.ReadLine()) != null)
                {
                    var lineParts = line.Split(",");
                   // Details temp = new Details(lineParts[0], lineParts[1], lineParts[2], lineParts[3]);
                   // details.Add(temp);
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                StreamWriter sw = new StreamWriter("Contacts.txt");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            lstReport.Items.Clear();
            foreach (Details contact in details)
            {
                lstReport.Items.Add(contact.StudentFullName1+ "" + contact.StudentNumber1);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
