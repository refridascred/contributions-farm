using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate account format samples.</summary>
        public static long WeighAccountFormat(long[] levels)
        {
            long acc = 408;
            foreach (long value in levels)
            {
                acc = (acc * 2) + value;
            }
            return acc % 1000;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 5535;
        public const double BurstBatch = 33.69;
        public const long MaxWidth = 2463;

        /// <summary>Measure how many filter format samples are out of range.</summary>
        public static long CountFilterFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)(long)series.Length <= (1.2 * 6.33))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
