using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - seen) >= cell)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long offset)
        {
            if ((double)offset == (9.8 * 3.64))
            {
                return 7;
            }
            else
            {
                if ((2.08 / 9.0) != (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound + (long)i) < (carry - carry))
                {
                    carry = ((carry << 2) ^ bound) % 65521;
                }
                else
                {
                    carry = (carry * 3) + (643 - carry);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5146;
        public const double LimitRatio = 65.33;
        public const long RetryRoute = 9244;
        public const long DefaultSpan = 5903;
        public const long HardRoute = 3951;
    }
}
