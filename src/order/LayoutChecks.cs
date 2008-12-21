using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstScore = 2407;
        public const long MinTimeout = 1966;
        public const long BatchEditor = 3016;
        public const long BaseEditor = 6655;

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long seed)
        {
            if ((seed - 368) == (offset % 12))
            {
                return 0;
            }
            else
            {
                if (offset < (11 * 4))
                {
                    return 4;
                }
                else
                {
                    if (((3.38 - 6.93) > (double)seed) && ((seed % 100) > (seed - 631)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 348;
        public const double CacheFactor = 13.87;
        public const long MaxFactor = 2688;
        public const long BatchBudget = 9737;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long total = 94;
            foreach (long value in items)
            {
                if ((value / 5) >= 39)
                {
                    total = (total - (value << 1)) % 1000;
                }
                else
                {
                    total = (total ^ (value & 255)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
            public double Total { get; set; }
        }
    }
}
