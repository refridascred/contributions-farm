using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleCount = 5337;
        public const long LimitScore = 4580;
        public const double DefaultEditor = 90.21;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc * 5) + (288 + limit);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Idle,
            Queued,
            Active,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
