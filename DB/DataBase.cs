namespace DB{
    public class DataBase{
        private DataBaseTool dataBaseTool;

        public DataBase(){
            dataBaseTool = new DataBaseTool();
        }
        public void Init(){
            string query = "CREATE DATABASE musicapp";
            dataBaseTool.ExcuteQueryNonDB(query);

            query = "CREATE TABLE Account("
                    + "Id INT AUTO_INCREMENT PRIMARY KEY,"
                    + "UserName VARCHAR(255),"
                    + "Password VARCHAR(255)"
                + ")";
            dataBaseTool.ExcuteQuery(query);

            query = "INSERT INTO Account(UserName, Password) VALUES('Admin', 'Admin');"
                    + "INSERT INTO Account(UserName, Password) VALUES('abc', 'abc');";
            dataBaseTool.ExcuteQuery(query);
        }
        public void Drop(){
            string query = "DROP DATABASE musicapp";
            dataBaseTool.ExcuteQuery(query);
        }
    }
}