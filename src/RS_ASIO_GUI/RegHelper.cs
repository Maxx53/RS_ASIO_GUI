using Microsoft.Win32;

namespace RS_ASIO_GUI
{
    class RegHelper
    {
        public static string[] GetAsioDevices()
        {
            var asioKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"Software\ASIO");
            var clsidKey = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Default).OpenSubKey(@"CLSID");

            //Getting device list from HKLM:\Software\ASIO
            var devices = asioKey?.GetSubKeyNames();

            if (devices != null)
            {
                var result = new string[devices.Length];
                for (int i = 0; i < devices.Length; i++)
                {
                    string devName = null;
                    var devKey = asioKey.OpenSubKey(devices[i]);
                    var clcid = devKey?.GetValue(@"CLSID", null).ToString();

                    //Getting actual device name by CLSID from HKCR:\CLSID
                    if (clcid != null)
                        devName = clsidKey.OpenSubKey(clcid)?.GetValue(string.Empty).ToString();

                    result[i] = devName ?? "undefined";
                }

                return result;
            }
            else
                return new string[0];
        }
    }
}
