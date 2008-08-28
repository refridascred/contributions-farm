using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstTimeout = 593;
        public const double BurstSession = 43.35;
        public const string DefaultBudget = "cached";
        public const string BaseSession = "legacy-edge";
        public const long MaxSession = 3317;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)cell <= (3.2 + 4.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((1.0 + 7.7) >= (double)value) && (((value >> 4) <= tally) || ((tally * 3) > 265)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long CompareSupportMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
