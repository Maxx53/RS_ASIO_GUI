using NAudio.Wave.Asio;
using System;
using System.Windows.Forms;

namespace RS_ASIO_GUI
{
    public partial class SettingControl : UserControl
    {
        private Guid[] DevGuids;
        private AsioDriver Driver;

        public SettingControl()
        {
            InitializeComponent();
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            volumeNumeric.Value = volumeTrackBar.Value;
        }

        private void VolumeNumeric_ValueChanged(object sender, EventArgs e)
        {
            volumeTrackBar.Value = (int)volumeNumeric.Value;
        }

        private void DeviceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                Driver.ReleaseComAsioDriver();
                Driver = null;
            }

            //First item is "None" with 0 index
            if (deviceCombo.SelectedIndex > 0)
            {
                var currGuid = DevGuids[deviceCombo.SelectedIndex - 1];
                Driver = AsioDriver.GetAsioDriverByGuid(currGuid);

                //Limiting channel numeric by real channel number
                Driver.GetChannels(out int inputCh, out _);
                channelNumeric.Maximum = inputCh - 1;

                UpdateDriverInfo();
                InfoUpdTimer.Start();
            }
            else
            {
                DriverInfoLabel.Text = "None";
                InfoUpdTimer.Stop();
            }
        }

        private void UpdateDriverInfo()
        {
            if (Driver != null)
            {
                //Buffer size not updating in this instance of Driver. Too Sad.
                Driver.GetBufferSize(out _, out _, out int prefBuff, out _);
                DriverInfoLabel.Text = $"BufferSize {prefBuff}, SampleRate {Driver.GetSampleRate()} Hz";
            }
        }

        internal void PassArrays(string[] devNames, Guid[] devGuids)
        {
            deviceCombo.Items.AddRange(devNames);
            DevGuids = devGuids;
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                Driver.ControlPanel();
            }
        }

        private void InfoUpdTimer_Tick(object sender, EventArgs e)
        {
            UpdateDriverInfo();
        }
    }
}
