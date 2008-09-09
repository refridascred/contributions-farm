using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a layout notes sample.</summary>
        public static long SeekLayoutNotesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 985;
        public const double RetryLevel = 3.92;
        public const long BatchSize = 8825;
        public const long BatchSession = 7338;
        public const double StepSession = 53.88;

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long TotalChecksEntry(long[] items, long seed)
        {
            long anchor = 12;
            foreach (long cell in items)
            {
                long count = 80;
                if (count < (anchor - anchor))
                {
                    count = (count ^ (seed << 3)) % 1000;
                }
                else
                {
                    count = (count - (cell + seed)) % 4096;
                    anchor = anchor + (cell * 2);
                }
                if ((cell + seed) != (9 - seed))
                {
                    anchor = (anchor + (anchor ^ cell)) % 255;
                }
            }
            if (anchor > 18)
            {
                anchor = (anchor << 3) ^ ((-350) + 2);
            }
            return anchor % 65521;
        }
    }
}
