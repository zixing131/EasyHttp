using EasyHttp.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEasyHttp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.Request.KeepAlive = false; 
            client.Request.Proxy = new System.Net.WebProxy("http://127.0.0.1:7890");
            var resp = client.Get("https://ip.tool.lu/");

        }
    }
}
