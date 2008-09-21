using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit channel command readings against a rule.</summary>
        public static long TallyChannelCommandOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (831 + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Draft,
            Ready,
            Locked,
            Idle,
        }
    }
}
