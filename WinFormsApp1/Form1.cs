using System.Data;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string sugarLevel = "";
        string iceLevel = "";

        public Form1()
        {
            InitializeComponent();
            if (Form2.namaUser != "admin")
            {
                manageUserToolStripMenuItem.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "100";
            comboBox2.SelectedItem = "100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int hargaTotal = 0;
            string invoice = "";
            if (radioButton1.Checked)
            {
                hargaTotal += 10000;
                invoice += "Espresso, ";
            }
            else if (radioButton2.Checked)
            {
                hargaTotal += 15000;
                invoice += "Latte, ";
            }
            else
            {
                hargaTotal += 12000;
                invoice += "Cappuccino, ";
            }

            if (checkBox1.Checked)
            {
                hargaTotal += 3000;
                invoice += "Large, ";
            }

            invoice += "Sugar(" + sugarLevel + "%), ";
            invoice += "Ice(" + iceLevel + "%), ";

            int i = 0;
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                if (i == 0) { invoice += "Topping("; }
                if (i != 0) { invoice += ", "; }
                i = 1;
                if (itemChecked.ToString() == "Bubble")
                {
                    hargaTotal += 3000;
                    invoice += "bubble";
                }
                else if (itemChecked.ToString() == "Grass Jelly")
                {
                    hargaTotal += 3500;
                    invoice += "grass jelly";
                }
                else if (itemChecked.ToString() == "Nata de coco")
                {
                    hargaTotal += 2500;
                    invoice += "nata de coco";
                }
                else if (itemChecked.ToString() == "Whipped cream")
                {
                    hargaTotal += 1000;
                    invoice += "whipped cream";
                }
                else if (itemChecked.ToString() == "Choco chip")
                {
                    hargaTotal += 1500;
                    invoice += "choco chip";
                }
                else if (itemChecked.ToString() == "Oreo")
                {
                    hargaTotal += 2000;
                    invoice += "oreo";
                }
            }
            if (i != 0) { invoice += ")"; }

            int myLimit = 35;
            string[] words = invoice.Split(' ');
            StringBuilder newSentence = new StringBuilder();

            string line = "";
            foreach (string word in words)
            {
                if ((line + word).Length > myLimit)
                {
                    newSentence.AppendLine(line);
                    line = "";
                }

                line += string.Format("{0} ", word);
            }

            if (line.Length > 0)
                newSentence.AppendLine(line);

            label21.Text = newSentence.ToString();
            label20.Text = "Rp" + hargaTotal;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    sugarLevel = "100";
                    break;
                case 1:
                    sugarLevel = "75";
                    break;
                case 2:
                    sugarLevel = "50";
                    break;
                case 3:
                    sugarLevel = "0";
                    break;
                default:
                    sugarLevel = "100";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    iceLevel = "100";
                    break;
                case 1:
                    iceLevel = "75";
                    break;
                case 2:
                    iceLevel = "50";
                    break;
                case 3:
                    iceLevel = "0";
                    break;
                default:
                    iceLevel = "100";
                    break;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!");
        }
    }
}