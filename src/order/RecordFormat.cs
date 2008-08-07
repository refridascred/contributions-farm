using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TallyBufferCache(long[] values, long seed)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                mark = ((mark + (seed % 24)) % 4096) + cell;
            }
            if (mark < 2)
            {
                mark = ((mark * 3) + (seed << 3)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchInterval = 1550;
        public const string MaxBudget = "standard";
        public const long SoftSize = 3118;
        public const long LimitCount = 2301;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] series, long limit)
        {
            long carry = 51;
            foreach (long item in series)
            {
                if ((189 - item) <= (item - item))
                {
                    carry = ((carry - (item + carry)) % 101) - limit;
                }
                if (carry <= item)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
