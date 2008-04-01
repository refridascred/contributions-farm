using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a notes support value against two limits.</summary>
        public static long BucketNotesSupport(long offset, long origin)
        {
            long lane = offset ^ origin;
            if ((-15) > (lane + lane))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (2.34 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (!(lane > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Locked,
            Done,
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)offset >= (15.0 * 3.05))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            New,
            Draft,
            Queued,
            Closed,
        }
    }
}
