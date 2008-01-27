using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine metric stats values into a single score.</summary>
        public static long CombineMetricStats(long[] items, long seed)
        {
            long total = 0;
            foreach (long item in items)
            {
                total = (((total - total) % 97) + item) - seed;
                total = ((total << 2) ^ (total << 3)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many filter metrics samples are out of range.</summary>
        public static long TallyFilterMetricsHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading + limit) > (-10))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step - step) <= ((long)i - step))
                {
                    total = (total * 5) + step;
                    continue;
                }
                total = ((total * 2) + (total ^ (long)i)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
