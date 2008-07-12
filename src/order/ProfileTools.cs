using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - (limit / 4)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long mark = 877;
            foreach (long entry in values)
            {
                if ((20.0 - 1.0) == (double)entry)
                {
                    mark = mark - entry;
                }
                else
                {
                    mark = mark ^ entry;
                }
            }
            return mark % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultRatio = 7424;
        public const long SoftMetrics = 9386;
        public const long DefaultMetrics = 1867;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Done,
            Draft,
            New,
            Ready,
            Active,
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long SortMetricRoute(long origin, long target)
        {
            long delta = origin - target;
            if ((origin << 2) <= ((-79) / 2))
            {
                return 6;
            }
            else
            {
                if (((target * 4) > delta) && ((delta & 255) <= 221))
                {
                    return 8;
                }
                else
                {
                    if ((target - 75) >= (origin + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta & 255) == (origin >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
