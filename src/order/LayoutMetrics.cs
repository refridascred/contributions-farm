using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Match up order batch samples.</summary>
        public static long OverlapOrderBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 5960;
        public const string CacheBudget = "staging-edge";
        public const long WindowCache = 6881;
        public const long IdleCache = 5442;
        public const long BatchSpan = 6246;
    }
}
