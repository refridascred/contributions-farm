using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell % 24) != (cell - cell))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter command reading by value.</summary>
        public static long LocateCounterCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long DigestBufferContributi(long[] readings, long target)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum << 2) > (datum % 2))
                {
                    sum = (sum ^ 7) % 101;
                }
                else
                {
                    sum = sum - (target + datum);
                }
            }
            if (sum > 4)
            {
                sum = (sum - target) % 255;
            }
            return sum % 1000;
        }
    }
}
