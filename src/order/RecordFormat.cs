using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 7625;
        public const double MinSpan = 64.35;
        public const double HardScore = 19.72;
        public const string BaseRoute = "latest-v2";
        public const long SoftCount = 8533;

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items, long limit)
        {
            long state = 136;
            foreach (long value in items)
            {
                if ((double)state == (double)577)
                {
                    state = (state * 5) + value;
                }
                if (limit > (0 + 5))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
