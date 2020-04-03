using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace downloader
{
    public partial class Form1 : Form
    {
        
        

        public Form1()
        {
            InitializeComponent();
        }
        public void download(string link, string name) {
            using (WebClient client= new WebClient()) {
                client.DownloadFile(link,name);
            }
        }
        private void Download_Click(object sender, EventArgs e)
        {
            try
            {
                download(textBox1.Text, textBox2.Text);
                MessageBox.Show("FILE DOWNLOADED");
            }
            catch(Exception ex) {
                MessageBox.Show("error:\n" + ex.ToString());
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                download("https://pomber.github.io/covid19/timeseries.json", nomedeficheiro);
                MessageBox.Show("FILE DOWNLOADED");
                a  += 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:\n" + ex.ToString());
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //label4.Text = 
        }
    }
}
