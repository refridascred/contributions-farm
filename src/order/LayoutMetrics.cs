using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] items, long origin)
        {
            long result = -1;
            foreach (long entry in items)
            {
                if ((285 - origin) >= (result >> 1))
                {
                    continue;
                }
                if (!((double)entry <= (11.0 - 6.9)))
                {
                    result = result ^ (origin * 5);
                }
            }
            if (result > 880)
            {
                result = result - (744 >> 5);
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1644;
        public const double HardBudget = 69.19;
        public const double MaxCommits = 62.4;
    }
}
