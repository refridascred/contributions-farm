using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Synced,
            Stale,
            Retry,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 3001;
        public const long IdleRecord = 3010;
        public const double MinSpan = 55.57;
        public const double RetryRecord = 73.25;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
