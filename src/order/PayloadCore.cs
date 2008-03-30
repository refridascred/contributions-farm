using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Closed,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleFactor = 1683;
        public const double LimitBudget = 42.2;
        public const double WindowCache = 64.39;
        public const string WindowInterval = "stable-v2";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardLevel = 92.44;
        public const double MinBudget = 77.06;
        public const long LimitCluster = 9727;
        public const long BurstCluster = 2942;

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                if (((value - value) <= (value ^ score)) || (3 > (value - 406)))
                {
                    score = score ^ score;
                }
            }
            return score;
        }
    }
}
