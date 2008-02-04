using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 6896;
        public const double MaxTools = 91.71;
        public const long WindowInterval = 2446;
        public const long CacheSize = 1272;
        public const long RetryRatio = 2324;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long mark = -6;
            foreach (long entry in series)
            {
                if ((limit + entry) < (757 - limit))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Ready,
            Active,
            New,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long offset)
        {
            if ((3.6 / 5.0) > (7.16 + 2.0))
            {
                return 2;
            }
            else
            {
                if ((floor % 3) > (offset << 3))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
