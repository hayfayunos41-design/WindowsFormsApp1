using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bttnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "-Thread Start-";

            Thread threadA = new Thread(MyThreadClass.Thread1);
            threadA.Name = "Thread A";
            threadA.Priority = ThreadPriority.Highest;

            Thread threadB = new Thread(MyThreadClass.Thread1);
            threadB.Name = "Thread B";
            threadB.Priority = ThreadPriority.Normal;

            Thread threadC = new Thread(MyThreadClass.Thread2);
            threadC.Name = "Thread C";
            threadC.Priority = ThreadPriority.AboveNormal;

            Thread threadD = new Thread(MyThreadClass.Thread2);
            threadD.Name = "Thread D";
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            lblStatus.Text = "-End of Thread-";
        }
    }
}
