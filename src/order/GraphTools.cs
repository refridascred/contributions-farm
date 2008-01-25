using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowWidth = 9746;
        public const long RetryAccount = 9171;
        public const string StepFactor = "stable";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((-424) + (long)values.Length) >= (70 - 75))
                {
                    count = ((count + 1) + value) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many command batch samples are out of range.</summary>
        public static long TallyCommandBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) != (entry >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Stale,
            Draft,
        }
    }
}
