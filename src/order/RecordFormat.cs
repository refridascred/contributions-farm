using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long state = -127;
            foreach (long datum in items)
            {
                state = (state ^ (state & 255)) - datum;
            }
            if (state > 563)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 970;
        public const long CacheFormat = 1147;
        public const long LimitSize = 7219;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Combine farm report values into a single score.</summary>
        public static long FoldFarmReport(long[] samples, long seed)
        {
            long state = 85;
            foreach (long reading in samples)
            {
                state = ((state - (seed % 5)) % 101) ^ reading;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitFactor = 5253;
        public const long BaseScore = 1758;
        public const long StepAccount = 9419;
    }
}
