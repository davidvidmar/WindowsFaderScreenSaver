using System.Drawing;
using Microsoft.Win32;

namespace DavidVidmar.WindowsFader
{
    class Settings
    {
        private const string regKey = "Software\\David Vidmar\\Windows Fader";

        public static int CompleteFadeInSeconds
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(regKey);                
                return key != null ? (int)key.GetValue("CompleteFadeInSeconds", 180) : 180;
            }
            set
            {
                var key = Registry.CurrentUser.OpenSubKey(regKey, true) ?? Registry.CurrentUser.CreateSubKey(regKey);
                if (key != null)
                    key.SetValue("CompleteFadeInSeconds", value);
            }

        }

        private static double? endOpacityPercent;
        public static double EndOpacityPercent
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(regKey);
                if (!endOpacityPercent.HasValue)
                {
                    endOpacityPercent = key != null ? System.Convert.ToDouble(key.GetValue("EndOpacityPercent", 0.95)) : 0.95;
                }
                return endOpacityPercent.Value;
            }
            set
            {
                endOpacityPercent = value;
                var key = Registry.CurrentUser.OpenSubKey(regKey, true) ?? Registry.CurrentUser.CreateSubKey(regKey);
                if (key != null) key.SetValue("EndOpacityPercent", value);
            }

        }

        public static int FadeColor
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(regKey);
                return key != null ? (int)key.GetValue("FadeColor", 0) : 0;
            }
            set
            {
                var key = Registry.CurrentUser.OpenSubKey(regKey, true) ?? Registry.CurrentUser.CreateSubKey(regKey);
                if (key != null) key.SetValue("FadeColor", value);
            }

        }
       
    }
}
