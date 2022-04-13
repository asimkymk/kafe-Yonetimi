using kafeyonetimi.objects;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Net.Http;
using System.Collections.Generic;

namespace kafeyonetimi
{
    public partial class frmMain : Form
    {
        User user;
        Cafe cafe;
        IEnumerable<Table> tables;
        Label[] labels = new Label[10];
        PictureBox[] pictureBoxes = new PictureBox[10];

        private bool cafeYukle()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BASE_URL + Constants.KAFE_URL);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {

                var dataObjects = response.Content.ReadAsAsync<IEnumerable<Cafe>>().Result;
                foreach (var foundCafe in dataObjects)
                {
                    if (foundCafe.id == user.id)
                    {
                        cafe = foundCafe;
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }


            client.Dispose();

            return false;
        }
        private bool masalariGetir(String id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BASE_URL + Constants.KAFE_URL+ id +"/"+ Constants.MASA_URL);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {

                tables = response.Content.ReadAsAsync<IEnumerable<Table>>().Result;
                
            }
            else
            {
                return false;
            }


            client.Dispose();

            return false;
        }

        private void masaGuncelle()
        {
            foreach (var table in tables)
            {
                if (table.masahesap > 0)
                {
                    labels[table.masano - 1].ForeColor = System.Drawing.Color.Red;
                    pictureBoxes[table.masano - 1].BackgroundImage = Properties.Resources.table_red;
                }
                else
                {

                    labels[table.masano - 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#f8efe4");
                    pictureBoxes[table.masano - 1].BackgroundImage = Properties.Resources.table;
                }
            }
            lblDoluluk.Text = ((((float)cafe.kafemasasayisi - (float)cafe.kafebosmasasayisi) / (float)cafe.kafemasasayisi)*100.0).ToString() + "%";
            //lblDoluluk.Text = cafe.kafebosmasasayisi.ToString();
        }

        public frmMain(Object user)
        {
            this.user = (User)user;
            cafeYukle();
            if (!masalariGetir(cafe.id))
            {
                Application.Exit();
            }
            

            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frmUserInfo = new frmUserInfo(user,cafe);
            frmUserInfo.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğine emin misin?", "Çıkış Yap", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                user.cleanSettings();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            

           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            if (cafe == null)
            {
                MessageBox.Show("Cafe bilgileri çekilirken hata oldu. Lütfen daha sonra tekrar deneyin.", "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                lblCafeIsim.Text = cafe.kafename + " - " + cafe.kafeilce + " - " + cafe.kafeil;
                labels[0] = lblMasa1;
                labels[1] = lblMasa2;
                labels[2] = lblMasa3;
                labels[3] = lblMasa4;
                labels[4] = lblMasa5;
                labels[5] = lblMasa6;
                labels[6] = lblMasa7;
                labels[7] = lblMasa8;
                labels[8] = lblMasa9;
                labels[9] = lblMasa10;
                pictureBoxes[0] = picMasa1;
                pictureBoxes[1] = picMasa2;
                pictureBoxes[2] = picMasa3;
                pictureBoxes[3] = picMasa4;
                pictureBoxes[4] = picMasa5;
                pictureBoxes[5] = picMasa6;
                pictureBoxes[6] = picMasa7;
                pictureBoxes[7] = picMasa8;
                pictureBoxes[8] = picMasa9;
                pictureBoxes[9] = picMasa10;
                masaGuncelle();
            }
        }
    }
}
