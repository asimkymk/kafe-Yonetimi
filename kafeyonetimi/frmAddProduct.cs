using kafeyonetimi.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafeyonetimi
{
    public partial class frmAddProduct : Form
    {
        Cafe cafe;
        IEnumerable<Table> tables;
        int total = 0;
        frmMain mainForm;
        public frmAddProduct(Object cafe, IEnumerable<Object> tables,Object mainForm)
        {
            this.cafe = (Cafe)cafe;
            this.tables = (IEnumerable<Table>)tables;
            this.mainForm = (frmMain)mainForm;
            InitializeComponent();
        }

        private void bunifuCheckbox20_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox20.Checked)
            {
                total += 9;
            }
            else
            {
                total -= 9;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label49.Text = total.ToString() + " TL";
        }

        private void bunifuCheckbox19_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox19.Checked)
            {
                total += 24;
            }
            else
            {
                total -= 24;
            }
        }

        private void bunifuCheckbox18_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox18.Checked)
            {
                total += 24;
            }
            else
            {
                total -= 24;
            }
        }

        private void bunifuCheckbox17_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox17.Checked)
            {
                total += 35;
            }
            else
            {
                total -= 35;
            }
        }

        private void bunifuCheckbox16_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox16.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox15_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox15.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox14_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox14.Checked)
            {
                total += 14;
            }
            else
            {
                total -= 14;
            }
        }

        private void beniHatirla_OnChange(object sender, EventArgs e)
        {
            if (beniHatirla.Checked)
            {
                total += 9;
            }
            else
            {
                total -= 9;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                total += 24;
            }
            else
            {
                total -= 24;
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked)
            {
                total += 24;
            }
            else
            {
                total -= 24;
            }
        }

        private void bunifuCheckbox3_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox3.Checked)
            {
                total += 35;
            }
            else
            {
                total -= 35;
            }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox4.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox5.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox6_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox6.Checked)
            {
                total += 14;
            }
            else
            {
                total -= 14;
            }
        }

        private void bunifuCheckbox13_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox13.Checked)
            {
                total += 9;
            }
            else
            {
                total -= 9;
            }
        }

        private void bunifuCheckbox12_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox12.Checked)
            {
                total += 14;
            }
            else
            {
                total -= 14;
            }
        }

        private void bunifuCheckbox11_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox11.Checked)
            {
                total += 14;
            }
            else
            {
                total -= 14;
            }
        }

        private void bunifuCheckbox10_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox10.Checked)
            {
                total += 35;
            }
            else
            {
                total -= 35;
            }
        }

        private void bunifuCheckbox9_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox9.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox8_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox8.Checked)
            {
                total += 18;
            }
            else
            {
                total -= 18;
            }
        }

        private void bunifuCheckbox7_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox7.Checked)
            {
                total += 14;
            }
            else
            {
                total -= 14;
            }
        }
        Table table;
        private bool cafeGuncelle()
        {



            cafe.kafebosmasasayisi--;
            string DATA = @"{""kafebosmasasayisi"":""" + cafe.kafebosmasasayisi.ToString() + @"""}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.BASE_URL +
                Constants.KAFE_URL + cafe.id);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;

            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                    

                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
        private bool masaGuncelle(String masano)
        {
            
            foreach (var tb in tables)
            {
                if (tb.masano == Int32.Parse(masano))
                {
                    table = tb;
                    break;
                }
            }

            int temp_hesap = table.masahesap;
            string temp_str_hesap = (temp_hesap + total).ToString(); // @"{""name"":""Asım""}";
            string DATA = @"{""masahesap"":""" + temp_str_hesap + @"""}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.BASE_URL +
                Constants.KAFE_URL+ cafe.id + "/" + Constants.MASA_URL + table.id);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = DATA.Length;

            using (Stream webStream = request.GetRequestStream())
            using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(DATA);
            }

            try
            {
                WebResponse webResponse = request.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                using (StreamReader responseReader = new StreamReader(webStream))
                {
                   if(temp_hesap == 0)
                    {
                        if (cafeGuncelle())
                        {
                            
                            return true;
                        }
                        else
                        {
                            
                            return false;
                        }
                    }
                    
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "")
            {
                
            }
            else
            {
                if (total == 0)
                {
                    
                }
                else
                {
                    if(masaGuncelle(comboBox1.Text.Remove(0, 5)))
                    {
                        mainForm.masaGuncelle();
                        this.Hide();
                    }
                }
            }
        }
    }
}
