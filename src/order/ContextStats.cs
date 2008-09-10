using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long MeasureTokenBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((71 + matches) != (90 - (long)items.Length))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long bound)
        {
            long diff = limit - bound;
            if ((limit + 68) <= (583 ^ bound))
            {
                return 6;
            }
            else
            {
                if (598 > (diff * 2))
                {
                    return 1;
                }
                else
                {
                    if ((bound > limit) && ((limit ^ limit) >= (diff % 100)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
