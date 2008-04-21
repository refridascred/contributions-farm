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

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] levels, long floor)
        {
            long result = 28;
            foreach (long reading in levels)
            {
                result = ((result * 4) + (62 - floor)) + reading;
            }
            return result % 65521;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitFactor = 5253;
        public const long BaseScore = 1758;
        public const long StepAccount = 9419;
    }
}
