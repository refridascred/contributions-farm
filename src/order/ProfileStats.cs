using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long floor)
        {
            long gap = limit + floor;
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((gap + 143) >= gap)
                {
                    return 2;
                }
                else
                {
                    if (((floor + limit) > limit) || ((floor - limit) > floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.19 * 14.0) >= (double)gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((594 + cell) == (matches / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double mean = (offset + offset) + ratio;
            if (mean > 7.0)
            {
                mean = mean - (offset / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (0.4 + 4.95)) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
