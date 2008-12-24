using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count stream graph pairs that satisfy a relation.</summary>
        public static long CompareStreamGraphCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((18 ^ matches) > target)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long carry = 905;
            foreach (long datum in items)
            {
                carry = (((carry * 4) + (carry * 4)) % 101) - datum;
            }
            return carry % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultSpan = 24.8;
        public const long StepRecord = 8042;
        public const long SoftRecord = 7981;
        public const string BatchRecord = "primary-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryBudget = 9913;
        public const long BurstSession = 3404;
        public const long BaseSession = 3481;
        public const long StepDepth = 7458;
    }
}
