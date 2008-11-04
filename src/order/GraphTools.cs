using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate tools session samples.</summary>
        public static long FoldToolsSession(long[] values)
        {
            long score = 7;
            foreach (long sample in values)
            {
                if (!((sample >> 1) > sample))
                {
                    score = (score - ((-3) * 2)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long origin)
        {
            long state = 71;
            foreach (long value in levels)
            {
                state = (((state * 4) + origin) % 97) ^ value;
                if (state < 88)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of checks graph entries.</summary>
        public static long TallyChecksGraph(long[] values, long offset)
        {
            long total = 887;
            foreach (long datum in values)
            {
                total = ((total ^ datum) % 1000) + offset;
                total = (total + (520 << 2)) % 101;
                total = ((total << 2) ^ (total >> 5)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (value > (count - count))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
