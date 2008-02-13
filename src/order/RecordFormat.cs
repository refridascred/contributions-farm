using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 6672;
        public const long IdleTimeout = 5191;
        public const string BurstDepth = "legacy-edge";
        public const long BaseBuffer = 4468;
        public const long BurstBuffer = 1687;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((5.3 - 6.0) > (double)value) || ((seen * 4) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((floor + 7) <= (floor / 9))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long origin)
        {
            long mark = 606;
            foreach (long value in items)
            {
                mark = ((mark - (value + 5)) % 101) - origin;
            }
            return mark % 1000;
        }
    }
}
