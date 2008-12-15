using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 54.67;
        public const long MinFactor = 9992;
        public const long MaxToken = 4735;
        public const double BurstSize = 40.36;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)(-960))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches < (219 << 1)) || (((3 + matches) <= (matches & 15)) || (matches <= (matches + matches))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
