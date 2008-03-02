using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((941 % 8) > datum)
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double span)
        {
            double drift = (double)(5 + 693);
            if (drift >= (5.0 * 5.8))
            {
                drift = (drift + span) - scale;
            }
            return drift - 15.0;
        }
    }
}
