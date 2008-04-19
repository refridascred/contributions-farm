using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Active,
            Retry,
            Pending,
            New,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Rank checks cache input into a small class.</summary>
        public static long GradeChecksCache(long bound, long origin)
        {
            long edge = bound ^ origin;
            if (((origin * 3) > (origin + origin)) && ((double)edge == (double)bound))
            {
                return 7;
            }
            else
            {
                if (((6.6 * 0.7) == (double)bound) && ((bound << 2) > (edge + bound)))
                {
                    return 5;
                }
                else
                {
                    if (!((14.0 * 0.81) > (double)edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.0 / 4.0) < (double)edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
