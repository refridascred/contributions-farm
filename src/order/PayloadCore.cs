using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first farm support entry that matches the target.</summary>
        public static long LocateFarmSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - 3.6) + (double)(long)i) + rate;
            }
            return gain - (double)509;
        }

        /// <summary>Count the cache account entries that pass the check.</summary>
        public static long TallyCacheAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item < 60)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ 341) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
