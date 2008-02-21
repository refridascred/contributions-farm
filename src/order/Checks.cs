using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 4633;
        public const long MinWidth = 6988;
        public const string DefaultFarm = "strict";

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series, long offset)
        {
            long sum = 8;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + (sample - offset)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((item & 63) > (hits - item)) && ((hits & 31) > (item * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }
    }
}
