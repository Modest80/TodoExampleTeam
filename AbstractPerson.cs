using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TodoExampleTeam {
    public abstract class AbstractPerson {
        private string password;
        public string Name { get; set; }
        public string Position { get; set; }
        public string Password { 
            get { 
                return password;
            } 
            set {
                password = value;
            } 
        }
        public void SetPassword(string password) {
            //this.password = Convert.ToBase64String(Encoding.UTF8.GetBytes(password));

            var md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            string cryptPassword = Encoding.UTF8.GetString(hash);
            this.password = cryptPassword;
        }
    }
}
