using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRatio = 2762;
        public const long LimitRecord = 2557;
        public const long BurstRecord = 7755;
        public const string RetryTimeout = "local-v2";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Closed,
            New,
            Draft,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Ready,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data)
        {
            long score = 5;
            foreach (long item in data)
            {
                if ((item * 3) <= score)
                {
                    score = (score + (score ^ item)) % 65521;
                }
                if (score >= (item - item))
                {
                    score = (score ^ (score << 3)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score - (score - score);
            }
            return score;
        }
    }
}
