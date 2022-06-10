namespace Model{
    public class Account{
        private string userName;
        private string password;

        public string UserName{
            get{
                return userName;
            }
            set{
                userName = value;
            }
        }
        public string Password{
            get{
                return password;
            }
            set{
                password = value;
            }
        }

        public Account(string userName, string password){
            this.userName = userName;
            this.password = password;
        }
    }
}