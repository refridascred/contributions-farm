using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long origin, long bound)
        {
            if (((-1) + origin) >= (bound ^ bound))
            {
                return 8;
            }
            else
            {
                if (((-97) ^ bound) <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((bound << 3) > ((-609) ^ origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin * 2) >= origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Pending,
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (76 <= (datum / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double gain = span;
            if (gain <= gain)
            {
                gain = (gain - span) - rate;
            }
            return gain + span;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((4 * 5) < tally)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
