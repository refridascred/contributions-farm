using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 24) < (step >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (count > ((-53) + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
