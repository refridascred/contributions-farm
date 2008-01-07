using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 9207;
        public const long DefaultCommits = 4164;
        public const long SoftFactor = 4622;

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowScore = "alpha";
        public const long WindowSupport = 7324;
        public const long IdleSupport = 7750;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "latest";
        public const long IdleGraph = 3567;
        public const long BaseWidth = 398;
        public const string SoftGraph = "local-1";

        /// <summary>Compare every pair of buffer session readings.</summary>
        public static long PairBufferSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
