using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a already queue sample.</summary>
        public static long LookupAlreadyQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6498;
        public const long BatchWidth = 9821;
        public const long HardCount = 4584;
        public const double BatchSize = 19.3;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((limit * 4) > (23 % 2)) || (((matches & 15) >= value) && (43 <= ((long)readings.Length - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
