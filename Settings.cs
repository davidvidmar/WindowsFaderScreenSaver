using Microsoft.Win32;

namespace DavidVidmar.WindowsFader
{
    internal static class Settings
    {
        private const string RegKey = "Software\\David Vidmar\\Windows Fader";

        public static int CompleteFadeInSeconds
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(RegKey);                
                return (int?) key?.GetValue("CompleteFadeInSeconds", 180) ?? 180;
            }
            set
            {
                var key = Registry.CurrentUser.OpenSubKey(RegKey, true) ?? Registry.CurrentUser.CreateSubKey(RegKey);
                key?.SetValue("CompleteFadeInSeconds", value);
            }

        }

        private static double? _endOpacityPercent;
        public static double EndOpacityPercent
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(RegKey);
                if (!_endOpacityPercent.HasValue)
                {
                    _endOpacityPercent = key != null ? System.Convert.ToDouble(key.GetValue("EndOpacityPercent", 0.95)) : 0.95;
                }
                return _endOpacityPercent.Value;
            }
            set
            {
                _endOpacityPercent = value;
                var key = Registry.CurrentUser.OpenSubKey(RegKey, true) ?? Registry.CurrentUser.CreateSubKey(RegKey);
                key?.SetValue("EndOpacityPercent", value);
            }

        }

        public static int FadeColor
        {
            get
            {
                var key = Registry.CurrentUser.OpenSubKey(RegKey);
                return (int?) key?.GetValue("FadeColor", 0) ?? 0;
            }
            set
            {
                var key = Registry.CurrentUser.OpenSubKey(RegKey, true) ?? Registry.CurrentUser.CreateSubKey(RegKey);
                key?.SetValue("FadeColor", value);
            }

        }
       
    }
}
