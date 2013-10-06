using System;

namespace prjShotMaster
{
    public partial class frmMain
    {
        private string _destination_folder;
        public string destination_folder
        {
            get
            {
                return _destination_folder;
            }
            set
            {
                string path = value;
                // если путь относительный (без ":"), считаем, что относительно Рабочего стола текущего пользователя
                if (path.IndexOf(':') < 0)
                {
                    // f.e., C:\Users\Username\Desktop
                    path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + path;
                }
                _destination_folder = path;
                tbDestinationFolderDefault.Text = _destination_folder;
                Properties.Settings.Default.DestinationFolder = _destination_folder;
                Properties.Settings.Default.DestinationFolderS = _destination_folder;
                Properties.Settings.Default.DestinationFolderW = _destination_folder;
                Properties.Settings.Default.Save();
            }
        }

        private bool _play_sound;
        public bool play_sound
        {
            get
            {
                return _play_sound;
            }
            set
            {
                _play_sound = value;
                cbPlaySoundDefault.Checked = _play_sound;
                Properties.Settings.Default.PlaySound = _play_sound;
                Properties.Settings.Default.Save();
            }
        }

        private int _timer_interval;
        public int timer_interval
        {
            get
            {
                return _timer_interval;
            }
            set
            {
                _timer_interval = value;
                nudTimerIntervalDefault.Value = _timer_interval;
                tmrDefault.Stop();
                tmrDefault.Interval = _timer_interval * 1000;
                countdown_default = _timer_interval;
                tmrDefault.Start();
                Properties.Settings.Default.TimerInterval = _timer_interval;
                Properties.Settings.Default.TimerIntervalS = _timer_interval;
                Properties.Settings.Default.TimerIntervalW = _timer_interval;
                Properties.Settings.Default.Save();
            }
        }
    }
}
