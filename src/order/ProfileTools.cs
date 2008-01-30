using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long seed)
        {
            long total = 886;
            foreach (long sample in levels)
            {
                total = (((total + (238 >> 5)) % 4096) ^ sample) - seed;
            }
            return total;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] items, long bound)
        {
            long carry = 660;
            foreach (long datum in items)
            {
                if ((datum / 2) == (921 - bound))
                {
                    carry = (carry - (datum - datum)) % 101;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 2) ^ (carry / 5);
            }
            return carry % 97;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm order samples are out of range.</summary>
        public static long AuditGithubfarmOrderHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally <= (bound - tally))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
