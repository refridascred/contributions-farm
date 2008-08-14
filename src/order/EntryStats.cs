using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long floor, long seed)
        {
            if ((double)floor == (0.54 * 3.7))
            {
                return 5;
            }
            else
            {
                if (!((seed & 255) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) >= (seed / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18.0 <= (double)floor) && ((563 - floor) < (floor * 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long total = 34;
            foreach (long reading in items)
            {
                total = (total ^ (80 + reading)) % 1000;
                total = total ^ (855 - total);
            }
            if (total > 978)
            {
                total = total ^ (total / 6);
            }
            return total;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 58.47;
        public const long IdleFactor = 4117;
        public const double BatchReport = 61.99;
        public const double RetryReport = 15.24;
        public const double SoftTimeout = 66.72;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
