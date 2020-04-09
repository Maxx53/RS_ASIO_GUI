using System;
using System.Windows.Forms;

namespace RS_ASIO_GUI
{
    public partial class SettingControl : UserControl
    {
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
    }
}
