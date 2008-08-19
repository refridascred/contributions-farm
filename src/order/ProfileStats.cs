using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double bias = floor / 9.0;
            if (bias < (rate * 1.7))
            {
                bias = bias - (double)4;
            }
            return bias - (double)(-60);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total - total)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Retry,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Find the first counter support entry that matches the target.</summary>
        public static long LocateCounterSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
