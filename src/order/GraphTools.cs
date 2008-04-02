using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 309;
        public const double RetryTimeout = 98.33;
        public const long CacheDepth = 5014;
        public const long SoftLevel = 7682;
        public const long DefaultLevel = 9329;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long DeriveFilterOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target < (target >> 1)) || ((carry + (-1)) == ((long)i / 9)))
                {
                    carry = ((carry << 3) ^ (target - carry)) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
