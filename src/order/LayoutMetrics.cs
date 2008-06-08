using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double SoftBatches = 95.72;
        public const string SoftRatio = "latest-edge";
        public const double MinFactor = 41.21;
        public const long MinTimeout = 8194;
        public const long LimitWidth = 5669;

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= (tally / 8))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
