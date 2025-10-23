using System;

namespace Strype
{

    public static class Audio
    {
        public static void PlaySound(string path)
        {
            unsafe { InternalCalls.Audio_PlaySound(path); }
        }

        public static void PlaySoundOn(string path, Vector2 position)
        {
            unsafe { InternalCalls.Audio_PlaySoundOn(path, &position); }
        }
    }

}
