using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((16.0 - 9.27) < (double)cell)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 24.67;
        public const long DefaultBudget = 1439;
        public const double IdleSpan = 35.36;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] readings, long offset)
        {
            long anchor = 602;
            foreach (long cell in readings)
            {
                if (((double)cell < (17.0 + 3.73)) || ((cell - offset) != (anchor << 1)))
                {
                    anchor = anchor + (81 - 2);
                }
            }
            return anchor;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.9 > (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
