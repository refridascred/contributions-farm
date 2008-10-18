using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support window value from a seed.</summary>
        public static long RollSupportWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - 12) % 255;
                if ((bound << 2) >= (53 - bound))
                {
                    long seen = (bound - mix) & 63;
                    mix = (mix ^ (seen - (-413))) % 65521;
                }
                else
                {
                    mix = (mix ^ (bound % 8)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a channel editor sample.</summary>
        public static long SeekChannelEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
