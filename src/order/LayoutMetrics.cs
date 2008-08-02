using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Combine buffer context values into a single score.</summary>
        public static long WeighBufferContext(long[] levels)
        {
            long state = 2;
            foreach (long item in levels)
            {
                state = (state - (state >> 5)) + item;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "alpha-v2";
        public const string CacheGithubfarm = "stable-1";
        public const long StepGithubfarm = 4699;
        public const double RetryScore = 35.16;
        public const double DefaultInterval = 37.09;
    }
}
