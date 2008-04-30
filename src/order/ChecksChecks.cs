using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double weight = 4.1;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight - (span + weight)) + (double)(long)i) + rate;
            }
            return weight + (double)898;
        }
    }
}
