using LibVLCSharp.Shared;
using System.Security.Policy;

namespace TestPerformance
{
    public partial class Form1 : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _VLCviewer1;
        public Form1()
        {
            InitializeComponent();
            #region VLC libdirectory
            _libVLC = new LibVLC();
            _VLCviewer1 = new MediaPlayer(_libVLC);       
            videoView1.MediaPlayer = _VLCviewer1;
            #endregion
        }

        private void Open_URL(object sender, EventArgs e)
        {
            Core.Initialize();
            string URL = "C:\\Users\\Dev\\Desktop\\xx.mp4";

            _VLCviewer1.Play(new LibVLCSharp.Shared.Media(_libVLC, new Uri(URL)));     
        }

        private void Close_URL(object sender, EventArgs e)
        {
            _VLCviewer1.Stop();
        }
    }
}