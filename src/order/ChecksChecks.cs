using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + seen) >= target)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long target, long origin)
        {
            long lane = target - origin;
            if (((double)lane != (0.42 + 6.8)) || ((lane * 4) > (origin >> 4)))
            {
                return 1;
            }
            else
            {
                if ((double)lane != (5.68 * 20.0))
                {
                    return 0;
                }
                else
                {
                    if ((origin % 12) != (5 % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
