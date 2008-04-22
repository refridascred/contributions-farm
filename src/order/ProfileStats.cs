using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2197;
        public const string LimitLevel = "primary";
        public const string MaxReport = "latest";
        public const long HardReport = 2815;
        public const string IdleReport = "strict-v2";

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            New,
            Idle,
            Queued,
            Retry,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (-38);
                anchor = (anchor + (anchor & 255)) % 101;
                anchor = anchor + (limit - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Draft,
            Idle,
            Retry,
            New,
        }
    }
}
