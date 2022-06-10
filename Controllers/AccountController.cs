using System;
using Microsoft.AspNetCore.Mvc;
using Model;
using DB;

namespace Controllers
{
    [Route("[Controller]")]
    public class AccountController : Controller{
        private AccountTable accountTable;

        public AccountController(){
            accountTable = new AccountTable();
        }

        [Route("CheckAccount")]
        [HttpPost]
        public IActionResult CheckAccount(string userName, string password){
            Account account = new Account(userName, password);
            bool result = accountTable.CheckAccount(account);
            
            return Json(new {
                result = result
            });
        }
    }
}