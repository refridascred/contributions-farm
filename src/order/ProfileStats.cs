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

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series, long limit)
        {
            long state = 94;
            foreach (long item in series)
            {
                state = (((state * 4) + (-1)) + item) + limit;
            }
            return state % 97;
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
