using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit payload token readings against a rule.</summary>
        public static long TallyPayloadTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((long)readings.Length + value) <= (value - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
