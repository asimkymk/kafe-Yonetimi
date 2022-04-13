using kafeyonetimi.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace kafeyonetimi
{
    public partial class frmLogin : Form
    {
        User activeUser;

        private bool girisYap(string username, string password)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.BASE_URL + Constants.KULLANICI_URL);

            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {

                var dataObjects = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                foreach (var user in dataObjects)
                {
                    if (user.username == username && user.password == password)
                    {
                        activeUser = user;
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

        public frmLogin()
        {
            if (Properties.Settings.Default.rememberMe == true)
            {
                activeUser = new User();
                activeUser.createdAt = Properties.Settings.Default.createdAt;
                activeUser.username = Properties.Settings.Default.username;
                activeUser.password = Properties.Settings.Default.password;
                activeUser.name = Properties.Settings.Default.name;
                activeUser.surname = Properties.Settings.Default.surname;
                activeUser.email = Properties.Settings.Default.email;
                activeUser.id = Properties.Settings.Default.id;
                frmMain frm = new frmMain(activeUser);
                this.Hide();
                frm.Show();

            }
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Length > 0)
            {
                if(txtUserPassword.Text.Length > 0)
                {
                    if(girisYap(txtUserName.Text, txtUserPassword.Text))
                    {
                        if (beniHatirla.Checked)
                        {
                            activeUser.saveToSettings();

                        }
                        frmMain frm = new frmMain(activeUser);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre girdin. Lütfen kontrol ederek tekrar dene.", "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen şifreni doldur.", "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adını doldur.", "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            beniHatirla.Checked = !beniHatirla.Checked;
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.rememberMe == true)
            {
                this.Hide();

            }
        }
    }
}