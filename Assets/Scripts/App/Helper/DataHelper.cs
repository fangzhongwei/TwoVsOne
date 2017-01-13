using System.IO;
using App.Base;
using App.Helper;
using Google.Protobuf;
using SimpleSQL;
using UnityEngine;

namespace App.Helper
{
    public class DataHelper
    {
        
        private static SimpleSQLManager dbManager;

        private static void init()
        {
            if (dbManager == null)
            {
                dbManager = dbManager = GameObject.FindGameObjectWithTag("appdbmanager").GetComponent<SimpleSQLManager>();
            }
        }

        public static ConfigRaw loadConfig()
        {

            return new ConfigRaw();
        }

        public static void saveProfile(LoginResp response)
        {
            init();
            SessionRow row = new SessionRow();
            row.Id = 1;
            row.Token = response.Token;
            row.Mobile = response.Mobile;
            row.Status = response.Status;
            row.NickName = response.NickName;
            dbManager.Delete(row);
            row.Id = 2;
            dbManager.Delete(row);
            row.Id = 3;
            dbManager.Delete(row);
            row.Id = 4;
            dbManager.Delete(row);
            row.Id = 1;
            dbManager.Insert(row);
        }
        
    }
}