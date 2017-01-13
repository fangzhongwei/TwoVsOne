using System.Collections.Generic;
using App.Base;
using Google.Protobuf.Collections;
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
                dbManager = GameObject.FindGameObjectWithTag("appdbmanager").GetComponent<SimpleSQLManager>();
            }
        }

        public static ConfigRaw loadConfig()
        {
            init();
            ConfigRaw configRaw;
            List<ConfigRaw> configRaws = dbManager.Query<ConfigRaw>("SELECT * FROM ConfigRaw WHERE Id = 1");

            if (configRaws == null || configRaws.Count == 0)
            {
                configRaw = saveDefaultConfig();
            }
            else
            {
                configRaw = configRaws[0];
            }
            return configRaw;
        }

        public static ConfigRaw saveDefaultConfig()
        {
            ConfigRaw configRaw = new ConfigRaw();
            configRaw.Id = 1;
            configRaw.ResourceVersion = 0;
            // todo get systemLanguage
            //SystemLanguage systemLanguage = Application.systemLanguage;
            configRaw.Lan = "zh";
            dbManager.Insert(configRaw);
            AppContext.GetInstance().SetLan(configRaw.Lan);
            return configRaw;
        }

        public static void saveProfile(LoginResp response)
        {
            SessionRow row = new SessionRow();
            row.Id = 1;
            row.Token = response.Token;
            row.Mobile = response.Mobile;
            row.Status = response.Status;
            row.NickName = response.NickName;
            dbManager.Insert(row);
        }

        public static string getDescByCode(string code, string lan)
        {
            SimpleDataTable dt = dbManager.QueryGeneric(string.Format("SELECT Desc FROM ResourceRow WHERE Code = {0} AND Lan = {1}", code, lan));
            List<SimpleDataRow> simpleDataRows = dt.rows;
            if (dt == null || simpleDataRows == null || simpleDataRows.Count == 0)
            {
                return "-";
            }
            return simpleDataRows[0]["Desc"].ToString();
        }

        public static void saveResource(ResourceResp response)
        {
            ConfigRaw configRaw = loadConfig();
            if (response.LatestVersion > configRaw.ResourceVersion)
            {
                dbManager.BeginTransaction();

                dbManager.Execute("UPDATE ConfigRaw SET ResourceVersion = ? WHERE Id = ?", response.LatestVersion, 1);

                Resource r;
                RepeatedField<Resource> list = response.List;
                for (int i = 0; i < list.Count; i++)
                {
                    r = list[i];
                    dbManager.Execute("DELETE FROM ResourceRaw WHERE Code = ? AND Lan = ?", r.Code, r.Lan);
                    dbManager.Insert(new ResourceRaw
                    {
                        Code = r.Code,
                        Lan = r.Lan,
                        Desc = r.Desc
                    });
                }

                dbManager.Commit();
            }
        }
    }
}