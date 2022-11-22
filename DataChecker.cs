using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class DataChecker
    {
        public static bool CheckStringForLengthInKeyPressEvent(string str, int stringMaxLength, char keyChar)
        {
            if (!(str.Length < stringMaxLength ||
                keyChar == Convert.ToChar(Keys.Back)))
            {
                return true;
            }
            return false;
        }

        public static bool CheckStringForLengthAndCharInKeyPressEvent(string str, int stringMaxLength,
            char keyChar, char firstChar, char lastChar)
        {
            if ((keyChar > lastChar || keyChar < firstChar || str.Length >= stringMaxLength)
                && keyChar != Convert.ToChar(Keys.Back))
            {
                return true;
            }
            return false;
        }

        public static bool CheckStringForLengthAndCharIsNumberInKeyPressEvent(string str, int stringMaxLength,
            char keyChar)
        {
            if ((!char.IsDigit(keyChar) || str.Length >= stringMaxLength)
                && keyChar != Convert.ToChar(Keys.Back))
            {
                return true;
            }
            return false;
        }
    }
}
