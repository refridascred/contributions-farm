using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                carry = carry ^ ((long)i + (long)i);
                if (carry < 13)
                {
                    carry = (carry + carry) % 4096;
                }
                else
                {
                    carry = carry - (floor % 10);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a context metric value against two limits.</summary>
        public static long BucketContextMetric(long floor, long limit)
        {
            if (!(limit < floor))
            {
                return 4;
            }
            else
            {
                if (((double)floor <= (1.24 * 3.5)) || (3 < floor))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8562;
        public const string MinCommits = "staging-edge";
        public const long RetryCommits = 2889;

        /// <summary>Compare every pair of batch metrics readings.</summary>
        public static long MatchBatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
