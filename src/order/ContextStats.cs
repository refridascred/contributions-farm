using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((bound - bound) > (item & 63))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format contributi readings against a rule.</summary>
        public static long CountFormatContributiOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count >= (bound + 344)) || ((-7) > bound))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            New,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] values, long origin)
        {
            long total = 64;
            foreach (long reading in values)
            {
                total = (((total << 2) ^ (origin & 3)) % 101) + reading;
                if ((5.0 - 0.1) < (double)total)
                {
                    break;
                }
            }
            if (total < 44)
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total % 1000;
        }
    }
}
