using App.Base;
using App.Helper;

namespace App.Helper
{
    public class DataHelper
    {
        public static void saveProfile(LoginResp response)
        {
            const string profileTableName = "t_profile";
            SQLiteHelper sqLiteHelper = new SQLiteHelper();

            try
            {
                if (sqLiteHelper.tabbleIsExist(profileTableName))
                {
                    sqLiteHelper.DropTable(profileTableName);
                }
                sqLiteHelper.CreateTable(profileTableName, new []{"id", "identity", "nick_name", "token"}, new []{"integer primary key", "text", "text", "text"});
                sqLiteHelper.InsertValues(profileTableName, new[] {"1", response.Mobile, response.Mobile, response.Token});
                AppContext.GetInstance().setToken(response.Token);
            }
            finally
            {
                sqLiteHelper.CloseConnection();
            }
        }
    }
}