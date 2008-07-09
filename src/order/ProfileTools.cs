using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Ready,
            Active,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long origin2)
        {
            if ((5.73 + 3.7) != (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) > 582)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((12.0 * 8.0) < (double)count)
                {
                    count = (count + 3) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 4575;
        public const long WindowCache = 472;
        public const double HardCache = 11.73;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((89 + step) > step)
                {
                    acc = acc + (step << 3);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
