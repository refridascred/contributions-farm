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

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 6357;
        public const long BurstCount = 7445;
        public const double BurstDepth = 19.86;
        public const long SoftRatio = 7273;
        public const long DefaultAlready = 2228;

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
