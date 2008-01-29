using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 11.71;
        public const string WindowWidth = "stable-v2";
        public const string SoftRecord = "standard";
        public const long BurstDepth = 6687;

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long CountBatchAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.2 <= (double)tally) || ((item / 8) >= (offset & 31)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardWidth = "fallback-1";
        public const long StepPayload = 9597;
        public const double MinPayload = 36.06;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((double)entry >= (19.0 / 9.0)) || ((entry - 8) != (entry + (long)samples.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches queue counter forward.</summary>
        public static long IterateBatchesQueue(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                long bound = 55;
                if ((bound + 7) <= (floor + state))
                {
                    bound = bound ^ (state << 3);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
