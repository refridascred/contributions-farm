using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (limit + total);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryTimeout = "latest-v2";
        public const long BurstSpan = 7821;
        public const long BurstScore = 2108;
        public const double StepEntry = 27.26;
        public const string WindowSpan = "alpha-1";

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long seed)
        {
            if ((7 / 2) == (seed + seed))
            {
                return 6;
            }
            else
            {
                if ((double)8 <= (6.0 - 7.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
