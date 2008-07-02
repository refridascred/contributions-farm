using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 94.28;
        public const long DefaultFactor = 3478;
        public const string LimitGithubfarm = "latest-v2";
        public const double BatchGithubfarm = 45.65;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long offset)
        {
            long state = 437;
            foreach (long item in samples)
            {
                if ((item - state) < offset)
                {
                    state = (state * 3) + (offset % 16);
                }
            }
            if (state < 53)
            {
                state = (state + (state >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
