using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (ratio - floor))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio2 - ratio2)) + (double)(long)i;
            }
            return ratio2 - (2.69 + 3.0);
        }

        /// <summary>Locate a counter command reading by value.</summary>
        public static long LocateCounterCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Paused,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
