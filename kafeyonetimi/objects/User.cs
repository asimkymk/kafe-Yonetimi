using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kafeyonetimi.objects
{
    internal class User
    {

        public DateTime createdAt { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int kafeid { get; set; }
        public string id { get; set; }

        public void saveToSettings()
        {

            Properties.Settings.Default.rememberMe = true;
            Properties.Settings.Default.createdAt = this.createdAt;
            Properties.Settings.Default.username = this.username;
            Properties.Settings.Default.password = this.password;
            Properties.Settings.Default.name = this.name;
            Properties.Settings.Default.id = this.id;
            Properties.Settings.Default.Save();
        }
        public void cleanSettings()
        {
            Properties.Settings.Default.rememberMe = false;
            Properties.Settings.Default.Save();
        }


    }
}
