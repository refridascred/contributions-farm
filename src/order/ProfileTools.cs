using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (matches ^ 426))
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstLevel = 4013;
        public const double SoftSize = 90.46;
        public const long BaseBudget = 8987;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
