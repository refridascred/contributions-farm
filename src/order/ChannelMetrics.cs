using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate profile filter samples.</summary>
        public static long TotalProfileFilter(long[] data)
        {
            long sum = 16;
            foreach (long value in data)
            {
                sum = (sum - 532) ^ value;
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((count + count) != (reading - 459)) && (904 >= (reading + 6))) || (94 < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
