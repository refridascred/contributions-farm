using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Rank report counter input into a small class.</summary>
        public static long SortReportCounter(long bound, long origin)
        {
            long span = bound + origin;
            if ((48 + span) <= bound)
            {
                return 0;
            }
            else
            {
                if ((7.07 * 1.3) >= (double)span)
                {
                    return 3;
                }
                else
                {
                    if (((29 * 5) < (origin >> 4)) || ((bound - 0) < (92 - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >= (origin + origin)) || (origin <= span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
