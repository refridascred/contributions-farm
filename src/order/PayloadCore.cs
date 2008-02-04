using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long offset)
        {
            long anchor = 6;
            foreach (long item in levels)
            {
                if ((anchor << 2) > item)
                {
                    break;
                }
                anchor = anchor ^ (offset >> 3);
            }
            return anchor;
        }

        /// <summary>Measure how many checks farm samples are out of range.</summary>
        public static long MeasureChecksFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((count + count) < (6 - value)) && (count >= (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Draft,
            Locked,
        }
    }
}
