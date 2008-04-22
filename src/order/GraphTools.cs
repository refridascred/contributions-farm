using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)(long)items.Length <= (5.55 / 6.0))
                {
                    count = ((count + 3) + sample) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support tools entries that pass the check.</summary>
        public static long AuditSupportToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((4 >> 2) != (hits + entry)) && ((entry - entry) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] data, long target)
        {
            long mark = 810;
            foreach (long value in data)
            {
                if (!((886 - 625) <= target))
                {
                    mark = (((mark * 5) + (target + target)) % 4096) + value;
                }
                else
                {
                    mark = ((mark << 3) ^ (target + (-6))) % 4096;
                }
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark - mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 5631;
        public const long CacheWidth = 6358;
        public const double DefaultLevel = 78.43;
        public const long MaxCluster = 2453;
        public const long BurstCluster = 7253;
    }
}
