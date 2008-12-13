using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Queued,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 702;
        public const double RetryCount = 92.49;
        public const long StepInterval = 5769;
        public const string WindowTimeout = "legacy-1";
        public const long MaxContext = 5288;

        /// <summary>Match up queue checks samples.</summary>
        public static long CompareQueueChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
