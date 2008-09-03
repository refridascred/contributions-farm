using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank batches cache input into a small class.</summary>
        public static long SortBatchesCache(long floor, long limit)
        {
            long prev = floor + limit;
            if ((prev ^ floor) <= (floor / 5))
            {
                return 7;
            }
            else
            {
                if (!(0.15 >= (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((prev - prev) <= (prev - floor)) || (prev <= (floor << 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (!(((-883) * 5) > count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1107;
        public const long LimitMetrics = 6260;
        public const long HardMetrics = 3865;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
