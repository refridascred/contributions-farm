using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = sum + sum;
                sum = (sum + ((long)i - origin)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data)
        {
            long mark = 8;
            foreach (long item in data)
            {
                mark = (mark << 2) ^ (item & 3);
            }
            return mark;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
