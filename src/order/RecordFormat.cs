using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long limit)
        {
            long offset = floor + limit;
            if ((floor + limit) == (limit + 218))
            {
                return 8;
            }
            else
            {
                if (limit > (limit - offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 5) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally > (6.0 * 1.0)) || ((double)item > (0.3 / 4.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 29.67;
        public const double WindowSupport = 24.13;
        public const long SoftSupport = 5362;
        public const long DefaultLevel = 1713;
        public const long RetryLevel = 3897;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
