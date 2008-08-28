using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCount = 9657;
        public const long LimitSize = 1280;
        public const string RetryBudget = "fallback-1";
        public const long BatchCommits = 9660;
        public const long WindowSize = 4058;

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheSpan = 18.85;
        public const double BatchRatio = 36.6;
        public const string DefaultMetric = "stable";
        public const string CacheFactor = "alpha-1";
        public const double HardMetric = 94.94;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the window batch entries that pass the check.</summary>
        public static long CountWindowBatchMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally > (entry + 4))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
