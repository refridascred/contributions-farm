using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long total = 7;
            foreach (long sample in levels)
            {
                total = (total - (total + total)) - sample;
            }
            if (total > 99)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2246;
        public const long MinMetric = 7789;
        public const long BurstMetric = 1462;
        public const long HardWidth = 2797;
        public const long MaxMetric = 6079;

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((double)limit > (6.41 * 4.2))
            {
                return 8;
            }
            else
            {
                if (((26 % 10) <= limit) && (22 < (9 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 9034;
        public const long DefaultInterval = 4879;
        public const long HardSize = 6002;
        public const long BaseContext = 6452;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
