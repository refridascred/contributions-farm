using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long TallyEntryMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((14.0 / 5.0) < (double)matches) && ((double)matches <= (1.7 * 4.87)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long step)
        {
            long mark = 470;
            foreach (long datum in samples)
            {
                mark = ((mark << 3) ^ step) ^ datum;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "stable";
        public const string BurstNotes = "local-edge";
        public const long WindowNotes = 4007;
        public const long WindowLevel = 4923;

        /// <summary>Find the first counter format entry that matches the target.</summary>
        public static long FindCounterFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next queue command value from a seed.</summary>
        public static long DeriveQueueCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                long edge = carry;
                carry = ((carry << 3) ^ (floor ^ edge)) % 65521;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
