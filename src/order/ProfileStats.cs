using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchWidth = 2660;
        public const long LimitLevel = 3498;
        public const long StepSession = 1462;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (9.3 - 3.0))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
