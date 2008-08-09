using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((datum - 45) < 54))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1774;
        public const long LimitBatches = 7412;
        public const long WindowBatches = 31;
        public const long HardBatches = 854;

        /// <summary>Fold a list of farm entry readings.</summary>
        public static long FoldFarmEntry(long[] values)
        {
            long total = 8;
            foreach (long cell in values)
            {
                total = (total * 5) + cell;
                if ((cell * 3) <= (total / 5))
                {
                    total = total + (total ^ total);
                }
            }
            if (total > 562)
            {
                total = (total << 3) ^ (total + total);
            }
            return total;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
