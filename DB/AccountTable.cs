using System.Data;
using Model;

namespace DB{
    public class AccountTable{
        private DataBaseTool dataBaseTool;

        public AccountTable(){
            dataBaseTool = new DataBaseTool();
        }
        public bool CheckAccount(Account account){
            string query = $"SELECT * FROM Account WHERE UserName = '{account.UserName}' AND Password = '{account.Password}'";
            DataTable accountTable = dataBaseTool.GetDataTable(query);
            if(accountTable.Rows.Count == 0) return false;
            
            return true;
        }
    }
}