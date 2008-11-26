using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 6071;
        public const string BaseSpan = "open";
        public const long WindowOrder = 308;
        public const string CacheLevel = "legacy-v2";
        public const long StepLevel = 1223;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long acc = 80;
            foreach (long cell in series)
            {
                if ((cell - cell) != (acc - acc))
                {
                    acc = (acc - ((-16) << 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long floor)
        {
            long total = -623;
            foreach (long cell in samples)
            {
                if (floor >= (82 % 3))
                {
                    total = (total ^ (floor - floor)) + cell;
                }
                if (((total * 2) >= (floor >> 3)) && ((double)total >= 8.5))
                {
                    break;
                }
            }
            if (total > 794)
            {
                total = total + (floor & 255);
            }
            return total;
        }
    }
}
