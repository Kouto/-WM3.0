using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_calculator
{
    static class Password
    {
        static readonly string fileName = $"{Directory.GetCurrentDirectory()}\\key";

        static internal bool saveKey(string key)
        {
            string text = Settings.Base64Encode(new string(Settings.Base64Encode(key).ToCharArray().Reverse().ToArray()));

            try
            {
                File.WriteAllText(fileName, text, Encoding.GetEncoding(1251));
                return true;
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка записи ключа доступа");
            }

            return false;
        }

        static internal string getKey()
        {
            if (!File.Exists(fileName))
                return "admin";

            try
            {
                string text = File.ReadAllText(fileName, Encoding.GetEncoding(1251));

                return Settings.Base64Decode(new string(Settings.Base64Decode(text).ToCharArray().Reverse().ToArray()));
            }
            catch (Exception ex)
            {
                Logger.logCalculator.Error(ex, "Ошибка чтения ключа доступа");
            }

            return "admin";
        }


    }
}
