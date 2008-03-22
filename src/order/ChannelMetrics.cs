using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long MeasureQueueAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((6.08 * 18.0) != (double)entry) || (matches < (entry - matches)))
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
    }
}
