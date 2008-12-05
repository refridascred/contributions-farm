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

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "standard-1";
        public const long CacheBatch = 8579;
        public const long SoftFactor = 789;
        public const long RetrySpan = 3657;
        public const long SoftRatio = 5366;
    }
}
