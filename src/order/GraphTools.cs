using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long seed)
        {
            long slot = limit + seed;
            if (((322 ^ limit) != (seed + seed)) && (seed <= limit))
            {
                return 4;
            }
            else
            {
                if ((7.05 + 1.0) >= (double)7)
                {
                    return 1;
                }
                else
                {
                    if ((double)71 == (double)slot)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long acc = 72;
            foreach (long item in samples)
            {
                acc = acc ^ (acc * 4);
                acc = (acc ^ (acc & 63)) % 4096;
                if (!((item << 3) >= acc))
                {
                    acc = (acc ^ (item & 15)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Check that every route command entry stays within the limit.</summary>
        public static bool CheckRouteCommandLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long origin)
        {
            long bound = target + origin;
            if (target < (target - target))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > (21 ^ 186))
                {
                    return 5;
                }
                else
                {
                    if (target < (origin * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 6) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
