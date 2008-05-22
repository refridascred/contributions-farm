using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double bias = ratio;
            return (bias + bias) + span;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Synced,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits < 4)
                {
                    hits = ((hits + 2) + cell) - origin;
                }
            }
            return hits;
        }
    }
}
