using System.IO;
using App.Base;
using App.Helper;
using Google.Protobuf;
using UnityEngine;

namespace App.Helper
{
    public class DataHelper
    {
        public static void saveProfile(LoginResp response)
        {
            Stream sw = null;

            try
            {
                byte[] bytes = response.ToByteArray();
                int length = bytes.Length;

                FileInfo file = new FileInfo(getDataFilePath() + "//" + "s.dat");
                if (! file.Exists)
                {
                    sw = file.Create();
                }
                else
                {
                    sw = file.Open(FileMode.CreateNew);
                }
                sw.Write(bytes, 0, length);
                sw.Flush();
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        private static string getDataFilePath()
        {
            //不同平台下StreamingAssets的路径是不同的，这里需要注意一下。
            string PathURL =
                #if UNITY_ANDROID   //安卓
                    "jar:file://" + Application.dataPath + "!/assets/";
                #elif UNITY_IPHONE  //iPhone
                    Application.dataPath + "/Raw/";
                #elif UNITY_STANDALONE_WIN || UNITY_EDITOR  //windows平台和web平台
                    "file://" + Application.dataPath + "/StreamingAssets/";
                #else
                    string.Empty;
                #endif

            return PathURL;
        }
    }
}