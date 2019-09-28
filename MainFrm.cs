using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros
{
    public partial class MainFrm : Form
    {
        private Random m_Rnd = new Random(System.DateTime.Now.Second);

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "랜덤 숫자 생성을 시작하려면";
            label3.Text = "아무 키나 누르십시오";
            label1.Text = label4.Text = label5.Text = label6.Text = label7.Text = label8.Text = label9.Text = "";
        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            label2.TextAlign = ContentAlignment.MiddleRight;
            label3.TextAlign = ContentAlignment.MiddleRight;

            string p1 = m_Rnd.Next(1000).ToString();
            label1.Text = p1.Substring(0, p1.Length - 1) + "," +
                p1.Substring(p1.Length - 1) + "%";
            if (p1.Length == 1) label1.Text = "0" + label1.Text;

            string p2 = m_Rnd.Next(10, 10000).ToString();
            label2.Text = p2.Substring(0, p2.Length - 2) + "," +
                p2.Substring(p2.Length - 2) + "%";
            if (p2.Length == 2) label2.Text = "0" + label2.Text;

            string n1 = m_Rnd.Next(10, 99).ToString();
            label3.Text = n1.Substring(0, 1) + "." + n1.Substring(1) + "00 personas";

            string n2 = m_Rnd.Next(100, 999).ToString();
            label4.Text = n2.Substring(0, 2) + "." + n2.Substring(2) + "00 personas";

            string n3 = m_Rnd.Next(1000, 9999).ToString();
            label5.Text = n3.Substring(0, 3) + "." + n3.Substring(3) + "00 personas";

            string n4 = m_Rnd.Next(100, 999).ToString();
            label6.Text = "$ " + n4.Substring(0, 1) + "." + n4.Substring(1, 2) + "0.000";

            string n5 = m_Rnd.Next(100, 999).ToString();
            label7.Text = "$ " + n5.Substring(0, 2) + "." + n5.Substring(2) + "00.000";

            string n6 = m_Rnd.Next(100, 999).ToString();
            label8.Text = "$ " + n6 + ".000.000";

            string n7 = m_Rnd.Next(100, 999).ToString();
            label9.Text = "$ " + n7.Substring(0, 1) + "." + n7.Substring(1, 2) + "0.000.000";
        }
    }
}
