using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window tools series from a seed.</summary>
        public static long SeriesWindowTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - (mix >> 2);
                if ((double)seed >= (5.6 * 8.0))
                {
                    mix = mix + (mix * 2);
                }
                if (((double)seed < 1.18) || ((seed % 60) == (seed - (long)i)))
                {
                    mix = mix ^ seed;
                }
                else
                {
                    mix = (mix + (mix - seed)) % 1000;
                    mix = (mix * 4) + mix;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
