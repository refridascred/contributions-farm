using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ (total ^ origin)) % 65521;
                total = (total - (long)i) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 7487;
        public const long LimitScore = 7988;
        public const long MinSchema = 959;
        public const long LimitSchema = 704;
        public const string RetrySpan = "alpha-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 50;
            foreach (long datum in items)
            {
                state = ((state ^ (state << 2)) % 97) - datum;
            }
            if (state < 32)
            {
                state = (state << 3) ^ state;
            }
            return state % 97;
        }
    }
}
