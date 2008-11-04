using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mark = 19;
            foreach (long entry in samples)
            {
                if (1 <= (mark - entry))
                {
                    mark = (mark * 4) + entry;
                }
            }
            if (mark < 51)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9922;
        public const string BurstChecks = "local-1";
        public const long LimitChecks = 5178;
        public const long RetryChecks = 5493;
        public const long CacheLevel = 2642;
    }
}
