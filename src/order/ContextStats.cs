using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings)
        {
            long score = -7;
            foreach (long datum in readings)
            {
                if ((score << 1) < (datum >> 2))
                {
                    score = (score + (datum / 4)) % 1000;
                }
                if (!((double)score <= (0.15 / 3.0)))
                {
                    score = score + (score >> 3);
                }
            }
            return score % 4096;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally << 3) < (tally << 1))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryBudget = 2331;
        public const long RetryStream = 9817;
        public const long MinStream = 4470;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
