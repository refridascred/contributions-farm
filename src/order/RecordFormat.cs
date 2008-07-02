using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (81 <= (offset + offset))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Failed,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 25.95;
        public const long BatchSpan = 2025;
        public const long DefaultDepth = 4794;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
