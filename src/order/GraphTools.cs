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

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long FindStreamGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
