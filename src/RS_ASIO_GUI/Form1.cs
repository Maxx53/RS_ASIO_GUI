using NAudio.Wave;
using NAudio.Wave.Asio;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RS_ASIO_GUI
{
    public partial class Form1 : Form
    {
        readonly IniFile RSIni = new IniFile(@"./RS_ASIO.ini");

        //Hints for buffersize mode setting
        readonly string[] buffInfo =      {    "respect buffer size setting set in the driver",
                                               "use a buffer size as close as possible as that requested by the host application",
                                               "use the buffer size specified in CustomBufferSize field"
                                          };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Getting ASIO device list from registry
            //Also you can return one object such array of tuple or keyvalue but it complicate further work
            RegHelper.GetAsioDevices(out string[] devNames, out Guid[] devGuids);

            //Hiding channel from OutputControl, there's no such setting
            OutputControl.Controls["channelPanel"].Visible = false;

            //Filling up device combos for all usercontrols
            OutputControl.PassArrays(devNames, devGuids);
            Input0Control.PassArrays(devNames, devGuids);
            Input1Control.PassArrays(devNames, devGuids);

            ReadSettings();
        }

        private void ReadSettings()
        {
            //Reading values to checkboxes
            wasapiCheck.Checked = RSIni.Read("EnableWasapi", "Config") == "1";
            asioCheck.Checked = RSIni.Read("EnableAsio", "Config") == "1";

            //Reading values to combobox
            bufferModeCombo.SelectedItem = RSIni.Read("BufferSizeMode", "Asio");

            //Reading values to numeric
            decimal.TryParse(RSIni.Read("CustomBufferSize", "Asio"), out decimal buffSize);
            bufferSizeNumeric.Value = buffSize;

            //Reading values to usercontrols
            ReadSettingControl(OutputControl);
            ReadSettingControl(Input0Control);
            ReadSettingControl(Input1Control);
        }

        private void ReadSettingControl(SettingControl setCtrl)
        {
            //Info about section stored in Tag property
            var section = setCtrl.Tag.ToString();

            //Reading values to combobox
            var devName = RSIni.Read("Driver", section);
            (setCtrl.Controls["deviceCombo"] as ComboBox).SelectedItem = devName != string.Empty ? devName : "None";

            //Reading values to checkboxes
            (setCtrl.Controls["enableEndpointCheck"] as CheckBox).Checked = RSIni.Read("EnableSoftwareEndpointVolumeControl", section) == "1";
            (setCtrl.Controls["enableMasterCheck"] as CheckBox).Checked = RSIni.Read("EnableSoftwareMasterVolumeControl", section) == "1";

            //Reading values to numeric
            decimal.TryParse(RSIni.Read("SoftwareMasterVolumePercent", section), out decimal volumePercent);
            (setCtrl.Controls["volumeNumeric"] as NumericUpDown).Value = volumePercent;


            //Exclude reading from Output section, there's no channel setting
            if (section != "Asio.Output")
            {
                decimal.TryParse(RSIni.Read("Channel", section), out decimal channelValue);
                (setCtrl.Controls["channelPanel"].Controls["channelNumeric"] as NumericUpDown).Value = channelValue;
            }
        }

        private void SaveSettings()
        {
            //Saving values from checkboxes
            RSIni.Write("EnableWasapi", wasapiCheck.Checked ? "1" : "0", "Config");
            RSIni.Write("EnableAsio", asioCheck.Checked ? "1" : "0", "Config");

            //Saving values from combobox
            RSIni.Write("BufferSizeMode", bufferModeCombo.Text, "Asio");

            //Saving values from numeric
            RSIni.Write("CustomBufferSize", bufferSizeNumeric.Value.ToString(), "Asio");

            //Saving values from usercontrols
            WriteSettingControl(OutputControl);
            WriteSettingControl(Input0Control);
            WriteSettingControl(Input1Control);
        }


        //Prevent saving with using one channel of one device on different inputs
        private bool CheckChannels()
        {
            var input1Dev = (Input0Control.Controls["deviceCombo"] as ComboBox).Text;
            var input2Dev = (Input1Control.Controls["deviceCombo"] as ComboBox).Text;
            var input1Ch = (Input0Control.Controls["channelPanel"].Controls["channelNumeric"] as NumericUpDown).Value;
            var input2Ch = (Input1Control.Controls["channelPanel"].Controls["channelNumeric"] as NumericUpDown).Value;

            return !((input1Dev == input2Dev) && (input1Ch == input2Ch));
        }

        private void WriteSettingControl(SettingControl setCtrl)
        {
            //Info about section stored in Tag property
            var section = setCtrl.Tag.ToString();

            //Saving values from combobox
            var devName = (setCtrl.Controls["deviceCombo"] as ComboBox).Text;
            RSIni.Write("Driver", devName != "None" ? devName : string.Empty, section);

            //Saving values from checkboxes
            RSIni.Write("EnableSoftwareEndpointVolumeControl", (setCtrl.Controls["enableEndpointCheck"] as CheckBox).Checked ? "1" : "0", section);
            RSIni.Write("EnableSoftwareMasterVolumeControl", (setCtrl.Controls["enableMasterCheck"] as CheckBox).Checked ? "1" : "0", section);

            //Saving values from numeric
            RSIni.Write("SoftwareMasterVolumePercent", (setCtrl.Controls["volumeNumeric"] as NumericUpDown).Value.ToString(), section);

            //Exclude writing to Output section, there's no channel setting
            if (section != "Asio.Output")
                RSIni.Write("Channel", (setCtrl.Controls["channelPanel"].Controls["channelNumeric"] as NumericUpDown).Value.ToString(), section);
        }


        private void BufferModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Adding hint to label on mode selection
            buffInfoLabel.Text = buffInfo[(sender as ComboBox).SelectedIndex];

            //Enabling numeric for Custom mode
            bufferSizeNumeric.Enabled = ((sender as ComboBox).SelectedIndex == 2);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CheckChannels())
            {
                SaveSettings();
                Application.Exit();
            }
            else 
                MessageBox.Show("You have one channel on different inputs. Settings NOT saved!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RunRsButton_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/221680");

            //Saving, closing window
            OkButton_Click(sender, e);
        }
    }
}
