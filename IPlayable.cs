using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    class MusicPlayer : IPlayable
    {
        private bool isPlaying;

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing music.");
            }
        }

        public void Pause()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Pausing music.");
            }
        }

        public void Stop()
        {
            isPlaying = false;
            Console.WriteLine("Stopping music.");
        }
    }

    class VideoPlayer : IPlayable
    {
        private bool isPlaying;

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing video.");
            }
        }

        public void Pause()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Pausing video.");
            }
        }

        public void Stop()
        {
            isPlaying = false;
            Console.WriteLine("Stopping video.");
        }
    }
}
