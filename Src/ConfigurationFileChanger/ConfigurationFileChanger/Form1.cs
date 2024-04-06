namespace ConfigurationFileChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e.KeyData);
        }
        private void OnKeyDown(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                const string message = "• Author: Michaël André Franiatte.\n\r\n\r• Contact: michael.franiatte@gmail.com.\n\r\n\r• Publisher: https://github.com/michaelandrefraniatte.\n\r\n\r• Copyrights: All rights reserved, no permissions granted.\n\r\n\r• License: Not open source, not free of charge to use.";
                const string caption = "About";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fromstring = ".";
            string replacestring = "";
            string[] splitstring = new string[14];
            splitstring = textBox1.Text.Split(", ");
            int inc = 0;
            List<string> newsplitstring = new List<string>();
            foreach (string valuestring in splitstring)
            {
                int pFrom = valuestring.IndexOf(fromstring);
                string newvaluestring;
                if (pFrom > 0)
                {
                    int pTo = valuestring.Length;
                    string result = valuestring.Substring(pFrom, pTo - pFrom);
                    newvaluestring = valuestring.Replace(result, replacestring);
                }
                else
                {
                    newvaluestring = valuestring;
                }
                newsplitstring.Add(newvaluestring);
                inc++;
            }
            textBox2.Text = "";
            foreach (string newvaluestring in newsplitstring)
            {
                textBox2.Text += newvaluestring + ", ";
            }
        }
    }
}