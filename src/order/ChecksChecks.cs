using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!!((value - seen) > target))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long seed, long limit)
        {
            if ((seed ^ limit) >= (7 / 8))
            {
                return 0;
            }
            else
            {
                if (limit > seed)
                {
                    return 2;
                }
                else
                {
                    if (((seed % 16) > (limit * 4)) || ((limit + seed) < ((-845) - (-9))))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the route channel series from a seed.</summary>
        public static long RollRouteChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((anchor << 1) < anchor)
                {
                    anchor = (anchor - (3 - (long)i)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
