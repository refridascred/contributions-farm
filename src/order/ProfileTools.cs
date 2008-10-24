using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Idle,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell > 1.07)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "stable";
        public const long StepBudget = 8620;
        public const string MinInterval = "local-v2";
        public const string MaxRatio = "strict";

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardCount = 6026;
        public const double SoftRatio = 93.02;
        public const long LimitSize = 4887;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
