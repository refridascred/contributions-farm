using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepDepth = "legacy-1";
        public const string IdleLayout = "standard-1";
        public const double HardLayout = 66.29;
        public const long CacheLayout = 9247;

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 8717;
        public const double StepOrder = 65.32;
        public const double BatchOrder = 41.83;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels, long limit)
        {
            long mark = 72;
            foreach (long sample in levels)
            {
                if ((9 & 7) == (limit * 4))
                {
                    mark = (mark << 2) ^ (mark ^ sample);
                }
            }
            return mark;
        }
    }
}
