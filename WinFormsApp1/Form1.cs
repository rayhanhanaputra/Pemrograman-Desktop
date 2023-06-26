using CsvHelper;
using QRCoder;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net.Mail;
using System.Net;
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

            var records = new List<object>
            {
                new { Id = 1, Name = newSentence.ToString() },
            };

            using (var writer = new StreamWriter("order.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }

            int maxQrCodeSize = 200;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(newSentence.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            int moduleSize = maxQrCodeSize / qrCodeData.ModuleMatrix.Count;
            Bitmap qrCodeImage = qrCode.GetGraphic(moduleSize);

            qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
            pictureBox1.Image = qrCodeImage;

            string senderEmail = "alextesseracts@gmail.com";
            string senderPassword = "D30A06A399EE6626D1219F2D9A5C5E482474";
            string recipientEmail = "rayhanrhanaputra@outlook.com";
            string subject = "QR Code Pesanan Anda";
            string body = "Please find the attached QR code.";

            using (MailMessage mailMessage = new MailMessage())
            {
                mailMessage.From = new MailAddress(senderEmail);
                mailMessage.To.Add(recipientEmail);
                mailMessage.Subject = subject;
                mailMessage.Body = body;

                Attachment attachment = new Attachment("qrcode.png");
                mailMessage.Attachments.Add(attachment);

                using (SmtpClient smtpClient = new SmtpClient("smtp.elasticemail.com", 2525))
                {
                    smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                }
            }
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chatbotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}