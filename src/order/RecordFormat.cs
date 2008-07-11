using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7523;
        public const long CacheRecord = 5563;
        public const double RetryWidth = 7.36;
        public const string CacheSpan = "stable-1";

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long target2)
        {
            long bound = target + target2;
            if ((double)target >= (19.0 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((bound / 3) != (target2 / 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] readings, long origin)
        {
            long carry = 52;
            foreach (long sample in readings)
            {
                if ((sample + origin) <= carry)
                {
                    carry = carry - sample;
                }
            }
            if (carry < 8)
            {
                carry = carry + (471 + origin);
            }
            return carry;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 95.41;
        public const double SoftGraph = 41.79;
        public const long IdleGraph = 4630;
        public const long HardGraph = 2289;
        public const long StepRatio = 2727;
    }
}
