using kafeyonetimi.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace kafeyonetimi
{
    public partial class frmUserInfo : Form
    {
        User user;
        Cafe cafe;
        public frmUserInfo(Object user,Object cafe)
        {
            this.user = (User)user;
            this.cafe = (Cafe)cafe;
            InitializeComponent();
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            var request = WebRequest.Create(cafe.kaferesim);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
                pictureBox1.BackgroundImage = Bitmap.FromStream(stream);
            lblUserName.Text = user.username;
            lblName.Text = user.name + " " + user.surname;
            lblEmail.Text = user.email;
            lblCafeName.Text = cafe.kafename + " - " + cafe.kafeilce + " - " + cafe.kafeil;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
