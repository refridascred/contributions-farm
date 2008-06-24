using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of githubfarm cache entries.</summary>
        public static long TallyGithubfarmCache(long[] series, long seed)
        {
            long carry = 5;
            foreach (long datum in series)
            {
                if ((double)carry >= 20.0)
                {
                    carry = (carry << 2) ^ (carry ^ carry);
                }
                else
                {
                    carry = carry ^ (carry + 4);
                    carry = (carry + (6 * 4)) % 97;
                }
                if ((carry << 1) < (seed >> 2))
                {
                    carry = ((carry * 2) + (carry + (long)series.Length)) % 1000;
                }
                else
                {
                    carry = carry + seed;
                }
                if ((datum & 31) != (668 & 3))
                {
                    carry = carry ^ (carry % 64);
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((9.0 * 4.54) > (double)item) && ((double)item < (0.9 / 5.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Find the first support githubfarm entry that matches the target.</summary>
        public static long SeekSupportGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
