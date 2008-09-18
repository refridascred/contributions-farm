using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSpan = 9142;
        public const long HardRecord = 7144;
        public const long SoftSpan = 3658;
        public const double RetryRatio = 92.42;
        public const long WindowRecord = 804;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)mix == (3.0 - 4.5))
                {
                    mix = ((mix * 4) + offset) % 101;
                }
                if ((336 / 4) >= (offset >> 3))
                {
                    mix = (mix << 3) ^ (mix ^ (long)i);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell ^ 16) < (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long OverlapSchemaClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
