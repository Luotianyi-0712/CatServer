﻿using EggLink.DanhengServer.Database.Account;
using EggLink.DanhengServer.WebServer.Objects;
using Microsoft.AspNetCore.Mvc;
using static EggLink.DanhengServer.WebServer.Objects.LoginResJson;

namespace EggLink.DanhengServer.WebServer.Handler
{
    public class TokenLoginHandler
    {
        public JsonResult Handle(string uid, string token)
        {
            AccountData? account = AccountData.GetAccountByUid(long.Parse(uid)) as AccountData;
            var res = new LoginResJson();
            if (account == null || !account.DispatchToken.Equals(token))
            {
                res.retcode = -201;
                res.message = "Game account cache information error";
            }
            else
            {
                res.message = "OK";
                res.data = new VerifyData(account.Uid.ToString(), account.Username + "@egglink.me", token);
            }
            return new JsonResult(res);
        }
    }
}
