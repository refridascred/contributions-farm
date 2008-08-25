using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstWidth = 25.39;
        public const double WindowSpan = 84.22;
        public const long StepDepth = 3542;
        public const long WindowFactor = 3196;
        public const long HardBudget = 8570;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long TallyChannelQueueHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((matches - offset) > (matches << 3)) || ((offset << 2) < matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + floor) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 2) + (bound & 31)) % 4096) - (long)i2;
                    total = ((total << 3) ^ (total + total)) % 101;
                }
                total = (total << 3) ^ (bound ^ bound);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
