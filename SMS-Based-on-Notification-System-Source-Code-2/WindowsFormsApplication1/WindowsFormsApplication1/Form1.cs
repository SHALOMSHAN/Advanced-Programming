using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient ();

            client.Headers.Add ("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            client.QueryString.Add("id", "94753627409");
            client.QueryString.Add("pw", "9221");
            client.QueryString.Add("to", "94756327409");
            client.QueryString.Add("text", "This is an example message");
            string baseurl ="http://www.textit.biz/sendmsg";
            Stream data = client.OpenRead(baseurl);
            StreamReader reader = new StreamReader (data);
            string s = reader.ReadToEnd ();
            data.Close ();
            reader.Close ();
            //return (s);
        }
    }
}
