using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen <= (entry + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen > (684 >> 4))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Ready,
            Stale,
            Synced,
        }
    }
}
