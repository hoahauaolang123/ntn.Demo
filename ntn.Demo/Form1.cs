using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntn.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetText_Click(object sender, EventArgs e)
        {
            var text = txtContent.Text;

            var a = Newtonsoft.Json.JsonConvert.SerializeObject(text);

            txtValue.Text = a;

        }
    }
}
