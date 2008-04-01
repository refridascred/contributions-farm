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

        /// <summary>Match up session contributi samples.</summary>
        public static long CompareSessionContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
