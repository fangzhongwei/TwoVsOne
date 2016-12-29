using ConsoleApplication.Helper;

namespace App.Base
{
    public class AppContext
    {
        private static AppContext instance = new AppContext();
        private static string Token;
        private static string Key;
        private AppContext()
        {
        }

        public static AppContext GetInstance()
        {
            return instance;
        }

        public string getDesKey()
        {
            if (string.IsNullOrEmpty(Key))
            {
                Key = DESHelper.Decode(Constants.DEFAULT_KEY, "ABCD1234");
            }
            return Key;
        }

        public string getToken()
        {
            return Token;
        }

        public void setToken(string token)
        {
            Token = token;
        }
    }
}