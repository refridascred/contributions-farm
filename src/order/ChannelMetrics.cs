using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((42 / 4) <= matches) && ((matches * 3) == (value + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
