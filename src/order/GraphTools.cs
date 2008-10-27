using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((matches + matches) > entry) || ((double)entry <= (7.6 / 8.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
