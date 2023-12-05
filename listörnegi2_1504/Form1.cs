using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listörnegi2_1504
{
    public partial class Form1 : Form
    {List<string> kişiler= new List<string>();
      int indexSira=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kişiler.Add("Semanur");
            kişiler.Add("Melisa");
            kişiler.Add("sükanya");
            kişiler.Add("ravza");
            kişiler.Add("hilila");
            kişiler.Add("irem");
    

            listBox1.DataSource = kişiler.ToList();
        }

        private void btnkişiler_Click(object sender, EventArgs e)
        {
            kişiler.Add (txtad.Text);

            listBox1.DataSource=kişiler.ToList ();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            bool durum = kişiler.Contains(txtad.Text);

            if (durum)
            {
                MessageBox.Show("bu kişiler var");

            }
            else
            {
                MessageBox.Show("bu kişi yok"); 

            }
        }

        private void btnsıra_Click(object sender, EventArgs e)
        {
            int sira = kişiler.IndexOf(txtad.Text);
          if(sira > -1)
            {
                MessageBox.Show(txtad.Text + " " + sira + "sırasında");

            }
            else
            {
                MessageBox.Show(txtad.Text + "sıralamada yok");


            }

        }

        private void btnsılı_Click(object sender, EventArgs e)
        {
            int sira = kişiler.IndexOf(txtad.Text);
            if(sira < -1)
            {
                kişiler.RemoveAt(sira);

            } listBox1.DataSource =kişiler.ToList ();
        }

        private void bttnremov_Click(object sender, EventArgs e)
        {
            bool durum = kişiler.Contains(txtad.Text);

            if (durum)
            {
                kişiler.Remove(txtad.Text);

            } listBox1.DataSource = kişiler.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtad.Text = listBox1.SelectedValue.ToString();
           indexSira = listBox1.SelectedIndex;
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(indexSira.ToString());
        }

        private void btndunezenle_Click(object sender, EventArgs e)
        {
            kişiler[indexSira] = txtad.Text;
            listBox1.DataSource = kişiler.ToList();
        }

        private void btnartan_Click(object sender, EventArgs e)
        {
            kişiler.Sort();
            
            listBox1.DataSource= kişiler.ToList() ;

        }

        private void btnazalan_Click(object sender, EventArgs e)
        {
            kişiler.Sort();
            kişiler.Reverse();

            listBox1.DataSource = kişiler.ToList(); 
        }

        private void btn5harlıgörenci_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = 0; i < kişiler.Count; i++)
            {
              if (kişiler[i].Length == 5)
                {
                    sayac++;
                }

                    

            }MessageBox.Show("5 karekkterli:" + "sayac" + "tan kişiyi göster");
        }

    }
}
