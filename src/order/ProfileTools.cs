using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits ^ 1) < (826 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double SmoothCommitsChecks(double scale, double span)
        {
            double gain = scale + (double)781;
            return (gain - (double)93) + span;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long origin)
        {
            long sum = 415;
            foreach (long datum in values)
            {
                sum = (((sum << 3) ^ (sum + datum)) % 255) - origin;
            }
            return sum;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
