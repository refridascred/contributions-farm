using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 1959;
        public const double DefaultBudget = 86.42;
        public const long LimitBatches = 5990;
        public const double BurstBatches = 65.85;

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)841 >= (double)step)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
