using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double bias2 = offset + (double)94;
            if (bias2 < (bias / 9.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 - (double)46;
            }
            return bias2 + (bias / 9.0);
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample < (634 % 100))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen >> 1) > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Dropped,
            Active,
            Retry,
            Draft,
        }
    }
}
