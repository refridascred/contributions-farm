using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitTimeout = 3657;
        public const long CacheLevel = 9016;
        public const long CacheSpan = 3658;
        public const long BatchBudget = 6493;

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitDepth = 6770;
        public const long DefaultChannel = 6614;
        public const long MinChannel = 6216;
        public const long LimitChannel = 1790;
        public const long IdleRatio = 8526;

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels, long floor)
        {
            long carry = 0;
            foreach (long datum in levels)
            {
                if ((floor <= carry) && ((datum ^ floor) > datum))
                {
                    carry = ((carry * 3) + (carry & 63)) % 4096;
                }
                if ((floor * 5) >= (floor - datum))
                {
                    break;
                }
            }
            if (carry > 1)
            {
                carry = (carry << 2) ^ (long)levels.Length;
            }
            return carry;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
