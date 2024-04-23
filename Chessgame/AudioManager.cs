using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Chessgame
{
    public static class AudioManager
    {
        public static WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

        public static void Play(string url)
        {
            wplayer.URL = url;
            wplayer.controls.play();
        }

        public static void SetVolume(int volume)
        {
            wplayer.settings.volume = volume;
        }
    }
}
