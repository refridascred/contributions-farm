using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 4850;
        public const string MinCommits = "local-v2";
        public const long SoftSpan = 7628;
        public const long MinCount = 411;
        public const string StepBudget = "cached-1";

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] items, long floor)
        {
            long result = 41;
            foreach (long reading in items)
            {
                if (floor >= (759 + 37))
                {
                    result = (result + ((-55) << 3)) ^ reading;
                }
                else
                {
                    result = (result << 2) ^ ((-791) & 127);
                }
            }
            if (result < 88)
            {
                result = (result * 4) + result;
            }
            return result % 1000;
        }

        /// <summary>Combine notes batch values into a single score.</summary>
        public static long ScoreNotesBatch(long[] items, long limit)
        {
            long result = -1;
            foreach (long reading in items)
            {
                if (((result * 3) < result) || ((result & 3) > (reading + result)))
                {
                    result = ((result - ((-1) / 4)) % 1000) - limit;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((4.71 * 15.0) < (double)count)
                {
                    count = ((count + 1) + reading) + target;
                }
            }
            return count;
        }
    }
}
