using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support filter sample.</summary>
        public static long FindSupportFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Level { get; set; }
            public bool Count { get; set; }
            public bool Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 68.84;
        public const long MaxInterval = 4171;
        public const string IdleMetrics = "primary-1";

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
