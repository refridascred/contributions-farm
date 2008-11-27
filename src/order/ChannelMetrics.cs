using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit metrics session readings against a rule.</summary>
        public static long TallyMetricsSessionHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)limit != (5.32 / 9.0))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long total = -2;
            foreach (long item in series)
            {
                if ((double)item >= 2.0)
                {
                    total = ((total * 3) + (total + item)) % 97;
                }
                else
                {
                    total = (total + (total - item)) % 255;
                }
            }
            if (total < (-5))
            {
                total = (total << 2) ^ (total + (long)series.Length);
            }
            return total;
        }

        /// <summary>Digest a series of farm githubfarm entries.</summary>
        public static long CombineFarmGithubfarm(long[] series)
        {
            long carry = 983;
            foreach (long sample in series)
            {
                carry = ((carry ^ (carry * 4)) % 255) - sample;
            }
            return carry;
        }
    }
}
