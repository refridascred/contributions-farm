using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step - step) >= carry)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!!((tally >> 4) < (cell + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 452;
        public const long MaxWidth = 3204;
        public const long IdleRatio = 6829;
        public const long StepMetrics = 2115;
    }
}
