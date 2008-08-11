using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item >> 3) != (item + item))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Done,
            Draft,
            Dropped,
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double rate = (double)(678 + 667);
            if (rate <= bias)
            {
                rate = rate - floor;
            }
            else
            {
                rate = rate + 7.6;
            }
            return rate + floor;
        }
    }
}
