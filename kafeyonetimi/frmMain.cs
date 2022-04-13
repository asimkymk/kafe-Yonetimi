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

        public frmMain(Object user)
        {
            this.user = (User)user;
            cafeYukle();
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
            }
        }
    }
}
