using System.Collections.Generic;

namespace App.Base
{
    public class Constants
    {
        public const string COMMON_DISPATCH_URL = "http://127.0.0.1:9019/v1.0-route";
        public const string DEFAULT_TOKEN = "0";
        public const string VERSION = "1.0.0";
        public const string DEFAULT_KEY = "19B313BB9FD9F9A8A1D0E82590DD77B9";

        public const int CLIENT_ID = 1;

        public const int API_ID_SEND_CODE = 1001;
        public const int API_ID_LOGIN = 1002;
        public const int API_ID_LOGIN_BY_TOKEN = 1003;
        public const int API_LOAD_ALL_RESOURCES = 1006;
        public const int API_PULL_RESOURCES = 1007;
        public const int API_UPDATE_NICKNAME = 1005;

        public const int API_QUERY_DIAMOND_AMOUNT = 2001;
        public const int API_GET_PRICE_LIST = 2002;
        public const int API_GET_CHANNEL_LIST = 2003;
        public const int API_DEPOSIT_REQUEST = 2004;
        public const int API_QUERY_DEPOSIT = 2005;

        public const string EC_UC_NO_MOBILE = "EC_UC_NO_MOBILE";
        public const string EC_UC_NO_CODE = "EC_UC_NO_CODE";
        public const string EC_UC_NO_NICKNAME = "EC_UC_NO_NICKNAME";

        public const string EC_UC_INVALID_MOBILE = "EC_UC_INVALID_MOBILE";
        public const string EC_UC_INVALID_CODE = "EC_UC_INVALID_CODE";
        public const string EC_UC_NICKNAME_TOO_LONG = "EC_UC_NICKNAME_TOO_LONG";

        public const string EC_NETWORK_UNREACHED = "EC_NETWORK_UNREACHED";
        public const string EC_NETWORK_TIMEOUT = "EC_NETWORK_TIMEOUT";
        public const string EC_SERVER_ERROR = "EC_SERVER_ERROR";
        public const string EC_PARSE_DATA_ERROR = "EC_PARSE_DATA_ERROR";

        public const string MSG_CODE_SENDED = "MSG_CODE_SENDED";

        public const string EC_SSO_SESSION_EXPIRED = "EC_SSO_SESSION_EXPIRED";
        public const string EC_SSO_SESSION_REPELLED = "EC_SSO_SESSION_REPELLED";

        public const string EC_GAME_INVALID_DATA = "EC_GAME_INVALID_DATA";

        public static char[] CARDS_SEPERATOR = new char[1]{','};


    }
}