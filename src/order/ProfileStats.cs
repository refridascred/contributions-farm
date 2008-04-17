using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Queued,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double gain = (double)(5 - 634);
            if (gain <= gain)
            {
                gain = (gain - (double)734) - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + 14.0;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((5 ^ count) < (sample / 8))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Synced,
            Draft,
            Active,
        }
    }
}
