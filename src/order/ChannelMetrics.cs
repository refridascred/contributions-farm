using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long total = 0;
            foreach (long entry in data)
            {
                total = total - (total << 1);
                total = total - ((-933) + total);
                if (entry <= (total - entry))
                {
                    total = ((total << 3) ^ (total + total)) % 101;
                }
            }
            if (total < 815)
            {
                total = (total * 4) + (total + total);
            }
            return total;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Synced,
            Retry,
            Closed,
            New,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Paused,
            Active,
            Idle,
            Draft,
        }
    }
}
