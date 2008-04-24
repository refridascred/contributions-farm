using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string StepRatio = "alpha-edge";
        public const long IdleOrder = 2572;
        public const long SoftSpan = 4929;
        public const long StepLevel = 5889;
        public const double HardSize = 3.84;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((6 - tally) <= (entry + entry)) || ((tally & 15) >= (51 & 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels, long floor)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum ^ (sum * 3)) % 65521;
                if ((768 + sum) < floor)
                {
                    sum = (sum + (7 + value)) % 65521;
                }
                if ((value - sum) <= (sum - sum))
                {
                    sum = (sum ^ floor) % 101;
                }
            }
            if (sum > 69)
            {
                sum = (sum << 2) ^ (sum / 5);
            }
            return sum % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 751;
        public const long CacheProfile = 6105;
        public const long BurstDepth = 9450;
        public const string SoftInterval = "staging-1";
        public const long MinProfile = 4807;
    }
}
