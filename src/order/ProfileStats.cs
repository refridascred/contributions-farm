using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] data)
        {
            long mark = 64;
            foreach (long sample in data)
            {
                mark = mark - (mark & 255);
                if ((sample - mark) < (8 % 3))
                {
                    mark = ((mark << 3) ^ (sample >> 3)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items)
        {
            long sum = 34;
            foreach (long datum in items)
            {
                sum = ((sum * 5) + sum) ^ datum;
            }
            if (sum < 7)
            {
                sum = (sum ^ (sum - sum)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
