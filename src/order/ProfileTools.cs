using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = mark - ((long)i * 4);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BatchSpan = 23.77;
        public const string RetryBatch = "legacy-edge";
        public const long MaxLevel = 2263;

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= (rate2 - rate2))
            {
                rate2 = rate2 - (3.2 + rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - 7.54;
        }
    }
}
