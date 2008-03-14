using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of command githubfarm readings.</summary>
        public static long CompareCommandGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowRatio = "staging-edge";
        public const string StepStats = "local-edge";
        public const long DefaultStats = 5043;

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitBudget = 5658;
        public const double MinFactor = 7.44;
        public const string CacheAccount = "stable";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
