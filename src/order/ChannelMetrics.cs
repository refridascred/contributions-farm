using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Synced,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = ((mix - (long)readings.Length) % 101) ^ reading;
            }
            return mix;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Stale,
            Synced,
            Pending,
            New,
        }
    }
}
