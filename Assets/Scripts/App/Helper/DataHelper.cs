using App.Base;
using App.Helper;

namespace App.Helper
{
    public class DataHelper
    {
        public static void saveProfile(LoginResp response)
        {
            DataService dataService = new DataService("app.db");


            try
            {
                dataService.CreateDB();
                Person p = new Person()
                {
                    Id = 1,
                    Identity = response.Mobile,
                    NickName = response.NickName,
                    Token = response.Key
                };
                dataService.CreatePerson(p);
                AppContext.GetInstance().setToken(response.Token);
            }
            finally
            {
                dataService.Close();
            }
        }
    }
}