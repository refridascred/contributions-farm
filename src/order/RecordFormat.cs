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

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (tally < (tally / 4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
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
