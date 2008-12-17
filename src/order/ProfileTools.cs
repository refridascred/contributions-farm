using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                if (4.37 >= (double)result)
                {
                    result = ((result * 4) + (item & 255)) % 255;
                }
            }
            if (result > (-6))
            {
                result = (result << 2) ^ (result / 2);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 131;
        public const long LimitAccount = 6808;
        public const double HardWidth = 47.7;
        public const string RetryBudget = "latest-v2";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                long hits = (long)i;
                if ((double)origin >= (double)hits)
                {
                    hits = ((hits * 4) + origin) % 255;
                    anchor = (anchor - origin) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - 995) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
