using Microsoft.Win32;
using System;

namespace RS_ASIO_GUI
{
    class RegHelper
    {
        public static void GetAsioDevices(out string[] devNames, out Guid[] devGuids)
        {
            var asioKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default).OpenSubKey(@"Software\ASIO");
            var clsidKey = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Default).OpenSubKey(@"CLSID");

            //Getting device list from HKLM:\Software\ASIO
            var devices = asioKey?.GetSubKeyNames();

            if (devices != null)
            {
                devNames = new string[devices.Length];
                devGuids = new Guid[devices.Length];

                for (int i = 0; i < devices.Length; i++)
                {
                    string devName = null;
                    var devKey = asioKey.OpenSubKey(devices[i]);
                    var clcid = devKey?.GetValue(@"CLSID", null).ToString();

                    //Getting actual device name by CLSID from HKCR:\CLSID
                    if (clcid != null)
                        devName = clsidKey.OpenSubKey(clcid)?.GetValue(string.Empty).ToString();

                    devNames[i] = devName ?? "undefined";
                    devGuids[i] = new Guid(clcid);
                }
            }
            else
            {
                devNames = new string[0];
                devGuids = new Guid[0];
            }
        }
    }
}
