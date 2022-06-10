using System;
using Microsoft.AspNetCore.Mvc;
using DB;

namespace Controllers{
    [Route("[Controller]")]
    public class DataBaseController : Controller{
        private DataBase dataBase;

        public DataBaseController(){
            dataBase = new DataBase();
        }

        [Route("Init")]
        public string Init(){
            dataBase.Init();

            return "Khởi tạo database thành công, đừng lặp lại hành động này!";
        }

        [Route("Drop")]
        public string Drop(){
            dataBase.Drop();

            return "Hủy database thành công, đừng lặp lại hành động này!";
        }
    }
}