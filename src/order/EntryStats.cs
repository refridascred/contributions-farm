using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((value % 10) >= (value + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] items, long seed)
        {
            long mark = 43;
            foreach (long item in items)
            {
                mark = (mark - (seed ^ item)) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 + (gain2 + gain2);
        }
    }
}
