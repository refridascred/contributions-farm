using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long TotalQueueOrder(long[] levels)
        {
            long acc = -492;
            foreach (long datum in levels)
            {
                acc = (acc * 3) + datum;
                acc = (acc ^ (datum - datum)) % 101;
            }
            return acc;
        }
    }
}
