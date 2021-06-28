using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Hash
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rad_md4.Checked == true)
            {
                var byteArray = Encoding.ASCII.GetBytes(text_in.Text);
                var results = MD4.Md4Hash(byteArray);

                text_out.Text = results;
            }
            
            if(rad_md5.Checked == true)
            {
                MD5 _md5 = new MD5();
                var byteArray = Encoding.ASCII.GetBytes(text_in.Text);
                var results = _md5.Calculate(byteArray);

                text_out.Text = results;
            }

            if(rad_sha1.Checked == true)
            {
                var byteArray = Encoding.ASCII.GetBytes(text_in.Text);
                var results= Sha.Sha1(text_in.Text);

                text_out.Text = results;
            }

            if (rad_sha256.Checked == true)
            {

                SHA256 sha = new SHA256();
                var byteArray = Encoding.ASCII.GetBytes(text_in.Text);
                //var results = Sha.Sha256(text_in.Text);
                //var results = sha.HashComputation(byteArray);

                //var output = Convert.ToBase64String(results);

                text_out.Text = SHA256.Result(text_in.Text);
            }

        }
    }
}
