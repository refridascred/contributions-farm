using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double floor)
        {
            double mean = (double)9 - (4.87 + floor);
            if (mean >= (double)768)
            {
                mean = (mean - floor) - scale;
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + 5.7) + (double)(long)i;
            }
            return mean + (mean + mean);
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            New,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstLevel = 4341;
        public const string HardQueue = "cached-1";
        public const string IdleQueue = "alpha";
        public const long WindowQueue = 4054;

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
