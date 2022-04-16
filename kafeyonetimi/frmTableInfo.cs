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
    public partial class frmTableInfo : Form
    {
        Table table;
        Cafe cafe;
        frmMain mainForm;
        public frmTableInfo(Object table,Object cafe,Object mainForm)
        {
            this.table = (Table)table;
            this.cafe = (Cafe)cafe;
            this.mainForm = (frmMain)mainForm;
            InitializeComponent();
        }

        private void frmTableInfo_Load(object sender, EventArgs e)
        {
            label1.Text = table.masahesap.ToString() + " TL";
            this.Text = "Kafe Yönetimi - Satış Yap " + "Masa " + table.masano.ToString();
        }
        private bool cafeGuncelle()
        {



            cafe.kafebosmasasayisi++;
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
        private bool masaGuncelle()
        {

            

            
            
            string DATA = @"{""masahesap"":""0""}"; ;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constants.BASE_URL +
                Constants.KAFE_URL + cafe.id + "/" + Constants.MASA_URL + table.id);
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

                    cafeGuncelle();
                     

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
            DialogResult dialogResult = MessageBox.Show("Bu masada satış yapmak istediğine emin misin?", "Satış Yap", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (masaGuncelle())
                {
                    mainForm.masaGuncelle();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Satış gerçekleştirilirken bir ahta meydana geldi.", "Hata",
                                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }
    }
}
